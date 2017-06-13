using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private string timeStamp = string.Empty;
        private const string dateFormat = "yyyy-MM-ddTHH:mm:ss.000Z";
        private const string stringToSignFormat = "GET\n{0}\n{1}\n{2}";
        private const string signedUriFormat = "http://{0}{1}?{2}&Signature={3}";
        private const string EndPoint = "webservices.amazon.com";
        private const string RequestUri = "/onca/xml";
        private HMACSHA256 hmac = null;

        public string UrlCliente(string palabra, string categoria)
        {
            if (categoria == null) categoria = "All";
            palabra = palabra.Replace(" ", "%20");
            this.timeStamp = DateTime.UtcNow.ToString(dateFormat).Replace(":", "%3A");
            string urlCliente =
                                "AWSAccessKeyId=" + this.myKey +
                                "&AssociateTag=" + this.myTag +
                                "&Keywords=" + palabra + 
                                "&Operation=ItemSearch"+ 
                                "&ResponseGroup=Images%2CItemAttributes%2COffers&" +
                                "SearchIndex=" + categoria + "&"+
                                "Service=AWSECommerceService&Timestamp=" +
                                this.timeStamp  ;

            string stringToSign = string.Format(stringToSignFormat, EndPoint, RequestUri, urlCliente);
            byte[] hashedSecretString = hmacSHA256(stringToSign, secretKey);
            string qsSignature = Convert.ToBase64String(hashedSecretString).Replace("+", "%2B").Replace("=", "%3D");

            urlCliente = string.Format(signedUriFormat, EndPoint, RequestUri, urlCliente, qsSignature);

            return urlCliente;                                         
        }

        private byte[] hmacSHA256(string data, string key)
        {
            if (hmac == null)
            {
                hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key));
            }
            return hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
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
