using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsWindowsForm
{
    public partial class AwsExampleNav : Form
    {
        Transferencia Valor =  Transferencia.Instance();
        public AwsExampleNav()
        {
            InitializeComponent();
        }

        private void AwsExampleNav_Load(object sender, EventArgs e)
        {
            this.Text = "ID - " + Valor.GetIdproduct();
            webBrowser1.Url = new Uri(Valor.GetUrlproduct());
        }
    }
}
