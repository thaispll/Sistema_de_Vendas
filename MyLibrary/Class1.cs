using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyLibrary
{
    public class Utilidade
    {
        public static DataSet Executar(string cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-03868EV\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //conexão, caminho do DB
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();

            return DS;
        }
    }   
}
