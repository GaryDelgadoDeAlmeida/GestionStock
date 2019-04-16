using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Gestion_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------------------------------------------------------------\n" +
                "\t\tApplication de Gestion de Stock" +
                "\n-----------------------------------------------------------------------\n");
            List<Article> lesArticles = new List<Article>();
            Article a1, a2, a3, a4, a5;
            a1 = new Article("a01", "Pomme", 0.50, 20);
            a2 = new Article("a02", "Poire", 0.30, 10);
            a3 = new Article("a03", "Banane", 1.20, 30);
            a4 = new Article("a04", "Fraise", 2.10, 15);
            a5 = new Article("a05", "Orange", 0.80, 50);
            lesArticles.Add(a1);
            lesArticles.Add(a2);
            lesArticles.Add(a3);
            lesArticles.Add(a4);
            lesArticles.Add(a5);
            Stock stockDuMagasin = new Stock(lesArticles);
            string resultatChoixUtilisateur = null;

            do
            {
                resultatChoixUtilisateur = Menu();
                TraitementChoix(resultatChoixUtilisateur, stockDuMagasin);
            } while (!resultatChoixUtilisateur.Equals("8"));
            Console.WriteLine("\nAu revoir ...");
            Console.ReadLine();
        }

        private static Article createArticle()
        {
            string num = null, nom = null;
            double prix = 0.0;
            int quantite = 0;

            Console.WriteLine("Pour l'article, veuillez me donnez le numéro de référence.");
            num = Console.ReadLine();
            Console.WriteLine("Veuillez me donnez le nom de l'article.");
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez me donnez le prix de l'article.");
            antiCrashDouble(out prix);
            Console.WriteLine("Veuillez me donnez le nombre d'exemplaire de l'article.");
            antiCrashInt(out quantite);

            Article article = new Article(num, nom, prix, quantite);

            return article;
        }

        private static void antiCrashInt(out int quantite)
        {
            try
            {
                quantite = Convert.ToInt16(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Une erreur est survenue lors la converssion. Veuillez recommencer.");
                try
                {
                    quantite = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception a)
                {
                    Console.WriteLine("Vous avez reprovoqué une erreur. La valeur demandée sera à 0. Vous pourrez " +
                        "la changer par la suite.");
                    quantite = 0;
                }
            }
        }

        private static void antiCrashDouble(out double prix)
        {
            try
            {
                prix = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Une erreur est survenue lors la converssion. Veuillez recommencer.");
                try
                {
                    prix = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception a)
                {
                    Console.WriteLine("Vous avez reprovoqué l'erreur. La valeur demandée sera à 0. Vous pourrez " +
                        "le changer par la suite.");
                    prix = 0.0;
                }
            }
        }

        public static string Menu()
        {
            Console.WriteLine("Menu : \n"
                + "1. Rechercher un article.\n"
                + "2. Ajouter un article au stock en vérifiant l'unicité de la référence.\n"
                + "3. Supprimer un article par référence.\n"
                + "4. Modifier un article par référence.\n"
                + "5. Rechercher un article par nom.\n"
                + "6. Rechercher un article par l'intervalle de prix de vente.\n"
                + "7. Afficher tous les articles.\n"
                + "8. Quitter.\n\n"
                );
            Console.WriteLine("Veuillez sélectionner le numéro de votre choix");
            string choixUtilisateur = Console.ReadLine();
            return choixUtilisateur;
        }

        public static void TraitementChoix(string choix, Stock sk)
        {
            Article article = null;
            switch(choix)
            {
                // Choix 1 : Rechercher un article du stock
                case "1":
                    Console.WriteLine("Veuillez me donnez le numéro de référence.");
                    string numRefResearch = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("\n" + sk.rechercheByNumRef(numRefResearch).ToString());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("\nL'article que vous recherchez n'existe pas dans nos données.");
                    }
                    finally
                    {
                        Console.WriteLine();
                    }
                    break;

                // Choix 2 : Ajouter un article dans le stock
                case "2":
                    article = createArticle();
                    sk.uniciteArticle(article);
                    break;

                // Choix 3 : Supprimer un article du stock
                case "3":
                    Console.WriteLine("Veuillez me donnez le numéro de référence.");
                    string numRefDelete = Console.ReadLine();
                    sk.supprimerArticleByNumReference(numRefDelete);
                    break;

                // Modifier un article du stock
                case "4":
                    article = createArticle();
                    sk.modifyArticleByNumReference(article);
                    break;

                // Choix 5 : Recherche un article par son nom
                case "5":
                    Console.WriteLine("Veuillez me donnez le nom de l'article.");
                    string nomArticle = Console.ReadLine();
                    List<Article> lesArticles = sk.getArticleByName(nomArticle);
                    sk.afficherLesArticles(lesArticles);
                    break;

                // Choix 6 : Rechercher des articles par une intervalle de prix
                case "6":
                    double prixVenteBas = 0.0, prixVenteHaut = 0.0;
                    Console.WriteLine("Veuille me donnez le seuil le plus bas du prix.");
                    antiCrashDouble(out prixVenteBas);
                    Console.WriteLine("Veuillez me donnez le seuil le plus élevé du prix.");
                    antiCrashDouble(out prixVenteHaut);
                    List<Article> listArticle = sk.rechercheArticleParPrixDeVente(prixVenteBas, prixVenteHaut);
                    sk.afficherLesArticles(listArticle);
                    break;

                // Choix 7 : Afficher les articles du stock
                case "7":
                    sk.afficherLesArticles();
                    break;

                // Choix 8 : Quitter
                case "8":
                    break;

                // Cas où l'utilisateur tape autre chose parmis les choix proposés
                default:
                    Console.WriteLine("Choix inexistant.\n");
                    break;
            }
        }
    }
}
