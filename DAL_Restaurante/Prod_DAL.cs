using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Restaurante;

namespace DAL_Restaurante
{
    public class Prod_DAL
    {
        public static string Cad_Prod(Prod_DTO obj)
        {
            try
            {
                string sql = "insert into TB_PRODUTOS(preco, nome, tipo, unid_medida, estoque) values(@preco, @nome,@tipo,@unid_medida, @estoque)";
                SqlCommand cm = new SqlCommand(sql, Conexao_DAL.PRODUTO());

                cm.Parameters.AddWithValue("@nome", obj.nome);
                cm.Parameters.AddWithValue("@tipo", obj.tipo);
                cm.Parameters.AddWithValue("@estoque", obj.estoque);
                cm.Parameters.AddWithValue("@unid_medida", obj.unid_medida);
                cm.Parameters.AddWithValue("@preco", obj.preco);
                SqlDataReader dados = cm.ExecuteReader();
                while (dados.Read())
                {
                    if (dados.HasRows)//Se ele encontrar ele executa esse código, se achar ele coloca em um vetor
                    {
                        return "Poduto já encontrado";
                    }
                }
                return "Produto cadastrado!";
            }

            catch (Exception xy)
            {
                return (xy.Message);
            }
        }
        public static string alterar(Prod_DTO produto)
        {
            try
            {
                string sql = "UPDATE tb_produtos SET nome=@nome, tipo=@tipo, unid_medida=@unid_medida, preco=@preco, estoque=@estoque";
                SqlCommand cm = new SqlCommand(sql, Conexao_DAL.PRODUTO());
                cm.Parameters.AddWithValue("@nome", produto.nome);
                cm.Parameters.AddWithValue("@tipo", produto.tipo);
                cm.Parameters.AddWithValue("@unid_medida", produto.unid_medida);
                cm.Parameters.AddWithValue("@preco", double.Parse(produto.preco));
                cm.Parameters.AddWithValue("@estoque", int.Parse(produto.estoque));
                cm.ExecuteNonQuery();
                return "Sucesso!";
            }
            catch (Exception ex)
            {
                return "ESSE ERRO AQUI" + ex.Message;
            }
        }
    }
}
