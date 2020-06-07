using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocios
{
    public class CamadaNegocios
    {
        public Boolean InserirTipoMaterial(string descricaoCompleta, string descricaoReduzida, Boolean statusTipoMaterial)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Tipo_Material (descricao_reduzida_tipo_material, descricao_tipo_material, status_tipo_material) values ('" + descricaoReduzida + "','" + descricaoCompleta + "'," + statusTipoMaterial + ')');

        }

        public Boolean InserirTipoSaida(string descricaoTipoSaida, Boolean statusTipoSaida)
        {
            Conexao insercao = new Conexao();
            //return insercao.ExecutaNQ("insert into Tipo_Saida (descricao_tipo_saida, status_tipo_saida) values('" + descricao_tipo_saida + "'," + status_tipo_saida + ")");
            return insercao.ExecutaNQ("insert into Tipo_saida (descricao_tipo_saida, status_tipo_saida) values('" + descricaoTipoSaida + "'," + statusTipoSaida + ')');
        }

        public Boolean InserirLocais(string descricaoLocal, string enderecoLocal, Boolean statusLocal)
        {
            Conexao insercao = new Conexao();
            return insercao.ExecutaNQ("insert into Locais (descricao_local, endereco_local, status_local) values('" + descricaoLocal + "','" + enderecoLocal + "'," + statusLocal + ')');
        }
    }
}
