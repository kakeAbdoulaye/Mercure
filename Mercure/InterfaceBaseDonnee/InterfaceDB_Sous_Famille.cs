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
    ///  Cette classe représente l'interface de requete sur la table SousFamilles
    /// </summary>
    /// <remarks>
    ///     Elle utilise la classe statique <see cref="InterfaceDB"/>
    /// </remarks>
    class InterfaceDB_Sous_Famille
    {
        /// <summary>
        ///  Attribut contentant la requete d'insertion de la classe 
        /// </summary>
        private string RequeteInsererSousFamille;

        /// <summary>
        ///  Attribut contentant la requete de selection  de la classe 
        /// </summary>
        private string RequeteDonneesSousFamilles;

        /// <summary>
        ///  Attribut contentant la requete de modification  de la classe 
        /// </summary>
        private string RequeteModifierSousFamille;

        /// <summary>
        ///  Attribut permettant la lecture des données retournées dans une commande de la classe 
        /// </summary>
        private SQLiteDataReader Lecture_Donnee;

        /// <summary>
        /// Constructeur par defaut 
        /// </summary>
        public InterfaceDB_Sous_Famille()
        {
        }


        /// <summary>
        ///  Cette methode permet d'inserer une nouvelle sous famille dans la table SousFamilles 
        /// </summary>
        /// <param name="refSousFamille">l'identifiant de la sous famille </param>
        /// <param name="refFamille">l'identifiant de la famille</param>
        /// <param name="nom">le nom de la sous famille </param>
        /// <returns>le resultat de l'operation </returns>
        /// <remarks>  
        ///     L'insertion est faite si la sous famille n'existait pas sinon rien 
        /// </remarks>
        public string InsererSousFamille(int refSousFamille, int refFamille, string nom)
        {
            string resultat = "";
            SousFamille sousfamille1 = GetSousFamille(nom);
            SousFamille sousfamille2 = GetSousFamille(refSousFamille);
            if (sousfamille2 != null || sousfamille1 != null)
            {
                resultat = " = Existe dejà dans la table SousFamille " + refSousFamille;

            }
            else
            {
                try
                {
                    RequeteInsererSousFamille = "INSERT INTO SousFamilles(RefSousFamille,RefFamille,Nom) VALUES"
                                             + "(@refsousfamille,@reffamille,@nom)";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererSousFamille, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refsousfamille", refSousFamille);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@reffamille", refFamille);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " + Insertion dans la Table Sous Famille : " + refSousFamille;

                }
                catch (SQLiteException ex)
                {
                    resultat = " * Erreur d'insertion dans la Table Sous Famille de " + refSousFamille + " : " + ex.Message;
                }


            }
            return resultat;

        }

        /// <summary>
        ///  Cette methode permet d'inserer une nouvelle sous famille dans la table SousFamilles 
        /// </summary>
        /// <param name="nomFamille"> le nom de la famille </param>
        /// <param name="nom"> le nom de la sous famille </param>
        /// <returns>le resultat de l'operation </returns>
        /// <remarks>  
        ///     - On cherche la famille correspondant au nom de la famille
        ///     - L'insertion est faite si la sous famille n'existait pas sinon rien 
        ///     - Et l'identifiant correspond au dernier identifiant dans de la table
        /// </remarks>
        public string InsererSousFamille(string nomFamille, string nom)
        {
            string resultat = " = Existe dejà dans la table SousFamille : " + nom;
            SousFamille sousfamille = GetSousFamille(nom);
            if (sousfamille == null)
            {
                int refSousFamille = InterfaceDB.DernierIdTable("SousFamilles", "RefSousFamille") + 1;
                InterfaceDB_Famille Interfamille = new InterfaceDB_Famille();
                Famille famille = Interfamille.GetFamille(nomFamille);
                return InsererSousFamille(refSousFamille, famille.RefFamille, nom);

            }
            else
            {
                return resultat;
            }


        }

        /// <summary>
        ///     Cette methode permet de modifier les données d'une sous famille dans la table SousFamilles
        /// </summary>
        /// <param name="refsousfamille"> l'identifiant de la sous famille à modifier</param>
        /// <param name="refnouvellefamile"> l'identifiant de la nouvelle famille </param>
        /// <param name="nouveaunomsousfamille"> le nouveau nom de la sous famille </param>
        /// <returns>le resultat de l'operation </returns>
        public string ModifierSousFamille(int refsousfamille, int refnouvellefamile, string nouveaunomsousfamille)
        {
            string resultat = "";
            try
            {

                RequeteModifierSousFamille = "UPDATE SousFamilles SET Nom = @nouveaunom , RefFamille =@nouvellefamille WHERE RefSousFamille = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierSousFamille, InterfaceDB.GetInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nouveaunom", nouveaunomsousfamille);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nouvellefamille", refnouvellefamile);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refsousfamille);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " / Mise à jour dans la Table Sous Famille de " + refsousfamille + " : " + refsousfamille;

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de mise à jour dans la Table Sous Famille de " + refsousfamille + "  : " + ex.Message;

            }
            return resultat;
        }

        /// <summary>
        ///      Cette methode permet de supprimer une sous famille dans la table SousFamilles
        /// </summary>
        /// <param name="refsousfamille">l'identifiant de la sous famille à supprimer </param>
        /// <returns>le resultat de l'operation </returns>
        /// <remarks>
        ///     la suppresion est faite si la sous famille à supprimer n'est liée à aucun  article 
        ///     sinon la suppression sera refusé
        /// </remarks>
        public string SupprimerSousFamille(int refsousfamille)
        {
            string requete = "DELETE FROM SousFamilles WHERE RefSousFamille=@ref";
            string resultat;
            InterfaceDB_Articles interArticle = new InterfaceDB_Articles();
            List<Article> liste = interArticle.GetToutesArticlebySousFamille(refsousfamille);

            try
            {
                if (liste != null && liste.Count > 0)
                {
                    resultat = "Echec de la suppresion de " + refsousfamille + " car cette sous famille est liée à des articles";
                }
                else
                {
                    /**
                     * suppression de la sous famille
                     * */
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refsousfamille);
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " - Suppresion de " + refsousfamille + " dans la table Sous Famille";

                }
            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de " + refsousfamille + " dans la table Sous Famille : " + ex.Message;
            }
            return resultat;
        }

        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une sous famille en fonction de son nom 
        /// </summary>
        /// <param name="nom"> le nom de la sous famille </param>
        /// <returns>la sous famille correspondante </returns>
        public SousFamille GetSousFamille(string nom)
        {
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequeteDonneesSousFamilles = "select * from SousFamilles where SousFamilles.Nom like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesSousFamilles, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_Donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_Donnee["Nom"].ToString();

                    sousfamille = new SousFamille(refsousfamille, interFamille.GetFamille(reffamille), nomsousfamille);
                }
            }
            catch (SQLiteException ex)
            {
                sousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Sous Famille : " + ex.Message);
            }

            return sousfamille;
        }


        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une sous famille en fonction de son identifiant 
        /// </summary>
        /// <param name="sousfamilleref"> l'identifiant de la sous famille </param>
        /// <returns>la sous famille correspondante </returns>
        public SousFamille GetSousFamille(int sousfamilleref)
        {
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequeteDonneesSousFamilles = "select * from SousFamilles where SousFamilles.RefSousFamille=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesSousFamilles, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", sousfamilleref);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_Donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_Donnee["Nom"].ToString();

                    sousfamille = new SousFamille(refsousfamille, interFamille.GetFamille(reffamille), nomsousfamille);
                }
            }
            catch (SQLiteException ex)
            {
                sousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Sous Famille : " + ex.Message);
            }

            return sousfamille;
        }

        /// <summary>
        ///  Cette methode nous donne la liste de toutes les sous familles de la table SousFamilles 
        /// </summary>
        /// <returns>liste des sous familles</returns>
        public List<SousFamille> getToutesSousFamille()
        {

            List<SousFamille> listsousfamille = null;
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequeteDonneesSousFamilles = "select * from SousFamilles";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesSousFamilles, InterfaceDB.GetInstaneConnexion());


            try
            {

                SQLiteDataReader Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listsousfamille = new List<SousFamille>();
                while (Lecture_donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_donnee["Nom"].ToString();

                    sousfamille = new SousFamille(refsousfamille, interFamille.GetFamille(reffamille), nomsousfamille);
                    listsousfamille.Add(sousfamille);

                }
            }
            catch (SQLiteException ex)
            {

                listsousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille: " + ex.Message);
            }

            return listsousfamille;
        }

        /// <summary>
        ///  Cette methode nous donne la liste de toutes les sous familles de la table SousFamilles appartenant à une famille
        /// </summary>
        /// <param name="refFamille"></param>
        /// <returns>liste des sous familles</returns>
        public List<SousFamille> GetToutesSousFamillebyFamille(int refFamille)
        {

            List<SousFamille> listsousfamille = null;
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequeteDonneesSousFamilles = "select * from SousFamilles where RefFamille = @ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesSousFamilles, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refFamille);
            try
            {

                SQLiteDataReader Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listsousfamille = new List<SousFamille>();
                while (Lecture_donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_donnee["Nom"].ToString();

                    sousfamille = new SousFamille(refsousfamille, interFamille.GetFamille(reffamille), nomsousfamille);
                    listsousfamille.Add(sousfamille);

                }
            }
            catch (SQLiteException ex)
            {

                listsousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille: " + ex.Message);
            }

            return listsousfamille;
        }








    }


}



