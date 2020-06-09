using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEstoque
{
    class Validacao
    {
        public Boolean Textos(string texto)
        {
            try
            {
                texto = texto.Trim();

                if (string.IsNullOrEmpty(texto))
                    return false;

                //Verificando se há caracteres especiais
                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i] == '"' || texto[i] == '/' || texto[i] == '/')
                        return false;
                }

                if (texto.Contains("'"))
                    return false;

                else
                    return true;
            }

            catch
            {
                return false;
            }
            
        }

        public Boolean Senha(string senha, string confirmarSenha)
        {
            if (senha == confirmarSenha)
                return true;
            else
                return false;
        }

        public int IsNumero(string texto)
        {
            try
            {
                int numero = int.Parse(texto);

                return numero;
            }

            catch
            {
                return 0;
            }
        }
    }
}
