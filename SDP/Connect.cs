using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP
{
    class Connect{

        public static OleDbConnection conn;
        public static void init()
        {
            Connect.conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
            conn.Open();
        }
        public static DataTable query(string sqlStr)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, conn);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            return dt;
        }
        public static void exec(string sqlStr)
        {
            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();
        }
    }

}
