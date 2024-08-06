using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection com = new SqlConnection(conexion);

            com.Open();

            String sql = "";
            sql = sql + "SELECT [CustomerID] " + "\n";
            sql = sql + "      ,[CompanyName] " + "\n";
            sql = sql + "      ,[ContactName] " + "\n";
            sql = sql + "      ,[ContactTitle] " + "\n";
            sql = sql + "      ,[Address] " + "\n";
            sql = sql + "      ,[City] " + "\n";
            sql = sql + "      ,[Region] " + "\n";
            sql = sql + "      ,[PostalCode] " + "\n";
            sql = sql + "      ,[Country] " + "\n";
            sql = sql + "      ,[Phone] " + "\n";
            sql = sql + "      ,[Fax] " + "\n";
            sql = sql + "  FROM [dbo].[Customers]";

            SqlCommand comandos = new SqlCommand(sql);
            var lectura = comandos.BeginExecuteReader();
        }
    }
}
