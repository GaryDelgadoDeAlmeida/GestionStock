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
    public partial class ModifierArticleNom : Form
    {
        private Stock leStock;

        public ModifierArticleNom(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }

        private void btnValiderModifName_Click(object sender, EventArgs e)
        {
            string msg = "La modification du nom de l'article " + this.txtNumRef.Text + " n'a pu se faire.";
            try
            {
                foreach (Article unArticle in this.leStock.getLesArticles())
                {
                    if (unArticle.getNumReferenceArticle().Equals(this.txtNumRef.Text))
                    {
                        unArticle.setNomArticle(this.txtName.Text);
                        msg = "La mofication c'est correctement effectué.";
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
            this.txtName.Text = null;
        }
    }
}
