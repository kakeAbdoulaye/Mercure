using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mercure.InterfaceBaseDonnee
{

    /// <summary>
    ///  A faire creer une fenetre qui permettra l'intégration 
    ///  avoir une seul instance de connection pour toutes les filles  voir openclassroom limiter le nombre de connexion
    ///  pour intégration tous supprimer et inserer 
    ///  pour la mise à jour mettre à jour les champs de l'article avec un update sans la reference
    ///  methode lors de l'ouverture de la fenetre connection et lors de la feneture deconnection
    /// </summary>
    /// 
    static class  InterfaceDB
    {
        private static SQLiteConnection connexion_sqlite;
        private static SQLiteCommand commande_sqlite;
        private static SQLiteDataReader lecture_donnee;
        private static string repertoirCourant = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        private static string nombaseDonnee = "Mercure.SQlite";
        private static string cheminBaseDonnee = repertoirCourant+"\\BaseDeDonnees\\"+nombaseDonnee;

        public static SQLiteCommand Commande_sqlite
        {
            get
            {
                return commande_sqlite;
            }

            set
            {
                commande_sqlite = value;
            }
        }

       
  
        public static void connection()
        {
            getInstaneConnexion().Open();
        }

        public static void deconnection()
        {
            getInstaneConnexion().Close();
        }
        public static SQLiteConnection getInstaneConnexion()
        {
            if (connexion_sqlite == null)
            {
                connexion_sqlite = new SQLiteConnection("Data Source=" + cheminBaseDonnee + "; Version=3");
                connexion_sqlite.Open();
            }
            return connexion_sqlite;
        }

        public static int dernierIdTable(string nomTable, string type)
        {
            string requete = "SELECT " + type + " as dernierID FROM " + nomTable + " ORDER BY " + type + " DESC LIMIT 1";
            int dernierId = 0;
            Commande_sqlite = new SQLiteCommand(requete, getInstaneConnexion());
            try
            {
                lecture_donnee = Commande_sqlite.ExecuteReader();
                while (lecture_donnee.Read())
                {
                    dernierId = Int32.Parse(lecture_donnee["dernierID"].ToString());
                }
            }
            catch (SQLiteException ex)
            {
                dernierId = -1;
            }
            return dernierId;
        }
        public static string supprimerToutTable(string nomTable)
        {
            string requete = "DELETE FROM "+nomTable;
            string resultat;
            Commande_sqlite = new SQLiteCommand(requete, getInstaneConnexion());
            resultat = "Suppresion des tuples dans la table " + nomTable;
            try
            {
                Commande_sqlite.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                resultat = "Erreur de  " + resultat;
            }
            return resultat;
        }

    }
}
