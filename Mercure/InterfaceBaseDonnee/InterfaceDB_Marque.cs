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
    ///  Cette classe représente l'interface de requete sur la table Marques
    /// </summary>
    /// <remarks>
    ///     Elle utilise la classe statique <see cref="InterfaceDB"/>
    /// </remarks>
    class InterfaceDB_Marque
    {
        /// <summary>
        ///  Attribut contentant la requete d'insertion de la classe 
        /// </summary>
        private string RequeteInsererMarque;

        /// <summary>
        ///  Attribut contentant la requete de selection  de la classe 
        /// </summary>
        private string RequeteDonneesMarque;

        /// <summary>
        ///  Attribut contentant la requete de modification  de la classe 
        /// </summary>
        private string RequeteModifierMarque;

        /// <summary>
        ///  Attribut permettant la lecture des données retournées dans une commande de la classe 
        /// </summary>
        private SQLiteDataReader Lecture_Donnee;

        /// <summary>
        /// Constructeur par defaut 
        /// </summary>
        public InterfaceDB_Marque()
        {

        }

        /// <summary>
        ///     Cette methode permet d'inserer une nouvelle marque dans la table Marques
        /// </summary>
        /// <param name="refmarque"> l'identifiant de la marque </param>
        /// <param name="nom"> le nom de la marque </param>
        /// <returns></returns>
        /// <remarks>
        ///     L'insertion ne sera faite que si la marque n'existe pas
        /// </remarks>
        public string InsererMarque(int refmarque, string nom)
        {
            string resultat = "";
            Marque marque = GetMarque(nom);
            Marque marque2 = GetMarque(refmarque);
            if (marque2 != null || marque != null)
            {
                resultat = " = Existe dejà dans la table Marque " + refmarque;

            }
            else
            {
                try
                {

                    RequeteInsererMarque = "INSERT INTO Marques(RefMarque,Nom) VALUES"
                                      + "(@refmarque,@nom)";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererMarque, InterfaceDB.GetInstaneConnexion());

                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refmarque", refmarque);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();

                    resultat = " + Insertion dans la Table Marque : " + refmarque;

                }
                catch (SQLiteException ex)
                {

                    resultat = " * Erreur d'insertion dans la Table Marque de " + refmarque + " : " + ex.Message;

                }


            }
            return resultat;
        }

        /// <summary>
        ///     Cette methode permet d'inserer une nouvelle marque dans la table Marques
        /// </summary>
        /// <param name="nom"> le nom de la marque </param>
        /// <returns>le resultat de l'operation </returns>
        /// <remarks>
        ///     L'identifiant est données par rapport au dernier identifiant de la table Marques
        /// </remarks>
        public string InsererMarque(string nom)
        {
            int refmarque = InterfaceDB.DernierIdTable("Marques", "RefMarque") + 1;
            return InsererMarque(refmarque, nom);
        }

        /// <summary>
        /// Cette methode permet de modifier les données d'une marque dans la table Marques
        /// </summary>
        /// <param name="refmarque">l'identifiant de la marque </param>
        /// <param name="nouveaunommarque">le nouveau nom de la marque </param>
        /// <returns>le resultat de l'operation </returns>
        public string ModifierMarque(int refmarque, string nouveaunommarque)
        {
            string resultat = "";
            try
            {

                RequeteModifierMarque = "UPDATE Marques SET Nom = @nouveaunom WHERE RefMarque = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierMarque, InterfaceDB.GetInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nouveaunom", nouveaunommarque);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refmarque);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " / Mise à jour dans la Table Marque : " + refmarque;

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de mise à jour dans la Table Marque de " + refmarque + " : " + ex.Message;

            }
            return resultat;

        }

        /// <summary>
        ///  Cette methode permet de supprimer une marque dans la table Marques en fonction de son identifiant
        /// </summary>
        /// <param name="refMarque">l'identifiant de la marque à supprimer </param>
        /// <returns>le resultat de l'operation </returns>
        /// <remarks>
        ///      la suppresion est faite si la marque à supprimer n'est pas liée à aucun article 
        ///     sinon la suppression sera refusé
        /// </remarks>
        public string SupprimerMarque(int refMarque)
        {
            string requete = "DELETE FROM Marques WHERE RefMarque=@ref";
            string resultat;
            InterfaceDB_Articles interArticle = new InterfaceDB_Articles();
            List<Article> liste = interArticle.GetToutesArticlebyMarque(refMarque);

            try
            {
                if (liste != null && liste.Count > 0)
                {
                    resultat = "Echec de la suppresion de " + refMarque + " car cette marque est liée à des articles";
                }
                else
                {
                    /**
                     * Suppresion de la maque 
                     * */
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refMarque);
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " - Suppresion de " + refMarque + " dans la table Marque";

                }



            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de " + refMarque + " dans la table Marque : " + ex.Message;
            }
            return resultat;
        }

        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une marque en fonction de son nom 
        /// </summary>
        /// <param name="nom"> le nom de la marque </param>
        /// <returns> la marque correspondante</returns>
        public Marque GetMarque(string nom)
        {
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequeteDonneesMarque = "select * from Marques where Marques.Nom like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesMarque, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    refmarqueTrouve = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    nomTrouve = Lecture_Donnee["Nom"].ToString();
                    marque = new Marque(refmarqueTrouve, nomTrouve);

                }
            }
            catch (SQLiteException ex)
            {
                marque = null;
                Console.WriteLine(" * Erreur de lecture dans la table Marque : " + ex.Message);
            }

            return marque;

        }

        /// <summary>
        ///  Cette methode permet d'avoir toutes les informations d'une marque en fonction de son identifiant 
        /// </summary>
        /// <param name="refmarque">l'identifiant de la marque </param>
        /// <returns>la marque correspondante</returns>
        public Marque GetMarque(int refmarque)
        {
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequeteDonneesMarque = "select * from Marques where Marques.RefMarque=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesMarque, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refmarque);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_Donnee.Read())
                {
                    refmarqueTrouve = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    nomTrouve = Lecture_Donnee["Nom"].ToString();
                    marque = new Marque(refmarqueTrouve, nomTrouve);

                }
            }
            catch (SQLiteException ex)
            {
                marque = null;
                Console.WriteLine(" * Erreur de lecture dans la table Marque : " + ex.Message);
            }

            return marque;

        }

        /// <summary>
        ///  Cette methode nous donne la liste de toutes les marques de la table Marques 
        /// </summary>
        /// <returns>liste de marque </returns>
        public List<Marque> GetToutesMarque()
        {

            List<Marque> listmarque = null;
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequeteDonneesMarque = "select * from Marques";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneesMarque, InterfaceDB.GetInstaneConnexion());


            try
            {

                SQLiteDataReader Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listmarque = new List<Marque>();
                while (Lecture_donnee.Read())
                {
                    refmarqueTrouve = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    nomTrouve = Lecture_donnee["Nom"].ToString();
                    marque = new Marque(refmarqueTrouve, nomTrouve);
                    listmarque.Add(marque);

                }
            }
            catch (SQLiteException ex)
            {

                listmarque = null;
                Console.WriteLine(" * Erreur de lecture dans la table Famille: " + ex.Message);
            }

            return listmarque;
        }

    }
}
