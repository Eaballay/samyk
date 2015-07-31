using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
namespace prueba_conexion
{
    public partial class Form1 : Form
    {
        static string cadena;
        static FbConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }


        public string armarQry()
        {
                  String armarQuery = "SELECT * FROM venta ";
               if (checkBox1.Checked) {
                   return  armarQuery + "where nombre = '" + textBox1.Text+"'";
        }
          
               else
               {
                   return armarQuery;
               }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into VENTA (ID_CLIENTE, VEN_CODI, VEN_ESTA, CREATED_BY, CREATED_AT) values ( '1', '1', 'a', '1', '2015/06/01')";
            FbCommand insert = new FbCommand(query, conexion);
            insert.ExecuteNonQuery();
            //conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        try {
            cadena = "User=SYSDBA;Password=masterkey;Database=C:\\Users\\Juan\\Desktop\\SAMYK\\samyk\\database.FDB;Datasource=localhost;Port=3050";
        } catch (Exception ex){
            cadena = "User=SYSDBA;Password=masterkey;Database=C:\\Users\\Ezequiel-Pc\\Desktop\\samyk\\samyk\\database.FDB;Datasource=localhost;Port=3050";
        }

        conexion = new FbConnection(cadena);

            try
            {
                conexion.Open();

                MessageBox.Show("conexion establecida");
                DataTable dtDatos = new DataTable();
                string qry = armarQry();
                FbDataAdapter mdaDatos = new FbDataAdapter(qry, conexion);
                mdaDatos.Fill(dtDatos);
                dataGridView1.DataSource = dtDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
               

            }
        }
    }
}
