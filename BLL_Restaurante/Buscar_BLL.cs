using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Restaurante;
using DTO_Restaurante;
namespace BLL_Restaurante
{
    public class Buscar_BLL
    {
        public CADASTRO_DTO Val_Busca(string CPF)// método que retorna cadastro_dto e tem como parâmetro string cpf
        {
            if (string.IsNullOrWhiteSpace(CPF))
            {
                throw new Exception ("CAMPO CPF EM BRANCO");
            }
            return Buscar_DAL.Buscar(CPF);
        }
        public Prod_DTO Validar_Busca_Produto(string Nome)
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("CAMPO NOME EM BRANCO");
            }
            return Buscar_DAL.BuscarProd(Nome);
        }
           
            

    }
}
