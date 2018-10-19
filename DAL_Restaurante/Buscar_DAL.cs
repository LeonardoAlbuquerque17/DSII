using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using DAL_Restaurante;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Restaurante
{
    public class Buscar_DAL
    {
        public static CADASTRO_DTO Buscar(string CPF)
        {
            try
            {
                CADASTRO_DTO obj = new CADASTRO_DTO();
                string sql = "select * from tb_funcionarios where CPF = @CPF";
                SqlCommand com = new SqlCommand(sql, Conexao_DAL.Cad_Func());//é necessário colocar a string onde irá pesquisar no banco, e a classe de conexão da onde vem.
                com.Parameters.AddWithValue("@CPF",CPF);
                SqlDataReader execut = com.ExecuteReader();


                while (execut.Read())
                {
                    if (execut.HasRows)
                    {

                        obj.ID = int.Parse(execut["cod_funcionario"].ToString());
                        obj.nome = execut["nome"].ToString();
                        obj.CPF = execut["CPF"].ToString();
                        obj.RG = execut["RG"].ToString();
                        obj.cidade = execut["cidade"].ToString();
                        obj.estado = execut["estado"].ToString();
                        obj.bairro = execut["bairro"].ToString();
                        obj.endereco = execut["endereco"].ToString();
                        obj.conta = execut["conta"].ToString();
                        obj.banco = execut["banco"].ToString();
                        obj.telefone = execut["telefone"].ToString();
                        obj.agencia = execut["agencia"].ToString();
                        obj.numero = execut["numero"].ToString();
                        return obj;

                    }

                }
                throw new Exception("Não encontrado!");
            }

            catch (Exception xy)
            {

                throw new Exception(xy.Message);

            }
            /*public static List<CADASTRO_DTO> Buscar(CADASTRO_DTO obj)
            {
                try
                {
                    List<CADASTRO_DTO> valor = new List<CADASTRO_DTO>();
                    //CADASTRO_DTO obj = new CADASTRO_DTO();

                    string script = "select * from tb_funcionarios where CPF = @CPF";
                    SqlCommand com = new SqlCommand(script, Conexao_DAL.Cad_Func());
                    com.Parameters.AddWithValue("@CPF", obj.CPF);//passando o valor do obj.CPF para variável @CPF

                    SqlDataReader dados = com.ExecuteReader();
                    while (dados.Read())
                    {

                        valor.Add(obj);

                    }
                    return valor;
                }
                catch
                {
                    throw new Exception("Erro no primeiro catch");
                }

            }*/

            /*public DataTable buscar(String valor)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from table tb_funcionarios where CPF like '%" + valor + "%'", Conexao_DAL.Cad_Func());
                da.Fill(dt);//fill executa o comando do data adapter, e preenche o datatable com os valores da busca
                return dt;
            }*/


            /*

            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RESTAURANTE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select * from tb_funcionarios where CPF = @CPF";
            cmd.Parameters.AddWithValue("@CPF", obj.CPF);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();*/
        }
        public static Prod_DTO BuscarProd(string Nome)//Testar pela string recebida da bll
        {
            try
            {
                Prod_DTO produto = new Prod_DTO();
                string sql = "select * from TB_PRODUTOS where nome = @nome";
                SqlCommand com = new SqlCommand(sql, Conexao_DAL.PRODUTO());//é necessário colocar a string onde irá pesquisar no banco, e a classe de conexão da onde vem.
                com.Parameters.AddWithValue("@nome", Nome);
                SqlDataReader executar = com.ExecuteReader();
                while (executar.Read())
                {
                    if (executar.HasRows)
                    {

                        produto.nome = executar["nome"].ToString();
                        produto.preco = executar["preco"].ToString();
                        produto.tipo = executar["tipo"].ToString();
                        produto.unid_medida = executar["unid_medida"].ToString();
                        produto.estoque = executar["estoque"].ToString();
                        return produto;
                    }

                }
                throw new Exception("O produto não foi encontrado");
            
            }
            catch(Exception ex)
            {
                throw new Exception("Erro fora do Try " + ex.Message);
            }
            
        }   
    }
}
