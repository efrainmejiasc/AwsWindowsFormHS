using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AwsWindowsForm
{
   public  class Handler
    {
        private const string awsSecretKey = "sRF4ipHKR+mZgNMm9XIG7poqvjWnXsV7zsCBeOY6";
        private const string awsAccessKeyId = "AKIAJ67SOPZRWPHPB47Q";
        private const string associateTag = "my053-20";

        public void ProcessRequest(HttpContext context)
        {
            var keywords = context.Request.QueryString["k"];
            string responseJson = string.Empty;

            if (string.IsNullOrEmpty(keywords))
            {
                responseJson = AmazonApiHelper.GetEmptyResponseJson(string.Empty, string.Empty, HttpStatusCode.OK);
            }
            else
            {
                using (AmazonApiHelper apiHelper = new AmazonApiHelper(associateTag, awsAccessKeyId, awsSecretKey))
                {
                    string requestUri = apiHelper.GetRequestUri(keywords);
                    try
                    {
                        responseJson = apiHelper.ExecuteWebRequest(requestUri, keywords);
                    }
                    catch (Exception ex)
                    {
                        responseJson = AmazonApiHelper.GetEmptyResponseJson(keywords, ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
            }

            context.Response.ContentType = "application/json";
            context.Response.Write(responseJson);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }

        }
    }
}
