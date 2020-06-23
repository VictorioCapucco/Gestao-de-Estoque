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

        public Boolean Cnpj(string documento)
        {
            if (documento.Length != 14)
                return false;
            try
            {
                //Validando primeiro dígito do CNPJ
                string sa = "", sb = "", sc = "", sd = "", se = "", sf = "", sg = "", sh = "", si = "", sj = "", sk = "", sl = "", sm = "", sn = "";

                sa += documento[0];
                sb += documento[1];
                sc += documento[2];
                sd += documento[3];
                se += documento[4];
                sf += documento[5];
                sg += documento[6];
                sh += documento[7];
                si += documento[8];
                sj += documento[9];
                sk += documento[10];
                sl += documento[11];
                sm += documento[12];
                sn += documento[13];

                int saint = int.Parse(sa);
                int sbint = int.Parse(sb);
                int scint = int.Parse(sc);
                int sdint = int.Parse(sd);
                int seint = int.Parse(se);
                int sfint = int.Parse(sf);
                int sgint = int.Parse(sg);
                int shint = int.Parse(sh);
                int siint = int.Parse(si);
                int sjint = int.Parse(sj);
                int skint = int.Parse(sk);
                int slint = int.Parse(sl);
                int smint = int.Parse(sm);
                int snint = int.Parse(sn);


                saint = saint * 5;
                sbint = sbint * 4;
                scint = scint * 3;
                sdint = sdint * 2;
                seint = seint * 9;
                sfint = sfint * 8;
                sgint = sgint * 7;
                shint = shint * 6;
                siint = siint * 5;
                sjint = sjint * 4;
                skint = skint * 3;
                slint = slint * 2;

                int soma;

                soma = saint + sbint + scint + sdint + seint + sfint + sgint + shint + siint + sjint + skint + slint;
                int resto = soma % 11;

                if (resto == 0 || resto == 1)
                {
                    if (int.Parse(sm) != 0 && int.Parse(sm) != 1)
                    {
                        return false;
                    }
                    //Caso contrário continua
                }

                else
                {
                    if (int.Parse(sm) != (11 - resto))
                    {
                        return false;
                    }
                    //Caso contrário continua
                }

                //Validando segundo dígito do CNPJ
                saint = int.Parse(sa);
                sbint = int.Parse(sb);
                scint = int.Parse(sc);
                sdint = int.Parse(sd);
                seint = int.Parse(se);
                sfint = int.Parse(sf);
                sgint = int.Parse(sg);
                shint = int.Parse(sh);
                siint = int.Parse(si);
                sjint = int.Parse(sj);
                skint = int.Parse(sk);
                slint = int.Parse(sl);
                smint = int.Parse(sm);
                snint = int.Parse(sn);

                saint = saint * 6;
                sbint = sbint * 5;
                scint = scint * 4;
                sdint = sdint * 3;
                seint = seint * 2;
                sfint = sfint * 9;
                sgint = sgint * 8;
                shint = shint * 7;
                siint = siint * 6;
                sjint = sjint * 5;
                skint = skint * 4;
                slint = slint * 3;
                smint = smint * 2;

                soma = saint + sbint + scint + sdint + seint + sfint + sgint + shint + siint + sjint + skint + slint + smint;

                resto = soma % 11;

                if (resto == 1 || resto == 0)
                {
                    if (int.Parse(sn) != 0 && int.Parse(sn) != 1)
                    {
                        return false;
                    }
                    //Caso contrário continua
                }

                else
                {
                    if (int.Parse(sn) != (11 - resto))
                    {
                        return false;
                    }
                    //Caso contrário continua
                }

                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
