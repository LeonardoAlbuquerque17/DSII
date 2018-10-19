using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Restaurante;
using DTO_Restaurante;

namespace BLL_Restaurante
{
    public class CADASTRO_BLL
    {
        public static string Val_Cad_Func(CADASTRO_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                return "Campo nome Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                return "Campo CPF Vazio";

            }

            if (string.IsNullOrWhiteSpace(obj.RG))
            {
                return "Campo RG Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.endereco))
            {
                return "Campo endereço Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.conta))
            {
                return "Campo conta Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.agencia))
            {
                return "Campo agencia Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.banco))
            {
                return "Campo banco Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.cidade))
            {
                return "Campo cidade Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.bairro))
            {
                return "Campo bairro Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.estado))
            {
                return "Campo estado Vazio";
            }
            try//o try está servindo para tentar capturar uma  excessão caso a conversão não seja relizada com sucesso
            {
                int.Parse(obj.numero);//convertendo o objeto número para inteiro, já que na declaração do objeto é string
            }
            catch
            {
                return "O campo numero deve conter UM NÚMERO!";
            }
            if (string.IsNullOrWhiteSpace(obj.telefone))
            {
                return "Campo telefone Vazio";
            }
            bool testaCPF = CONFIRMAR_CADASTRO.Validar_CADASTRO(obj);
            if (testaCPF == true)
            {
                return "Funcionário já cadastrado!";
            }
            return CADASTRO_DAL.val_cad_func(obj);
            
        }
        public static string Alterar(CADASTRO_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                return "Campo nome Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                return "Campo CPF Vazio";

            }

            if (string.IsNullOrWhiteSpace(obj.RG))
            {
                return "Campo RG Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.endereco))
            {
                return "Campo endereço Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.conta))
            {
                return "Campo conta Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.agencia))
            {
                return "Campo agencia Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.banco))
            {
                return "Campo banco Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.cidade))
            {
                return "Campo cidade Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.bairro))
            {
                return "Campo bairro Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.estado))
            {
                return "Campo estado Vazio";
            }
            try//o try está servindo para tentar capturar uma  excessão caso a conversão não seja relizada com sucesso
            {
                int.Parse(obj.numero);//convertendo o objeto número para inteiro, já que na declaração do objeto é string
            }
            catch
            {
                return "O campo numero deve conter UM NÚMERO!";
            }
            if (string.IsNullOrWhiteSpace(obj.telefone))
            {
                return "Campo telefone Vazio";
            }
            return CADASTRO_DAL.alterar(obj);
        }
       
    }
}
