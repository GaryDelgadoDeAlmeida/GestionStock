using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStockWindowsForms
{
    public partial class HomeApplication : Form
    {
        private Stock leStock;

        public HomeApplication()
        {
            InitializeComponent();
            this.leStock = new Stock();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterUnArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterArticle aa = new AjouterArticle(this.leStock);
            aa.Show();
        }

        private void supprimerUnArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerArticle sa = new SupprimerArticle(this.leStock);
            sa.Show();
        }

        private void rechercherParUnNuméroDidentificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherArticleParIdentification rapi = new RechercherArticleParIdentification(this.leStock);
            rapi.Show();
        }

        private void rechercherParUnNomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherArticleParNom rapn = new RechercherArticleParNom(this.leStock);
            rapn.Show();
        }

        private void rechercherParUnIntervalleDePrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherArticleParIntervalle rapi = new RechercherArticleParIntervalle(this.leStock);
            rapi.Show();
        }

        private void afficherTousLesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherArticles aa = new AfficherArticles(this.leStock);
            aa.Show();
        }

        private void nomDeLarticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierArticleNom man = new ModifierArticleNom(this.leStock);
            man.Show();
        }

        private void prixDeLarticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierArticlePrice map = new ModifierArticlePrice(this.leStock);
            map.Show();
        }

        private void nbrExemplairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierArticleNbrExemplaire mane = new ModifierArticleNbrExemplaire(this.leStock);
            mane.Show();
        }
    }
}
