using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Admin
{
    public class ErrorRepository
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public bool AddError(string message, string route, string ip, string values, DateTime date)
        {

            OpenConn();
            SetQuery("INSERT INTO Errors(message,route,ip,vals,date) VALUES (\'" + message + "\',\'" + route + "\',\'" + ip + "\',\'" + values + "\',\'" + date.ToString() +  "\');");
            return CloseConn();
        }

        private void OpenConn()
        {
            conn = new SqlConnection(Entity.ConnecectionString.connection1);
            conn.Open();
        }

        private void SetQuery(string query, int mode = 0)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            if (mode == 1)
            {
                dr = cmd.ExecuteReader();
            }


        }

        private bool CloseConn()
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
