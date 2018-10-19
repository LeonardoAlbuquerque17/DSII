using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using System.Data;
using System.Data.SqlClient;
using DAL_Restaurante;

namespace DAL_Restaurante
{
    public class CADASTRO_DAL
    {
        public static string val_cad_func(CADASTRO_DTO obj)
        {
            try
            {
                string sql = "insert into tb_funcionarios(nome, CPF, RG, endereco, agencia, conta, banco, numero, cidade, bairro, estado, telefone) values(@nome, @CPF, @RG, @endereco, @agencia, @conta, @banco, @numero, @cidade, @bairro, @estado, @telefone)";
                SqlCommand cm = new SqlCommand(sql, Conexao_DAL.Cad_Func());
                cm.Parameters.AddWithValue("@nome", obj.nome);
                cm.Parameters.AddWithValue("@CPF", obj.CPF);
                cm.Parameters.AddWithValue("@RG", obj.RG);
                cm.Parameters.AddWithValue("@endereco", obj.endereco);
                cm.Parameters.AddWithValue("@agencia", obj.agencia);
                cm.Parameters.AddWithValue("@conta", obj.conta);
                cm.Parameters.AddWithValue("@banco", obj.banco);
                cm.Parameters.AddWithValue("@numero", obj.numero);
                cm.Parameters.AddWithValue("@cidade", obj.cidade);
                cm.Parameters.AddWithValue("@bairro", obj.bairro);
                cm.Parameters.AddWithValue("@estado", obj.estado);
                cm.Parameters.AddWithValue("@telefone", obj.telefone);
                SqlDataReader dados = cm.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt = sql();
                return "Sucesso!";
            }
            catch(Exception exe)
            {
                return ("ERRO Ao cadastrar" + exe.Message);
            }
            finally
            {
                if (Conexao_DAL.Login().State != ConnectionState.Closed)
                {
                    Conexao_DAL.Login().Close();
                }
            }
        }
        public static string alterar(CADASTRO_DTO obj)
        {
            try
            {
            string sql = "UPDATE tb_funcionarios SET nome=@nome, CPF=@CPF, RG=@RG, endereco=@endereco, agencia=@agencia, conta=@conta, banco=@banco, numero=@numero, cidade=@cidade, bairro = @bairro, estado=@estado, telefone=@telefone";
            SqlCommand cm = new SqlCommand(sql, Conexao_DAL.Cad_Func());
            cm.Parameters.AddWithValue("@nome", obj.nome);
            cm.Parameters.AddWithValue("@CPF", obj.CPF);
            cm.Parameters.AddWithValue("@RG", obj.RG);
            cm.Parameters.AddWithValue("@endereco", obj.endereco);
            cm.Parameters.AddWithValue("@agencia", obj.agencia);
            cm.Parameters.AddWithValue("@conta", obj.conta);
            cm.Parameters.AddWithValue("@banco", obj.banco);
            cm.Parameters.AddWithValue("@numero", obj.numero);
            cm.Parameters.AddWithValue("@cidade", obj.cidade);
            cm.Parameters.AddWithValue("@bairro", obj.bairro);
            cm.Parameters.AddWithValue("@estado", obj.estado);
            cm.Parameters.AddWithValue("@telefone", obj.telefone);
            cm.ExecuteNonQuery();
            return "Alterado com sucesso!";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
        
    
}
