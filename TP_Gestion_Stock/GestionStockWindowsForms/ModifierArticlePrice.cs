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
    public partial class ModifierArticlePrice : Form
    {
        private Stock leStock;
        public ModifierArticlePrice(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }

        private void btnValiderModifPrice_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(this.txtNewPrice.Text);
                string msg = "Le prix de l'article " + this.txtNumRef.Text + " n'a pu être modifié.";
                foreach (Article unArticle in this.leStock.getLesArticles())
                {
                    if (unArticle.getNumReferenceArticle().Equals(this.txtNumRef.Text))
                    {
                        unArticle.setPrixVenteArticle(price);
                        msg = "Le prix a été modifié.";
                        this.inputTextToEmpty();
                    }
                }
                MessageBox.Show(msg);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void inputTextToEmpty()
        {
            this.txtNumRef.Text = null;
            this.txtNewPrice.Text = null;
        }
    }
}
