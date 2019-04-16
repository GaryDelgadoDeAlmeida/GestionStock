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
    public partial class AjouterArticle : Form
    {
        private Stock leStock;

        public AjouterArticle(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0.0;
            int nbrCopy = 0;
            try
            {
                price = Convert.ToDouble(this.inputPrice.Text);
                nbrCopy = Convert.ToInt32(this.inputNbr.Text);

                Article article = new Article(this.inputNum.Text, this.inputName.Text, price, nbrCopy);
                turnInputTextToNull();

                if (this.leStock.addArticle(article) == true)
                {
                    MessageBox.Show("L'ajout a correctement été effectué");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void turnInputTextToNull()
        {
            this.inputNum.Text = null;
            this.inputName.Text = null;
            this.inputPrice.Text = null;
            this.inputNbr.Text = null;
        }
    }
}
