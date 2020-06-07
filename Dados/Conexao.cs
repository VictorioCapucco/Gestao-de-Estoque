using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Dados
{
    public class Conexao
    {
        OleDbConnection myDBConnection = new OleDbConnection(Properties.Settings.Default.ConBanco);

        public void AbrirConexao()
        {
            myDBConnection.Open();
        }

        public void FecharConexao()
        {
            myDBConnection.Close();
        }

        public DataTable RetornarDataTable(string sql, string nome_tabela)
        {
            try
            {

                AbrirConexao();
                OleDbDataAdapter oDa = new OleDbDataAdapter(sql, myDBConnection);
                DataSet oDs = new DataSet();
                DataTable oDT = new DataTable();
                oDa.Fill(oDs, nome_tabela);
                oDT = oDs.Tables[nome_tabela];

                oDa.Fill(oDs);
                FecharConexao();
                return oDT;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public DataSet RetornarDataSet(string sql)
        {
            try
            {
                AbrirConexao();
                OleDbDataAdapter oDa = new OleDbDataAdapter(sql, myDBConnection);
                DataSet oDs = new DataSet();
                oDa.Fill(oDs);
                FecharConexao();
                return oDs;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public Boolean ExecutaNQ(string sql)
        {

            try
            {
                AbrirConexao();
                OleDbCommand command = new OleDbCommand(sql, myDBConnection);
                command.ExecuteNonQuery();
                FecharConexao();
                return true;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
