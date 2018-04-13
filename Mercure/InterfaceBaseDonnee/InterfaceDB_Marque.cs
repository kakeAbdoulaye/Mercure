using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Mercure.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.InterfaceBaseDonnee
{
    class InterfaceDB_Marque
    {
        private string RequeteInsererMarque;
        private string RequetedonneesMarque;
        private string RequeteModifierMarque;
        private SQLiteDataReader Lecture_donnee;

        public InterfaceDB_Marque()
        {

        }

        public string insererMarque(int refmarque, string nom)
        {
            string resultat = "";
            Marque marque = getMarque(nom);
            Marque marque2 = getMarque(refmarque);
            if (marque2 != null || marque != null)
            {
               resultat = " = Existe dejà dans la table Marque " +refmarque;

            }
            else
            {
                try
                {

                    RequeteInsererMarque = "INSERT INTO Marques(RefMarque,Nom) VALUES"
                                      + "(@refmarque,@nom)";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererMarque, InterfaceDB.getInstaneConnexion());

                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refmarque", refmarque);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();

                    resultat = " + Insertion dans la Table Marque : "+refmarque;

                }
                catch (SQLiteException ex)
                {

                   resultat = " * Erreur d'insertion dans la Table Marque de "+refmarque+" : " + ex.Message;

                }


            }
            return resultat;
        }
        public string insererMarque(Marque marque)
        {
           return  insererMarque(marque.RefMarque, marque.NomMarque);
        }
        public string insererMarque(string nom)
        {
            int refmarque = InterfaceDB.dernierIdTable("Marques", "RefMarque") + 1;
            return insererMarque(refmarque, nom);
        }
        public string modifierMarque(int refmarque, string nouveaunommarque)
        {
            string resultat = "";
            try
            {

                RequeteModifierMarque = "UPDATE Marques SET Nom = @nouveaunom WHERE RefMarque = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierMarque, InterfaceDB.getInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nouveaunom", nouveaunommarque);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refmarque);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " / Mise à jour dans la Table Marque : " + refmarque;

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de mise à jour dans la Table Marque de "+refmarque+" : " + ex.Message;

            }
            return resultat;

        }
        public string supprimerMarque(int refMarque)
        {
            string requete = "DELETE FROM Marques WHERE RefMarque=@ref";
            string resultat;
            

            try
            {
                /**
                 * Suppresion de la maque 
                 * */
                InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.getInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refMarque);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " - Suppresion de " + refMarque + " dans la table Marque";

              

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de " + refMarque + " dans la table Marque : " + ex.Message;
            }
            return resultat;
        }
        public Marque getMarque(string nom)
        {
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequetedonneesMarque = "select * from Marques where Marques.Nom like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesMarque, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
               Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    refmarqueTrouve = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    nomTrouve =Lecture_donnee["Nom"].ToString();
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
        public Marque getMarque(int refmarque)
        {
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequetedonneesMarque = "select * from Marques where Marques.RefMarque=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesMarque, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refmarque);

            try
            {
               Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    refmarqueTrouve = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    nomTrouve =Lecture_donnee["Nom"].ToString();
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

        public List<Marque> getToutesMarque()
        {

            List<Marque> listmarque= null;
            Marque marque = null;
            int refmarqueTrouve;
            string nomTrouve;

            RequetedonneesMarque = "select * from Marques";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesMarque, InterfaceDB.getInstaneConnexion());


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
