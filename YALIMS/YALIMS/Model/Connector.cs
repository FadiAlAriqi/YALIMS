using System.Net;
using System.Text;

namespace YALIMS.Controller
{
    public static class Connector
    {
        /// <summary>
        /// The server address
        /// </summary>
        public static string host = "localhost";
        /// <summary>
        /// The port of the server
        /// </summary>
        public static string port = "8080";
        /// <summary>
        /// The path where APIs are
        /// </summary>
        public static string path = "YALIMS/APIs";
        /// <summary>
        /// Connect to the server and send and recieve data
        /// </summary>
        /// <param name="postData">The query</param>
        /// <param name="type">The user Type to which the query is done</param>
        /// <returns>returns the recived data</returns>
        /// <exception cref="ArgumentException">throws an error if the operation in the server encountered an error</exception>
        private static string connect(string postData, string type)
        {
            WebRequest request = WebRequest.Create(string.Format("http://{0}:{1}/{2}/{3}APIs.php", host, port, path, type));
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string recievedData = sr.ReadToEnd();
            if (!recievedData.StartsWith("ERR"))
            {
                return recievedData;
            }
            else
            {
                throw new Exception(recievedData);
            }
        }
        /// <summary>
        /// Send operation to the connect method
        /// </summary>
        /// <param name="requestType">Request Type</param>
        /// <param name="query">The Request query</param>
        /// <param name="type">The Table Type</param>
        /// <returns></returns>
        public static string Operate(string requestType, string query, string type)
        {
            return connect(
                string.Format("RequestType={0}{1}", requestType, query),
                type
                );
        }
        /// <summary>
        /// Convert the parameters array into request query string
        /// </summary>
        /// <param name="array">Parameters array</param>
        /// <returns>Request query string</returns>
        public static string ArrayToString(string[,] array)
        {
            if (array is null)
                return String.Empty;
            string ready = "";
            for (int i = 0; i < array.Length/2; i++)
            {
                ready += $"&{array[i,0]}={array[i,1]}";
            }
            return ready;
        }
    }
}
