using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Gestion_Stock
{
    public class Stock
    {
        private List<Article> lesArticles;

        public Stock()
        {
            this.lesArticles = new List<Article>();
        }

        public Stock(List<Article> lesArticles)
        {
            this.lesArticles = lesArticles;
        }

        /// <summary>
        /// Récupére la liste d'articles du stock
        /// </summary>
        /// <returns>lesArticles</returns>
        public List<Article> getLesArticles()
        {
            return this.lesArticles;
        }

        /// <summary>
        /// Recherche dans la collection, le numéro de référence
        /// de l'article
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public Article rechercheByNumRef(string num)
        {
            Article a = null;

            foreach(Article unArticle in this.lesArticles)
            {
                if (num.Equals(unArticle.getNumReferenceArticle()))
                {
                    a = unArticle;
                    break;
                }
            }
            return a;
        }

        /// <summary>
        /// Vérifie si le numéro de référence de l'article donnée
        /// est unique.
        /// </summary>
        /// <param name="article"></param>
        public void uniciteArticle(Article article)
        {
            bool unicite = true;

            foreach(Article unArticle in this.lesArticles)
            {
                if (article.getNumReferenceArticle().Equals(unArticle.getNumReferenceArticle()))
                {
                    unicite = false;
                }
            }

            this.ajouterArticle(article, unicite);
        }

        /// <summary>
        /// Supprime un ou les article(s) ayant comme numéro
        /// de référence donné de la collection d'article.
        /// </summary>
        /// <param name="num"></param>
        public void supprimerArticleByNumReference(string num)
        {
            string response = "La suppréssion de l'article n'a pu s'effectué pour cause,\n" +
                "son inéxistance dans le stock.";
            foreach (Article unArticle in this.lesArticles)
            {
                if (num.Equals(unArticle.getNumReferenceArticle()))
                {
                    this.lesArticles.Remove(unArticle);
                    response = "La suppréssion de l'article ayant comme référence" + num + ", " +
                        "c'est correctement effectué.";
                }
            }
            Console.WriteLine("\n" + response + "\n");
        }

        /// <summary>
        /// Modifie un article en utilisant son numéro de référence
        /// les remplaçant par des nouvelles données.
        /// </summary>
        /// <param name="article"></param>
        public void modifyArticleByNumReference(Article article)
        {
            Article a = this.rechercheByNumRef(article.getNumReferenceArticle());

            try
            {
                a.setNomArticle(article.getNomArticle());
                a.setPrixVenteArticle(article.getPrixVenteArticle());
                a.setQuantiteArticle(article.getQuantiteArticle());

                Console.WriteLine("\nModification de l'article terminée.\n");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nL'article que vous souhaitez modifié n'existe pas dans nos données.\n");
            }
            finally { }
        }

        /// <summary>
        /// Recherche dans la collection un ou plusieurs article(s) 
        /// ayant le nom donnée en paramètre
        /// </summary>
        /// <param name="name"></param>
        /// <returns name="article"></returns>
        public List<Article> getArticleByName(string name)
        {
            List<Article> article = new List<Article>();

            foreach(Article unArticle in lesArticles)
            {
                if (name.Equals(unArticle.getNomArticle()))
                {
                    article.Add(unArticle);
                }
            }
            return article;
        }

        /// <summary>
        /// Recherche les articles dans la collection correspondant
        /// à l'intervalle de prix donnée
        /// </summary>
        /// <param name="prixMin"></param>
        /// <param name="prixMax"></param>
        /// <returns name="articles"></returns>
        public List<Article> rechercheArticleParPrixDeVente(double prixMin, double prixMax)
        {
            List<Article> articles = new List<Article>();

            foreach (Article unArticle in this.lesArticles)
            {
                if((unArticle.getPrixVenteArticle() >= prixMin) && (unArticle.getPrixVenteArticle() <= prixMax))
                {
                    articles.Add(unArticle);
                }
            }
            return articles;
        }

        /// <summary>
        /// Affiche tout le contenu de la collection
        /// </summary>
        public void afficherLesArticles()
        {
            Console.WriteLine();
            if (this.lesArticles.Count > 0)
            {
                foreach (Article unArticle in this.lesArticles)
                {
                    Console.WriteLine(unArticle.ToString());
                }
            }
            else
            {
                Console.WriteLine("La liste d'articles est vide.");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Affiche tout le contenu de la collection
        /// passer en paramètre
        /// </summary>
        /// <param name="articles"></param>
        public void afficherLesArticles(List<Article> articles)
        {
            Console.WriteLine();
            if (articles.Count > 0)
            {
                foreach (Article unArticle in articles)
                {
                    Console.WriteLine(unArticle.ToString());
                }
            }
            else
            {
                Console.WriteLine("La liste d'articles est vide.");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// En fonction de la valeur de l'unicité, l'article donnée 
        /// sera soit ajouter, soit rejeter.
        /// </summary>
        /// <param name="article"></param>
        /// <param name="unicite"></param>
        private void ajouterArticle(Article article, bool unicite)
        {
            string response = "Le numéro de référence donnée n'est pas unique.";
            // Si unicite est vrai => true
            if(unicite)
            {
                this.lesArticles.Add(article);
                response = "L'article a été ajouté dans le stock.";
            }
            Console.WriteLine(response + "\n");
        }
    }
}
