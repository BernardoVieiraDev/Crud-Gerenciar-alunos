using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Concurrent;
using System.Windows.Forms;

namespace CrudTesteFinal_Gerenciar_alunos
{
    internal class Conexao
    {
        MySqlConnection connection;

        public void Conectar()
        {
            try
            {
                string dadosDaConexao = "Persist Security info = false; server=change-me; database=change-me; user=change-me; pwd=change-me;";

                connection = new MySqlConnection(dadosDaConexao);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar: ", ex.Message);
            }
        }


        public DataTable ExecutarConsulta(string comandoSql)
        {
           try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(comandoSql, connection);
                DataTable dataTable = new DataTable();
                dados.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex){
                MessageBox.Show("Nao foi possivel executar a consulta, erro: " + ex.Message);
                return null;
            
            }
            

        }


        public void ExecutarComando(string comandoSql) 
        {   Conectar();
            MySqlCommand comando = new MySqlCommand(comandoSql, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }


    }
}
