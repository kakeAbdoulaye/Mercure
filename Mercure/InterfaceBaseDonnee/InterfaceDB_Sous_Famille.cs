using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Mercure.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.InterfaceBaseDonnee
{
    class InterfaceDB_Sous_Famille
    {

        private string RequeteInsererSousFamille;
        private string RequetedonneesSousFamilles;
        private string RequeteModifierSousFamille;
        private SQLiteDataReader Lecture_donnee;
        public InterfaceDB_Sous_Famille()
        {
        }
        public string insererSousFamille(int refSousFamille, int refFamille, string nom)
        {
            string resultat = "";
            SousFamille sousfamille1 = getSousFamille(nom);
            SousFamille sousfamille2 = getSousFamille(refSousFamille);
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
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererSousFamille, InterfaceDB.getInstaneConnexion());
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
        public string insererSousFamille(string nomFamille, string nom)
        {
            string resultat = " = Existe dejà dans la table SousFamille : " + nom;
            SousFamille sousfamille = getSousFamille(nom);
            if (sousfamille == null)
            {
                int refSousFamille = InterfaceDB.dernierIdTable("SousFamilles", "RefSousFamille") + 1;
                InterfaceDB_Famille Interfamille = new InterfaceDB_Famille();
                Famille famille = Interfamille.getFamille(nomFamille);
                return insererSousFamille(refSousFamille, famille.RefFamille, nom);

            }
            else
            {
                return resultat;
            }


        }
        public string insererSousFamille(SousFamille sousfamille)
        {
            return insererSousFamille(sousfamille.RefSousFamille, sousfamille.MaFamille.RefFamille, sousfamille.NomSousFamille);
        }
        public string modifierSousFamille(int refsousfamille, int refnouvellefamile, string nouveaunomsousfamille)
        {
            string resultat = "";
            try
            {

                RequeteModifierSousFamille = "UPDATE SousFamilles SET Nom = @nouveaunom , RefFamille =@nouvellefamille WHERE RefSousFamille = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierSousFamille, InterfaceDB.getInstaneConnexion());
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
        public string supprimerSousFamille(int refsousfamille)
        {
            string requete = "DELETE FROM SousFamilles WHERE RefSousFamille=@ref";
            string resultat;
            InterfaceDB_Articles interArticle = new InterfaceDB_Articles();
            List<Article> liste = interArticle.getToutesArticlebySousFamille(refsousfamille);

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
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.getInstaneConnexion());
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
     

        public SousFamille getSousFamille(string nom)
        {
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequetedonneesSousFamilles = "select * from SousFamilles where SousFamilles.Nom like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesSousFamilles, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", nom);

            try
            {
                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_donnee["Nom"].ToString();
                    
                    sousfamille = new SousFamille(refsousfamille, interFamille.getFamille(reffamille), nomsousfamille);
                }
            }
            catch (SQLiteException ex)
            {
                sousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Sous Famille : " + ex.Message);
            }

            return sousfamille;
        }
        public SousFamille getSousFamille(int sousfamilleref)
        {
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequetedonneesSousFamilles = "select * from SousFamilles where SousFamilles.RefSousFamille=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesSousFamilles, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", sousfamilleref);

            try
            {
                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();

                while (Lecture_donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_donnee["Nom"].ToString();
                    
                    sousfamille = new SousFamille(refsousfamille, interFamille.getFamille(reffamille), nomsousfamille);
                }
            }
            catch (SQLiteException ex)
            {
                sousfamille = null;
                Console.WriteLine(" * Erreur de lecture dans la table Sous Famille : " + ex.Message);
            }

            return sousfamille;
        }
        public List<SousFamille> getToutesSousFamille()
        {

            List<SousFamille> listsousfamille = null;
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequetedonneesSousFamilles = "select * from SousFamilles";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesSousFamilles, InterfaceDB.getInstaneConnexion());


            try
            {

                SQLiteDataReader Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listsousfamille = new List<SousFamille>();
                while (Lecture_donnee.Read())
                {
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    reffamille = Int32.Parse(Lecture_donnee["RefFamille"].ToString());
                    nomsousfamille = Lecture_donnee["Nom"].ToString();
                   
                    sousfamille = new SousFamille(refsousfamille, interFamille.getFamille(reffamille), nomsousfamille);
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

        public List<SousFamille> getToutesSousFamillebyFamille(int refFamille)
        {

            List<SousFamille> listsousfamille = null;
            SousFamille sousfamille = null;
            int reffamille;
            int refsousfamille;
            string nomsousfamille;
            InterfaceDB_Famille interFamille = new InterfaceDB_Famille();
            RequetedonneesSousFamilles = "select * from SousFamilles where RefFamille = @ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneesSousFamilles, InterfaceDB.getInstaneConnexion());
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
                    
                    sousfamille = new SousFamille(refsousfamille, interFamille.getFamille(reffamille), nomsousfamille);
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



