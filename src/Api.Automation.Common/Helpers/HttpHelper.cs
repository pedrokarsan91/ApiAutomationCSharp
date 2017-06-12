using Api.Automation.Common.Utils;
using System.Net;
using System.Text;

namespace Api.Automation.Common.Helpers
{
    public class HttpHelper
    {
        private static readonly HttpHelper instance = new HttpHelper();

        public enum HttpType
        {
            Post,
            Get
        }

        public static HttpHelper GetInstance
        {
            get { return instance; }
        }

        public int GetResponseCode(string url, HttpType httpType)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = httpType.ToString().ToUpper();
            HttpWebResponse response;

            try
            {
                if (httpType == HttpType.Post)
                {
                    var encoding = new ASCIIEncoding();
                    var bytesToWrite = encoding.GetBytes(string.Empty);
                    request.ContentLength = bytesToWrite.Length;
                }
                response = (HttpWebResponse)request.GetResponse();
            }
            catch
            {
                return (int)Constants.HttpStatusCode.NotFound;
            }

            var statusCode = response.StatusCode;
            return (int)statusCode;
        }
    }
}
