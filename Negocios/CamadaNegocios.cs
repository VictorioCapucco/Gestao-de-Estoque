using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Negocios
{
    public class CamadaNegocios
    {
        //Tipo Material
        public Boolean InserirTipoMaterial(string descricaoCompleta, string descricaoReduzida, Boolean statusTipoMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Tipo_Material (descricao_reduzida_tipo_material, descricao_tipo_material, status_tipo_material) values ('" + descricaoReduzida + "','" + descricaoCompleta + "'," + statusTipoMaterial + ')');

        }

        public DataTable DataTableTipoMaterial()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_tipo_material, descricao_reduzida_tipo_material from Tipo_Material where status_tipo_material = true", "Tipo_Material");
        }


        //Locais
        public Boolean InserirLocais(string descricaoLocal, string enderecoLocal, Boolean statusLocal, Boolean obra)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Locais (descricao_local, endereco_local, status_local, obra) values('" + descricaoLocal + "','" + enderecoLocal + "'," + statusLocal + "," + obra + ')');
        }

        public DataTable DataTableLocais(Boolean statusLocal, Boolean isObra, Boolean statusObra)
        {
            Conexao consulta = new Conexao();
            if (isObra == true)
                return consulta.RetornarDataTable("select id_local, descricao_local from Locais where status_local = " + statusLocal + " and obra = " + isObra + " and status_obra = " + statusObra, "Locais");
            else
                return consulta.RetornarDataTable("select id_local, descricao_local from Locais where status_local = " + statusLocal + " and obra = " + isObra, "Locais");
        }

        public Boolean ValidarObra(int codigoLocal)
        {
            Conexao atualizar = new Conexao();
            return atualizar.ExecutaNQ("update Locais set status_obra = true where id_local = " + codigoLocal);
        }


        //Usuarios
        public Boolean InserirUsuario(string nomeUsuario, int tipoUsuario, Boolean statusUsuario, string senhaUsuario)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Usuario (nome_usuario, tipo_usuario, status_usuario, senha_usuario) values('" + nomeUsuario + "'," + tipoUsuario + "," + statusUsuario + ",'" + senhaUsuario + "')");
        }

        public Boolean ExisteUsuario(string nomeUsuario)
        {
            Conexao consulta = new Conexao();
            return consulta.ExisteRegistro("select nome_usuario from Usuario where nome_usuario = '" + nomeUsuario + "'", "Usuario");
        }

        //Material
        public Boolean InserirMaterial(string nomeMaterial, Boolean statusMaterial, int idTipoMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Material (nome_material, status_material, id_tipo_material) values('" + nomeMaterial + "'," + statusMaterial + "," + idTipoMaterial + ")");
        }

        public Boolean ExisteMaterialLocal(int codigoMaterial, int codigoLocal)
        {
            Conexao consulta = new Conexao();
            return consulta.ExisteRegistro("select id_material from Quantidade_Material where id_material = " + codigoMaterial + " and id_local = " + codigoLocal, "Quantidade_Material");
        }


        public string ExisteMaterial(int codigoMaterial)
        {
            Conexao consulta = new Conexao();
            DataTable oDtMaterial = new DataTable();
            oDtMaterial = consulta.RetornarDataTable("select nome_material from Material where id_material = " + codigoMaterial, " Material");

            string nomeMaterial;

            if (oDtMaterial.Rows.Count > 0)
                nomeMaterial = oDtMaterial.Rows[0]["nome_material"].ToString();

            else
                nomeMaterial = "";

            return nomeMaterial;
        }


        //Transferencia
        public int InserirTransferencia(int codigoLocalOrigem, int codigoLocalDestino, int codigoTipoTransferencia, string dataTransferencia)
        {
            //Criando a requisição
            Conexao insercao = new Conexao();
            Boolean statusCriarTransferencia = insercao.ExecutaNQ("insert into Transferencia (id_local_origem, id_local_destino, data_transferencia, id_tipo_transferencia) values (" + codigoLocalOrigem + "," + codigoLocalDestino + ",'" + dataTransferencia + "'," + codigoTipoTransferencia + ")");

            if (statusCriarTransferencia == true)
            {
                try
                {
                    //Obtendo o id da transferência criada
                    DataTable oDtUltimaTransferencia = new DataTable();

                    oDtUltimaTransferencia = insercao.RetornarDataTable("select id_transferencia from Transferencia where id_transferencia = (select max (id_transferencia) from Transferencia)", "Transferencia");
                    int codigoTransferencia = int.Parse(oDtUltimaTransferencia.Rows[0]["id_transferencia"].ToString());

                    return codigoTransferencia;
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
        }

        public Boolean InserirMateriaisTransferenciaSaida(int codigoTransferencia, int codigoMaterial, int quantidadeMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Materiais_Transferencia (quantidade_material, id_material, id_transferencia) values (" + quantidadeMaterial + "," + codigoMaterial + "," + codigoTransferencia + ")");
        }

        public DataTable DataTableRequisicao(Boolean filtrarLocal, int codigoLocal, Boolean requisicaoValidada)
        {
            Conexao consulta = new Conexao();
            if (filtrarLocal == true)
                return consulta.RetornarDataTable("select id_requisicao from Requisicao where status_requisicao = " + requisicaoValidada + " and id_local = " + codigoLocal, "Requisicao");
            else
                return consulta.RetornarDataTable("select id_requisicao from Requisicao where status_requisicao = " + requisicaoValidada, "Requisicao");
        }


        public DataSet ConsultaCodigoMateriaisTransferencia(int codigoTransferencia)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataSet("select M.id_material as Material, MT.quantidade_material as Quantidade from Material as M inner join Materiais_Transferencia as MT on M.id_material = MT.id_material where MT.id_transferencia = " + codigoTransferencia);
        }

        public string ConsultaDataTransferencia(int codigoTransferencia)
        {
            Conexao consulta = new Conexao();
            DataTable oDtDataTransferencia = new DataTable();
            oDtDataTransferencia = consulta.RetornarDataTable("select data_transferencia from Transferencia where id_transferencia = " + codigoTransferencia, "Transferencia");

            if (oDtDataTransferencia.Rows.Count != 0)
            {
                return oDtDataTransferencia.Rows[0]["data_transferencia"].ToString();
            }

            else
                return "0";
        }

        public Boolean AlteraMateriaisTransferencia(int codigoMaterial, int codigoTransferencia, int quantidadeMaterial)
        {
            Conexao alterar = new Conexao();
            return alterar.ExecutaNQ("update Materiais_Transferencia set quantidade_material = " + quantidadeMaterial + " where id_material = " + codigoMaterial + " and id_transferencia = " + codigoTransferencia);
        }

        //Tipos de Transferencia
        public DataTable DataTableTipoTransferencia(Boolean statusTipoSaida, Boolean saida)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_tipo_transferencia, descricao_tipo_transferencia from Tipo_Transferencia where status_tipo_transferencia = " + statusTipoSaida + " and saida = " + saida , "Tipo_Transferencia");
        }

        public Boolean InserirTipoSaida(string descricaoTipoSaida, Boolean statusTipoSaida, Boolean saida)
        {
            Conexao insercao = new Conexao();
            //return insercao.ExecutaNQ("insert into Tipo_Saida (descricao_tipo_saida, status_tipo_saida) values('" + descricao_tipo_saida + "'," + status_tipo_saida + ")");
            return insercao.ExecutaNQ("insert into Tipo_Transferencia (descricao_tipo_transferencia, status_tipo_transferencia, saida) values('" + descricaoTipoSaida + "'," + statusTipoSaida + ", " + saida + ')');
        }


        //Materiais Transferencia
        public Boolean DiminuiEstoque(int codigoMaterial, int codigoLocal, int quantidadeMaterial)
        {
            Conexao atualizar = new Conexao();
            DataTable oDtEstoque = new DataTable();

            try
            {
                oDtEstoque = atualizar.RetornarDataTable("select * from Quantidade_Material where id_material = " + codigoMaterial + "and id_local = " + codigoLocal, "Quantidade_Material");
                int codigoQuantidadeMaterial;
                //Se não existir ainda, será registrado este material neste local
                if (oDtEstoque.Rows.Count == 0)
                {
                    atualizar.ExecutaNQ("insert into Quantidade_Material (quantidade_material, id_material, id_local) values(" + 0 + "," + codigoMaterial + "," + codigoLocal + ")");
                    //Pegando o id criado
                    DataTable oDtUltimoQuantidadeMaterial = new DataTable();
                    oDtUltimoQuantidadeMaterial = atualizar.RetornarDataTable("select id_quantidade_material from Quantidade_Material where id_quantidade_material = (select max (id_quantidade_material) from Quantidade_Material)", "Quantidade_Material");
                    codigoQuantidadeMaterial = int.Parse(oDtUltimoQuantidadeMaterial.Rows[0]["id_quantidade_material"].ToString());
                }

                //Se existir, deve-se pegar o código da quantidade_material
                else
                {
                    DataTable oDtCodigoQuantidadeMaterial = new DataTable();

                    oDtCodigoQuantidadeMaterial = atualizar.RetornarDataTable("select id_quantidade_material from Quantidade_Material where id_material = " + codigoMaterial + " and id_local = " + codigoLocal, "Quantidade_Material");
                    codigoQuantidadeMaterial = int.Parse(oDtCodigoQuantidadeMaterial.Rows[0]["id_quantidade_material"].ToString());
                }

                //Atualizando a quantidade do material
                atualizar.ExecutaNQ("update Quantidade_Material set quantidade_material = quantidade_material - " + quantidadeMaterial + " where id_quantidade_material = " + codigoQuantidadeMaterial);

                return true;
            }

            catch
            {
                return false;
            }
        }

        public Boolean AumentaEstoque(int codigoMaterial, int codigoLocal, int quantidadeMaterial)
        {
            Conexao atualizar = new Conexao();
            DataTable oDtEstoque = new DataTable();

            try
            {
                oDtEstoque = atualizar.RetornarDataTable("select * from Quantidade_Material where id_material = " + codigoMaterial + "and id_local = " + codigoLocal, "Quantidade_Material");
                int codigoQuantidadeMaterial;
                //Se não existir ainda, será registrado este material neste local
                if (oDtEstoque.Rows.Count == 0)
                {
                    atualizar.ExecutaNQ("insert into Quantidade_Material (quantidade_material, id_material, id_local) values(" + 0 + "," + codigoMaterial + "," + codigoLocal + ")");
                    //Pegando o id criado
                    DataTable oDtUltimoQuantidadeMaterial = new DataTable();
                    oDtUltimoQuantidadeMaterial = atualizar.RetornarDataTable("select id_quantidade_material from Quantidade_Material where id_quantidade_material = (select max (id_quantidade_material) from Quantidade_Material)", "Quantidade_Material");
                    codigoQuantidadeMaterial = int.Parse(oDtUltimoQuantidadeMaterial.Rows[0]["id_quantidade_material"].ToString());
                }

                //Se existir, deve-se pegar o código da quantidade_material
                else
                {
                    DataTable oDtCodigoQuantidadeMaterial = new DataTable();

                    oDtCodigoQuantidadeMaterial = atualizar.RetornarDataTable("select id_quantidade_material from Quantidade_Material where id_material = " + codigoMaterial + " and id_local = " + codigoLocal, "Quantidade_Material");
                    codigoQuantidadeMaterial = int.Parse(oDtCodigoQuantidadeMaterial.Rows[0]["id_quantidade_material"].ToString());
                }

                //Atualizando a quantidade do material
                atualizar.ExecutaNQ("update Quantidade_Material set quantidade_material = quantidade_material + " + quantidadeMaterial + " where id_quantidade_material = " + codigoQuantidadeMaterial);

                return true;
            }

            catch
            {
                return false;
            }
        }

        public DataTable DataTableMateriaisTransferencia(int codigoLocal)
        {
            Conexao consulta = new Conexao();

            //Obtendo o código da transferencia
            DataTable oDtTransferencia = new DataTable();
            oDtTransferencia = consulta.RetornarDataTable("select T.id_transferencia as Codigo, L.id_local from Transferencia as T inner join Locais as L on T.id_local_destino = L.id_local where T.id_local_destino = " + codigoLocal, "Transferencia");

            int codigoTransferencia = int.Parse(oDtTransferencia.Rows[0]["Codigo"].ToString());

            //Obtendo os materiais da transferencia
            return consulta.RetornarDataTable("select MT.id_transferencia as CodigoTransferencia, M.id_material as Codigo, M.nome_material as Nome, MT.quantidade_material as Quantidade from Material as M " +
                                                "inner join Materiais_Transferencia as MT on M.id_material = MT.id_material " +
                                                "where MT.id_transferencia = " + codigoTransferencia + " order by M.id_material asc", "Materiais_Transferencia");
        }
    }
}
