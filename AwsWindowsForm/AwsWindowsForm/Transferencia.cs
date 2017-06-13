using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsWindowsForm
{
    public class Transferencia
    {

        private static Transferencia valor;
        public static Transferencia Instance()
        {
            if ((valor == null))
            {
                valor = new Transferencia();
            }
            return valor;
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private string myTag = "my053-20";
        public string MyTag() { return myTag; }

        private string myKey = "AKIAJ67SOPZRWPHPB47Q";
        public string MyKeyId() { return myKey; }

        private string secretKey = "sRF4ipHKR+mZgNMm9XIG7poqvjWnXsV7zsCBeOY6";
        public string SecretKey() { return secretKey; }

        private string region = "us-west-2";
        public string Region() { return region; }

        private string urlProducto = string.Empty;
        public void SetUrlProduct (string vUrl) { urlProducto = vUrl; }
        public string  GetUrlproduct() { return urlProducto; }

        private string idProducto = string.Empty;
        public void SetIdProduct(string vId) { idProducto = vId; }
        public string GetIdproduct() { return idProducto; }

    }
}
