using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Mercure.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.InterfaceBaseDonnee
{
    class InterfaceDB_Famille
    {
        private string RequeteInsererFamille;
        private string RequetedonneesFamille;
        private string RequeteModifierFamille;
        private SQLiteDataReader Lecture_donnee;
        public InterfaceDB_Famille()
        {

        }
        public string insererFamille(int refFamille, string nom)
        {
            string resultat = "";
            Famille famille = getFamille(nom);
            Famille famille2 = getFamille(refFamille);
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
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererFamille, InterfaceDB.getInstaneConnexion());
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
        public string insererFamille(string nom)
        {
            int refFamille = InterfaceDB.dernierIdTable("Familles", "RefFamille") + 1;
            return insererFamille(refFamille, nom);
        }
        public string insererFamille(Famille famille)
        {
            return insererFamille(famille.RefFamille, famille.NomFamille);
        }
        public string modifierFamille(int reffamille, string nouveaunomfamille)
        {
            string resultat = "";
            try
            {
                Famille famille2 = getFamille(reffamille);
                if (famille2 == null)
                {
                    resultat = " * Pas de mise à jour car n'existe pas dans la table Famille " + reffamille;

                }
                else
                {
                    RequeteModifierFamille = "UPDATE Familles SET Nom = @nouveaunom WHERE RefFamille = @ref";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierFamille, InterfaceDB.getInstaneConnexion());
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
        public string supprimerFamille(int refFamille)
        {
            string requete = "DELETE FROM Familles WHERE RefFamille=@ref";
            string resultat;
            

            try
            {
                /**
                 * Suppression de la famille 
                 * */
                InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.getInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refFamille);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " - Suppresion de " + refFamille + " dans la table Famille";

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de " + refFamille + " dans la table Famille : " + ex.Message;
            }
            return resultat;
        }
        public Famille getFamille(string nom)
        {
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequetedonneesFamille = "select * from Familles where Familles.Nom like @nom";
          
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesFamille, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    reffamilleTrouve = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomfamilleTrouve = Lecture_donnee["Nom"].ToString();
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
        public Famille getFamille(int reffamille)
        {
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequetedonneesFamille = "select * from Familles where Familles.RefFamille = @ref";
            
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesFamille, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", reffamille);

            try
            {
                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    reffamilleTrouve = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomfamilleTrouve =Lecture_donnee["Nom"].ToString();
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
        public List<Famille> getToutesFamille()
        {

            List<Famille> listfamille = null;
            Famille famille = null;
            int reffamilleTrouve;
            string nomfamilleTrouve;

            RequetedonneesFamille = "select * from Familles";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesFamille, InterfaceDB.getInstaneConnexion());


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
