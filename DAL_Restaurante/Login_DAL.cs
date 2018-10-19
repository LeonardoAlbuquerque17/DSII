using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
/*using MySql.Data;
using MySql.Data.MySqlClient;*/
using System.Data;
using System.Data.SqlClient;
namespace DAL_Restaurante
{
    public class Login_DAL
    {
        public static string Validar_Login(Login_DTO obj)
        {
            try
            {
        string sql = "select * from TB_LOGIN where usuario = @usuario AND senha = @senha";
            SqlCommand cm = new SqlCommand(sql, Conexao_DAL.Login());
            
            cm.Parameters.AddWithValue("@usuario", obj.Usuario);
            cm.Parameters.AddWithValue("@senha", obj.Senha);
            SqlDataReader dados = cm.ExecuteReader();//serve para executar
                while (dados.Read())//executa o loop para encontrar os dados
                {
                    if (dados.HasRows)//Se ele encontrar ele executa esse código, se achar ele coloca em um vetor
                    {
                        return "sucesso";
                    }
                }
                return "usuário ou senha inválidos!!";
            }

            catch(Exception xy)
            {
                return (xy.Message);
            }
        }
    }
}
