using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsWindowsForm
{
    public partial class AwsExampleMain : Form
    {
        Transferencia Valor = Transferencia.Instance();
        EngineAws Metodo = new EngineAws();
        AwsExampleMsjWait K = new AwsExampleMsjWait();

        public AwsExampleMain()
        {
            InitializeComponent();
        }

        private void AwsExample_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text == string.Empty) return;
            K = new AwsExampleMsjWait();
            K.Show();
            timer1.Interval =100;
            timer1.Start();
        }

        private  void BusquedaArticulo()
        {
            string palabra = txtProduct.Text;
            AmazonApiHelper AwsApiHelp2 = new AmazonApiHelper(Valor.MyTag(), Valor.MyKeyId(), Valor.SecretKey());
            string urlSearch2 = AwsApiHelp2.GetRequestUri(palabra);
            txtUrl.Text = urlSearch2;
            string json2 = AwsApiHelp2.ExecuteWebRequest(urlSearch2, palabra);
            DataTable dt2 = new DataTable();
            dt2 = Metodo.BuidingDataTable(dt2);
            dt2 = Metodo.DataAddTable(dt2, json2);
            dgv1.DataSource = dt2;
            WebClient wc;
            MemoryStream ms;
            int f = 0;
            foreach (DataRow r in dt2.Rows)
            {
                wc = new WebClient();
                byte[] bytes = wc.DownloadData(r["productImgUrl"].ToString());

                ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                Image img2;
                img2 = Metodo.ResizeImage(img, 6000, 3500);
                if (img2 != null)
                    dgv1.Rows[f].Cells["productImgUrl"].Value = img2;
                else
                    dgv1.Rows[f].Cells["productImgUrl"].Value = img;
                f++;
            }

            Metodo.CaracteristicaGrilla(dgv1);
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridViewRow  row = dgv1.CurrentRow;
             string urlProduct = row.Cells["productUrl"].Value.ToString();
             string idProduct = row.Cells["ASIN"].Value.ToString();
             Valor.SetUrlProduct(urlProduct);
             Valor.SetIdProduct(idProduct);
             AwsExampleNav f = new AwsExampleNav();
             f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            BusquedaArticulo();
            K.Close();

        }
    }
}
