using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mercure.Models;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mercure.InterfaceBaseDonnee
{
    /// <summary>
    ///  Cette classe représente l'interface de requete sur la table Articles 
    /// </summary>
    /// <remarks>
    ///     Elle utilise la classe statique <see cref="InterfaceDB"/>
    /// </remarks>
    class InterfaceDB_Articles
    {
        /// <summary>
        ///  Attribut contentant la requete d'insertion de la classe 
        /// </summary>
        private string RequeteInsererArticle;

        /// <summary>
        ///  Attribut contentant la requete de selection  de la classe 
        /// </summary>
        private string RequeteDonneeArticle;

        /// <summary>
        ///  Attribut contentant la requete de modification  de la classe 
        /// </summary>
        private string RequeteModifierArticle;

        /// <summary>
        ///  Attribut permettant la lecture des données retournées dans une commande de la classe 
        /// </summary>
        private SQLiteDataReader Lecture_Donnee;

        /// <summary>
        ///  Constructeur par defaut 
        /// </summary>
        public InterfaceDB_Articles()
        {

        }
        /// <summary>
        ///  cette methode d'insérer un nouveau article dans la table Articles de la base de données
        /// </summary>
        /// <param name="refArticle">l'identifiant de l'article </param>
        /// <param name="description"> la description de l'article </param>
        /// <param name="refsousfamille"> l'identifiant de la sous famille de l'article </param>
        /// <param name="refmarque">l'identifiant de la marque de l'artcile </param>
        /// <param name="prixht">le prix de l'article </param>
        /// <param name="quantite">la quantité de l'article </param>
        /// <returns>le resultat de l'opération </returns>
        /// <remarks>
        ///     Elle vérifie si l'article existe ou pas avant l'insertion dans la table Articles et gère les erreurs qui peuvent survenir 
        /// </remarks>
        public string InsererArticle(string refArticle, string description, int refsousfamille
            , int refmarque, double prixht, int quantite)
        {
            string resultat="";
            Article article = GetArticle(refArticle);
            if (article != null)
            {
                resultat = " = Existe dejà dans la table Article " + refArticle;

            }
            else
            {
                try
                {
                    RequeteInsererArticle = "INSERT INTO Articles(RefArticle,Description,RefSousFamille,RefMarque,PrixHT,Quantite) VALUES"
                   + "(@refArticle,@description,@refsousfamille,@refmarque,@prixht,@quantite)";
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererArticle, InterfaceDB.GetInstaneConnexion());
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refArticle", refArticle);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@description", description);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refsousfamille", refsousfamille);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refmarque", refmarque);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@prixht", prixht);
                    InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@quantite", quantite);
                    InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                    resultat = " + Insertion dans la Table Article : " + refArticle;
                }
                catch (SQLiteException ex)
                {
                    resultat = " * Erreur d'insertion dans la Table Article de  "+refArticle+"  " + ex.Message;
                }
            }
            return resultat;

        }
        /// <summary>
        ///     cette methode d'insérer un nouveau article dans la table Articles de la base de données
        /// </summary>
        /// <param name="article"> un objet Article représentant le nouveau article </param>
        /// <returns></returns>
        public string InsererArticle(Article article)
        {
            return InsererArticle(article.RefArticle, article.Description, article.SousFamille.RefSousFamille, article.Marque.RefMarque, article.PrixHT, article.Quantite);

        }

        /// <summary>
        ///  Cette methode permet de modifier les informations d'un article existant 
        /// </summary>
        /// <param name="refArticle">le nouvel identifiant de l'article </param>
        /// <param name="description"> la nouvelle  description de l'article </param>
        /// <param name="refsousfamille"> le nouvel identifiant de la sous famille de l'article </param>
        /// <param name="refmarque">le nouvel identifiant de la marque de l'artcile </param>
        /// <param name="prixht">le nouveau prix de l'article </param>
        /// <param name="quantite">la nouvelle quantité de l'article </param>
        /// <returns>le resutat de l'opération </returns>
        public string ModifierArticle(string refArticle, string description, int refsousfamille, int refmarque, double prixht, int quantite)
        {
            string resultat="";
            try
            {

                RequeteModifierArticle = "UPDATE Articles SET Description =@desc ,RefSousFamille =@refsous,RefMarque=@refmar,PrixHT=@prix,Quantite=@quan WHERE RefArticle = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierArticle, InterfaceDB.GetInstaneConnexion());
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@desc", description);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refsous", refsousfamille);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@refmar", refmarque);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@prix", prixht);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@quan", quantite);
                InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refArticle);
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " / Mise à jour dans la Table Artcile : " + refArticle;

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de mise à jour dans la Table Article de " +refArticle+" : "+ ex.Message;

            }
            return resultat;

        }

        /// <summary>
        ///  Cette methode permet de supprimer un article dans la table Articles 
        ///  en fonction de son identifiant 
        /// </summary>
        /// <param name="refarticle"> l'identifiant de l'article à supprimer </param>
        /// <returns>le resultat de l'opération </returns>
        public string SupprimerArticle(string refarticle)
        {
            string requete = "DELETE FROM Articles WHERE RefArticle=@ref";
            string resultat;
            InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refarticle);
            
            try
            {
                InterfaceDB.Commande_sqlite.ExecuteNonQuery();
                resultat = " - Suppresion de " + refarticle +" dans la table Article";

            }
            catch (SQLiteException ex)
            {
                resultat = " * Erreur de  suppression de "+refarticle+ " dans la table Article : "+ ex.Message;
            }
            return resultat;
        }
        
        /// <summary>
        /// Cette methode permet d'avoir toutes les insformations d'un article dans la table Articles 
        /// en fonction de l'identifiant de l'article
        /// </summary>
        /// <param name="refarticle"> l'identiifiant de l'article</param>
        /// <returns>L'article recuperer </returns>
        public Article GetArticle(string refarticle)
        {
            Article article = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();

            RequeteDonneeArticle = "select * from Articles where Articles.RefArticle like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneeArticle, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", refarticle);

            try
            {
                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                while (Lecture_Donnee.Read())
                {
                    articleref = Lecture_Donnee["RefArticle"].ToString();
                    desc = Lecture_Donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_Donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_Donnee["Quantite"].ToString());

                   
                    SousFamille sousfamille = Intersousfamille.GetSousFamille(refsousfamille);
                    Marque marque = InterMarque.GetMarque(refmarque);

                    article = new Article(articleref, desc, sousfamille, marque, prix, quan);

                }
            }
            catch (SQLiteException ex)
            {
                article = null;
                Console.WriteLine(" * Erreur de lecture dans la table Article : " + ex.Message);
            }

            return article;
        }

        /// <summary>
        ///  Cette methode nous donne la liste de toutes les articles dans la table Articles de la base de données 
        /// </summary>
        /// <returns>liste d'article </returns>
        /// <see cref="Article"/>
        public List<Article> GetToutesArticle()
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();

            RequeteDonneeArticle = "select * from Articles";
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneeArticle, InterfaceDB.GetInstaneConnexion());


            try
            {

                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_Donnee.Read())
                {
                    articleref = Lecture_Donnee["RefArticle"].ToString();
                    desc = Lecture_Donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_Donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_Donnee["Quantite"].ToString());

                    SousFamille sousfamille = Intersousfamille.GetSousFamille(refsousfamille);
                    Marque marque = InterMarque.GetMarque(refmarque);

                    Article article = new Article(articleref, desc, sousfamille, marque, prix, quan);
                    listarticle.Add(article);

                }
            }
            catch (SQLiteException ex)
            {

                listarticle = null;
                Console.WriteLine(" * Erreur de lecture dans la table Article : " + ex.Message);
            }

            return listarticle;
        }

        /// <summary>
        ///  Cette methode permet d'avoir tous les articles appartenant à une marque 
        /// </summary>
        /// <param name="refMarque">l'identifiant de la marque</param>
        /// <returns>une liste d'article </returns>
        /// <see cref="Article"/>
        public List<Article> GetToutesArticlebyMarque(int refMarque)
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();
            RequeteDonneeArticle = "select * from Articles where RefMarque=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneeArticle, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refMarque);

            try
            {

                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_Donnee.Read())
                {
                    articleref = Lecture_Donnee["RefArticle"].ToString();
                    desc = Lecture_Donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_Donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_Donnee["Quantite"].ToString());

                    
                    SousFamille sousfamille = Intersousfamille.GetSousFamille(refsousfamille);
                    Marque marque = InterMarque.GetMarque(refmarque);

                    Article article = new Article(articleref, desc, sousfamille, marque, prix, quan);
                    listarticle.Add(article);

                }
            }
            catch (SQLiteException ex)
            {

                listarticle = null;
                Console.WriteLine(" * Erreur de lecture dans la table Article : " + ex.Message);
            }

            return listarticle;
        }

        /// <summary>
        ///  Cette methode permet d'avoir tous les articles appartenant à une sous famille
        /// </summary>
        /// <param name="refSousFamille">l'identifiant de la sous famille</param>
        /// <returns>une liste d'article </returns>
        public List<Article> GetToutesArticlebySousFamille(int refSousFamille)
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();
            RequeteDonneeArticle = "select * from Articles where RefSousFamille=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteDonneeArticle, InterfaceDB.GetInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refSousFamille);

            try
            {

                Lecture_Donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_Donnee.Read())
                {
                    articleref = Lecture_Donnee["RefArticle"].ToString();
                    desc = Lecture_Donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_Donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_Donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_Donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_Donnee["Quantite"].ToString());


                    SousFamille sousfamille = Intersousfamille.GetSousFamille(refsousfamille);
                    Marque marque = InterMarque.GetMarque(refmarque);

                    Article article = new Article(articleref, desc, sousfamille, marque, prix, quan);
                    listarticle.Add(article);

                }
            }
            catch (SQLiteException ex)
            {

                listarticle = null;
                Console.WriteLine(" * Erreur de lecture dans la table Article : " + ex.Message);
            }

            return listarticle;
        }





    }
}
