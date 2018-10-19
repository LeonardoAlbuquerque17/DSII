using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Restaurante
{
    public class CONFIRMAR_CADASTRO
    {
        public static bool Validar_CADASTRO(CADASTRO_DTO obj)
        {
            try
            {
                string sql = "select * from TB_FUNCIONARIOS where CPF = @CPF";
                SqlCommand cm = new SqlCommand(sql, Conexao_DAL.Cad_Func());

                cm.Parameters.AddWithValue("@CPF", obj.CPF);


                SqlDataReader dados = cm.ExecuteReader();//serve para executar
                while (dados.Read())//executa o loop para encontrar os dados
                {
                    if (dados.HasRows)//Se ele encontrar ele executa esse código, se achar ele coloca em um vetor
                    {
                        return true;
                    }
                }
                return false;
            }

            catch (Exception xy)
            {
                throw new Exception(xy.Message);
            }
        }
        public static bool Validar_Cad_Prod(Prod_DTO obj)
        {
            try
            {
                string sql = "select * from TB_Produtos where nome = @nome";
                SqlCommand cm = new SqlCommand(sql, Conexao_DAL.Cad_Func());

                cm.Parameters.AddWithValue("@nome", obj.nome);


                SqlDataReader dados = cm.ExecuteReader();//serve para executar
                while (dados.Read())//executa o loop para encontrar os dados
                {
                    if (dados.HasRows)//Se ele encontrar ele executa esse código, se achar ele coloca em um vetor
                    {
                        return true;
                    }
                }
                return false;

            }

            catch (Exception xy)
            {
                throw new Exception(xy.Message);
            }

        }
    }
    
}

