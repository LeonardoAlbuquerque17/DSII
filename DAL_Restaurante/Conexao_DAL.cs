using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
/*using MySql.Data.MySqlClient;
using MySql.Data;*/
using System.Data;
using System.Data.SqlClient;


namespace DAL_Restaurante

{
    public class Conexao_DAL
    {
        public static SqlConnection Login()
        {
            try
            {
                SqlConnection con = new SqlConnection
                    (@"Data Source=(localdb)\Projects;Initial Catalog=RESTAURANTE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                throw new Exception("qualquer coisa" + ex.Message);
            }
                
            
        }
        public static SqlConnection PRODUTO()
        {
            try
            {
                SqlConnection con = new SqlConnection
                    (@"Data Source=(localdb)\Projects;Initial Catalog=RESTAURANTE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                return con;
            }
            catch
            {
                throw new Exception("Não foi possível conectar!!");
            }
        }
        public static SqlConnection Cad_Func()
        {
            try
            {
                SqlConnection con = new SqlConnection
                    (@"Data Source=(localdb)\Projects;Initial Catalog=RESTAURANTE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                return con;
            }
            catch
            {
                throw new Exception("Não foi possível conectar!!");
            }
            
        }
    }
}
