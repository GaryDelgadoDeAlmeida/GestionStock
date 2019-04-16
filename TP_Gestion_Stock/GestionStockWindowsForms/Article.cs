using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockWindowsForms
{
    public class Article
    {
        private string numRef;
        private string nom;
        private double prixVente;
        private int quantite;

        public Article(string numRef, string nom, double prix, int quantite)
        {
            this.numRef = numRef;
            this.nom = nom;
            this.prixVente = prix;
            this.quantite = quantite;
        }

        /// <summary>
        /// Récupére le numéro de référence de l'article
        /// </summary>
        /// <returns>numRef</returns>
        public string getNumReferenceArticle()
        {
            return this.numRef;
        }

        /// <summary>
        /// Récupére le nom de l'article
        /// </summary>
        /// <returns>nom</returns>
        public string getNomArticle()
        {
            return this.nom;
        }

        /// <summary>
        /// Récupére le prix de vente de l'article
        /// </summary>
        /// <returns></returns>
        public double getPrixVenteArticle()
        {
            return this.prixVente;
        }

        /// <summary>
        /// Récupére la quantité restante de l'article
        /// </summary>
        /// <returns></returns>
        public int getQuantiteArticle()
        {
            return this.quantite;
        }

        /// <summary>
        /// Modifie le nom de l'article
        /// </summary>
        /// <param name="nom"></param>
        public void setNomArticle(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Modifie le prix de vente de l'article
        /// </summary>
        /// <param name="prixVente"></param>
        public void setPrixVenteArticle(double prixVente)
        {
            this.prixVente = prixVente;
        }

        /// <summary>
        /// Modifie le nombre d'exemplaire de l'article
        /// </summary>
        /// <param name="quantite"></param>
        public void setQuantiteArticle(int quantite)
        {
            this.quantite = quantite;
        }

        public override string ToString()
        {
            return "Id de référence : " + this.numRef + ", Nom : " + this.nom +
                ", Prix de vente : " + this.prixVente + ", Nombre d'exemplaire : " + this.quantite;
        }
    }
}
