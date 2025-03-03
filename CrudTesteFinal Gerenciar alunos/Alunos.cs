using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTesteFinal_Gerenciar_alunos
{
    internal class Alunos
    {
        private int id, idade;
        private string nome, curso;
        private double nota_final;

        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;     
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }
        public string GetCurso()
        {
            return this.curso;
        }

        public void SetNotaFinal(double nota_final) 
        {
            this.nota_final = nota_final;
        }

        public double GetNotaFinal()
        {
            return this.nota_final;
        }

        Conexao conn = new Conexao();   

        public void InserirAluno()
        {
            string inserir = $"insert into Alunos values(null, '{this.nome}',{this.idade}, '{this.curso}', {this.nota_final});";

           

            conn.ExecutarComando(inserir);
        }

        public void AlterarAluno()
        {
            string alterar = $"update Alunos set nome = '{this.nome}',idade ={this.idade}, curso ='{this.curso}',nota_final = {this.nota_final} where id = {this.id};";
            conn.ExecutarComando( alterar );
        }

        public void ExcluirAluno()
        {
            string excluir = $"delete from Alunos where id ={this.id} ;";
            conn.ExecutarComando(excluir);
        }

        public DataTable ListarAlunos()
        {
            string query = "select * from Alunos order by nome;";
            return conn.ExecutarConsulta(query);
        } 


        public DataTable PesquisarAlunos(string nome)
        {
            string query = $"select * from Alunos where nome LIKE '%{nome}%' order by nome;";
            return conn.ExecutarConsulta(query);

        }

        //id nome idade curso nota_final
    }
}
