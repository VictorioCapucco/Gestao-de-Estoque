using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GestaoEstoque
{
    class Criptografia
    {
        public string Senha(string senha)
        {
            MD5 md5Hash = MD5.Create();
            // Converter string para array
            byte[] dados = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            // Montar a string
            StringBuilder sBuilder = new StringBuilder();

            // Formatando byte a byte
            for (int i = 0; i < dados.Length; i++)
            {
                sBuilder.Append(dados[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
