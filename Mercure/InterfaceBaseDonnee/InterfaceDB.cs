using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
namespace Mercure.InterfaceBaseDonnee
{

    /// <summary>
    ///  Cette classe statique , représente une interface de connexion à la base de données 
    ///  , elle contient toutes les méthodes de traitement générale sur la base de données 
    /// </summary>
    static class  InterfaceDB
    {
        /// <summary>
        ///     l'attribut de  connexion à la base de données 
        /// </summary>
        /// <see cref="SQLiteConnection"/>
        private static SQLiteConnection Connexion_Sqlite;

        /// <summary>
        ///  Attribut permettant de faire des commandes sql sur la base de données
        /// </summary>
        /// <see cref="SQLiteCommand"/>
        private static SQLiteCommand Commande_Sqlite;

        /// <summary>
        ///  Attribut permettant la lecture des données renvoyé par une commande 
        /// </summary>
        /// <see cref="SQLiteDataReader"/>
        private static SQLiteDataReader Lecture_Donnee;

        /// <summary>
        ///  le repertoir du projet 
        /// </summary>
        /// <see cref="string"/>
        private static string RepertoireCourant = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        /// <summary>
        /// Le fichier, nom de la base de données 
        /// </summary>
        /// <see cref="string"/>
        private static string NomBaseDonnee = "Mercure.SQlite";

        /// <summary>
        ///  Le chemin complet mennant au fichier contenant la base de données 
        /// </summary>
        /// <see cref="string"/>
        private static string CheminBaseDonnee = RepertoireCourant + "\\BaseDeDonnees\\"+ NomBaseDonnee;

        /// <summary>
        ///  Cette propriété statique , correspond à une commande sqlite 
        ///  
        /// </summary>
        public static SQLiteCommand Commande_sqlite
        {
            get
            {
                return Commande_Sqlite;
            }

            set
            {
                Commande_Sqlite = value;
            }
        }

       
  
        /// <summary>
        ///  Cette methode permet de d'ouvrir une connexion sur la base de données 
        /// </summary>
        public static void Connection()
        {
            GetInstaneConnexion().Open();
        }

        /// <summary>
        ///  Cette methode permet de se deconnecter ou fermer la connexion à la base de données
        /// </summary>
        public static void Deconnection()
        {
            GetInstaneConnexion().Close();
        }

        /// <summary>
        ///     Cette methode permet d'instancier une connection en suivant le processus Singleton 
        ///    et  d'ouvrir directement la connection vers la base de données 
        ///  
        /// </summary>
        /// <remarks> Singleton : permet d'instancer une seul fois un attribut
        ///     - Si Connexion_Sqlite est déja instancier alors on le retourne 
        ///     - Sinon il doit être instancier en indiquant le chemin de connection à la base de données 
        /// </remarks>
        /// <returns> l'attribut contenant la connection à la base de données   </returns>
        public static SQLiteConnection GetInstaneConnexion()
        {
            if (Connexion_Sqlite == null)
            {
                Connexion_Sqlite = new SQLiteConnection("Data Source=" + CheminBaseDonnee + "; Version=3");
                Connexion_Sqlite.Open();
            }
            return Connexion_Sqlite;
        }

        /// <summary>
        ///  Cette methode pour une table de la base de données et son champ représentant
        ///  les identifiants de la table nous donne le dernier identifiant de la table 
        /// </summary>
        /// <param name="nomTable"> le nom de la table </param>
        /// <param name="type"> la colonne / champ correspondant aux identifiants</param>
        /// <returns>le dernier identifiant de table </returns>
        /// <remarks>
        ///     <example> Voici un exemple d'utilisation de la methode : 
        ///         <code> int dernierId = InterfaceDB.DernierIdTable("Marques","RefMarque")</code>
        ///         qui nous donne le dernier id de la table Marques de la base de données en fonction de son identifiant ici RefMarque
        ///     </example>
        /// </remarks>
        public static int DernierIdTable(string nomTable, string type)
        {
            string requete = "SELECT " + type + " as dernierID FROM " + nomTable + " ORDER BY " + type + " DESC LIMIT 1";
            int dernierId = 0;
            Commande_sqlite = new SQLiteCommand(requete, GetInstaneConnexion());
            try
            {
                Lecture_Donnee = Commande_sqlite.ExecuteReader();
                while (Lecture_Donnee.Read())
                {
                    dernierId = Int32.Parse(Lecture_Donnee["dernierID"].ToString());
                }
            }
            catch (SQLiteException ex)
            {
                dernierId = -1;
                Console.WriteLine(ex.Message);
            }
            return dernierId;
        }

        /// <summary>
        ///  Cette methode pour une table de base de données supprime toutes les tuples de la table 
        /// </summary>
        /// <param name="nomTable"> le nom de la table existante dans la base de données </param>
        /// <returns>le resultat de l'opération </returns>
        public static string SupprimerToutTable(string nomTable)
        {
            string requete = "DELETE FROM "+nomTable;
            string resultat;
            Commande_sqlite = new SQLiteCommand(requete, GetInstaneConnexion());
            resultat = "Suppresion des tuples dans la table " + nomTable;
            try
            {
                Commande_sqlite.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                resultat = "Erreur de  " + ex.Message;
            }
            return resultat;
        }

    }
}
