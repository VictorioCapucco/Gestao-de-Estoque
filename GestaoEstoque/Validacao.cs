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

        public string AjustarData(string data)
        {
            try
            {
                data = data.Substring(0, 10);
                return data;
            }

            catch
            {
                return "0";
            }
            
        }

        public Boolean DataMenorDataMaior(string dataMenor, string dataMaior)
        {
            try
            {
                var arrayMenor = dataMenor.Split('/');
                int diaMenor = int.Parse(arrayMenor[0]);
                int mesMenor = int.Parse(arrayMenor[1]);
                int anoMenor = int.Parse(arrayMenor[2]);

                var arrayMaior = dataMaior.Split('/');
                int diaMaior = int.Parse(arrayMaior[0]);
                int mesMaior = int.Parse(arrayMaior[1]);
                int anoMaior = int.Parse(arrayMaior[2]);


                DateTime dataInicial = new DateTime(anoMenor, mesMenor, diaMenor);
                DateTime dataFinal = new DateTime(anoMaior, mesMaior, diaMaior);

                int resultado = DateTime.Compare(dataInicial, dataFinal);

                if (resultado <= 0)
                    return true;
                else
                    return false;
            }

            catch
            {
                return false;
            }
        }

        public Boolean Data(string data)
        {
            var array = data.Split('/');

            //Validando dia
            try
            {
                if (int.Parse(array[0]) > 31)
                    return false;
                else if (int.Parse(array[1]) > 12)
                    return false;
                else if (int.Parse(array[2]) > 9999 || int.Parse(array[2]) < 0)
                    return false;
                else if (array[0].Length != 2)
                    return false;
                else if (array[1].Length != 2)
                    return false;
                else if (array[2].Length != 4)
                    return false;
                else
                    return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
