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
    public partial class ModifierArticleNbrExemplaire : Form
    {
        private Stock leStock;

        public ModifierArticleNbrExemplaire(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }

        private void btnValiderModifNbrExemplaire_Click(object sender, EventArgs e)
        {
            try
            {
                int nbrEx = Convert.ToInt32(this.txtNbrExemplaire.Text);
                string msg = "La modification de l'article " + this.txtNumRef.Text + " n'a pu s'effectué";

                foreach(Article unArticle in this.leStock.getLesArticles())
                {
                    if (unArticle.getNumReferenceArticle().Equals(this.txtNumRef.Text))
                    {
                        unArticle.setQuantiteArticle(nbrEx);
                        msg = "La quantité a été modifié.";
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
            this.txtNbrExemplaire = null;
        }
    }
}