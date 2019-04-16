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
    public partial class SupprimerArticle : Form
    {
        private Stock leStock;
        public SupprimerArticle(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }

        private void btnValiderSupp_Click(object sender, EventArgs e)
        {
            string msg = "L'article n'existe pas dans le stock";
            List<Article> lesArticles = this.leStock.getLesArticles();
            try
            {
                foreach (Article unArticle in lesArticles)
                {
                    if (unArticle.getNumReferenceArticle().Equals(this.txtSuppId.Text))
                    {
                        this.leStock.getLesArticles().Remove(unArticle);
                        msg = "La suppression c'est correctement effectué";
                    }
                }
                this.leStock.setLesArticles(lesArticles);
                MessageBox.Show(msg);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
