using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLibrary;
using System.Linq.Expressions;

namespace SistemaVenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Botaoclique_Click_1(object sender, EventArgs e)
        {
            try 
            { 
            string CMD = string.Format("select from Usuario where txt_conta = '{0}' and Password = '{1}'", txt_conta.Text.Trim(),txt_senha.Text.Trim();
            DataSet ds = Utilidade.Executar(CMD);

            string conta = ds.Tables[0].Rows[0]["Conta"].ToString().Trim();
            string senha = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
            
            if (conta == txtconta.Tex.Trim() && senha == txtsenha.Text.Trim())
            {
                MessageBox.Show("Seja bem-vindo ao sistema Cs.");
            }

             catch (Exception error)
            {
                MessageBox.Show("Usuario e Senha incorretas");
                    
            }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }   
}

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