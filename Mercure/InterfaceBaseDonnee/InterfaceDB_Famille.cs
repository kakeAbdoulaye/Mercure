using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Mercure.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.InterfaceBaseDonnee
{
    /// <summary>
    ///  Cette classe représente l'interface de requete sur la table Familles
    /// </summary>
    /// <remarks>
    ///     Elle utilise la classe statique <see cref="InterfaceDB"/>
    /// </remarks>
    class InterfaceDB_Famille
    {
        /// <summary>
        ///  Attribut contentant la requete d'insertion de la classe 
        /// </summary>
        private string RequeteInsererFamille;

        /// <summary>
        ///  Attribut contentant la requete de selection  de la classe 
        /// </summary>
        private string RequeteDonneesFamille;

        /// <summary>
        ///  Attribut contentant la requete de modification  de la classe 
        /// </summary>
        private string RequeteModifierFamille;

        /// <summary>
        ///  Attribut permettant la lecture des données retournées dans une commande de la classe 
        /// </summary>
        private SQLiteDataReader Lecture_Donnee;

        /// <summary>
        /// Constructeur par defaut 
        /// </summary>
        public InterfaceDB_Famille()
        {

        }
        
        /// <summary>
        ///  Cette methode permet d'inserer une nouvelle famille dans la table Famille 
        /// </summary>
        /// <param name="refFamille"> l'identifiant de la nouvelle famille </param>
        /// <param name="nom">le nom de la famille </param>
        /// <returns>le resulat de l'operation </returns>
        public string InsererFamille(int refFamille, string nom)
        {
            string resultat = "";
            Famille famille = GetFamille(nom);
            Famille famille2 = GetFamille(refFamille);
            if (famille2 != null || famille != null)
            {
                resultat =" = Existe dejà dans la table Famille "+refFamille;

            }
            else
            {
                try
                {
                    RequeteInsererFamille = "INSERT INTO Familles(RefFamille,Nom) VALUES"
                                        + "(@reffamille,@nom)";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererFamille, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@reffamille", refFamille);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);
                   
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " + Insertion dans la Table Famille : "+refFamille;
                }
                catch (SQLiteException ex)
                {
                   resultat = " * Erreur d'insertion dans la Table Famille de "+ refFamille+" : " + ex.Message;

                }
               
            }
            return resultat;

        }

        /// <summary>
        ///  Cette methode permet d'inserer une nouvelle famille dans la table Famille 
        /// </summary>
        /// <param name="nom">le nom de la famille </param>
        /// <returns>le resulat de l'operation </returns>
        /// <remarks>
        ///     Elle donne un identifiant qui est le dernier identifiant de table Familles à la nouvelle famille 
        /// </remarks>
        public string InsererFamille(string nom)
        {
            int refFamille = InterfaceDB.DernierIdTable("Familles", "RefFamille") + 1;
            return InsererFamille(refFamille, nom);
        }

        /// <summary>
        ///     Cette methode permet de modifier les données d'une famille dans la table Famille
        /// </summary>
        /// <param name="reffamille"> l'identifiant de la famille à modifier </param>
        /// <param name="nouveaunomfamille">le nouveau nom  de la famille </param>
        /// <returns>le resultat de l'opération </returns>
        /// <remarks>
        ///     la mise à jour est faite si la famille existe 
        /// </remarks>
        public string ModifierFamille(int reffamille, string nouveaunomfamille)
        {
            string resultat = "";
            try
            {
                Famille famille = GetFamille(reffamille);
                if (famille == null)
                {
                    resultat = " * Pas de mise à jour car n'existe pas dans la table Famille " + reffamille;

                }
                else
                {
                    RequeteModifierFamille = "UPDATE Familles SET Nom = @nouveaunom WHERE RefFamille = @ref";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierFamille, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nouveaunom", nouveaunomfamille);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", reffamille);
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " / Mise à jour dans la Table Marque  de " + reffamille + " : " + reffamille;
                }
            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de mise à jour dans la Table Marque de "+reffamille+" : " + ex.Message;

            }
            return resultat;
        }

        /// <summary>
        /// Cette methode permet de supprimer une famille dans la table Familles
        /// </summary>
        /// <param name="refFamille">l'identifiant de la famille à supprimer </param>
        /// <returns>le resultat de l'opération </returns>
        /// <remarks>
        ///     la suppresion est faite si la famille à supprimer n'est liée à aucune sous famille 
        ///     sinon la suppression sera refusé
        /// </remarks>
        public string SupprimerFamille(int refFamille)
        {
            string requete = "DELETE FROM Familles WHERE RefFamille=@ref";
            string resultat;
            InterfaceDB_Sous_Famille interSousfam = new InterfaceDB_Sous_Famille();
            List<SousFamille> liste = interSousfam.GetToutesSousFamillebyFamille(refFamille);
            try
            {
                if (liste != null && liste.Count > 0)
                {
                    resultat = "Echec de la suppresion de " + refFamille + " car cette famille est liée à des sous familles ";
                }
                else
                {
                    /**
                    * Suppression de la famille 
                    * */
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refFamille);
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " - Suppresion de " + refFamille + " dans la table Famille";
                }
               

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de " + refFamille + " dans la table Famille : " + ex.Message;
            }
            return resultat;
        }

        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une famille en fonction de son nom 
        /// </summary>
        /// <param name="nom"> le nom de la famille </param>
        /// <returns> la famille correspondante </returns>
        public Famille GetFamille(string nom)
        {
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequeteDonneesFamille = "select * from Familles where Familles.Nom like @nom";
          
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesFamille, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    reffamilleTrouve = Int32.Parse(Lecture_Donnee["RefFamille"].ToString());
                    nomfamilleTrouve = Lecture_Donnee["Nom"].ToString();
                    famille = new Famille(reffamilleTrouve, nomfamilleTrouve);
                }
            }
            catch (SQLiteException ex)
            {
                famille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille : " + ex.Message);
            }
           
            return famille;
        }
        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une famille en fonction de son identifiant
        /// </summary>
        /// <param name="reffamille"> l'identifiant de la famille</param>
        /// <returns>la famille correspondante </returns>
        public Famille GetFamille(int reffamille)
        {
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequeteDonneesFamille = "select * from Familles where Familles.RefFamille = @ref";
            
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesFamille, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", reffamille);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    reffamilleTrouve = Int32.Parse(Lecture_Donnee["RefFamille"].ToString());
                    nomfamilleTrouve =Lecture_Donnee["Nom"].ToString();
                    famille = new Famille(reffamilleTrouve, nomfamilleTrouve);
                }
            }
            catch (SQLiteException ex)
            {
                famille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille : " + ex.Message);
            }
          
            return famille;
        }

        /// <summary>
        ///  Cette methode nous donne la liste de toutes les familles de la table Familles 
        /// </summary>
        /// <returns>liste de famille</returns>
        public List<Famille> GetToutesFamille()
        {

            List<Famille> listfamille = null;
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequeteDonneesFamille = "select * from Familles";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesFamille, InterfaceDB.GetInstaneConnexion());


            try
            {

                SQLiteDataReader Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listfamille = new List<Famille>();
                while (Lecture_donnee.Read())
                {
                    reffamilleTrouve = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomfamilleTrouve = Lecture_donnee["Nom"].ToString();
                    famille = new Famille(reffamilleTrouve, nomfamilleTrouve);
                    listfamille.Add(famille);

                }
            }
            catch (SQLiteException ex)
            {

                listfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille: " + ex.Message);
            }

            return listfamille;
        }
    }
}
