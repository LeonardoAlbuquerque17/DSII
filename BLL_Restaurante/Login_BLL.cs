using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Restaurante;
using DTO_Restaurante;

namespace BLL_Restaurante
{
    public class Login_BLL
    {
        public static string ValidarLogin (Login_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Usuario))
            {
                return "Campo usuário Vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                return "Campo senha Vazio";
            }
            return Login_DAL.Validar_Login(obj);
            //return "Sucesso!!";
            
            /*if (obj.Senha != confsenha)
            {
                throw new Exception("Senhas Diferentes!!");
            }*/
        }
        
    }
}
