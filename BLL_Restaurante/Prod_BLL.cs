using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Restaurante;
using DTO_Restaurante;
namespace BLL_Restaurante
{
    public class Prod_BLL
    {
        public static string CadProd(Prod_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                return "Campo nome Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.tipo))
            {
                return "Campo tipo Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.estoque))
            {
                return "Campo estoque Vazio";
            }

            if (string.IsNullOrWhiteSpace(obj.preco))
            {
                return "Campo preço Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.unid_medida))
            {
                return "Campo unidade de medida Vazio";
            }
            try
            {
                double.Parse(obj.preco);
            }
            catch
            {
                return "O preço deve conter apenas números";
            }
            try
            {
                double.Parse(obj.estoque);
            }
            catch
            {
                return "O estoque deve conter apenas números";
            }
            bool testaprod = CONFIRMAR_CADASTRO.Validar_Cad_Prod(obj);
            if (testaprod == true)
            {
                return "Produto já cadastrado!";
            }
            return Prod_DAL.Cad_Prod(obj);
            //return "Sucesso!!";

            /*if (obj.Senha != confsenha)
            {
                throw new Exception("Senhas Diferentes!!");
            }*/


        }
        public static string Alterar_prod(Prod_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                return "Campo nome Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.tipo))
            {
                return "Campo tipo Vazio";

            }

            if (string.IsNullOrWhiteSpace(obj.unid_medida))
            {
                return "Campo unidade de medida Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.preco))
            {
                return "Campo preço Vazio";
            } try//o try está servindo para tentar capturar uma  excessão caso a conversão não seja relizada com sucesso
            {
                double.Parse(obj.preco);//convertendo o objeto número para inteiro, já que na declaração do objeto é string
            }
            catch
            {
                return "O campo numero deve conter UM NÚMERO!";
            }
            try//o try está servindo para tentar capturar uma  excessão caso a conversão não seja relizada com sucesso
            {
                int.Parse(obj.estoque);//convertendo o objeto número para inteiro, já que na declaração do objeto é string
            }
            catch
            {
                return "O campo numero deve conter UM NÚMERO!";
            }
            return Prod_DAL.alterar(obj);
        }
    }
}
