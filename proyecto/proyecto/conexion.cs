using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyecto
{
    class conexion
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; database=proyectofin; Uid=root; pwd=;");
        public MySqlCommandBuilder msqlcmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter adaptador;
        public MySqlCommand comando;
        public void Conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado con exito");
            }
            catch
            {
                MessageBox.Show("Conectado sin exito");
            }
            finally
            {
                con.Close();
            }

        }

        public bool InsertarDatos(string sql)
        {
            con.Open();
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        }

       
    }

