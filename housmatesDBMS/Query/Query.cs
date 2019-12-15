using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace housmatesDBMS
{
    class Query
    {
        private MySqlConnection connection = null;
        private const string FORMAT_DATE = "yyy-MM-dd HH:mm:ss.fff";
        public Query(string host, string db, string username, string password)
        {
            try
            {
                string connStr = string.Format("Server={0}; database={1}; UID={2}; password={3}; convert zero datetime=True", host, db, username, password);
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        private MySqlDataReader GetReader(string query)
        {
            try
            {
                var cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        private void ExecuteNonQuery(string command)
        {
            try
            {
                var cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        private string InjectionSanitizer(string cmd)
        {
            cmd = MySql.Data.MySqlClient.MySqlHelper.EscapeString(cmd);
            return cmd;
        }

        public List<data.House> populateHouses()
        { 
            List<data.House> result = new List<data.House>();
            string cmd = "SELECT houseID, houseName, "




            return result;
        }

        




    }

}
