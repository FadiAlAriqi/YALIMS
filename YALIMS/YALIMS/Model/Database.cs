using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Controller
{
    public abstract class Database
    {
        /// <summary>
        /// Get the Type of API
        /// </summary>
        /// <returns>API type</returns>
        public static string TYPE;
        /// <summary>
        /// Fields 
        /// </summary>
        /// <returns></returns>
        protected abstract string[,] Fields();
        public static void Add(string[,] parameters) {
            Connector.Operate("insert", Connector.ArrayToString(parameters), TYPE);
        }
        public static void Remove(string key, string column = "")
        {
            if (column == "") column = "username";
            string query = $"&{column}={key}";
            Connector.Operate("delete", query, TYPE);
        }
        public static string Update(string[,] parameters) 
        {
            return Connector.Operate("update", Connector.ArrayToString(parameters), TYPE);
        }
        public string Update()
        {
            return Connector.Operate("update", Connector.ArrayToString(Fields()), TYPE);
        }
        public static string Activate(string username)
        {
            return Connector.Operate("activate", $"&username={username}", TYPE);
        }
        public static DataTable? Find(string key, string column = "")
        {
            if (column == "") column = "username";
            string query = $"&{column}={key}";
            string data = Connector.Operate("select", query, TYPE);
            if (data != "0")
            {
                return JsonConvert.DeserializeObject<DataTable>(data);
            }
            else
            {
                return new DataTable();
            }
        }
        public static DataTable? All()
        {
            string data = Connector.Operate("select", "", TYPE);
            if (data != "0")
            {
                return JsonConvert.DeserializeObject<DataTable>(data);
            }
            else
            {
                return new DataTable();
            }
        }
        public string Save()
        {
            return Connector.Operate("insert", Connector.ArrayToString(Fields()), TYPE);
        }
    }
}
