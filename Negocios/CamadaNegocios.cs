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

        public DataTable DataTableTipoMaterial(Boolean filtraCodigo, Boolean filtraStatus, int codigoTipoMaterial)
        {
            Conexao consulta = new Conexao();
            if (filtraCodigo == true)
                return consulta.RetornarDataTable("select * from Tipo_Material where id_tipo_material = " + codigoTipoMaterial, "Tipo_Material");
            else
            {
                if (filtraStatus == true)
                    return consulta.RetornarDataTable("select id_tipo_material, descricao_reduzida_tipo_material from Tipo_Material where status_tipo_material = true", "Tipo_Material");
                else
                    return consulta.RetornarDataTable("select id_tipo_material, descricao_reduzida_tipo_material from Tipo_Material", "Tipo_Material");
            }
        }

        public Boolean AlterarTipoMaterial(int codigoTipoMaterial, string descricaoReduzida, string descricao, Boolean statusTipoMaterial)
        {
            Conexao alteracao = new Conexao();
            string stringStatusTipoMaterial = statusTipoMaterial.ToString();

            return alteracao.ExecutaNQ("update Tipo_Material set descricao_reduzida_tipo_material = '" + descricaoReduzida + "', descricao_tipo_material = '" + descricao + "', status_tipo_material = " + stringStatusTipoMaterial + " where id_tipo_material = " + codigoTipoMaterial);
        }



        //Locais
        public Boolean InserirLocais(string descricaoLocal, string enderecoLocal, Boolean statusLocal, Boolean obra)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Locais (descricao_local, endereco_local, status_local, obra) values('" + descricaoLocal + "','" + enderecoLocal + "'," + statusLocal + "," + obra + ')');
        }

        public DataTable DataTableLocais(Boolean filtraLocal, Boolean statusLocal, Boolean isObra, Boolean statusObra, int codigoLocal)
        {
            Conexao consulta = new Conexao();
            if (isObra == true)
                return consulta.RetornarDataTable("select id_local, descricao_local from Locais where status_local = " + statusLocal + " and obra = " + isObra + " and status_obra = " + statusObra, "Locais");
            else
            {
                if (filtraLocal == false)
                    return consulta.RetornarDataTable("select id_local, descricao_local from Locais where status_local = " + statusLocal + " and obra = " + isObra, "Locais");
                else
                    return consulta.RetornarDataTable("select * from Locais where id_local = " + codigoLocal + " and obra = false", "Locais");
            }
        }

        public DataTable DataTableTodosLocais()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_local, descricao_local from Locais", "Locais");
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

        public string DescricaoLocal(int codigoLocal)
        {
            Conexao consulta = new Conexao();
            DataTable oDtLocal = new DataTable();
            oDtLocal = consulta.RetornarDataTable("select descricao_local from Locais where id_local = " + codigoLocal, "Locais");

            if (oDtLocal.Rows.Count > 0)
            {
                string descricaoLocal = oDtLocal.Rows[0]["descricao_local"].ToString();

                return descricaoLocal;
            }

            else
                return "";
        }

        public DataTable BuscaLocais(string descricaoBusca)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_local, descricao_local, endereco_local from Locais where descricao_local like '%" + descricaoBusca + "%' and obra = false", "Locais");
        }

        public Boolean AlterarLocal(int codigoLocal, string descricaoLocal, string enderecoLocal, Boolean statusLocal)
        {
            Conexao alteracao = new Conexao();
            string stringStatusLocal = statusLocal.ToString();
            return alteracao.ExecutaNQ("update Locais set descricao_local = '" + descricaoLocal + "', endereco_local = '" + enderecoLocal + "', status_local = " + stringStatusLocal + " where id_local = " + codigoLocal);
        }

        //Usuarios
        public int InserirUsuario(string nomeUsuario, int tipoUsuario, Boolean statusUsuario, string senhaUsuario)
        {
            Conexao insercao = new Conexao();
            Boolean statusInsercao = insercao.ExecutaNQ("insert into Usuario (nome_usuario, tipo_usuario, status_usuario, senha_usuario) values('" + nomeUsuario + "'," + tipoUsuario + "," + statusUsuario + ",'" + senhaUsuario + "')");

            if (statusInsercao == true)
            {
                DataTable oDtUsuario = new DataTable();
                oDtUsuario = insercao.RetornarDataTable("select id_usuario from Usuario where id_usuario = (select max(id_usuario) from Usuario)", "Usuario");
                return int.Parse(oDtUsuario.Rows[0]["id_usuario"].ToString());
            }

            else
                return 0;
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

        public DataTable DataTableMaterial()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select * from Material order by id_material asc", "Material");
        }

        public DataTable DataTableMaterialLocais(int codigoMaterial)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select L.id_local as Codigo, L.descricao_local as Descricao, QM.id_material from Locais as L inner join Quantidade_Material as QM on L.id_local = QM.id_local where QM.id_material = " + codigoMaterial + " and L.obra = false", "Locais");
        }

        public Boolean AlterarMaterial(int codigoMaterial, Boolean statusMaterial, int codigoTipoMaterial, int codigoUnidade)
        {
            Conexao alteracao = new Conexao();
            string stringStatusMaterial = statusMaterial.ToString();

            return alteracao.ExecutaNQ("update Material set status_material = " + statusMaterial + ", id_tipo_material = " + codigoTipoMaterial + ", id_unidade = " + codigoUnidade + " where id_material = " + codigoMaterial);
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

        public DataTable DataTableTransferencia(int codigoLocalDestino, int codigoTipoTransferencia)
        {
            Conexao consultar = new Conexao();
            return consultar.RetornarDataTable("select * from Transferencia where id_local_destino = " + codigoLocalDestino + " and id_tipo_transferencia = " + codigoTipoTransferencia, "Transferencia");
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


        public DataTable DataTableMateriaisCodigoTransferencia(int codigoTransferencia)
        {
            Conexao consulta = new Conexao();

            //Obtendo os materiais da transferencia
            return consulta.RetornarDataTable("select M.id_material as Codigo, M.nome_material as Nome, MT.quantidade_material as Quantidade from Material as M " +
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

        public DataTable DataTableFornecedor(Boolean filtroStatus, Boolean statusFornecedor)
        {
            Conexao consulta = new Conexao();
            if (filtroStatus == true)
                return consulta.RetornarDataTable("select id_for, nome_for from Fornecedor where status_for = " + statusFornecedor, "Fornecedor");
            else
                return consulta.RetornarDataTable("select * from Fornecedor", "Fornecedor");   
        }

        public Boolean ExisteMaterialFornecedor(int codigoFornecedor, int codigoMaterial)
        {
            Conexao consulta = new Conexao();
            return consulta.ExisteRegistro("select id_material_fornecedor from Materiais_Fornecedor where id_for = " + codigoFornecedor + " and id_material = " + codigoMaterial, "Materiais_Fornecedor");
        }

        public DataTable DataTableMateriaisFornecedor(int codigoFornecedor)
        {
            Conexao consulta = new Conexao();

            return consulta.RetornarDataTable("select MF.id_material as Codigo, M.nome_material as Nome " +
                                              "from Materiais_Fornecedor as MF " +
                                              "inner join Material as M on MF.id_material = M.id_material " +
                                              "where MF.id_for = " + codigoFornecedor +
                                              " order by MF.id_material asc", "Materiais_Fornecedor");
        }

        public Boolean AlterarFornecedor(int codigoFornecedor, string nomeFornecedor, string cnpjFornecedor, string telefoneFornecedor, string enderecoFornecedor, Boolean statusFornecedor)
        {
            Conexao alterar = new Conexao();
            string stringStatusFornecedor = statusFornecedor.ToString();
            return alterar.ExecutaNQ("update Fornecedor set nome_for = '" + nomeFornecedor + "', cnpj_for = '" + cnpjFornecedor + "', telefone_for = '" + telefoneFornecedor + "', endereco_for = '" + enderecoFornecedor + "', status_for = " + stringStatusFornecedor + " where id_for = " + codigoFornecedor);
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
        
        public DataTable DataTablePedidoCompraFornecedor(Boolean statusPedidoCompra, int codigoLocal, int codigoFornecedor)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_pedido_compra from Pedido_Compra where status_pedido_compra = " + statusPedidoCompra + " and id_fornecedor = " + codigoFornecedor + " and id_local = " + codigoLocal, "Pedido_Compra");
        }

        public DataTable DataTableMateriaisPedidoCompra(int codigoPedidoCompra)
        {
            Conexao consulta = new Conexao();

            return consulta.RetornarDataTable("select MPC.id_material as Codigo, M.nome_material as Nome, MPC.quantidade_material as Quantidade, MPC.quantidade_recebida as Quantidade_Recebida " +
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

        public Boolean ExcluirPedidoCOmpra(int codigoPedidoCompra)
        {
            Conexao exclusao = new Conexao();
            return exclusao.ExecutaNQ("delete from Pedido_Compra where id_pedido_compra = " + codigoPedidoCompra);
        }

        public Boolean ExcluirMateriaisPedidoCompra(int codigoPedidoCompra)
        {
            Conexao exclusao = new Conexao();
            return exclusao.ExecutaNQ("delete from Materiais_PedidoCompra where id_pedido_compra = " + codigoPedidoCompra);
        }

        public Boolean AlterarMateralPedido(int codigoPedidoCompra, int codigoMaterial, int quantidadeMaterial)
        {
            Conexao alteracao = new Conexao();
            return alteracao.ExecutaNQ("update Materiais_PedidoCompra set quantidade_recebida = quantidade_recebida + " + quantidadeMaterial + " where id_pedido_compra = " + codigoPedidoCompra + " and id_material = " + codigoMaterial);
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

        
        //Recebimento
        public int InserirRecebimento(string dataRecebimento, int codigoPedidoCompra)
        {
            Conexao insercao = new Conexao();
            Boolean statusInsercao;
            statusInsercao = insercao.ExecutaNQ("insert into Recebimento (dt_recebimento, id_pedido_compra) values ('" + dataRecebimento + "'," + codigoPedidoCompra + ")");

            if (statusInsercao == true)
            {
                try
                {
                    DataTable oDtRecebimento = new DataTable();
                    oDtRecebimento = insercao.RetornarDataTable("select id_recebimento from Recebimento where id_recebimento = (select max(id_recebimento) from Recebimento)", "Recebimento");
                    return int.Parse(oDtRecebimento.Rows[0]["id_recebimento"].ToString());
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
        }

        public DataTable DataTableRecebimento()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_recebimento, dt_recebimento, id_pedido_compra from Recebimento", "Recebimento");
        }

        public Boolean InserirMaterialRecebimento(int codigoMaterial, int codigoRecebimento, int quantidadeMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Materiais_Recebimento (id_material, id_recebimento, quantidade_material) values (" + codigoMaterial + "," + codigoRecebimento + "," + quantidadeMaterial + ")");
        }


        //Autenticação
        public int AutenticarSenha(int codigoUsuario, string senhaUsuario)
        {
            Conexao consulta = new Conexao();
            DataTable oDtUsuario = consulta.RetornarDataTable("select * from Usuario where id_usuario = " + codigoUsuario + " and senha_usuario = '" + senhaUsuario + "'" , "Usuario");

            if (oDtUsuario.Rows.Count > 0)
            {
                return int.Parse(oDtUsuario.Rows[0]["tipo_usuario"].ToString());
            }

            else
                return 99;
        }

        public void AbreSessao(int codigoUsuario)
        {
            Conexao insercao = new Conexao();
            insercao.ExecutaNQ("insert into Sessao (status_sessao, id_usuario) values (1," + codigoUsuario + ")");
            return;
        }


        //Estoque
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

        public DataTable ConsultaEstoque(int codigoLocal)
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select M.id_material as Codigo, M.nome_material as Nome, QM.quantidade_material as Quantidade " +
                                                "from Material as M " +
                                                "inner join Quantidade_Material as QM " +
                                                "on M.id_material = QM.id_material " +
                                                "where QM.id_local = " + codigoLocal, "Quantidade_Material");
        }
    }

}
