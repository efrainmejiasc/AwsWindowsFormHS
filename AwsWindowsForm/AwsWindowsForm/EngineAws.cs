using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AwsWindowsForm
{
    public class EngineAws
    {
        public DataTable BuidingDataTable(DataTable dt)
        {
            if (dt.Columns.Count > 0) return dt;
            dt.Columns.Add("asin");
            dt.Columns.Add("productUrl");
            dt.Columns.Add("productImgUrl");
            dt.Columns.Add("price");
            dt.Columns.Add("title");
            dt.Columns.Add("offersUrl");
            dt.Columns.Add("ShopNow");

            return dt;
        }

        public DataTable DataAddTable(DataTable dt, string json)
        {
            EngineDesSerialize.ListaAwsProfileSearch awsSearch = new JavaScriptSerializer().Deserialize<EngineDesSerialize.ListaAwsProfileSearch>(json);
            foreach (var item in awsSearch.responseArray)
            {
                if (item.productImgUrl != null)
                {
                    dt.Rows.Add(item.asin, item.productUrl, item.productImgUrl, item.price, item.title, item.offersUrl, "Shop Now");
                }
            }
            return dt;
        }

        public Image ResizeImage(Image img, int width, int height)
        {
            try
            {
                Bitmap b = new Bitmap(width, height);
                Graphics g = Graphics.FromImage((Image)b);

                g.DrawImage(img, 0, 0, width, height);
                g.Dispose();
                return (Image)b;
            }
            catch(Exception e) {  }

            return null;
        }

        public DataGridView CaracteristicaGrilla(DataGridView dgv)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.HeaderCell.Value = (r.Index + 1).ToString();
                if (r.Index % 2 == 0) r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                else r.DefaultCellStyle.BackColor = Color.Silver;
            }
            dgv.ClearSelection();
            return dgv;
        }


    }
}
