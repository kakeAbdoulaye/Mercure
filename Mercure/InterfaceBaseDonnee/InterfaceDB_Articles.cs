using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mercure.Models;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mercure.InterfaceBaseDonnee
{
    class InterfaceDB_Articles
    {
        private string RequeteInsererArticle;
        private string RequetedonneeArticle;
        private string RequeteModifierArticle;
        private SQLiteDataReader Lecture_donnee;
        public InterfaceDB_Articles()
        {

        }

        public string insererArticle(string refArticle, string description, int refsousfamille
            , int refmarque, double prixht, int quantite)
        {
            string resultat="";
            Article article = getArticle(refArticle);
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
                    InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteInsererArticle, InterfaceDB.getInstaneConnexion());
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

        public string insererArticle(Article article)
        {
            return insererArticle(article.RefArticle, article.Description, article.SousFamille.RefSousFamille, article.Marque.RefMarque, article.PrixHT, article.Quantite);

        }
        public string modifierArticle(string refArticle, string description, int refsousfamille, int refmarque, double prixht, int quantite)
        {
            string resultat="";
            try
            {

                RequeteModifierArticle = "UPDATE Articles SET Description =@desc ,RefSousFamille =@refsous,RefMarque=@refmar,PrixHT=@prix,Quantite=@quan WHERE RefArticle = @ref";
                InterfaceDB.Commande_sqlite = new SQLiteCommand(RequeteModifierArticle, InterfaceDB.getInstaneConnexion());
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
        public string supprimerArticle(string refarticle)
        {
            string requete = "DELETE FROM Articles WHERE RefArticle=@ref";
            string resultat;
            InterfaceDB.Commande_sqlite = new SQLiteCommand(requete, InterfaceDB.getInstaneConnexion());
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
        

        public Article getArticle(string refarticle)
        {
            Article article = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();

            RequetedonneeArticle = "select * from Articles where Articles.RefArticle like @nom";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneeArticle, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@nom", refarticle);

            try
            {
                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                while (Lecture_donnee.Read())
                {
                    articleref = Lecture_donnee["RefArticle"].ToString();
                    desc = Lecture_donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_donnee["Quantite"].ToString());

                   
                    SousFamille sousfamille = Intersousfamille.getSousFamille(refsousfamille);
                    Marque marque = InterMarque.getMarque(refmarque);

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
        public List<Article> getToutesArticle()
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();

            RequetedonneeArticle = "select * from Articles";
            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneeArticle, InterfaceDB.getInstaneConnexion());


            try
            {

                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_donnee.Read())
                {
                    articleref = Lecture_donnee["RefArticle"].ToString();
                    desc = Lecture_donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_donnee["Quantite"].ToString());

                    SousFamille sousfamille = Intersousfamille.getSousFamille(refsousfamille);
                    Marque marque = InterMarque.getMarque(refmarque);

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

        public List<Article> getToutesArticlebyMarque(int refMarque)
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();
            RequetedonneeArticle = "select * from Articles where RefMarque=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneeArticle, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refMarque);

            try
            {

                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_donnee.Read())
                {
                    articleref = Lecture_donnee["RefArticle"].ToString();
                    desc = Lecture_donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_donnee["Quantite"].ToString());

                    
                    SousFamille sousfamille = Intersousfamille.getSousFamille(refsousfamille);
                    Marque marque = InterMarque.getMarque(refmarque);

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

        public List<Article> getToutesArticlebySousFamille(int refSousFamille)
        {

            List<Article> listarticle = null;
            string articleref, desc;
            int refsousfamille, refmarque, quan;
            double prix;
            InterfaceDB_Sous_Famille Intersousfamille = new InterfaceDB_Sous_Famille();
            InterfaceDB_Marque InterMarque = new InterfaceDB_Marque();
            RequetedonneeArticle = "select * from Articles where RefSousFamille=@ref";

            InterfaceDB.Commande_sqlite = new SQLiteCommand(RequetedonneeArticle, InterfaceDB.getInstaneConnexion());
            InterfaceDB.Commande_sqlite.Parameters.AddWithValue("@ref", refSousFamille);

            try
            {

                Lecture_donnee = InterfaceDB.Commande_sqlite.ExecuteReader();
                listarticle = new List<Article>();
                while (Lecture_donnee.Read())
                {
                    articleref = Lecture_donnee["RefArticle"].ToString();
                    desc = Lecture_donnee["Description"].ToString();
                    refsousfamille = Int32.Parse(Lecture_donnee["RefSousFamille"].ToString());
                    refmarque = Int32.Parse(Lecture_donnee["RefMarque"].ToString());
                    prix = Double.Parse(Lecture_donnee["PrixHT"].ToString());
                    quan = Int32.Parse(Lecture_donnee["Quantite"].ToString());


                    SousFamille sousfamille = Intersousfamille.getSousFamille(refsousfamille);
                    Marque marque = InterMarque.getMarque(refmarque);

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
