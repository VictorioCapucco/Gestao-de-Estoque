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

        public string ExisteLocal(int codigoLocal)
        {
            Conexao consulta = new Conexao();
            DataTable oDtLocal = new DataTable();
            oDtLocal = consulta.RetornarDataTable("select descricao_local from Locais where id_local = " + codigoLocal + " and obra = false and status_local = true", " Locais");

            string nomeLocal;

            if (oDtLocal.Rows.Count > 0)
                nomeLocal = oDtLocal.Rows[0]["descricao_local"].ToString();

            else
                nomeLocal = "";

            return nomeLocal;
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

        public DataTable DataTableUsuario()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_usuario, nome_usuario, tipo_usuario, status_usuario from Usuario", "Usuario");
        }

        public Boolean AlterarUsuario(int codigoUsuario, string nomeUsuario, int tipoUsuario, string senhaUsuario, Boolean statusUsuario)
        {
            Conexao alteracao = new Conexao();

            string stringStatusUsuario = statusUsuario.ToString();

            if (senhaUsuario == "")
                return alteracao.ExecutaNQ("update Usuario set nome_usuario = '" + nomeUsuario + "', tipo_usuario = " + tipoUsuario + ", status_usuario = " + stringStatusUsuario + " where id_usuario = " + codigoUsuario);
            else
                return alteracao.ExecutaNQ("update Usuario set nome_usuario = '" + nomeUsuario + "', tipo_usuario = " + tipoUsuario + ", status_usuario = " + stringStatusUsuario + ", senha_usuario = '" + senhaUsuario + "' where id_usuario = " + codigoUsuario);
        }


        //Material
        public int InserirMaterial(string nomeMaterial, Boolean statusMaterial, int codigoTipoMaterial, int codigoUnidade)
        {
            Conexao insercao = new Conexao();
            Boolean statusInserirMaterial = insercao.ExecutaNQ("insert into Material (nome_material, status_material, id_tipo_material, id_unidade) values('" + nomeMaterial + "'," + statusMaterial + "," + codigoTipoMaterial + "," + codigoUnidade + ")");

            if (statusInserirMaterial == true)
            {
                try
                {
                    //Obtendo o id do ultimo material criado
                    DataTable oDtUltimoMaterial = new DataTable();

                    oDtUltimoMaterial = insercao.RetornarDataTable("select id_material from Material where id_material = (select max (id_material) from Material)", "Material");
                    int codigoMaterial = int.Parse(oDtUltimoMaterial.Rows[0]["id_material"].ToString());

                    return codigoMaterial;
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
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
            oDtMaterial = consulta.RetornarDataTable("select nome_material from Material where id_material = " + codigoMaterial + " and status_material = true" , " Material");

            string nomeMaterial;

            if (oDtMaterial.Rows.Count > 0)
                nomeMaterial = oDtMaterial.Rows[0]["nome_material"].ToString();

            else
                nomeMaterial = "";

            return nomeMaterial;
        }

        public Boolean InserirMaterialLocal(int codigoMaterial, int codigoLocal)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Quantidade_Material (quantidade_material, id_material, id_local) values (0," + codigoMaterial + "," + codigoLocal + ")");
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

        public Boolean InserirTipoTransferencia(string descricaoTipoSaida, Boolean statusTipoSaida, Boolean saida)
        {
            Conexao insercao = new Conexao();
            //return insercao.ExecutaNQ("insert into Tipo_Saida (descricao_tipo_saida, status_tipo_saida) values('" + descricao_tipo_saida + "'," + status_tipo_saida + ")");
            return insercao.ExecutaNQ("insert into Tipo_Transferencia (descricao_tipo_transferencia, status_tipo_transferencia, saida) values('" + descricaoTipoSaida + "'," + statusTipoSaida + ", " + saida + ')');
        }

        public DataTable DataTableTipoTransferencia()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_tipo_transferencia, descricao_tipo_transferencia, status_tipo_transferencia from Tipo_Transferencia", "Tipo_Transferencia");
        }

        public Boolean AlterarTipoTransferencia(int codigoTipoTransferencia, string descricaoTipoTransferencia, Boolean statusTipoTransferencia)
        {
            Conexao alteracao = new Conexao();

            if (statusTipoTransferencia == true)
                return alteracao.ExecutaNQ("update Tipo_Transferencia set descricao_tipo_transferencia = '" + descricaoTipoTransferencia + "', status_tipo_transferencia = true where id_tipo_transferencia = " + codigoTipoTransferencia);
            else
                return alteracao.ExecutaNQ("update Tipo_Transferencia set descricao_tipo_transferencia = '" + descricaoTipoTransferencia + "', status_tipo_transferencia = false where id_tipo_transferencia = " + codigoTipoTransferencia);
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

        //Fornecedor
        public int InserirFornecedor(string nomeFornecedor, string cnpjFornecedor, string telefoneFornecedor, string enderecoFornecedor)
        {
            Conexao insercao = new Conexao();
            Boolean statusCriarFornecedor = insercao.ExecutaNQ("insert into Fornecedor (nome_for, cnpj_for, telefone_for, endereco_for, status_for) values ('" + nomeFornecedor + "','" + cnpjFornecedor + "','" + telefoneFornecedor + "','" + enderecoFornecedor + "',true)");
            if (statusCriarFornecedor == true)
            {
                try
                {
                    //Obtendo o id da transferência criada
                    DataTable oDtUltimoFornecedor = new DataTable();

                    oDtUltimoFornecedor = insercao.RetornarDataTable("select id_for from Fornecedor where id_for = (select max (id_for) from Fornecedor)", "Fornecedor");
                    int codigoFornecedor = int.Parse(oDtUltimoFornecedor.Rows[0]["id_for"].ToString());

                    return codigoFornecedor;
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
        }

        public Boolean InserirMateriaisFornecedor(int codigoFornecedor, int codigoMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Materiais_Fornecedor (id_for, id_material) values (" + codigoFornecedor + "," + codigoMaterial + ")");
        }

        public DataTable DataTableFornecedor(Boolean statusFornecedor)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_for, nome_for from Fornecedor where status_for = " + statusFornecedor, "Fornecedor");
        }

        public Boolean ExisteMaterialFornecedor(int codigoFornecedor, int codigoMaterial)
        {
            Conexao consulta = new Conexao();
            return consulta.ExisteRegistro("select id_material_fornecedor from Materiais_Fornecedor where id_for = " + codigoFornecedor + " and id_material = " + codigoMaterial, "Materiais_Fornecedor");
        }

        //Pedido Compra
        public int InserirPedidoCompra(int codigoFornecedor, int codigoLocal)
        {
            //Criando a requisição
            Conexao insercao = new Conexao();
            Boolean statusCriarPedidoCompra = insercao.ExecutaNQ("insert into Pedido_Compra (status_pedido_compra, id_fornecedor, id_local) values (false," + codigoFornecedor + "," + codigoLocal + ")");

            if (statusCriarPedidoCompra == true)
            {
                try
                {
                    //Obtendo o id da transferência criada
                    DataTable oDtUltimoPedidoCompra = new DataTable();

                    oDtUltimoPedidoCompra = insercao.RetornarDataTable("select id_pedido_compra from Pedido_Compra where id_pedido_compra = (select max (id_pedido_compra) from Pedido_Compra)", "Pedido_Compra");
                    int codigoPedidoCompra = int.Parse(oDtUltimoPedidoCompra.Rows[0]["id_pedido_compra"].ToString());

                    return codigoPedidoCompra;
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
        }

        public Boolean InserirMateriaisPedidoCompra(int codigoPedidoCompra, int codigoMaterial, int quantidadeMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Materiais_PedidoCompra (quantidade_material, id_material, id_pedido_compra) values (" + quantidadeMaterial + "," + codigoMaterial + "," + codigoPedidoCompra + ")");
        }

        public DataTable DataTablePedidoCompra(Boolean statusPedidoCompra, int codigoLocal)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select PC.id_pedido_compra as Codigo, F.nome_for as Fornecedor from Pedido_Compra as PC inner join Fornecedor as F on PC.id_fornecedor = F.id_for where PC.status_pedido_compra = " + statusPedidoCompra + " and PC.id_local = " + codigoLocal, "Pedido_Compra");
        }

        public DataTable DataTableMateriaisPedidoCompra(int codigoPedidoCompra)
        {
            Conexao consulta = new Conexao();

            return consulta.RetornarDataTable("select MPC.id_material as Codigo, M.nome_material as Nome, MPC.quantidade_material as Quantidade " +
                                              "from Materiais_PedidoCompra as MPC " +
                                              "inner join Material as M on MPC.id_material = M.id_material " +
                                              "where MPC.id_pedido_compra = " + codigoPedidoCompra +
                                              " order by MPC.id_material asc", "Materiais_PedidoCompra");
        }

        public Boolean AtualizarPedidoCopmra(int codigoPedidoCompra)
        {
            Conexao atualizacao = new Conexao();
            return atualizacao.ExecutaNQ("update Pedido_Compra set status_pedido_compra = true where id_pedido_compra = " + codigoPedidoCompra);
        }


        //Unidade de Medida
        public Boolean InserirUnidadeMedida(string descricaoUnidade, string siglaUnidade)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Unidade_Medida (descricao_unidade, sigla_unidade, status_unidade) values ('" + descricaoUnidade + "','" + siglaUnidade + "',true)");
        }

        public DataTable DataTableUnidade(Boolean filtroStatus)
        {
            Conexao consulta = new Conexao();
            if (filtroStatus == true)
                return consulta.RetornarDataTable("select id_unidade, descricao_unidade from Unidade_Medida where status_unidade = true", "Unidade_Medida");
            else
                return consulta.RetornarDataTable("select id_unidade, descricao_unidade, sigla_unidade, status_unidade from Unidade_Medida", "Unidade_Medida");
        }

        public Boolean AlterarUnidadeMedida(int codigoUnidade, string descricaoUnidade, string siglaUnidade, Boolean statusUnidade)
        {
            Conexao alteracao = new Conexao();

            if (statusUnidade == true)
                return alteracao.ExecutaNQ("update Unidade_Medida set descricao_unidade = '" + descricaoUnidade + "', sigla_unidade = '" + siglaUnidade + "', status_unidade = true where id_unidade = " + codigoUnidade);
            else
                return alteracao.ExecutaNQ("update Unidade_Medida set descricao_unidade = '" + descricaoUnidade + "', sigla_unidade = '" + siglaUnidade + "', status_unidade = false where id_unidade = " + codigoUnidade);
        }
    }
}
