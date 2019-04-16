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
    public partial class RechercherArticleParIdentification : Form
    {
        private Stock leStock;

        public RechercherArticleParIdentification(Stock leStock)
        {
            InitializeComponent();
            this.leStock = leStock;
        }
    }
}
