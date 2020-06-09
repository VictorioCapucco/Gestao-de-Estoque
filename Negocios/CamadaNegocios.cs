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

        //Tipo Saida
        public Boolean InserirTipoSaida(string descricaoTipoSaida, Boolean statusTipoSaida)
        {
            Conexao insercao = new Conexao();
            //return insercao.ExecutaNQ("insert into Tipo_Saida (descricao_tipo_saida, status_tipo_saida) values('" + descricao_tipo_saida + "'," + status_tipo_saida + ")");
            return insercao.ExecutaNQ("insert into Tipo_saida (descricao_tipo_saida, status_tipo_saida) values('" + descricaoTipoSaida + "'," + statusTipoSaida + ')');
        }

        //Locais
        public Boolean InserirLocais(string descricaoLocal, string enderecoLocal, Boolean statusLocal)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Locais (descricao_local, endereco_local, status_local) values('" + descricaoLocal + "','" + enderecoLocal + "'," + statusLocal + ')');
        }

        public DataTable DataTableLocais()
        {
            Conexao consulta = new Conexao();
            return consulta.RetornarDataTable("select id_local, descricao_local from Locais where status_local = true", "Locais");
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


        //Requisição de saída
        public int InserirRequisicao(int codigoLocal)
        {
            //Criando a requisição
            Conexao insercao = new Conexao();
            Boolean statusCriarRequisicao = insercao.ExecutaNQ("insert into Requisicao (status_requisicao, id_local) values (false," + codigoLocal + ")");

            if (statusCriarRequisicao == true)
            {
                try
                {
                    //Obtendo o id da requisição criada
                    DataTable oDtUltimaRequisicao = new DataTable();

                    oDtUltimaRequisicao = insercao.RetornarDataTable("select id_requisicao from Requisicao where id_requisicao = (select max (id_requisicao) from Requisicao)", "Requisicao");
                    int codigoRequisicao = int.Parse(oDtUltimaRequisicao.Rows[0]["id_requisicao"].ToString());

                    return codigoRequisicao;
                }

                catch
                {
                    return 0;
                }
            }

            else
                return 0;
        }

        public Boolean InserirMateriaisRequisicaoSaida(int codigoRequisicao, int codigoMaterial, int quantidadeMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Materiais_Requisicao (quantidade_material, id_material, id_requisicao) values (" + quantidadeMaterial + "," + codigoMaterial + "," + codigoRequisicao + ")");
        }

    }
}
