

```markdown
# CRUD - Gerenciamento de Alunos

Este projeto � um sistema CRUD (Criar, Ler, Atualizar e Excluir) para gerenciamento de alunos, desenvolvido em C# e MySQL. O objetivo � criar uma aplica��o simples que permita registrar, editar, excluir e listar alunos em um banco de dados MySQL.

## Configura��o do Banco de Dados

### 1. Editar a String de Conex�o

Antes de rodar o projeto, voc� precisa configurar a string de conex�o para o banco de dados. Para isso, siga os passos abaixo:

1. Abra o arquivo `Conexao.cs` na sua IDE.
2. Localize a seguinte linha, onde est� a string de conex�o com o banco de dados:

   ```csharp
   string dadosDaConexao = "Persist Security info = false; server=change-me; database=change-me; user=change-me; pwd=change-me;";
   ```

3. Substitua os valores de `server`, `database`, `user` e `pwd` com as informa��es do seu banco de dados MySQL. Aqui est� um exemplo de como deve ficar a string de conex�o ap�s a edi��o:

   ```csharp
   string dadosDaConexao = "Persist Security info = false; server=localhost; database=GerenciamentoEstudantes; user=root; pwd=12345678;";
   ```

   - **server**: O endere�o do servidor do banco de dados. Para banco local, use `localhost` ou `127.0.0.1`.
   - **database**: O nome do banco de dados. Se o nome do banco for `GerenciamentoEstudantes`, como no exemplo acima, use esse nome.
   - **user**: O nome de usu�rio do MySQL. O usu�rio padr�o � `root`, mas voc� pode utilizar outro nome de usu�rio, caso tenha configurado um diferente.
   - **pwd**: A senha do usu�rio. Substitua `12345678` pela senha correta do seu banco de dados.

### 2. Criar o Banco de Dados e Tabelas no MySQL

Certifique-se de que o MySQL est� instalado e rodando na sua m�quina. Caso o banco de dados ainda n�o esteja criado, siga os seguintes passos:

1. Abra seu cliente MySQL (como o MySQL Workbench ou o Terminal).
2. Crie o banco de dados e a tabela executando o seguinte comando:

   ```sql
   CREATE DATABASE GerenciamentoEstudantes;

   USE GerenciamentoEstudantes;

   CREATE TABLE Alunos (
       id INT AUTO_INCREMENT PRIMARY KEY,
       nome VARCHAR(100),
       idade INT,
       curso VARCHAR(50),
       nota_final DOUBLE
   );
   ```

   Isso criar� um banco de dados chamado `GerenciamentoEstudantes` com uma tabela `Alunos`, que tem as colunas: `id`, `nome`, `idade`, `curso` e `nota_final`.

### 3. Rodando o Projeto

Ap�s configurar corretamente a string de conex�o e o banco de dados, voc� pode rodar o projeto:

1. Abra o Visual Studio 2022 e carregue o projeto.
2. Compile e execute a aplica��o.
3. O sistema estar� pronto para realizar opera��es CRUD no banco de dados, como adicionar, editar, excluir e listar alunos.

### 4. Importante: Seguran�a das Credenciais

**Aviso Importante**: N�o compartilhe sua string de conex�o com informa��es sens�veis (como o usu�rio e a senha do banco de dados) em reposit�rios p�blicos ou com outras pessoas. Em um projeto real, � altamente recomend�vel usar vari�veis de ambiente ou outro m�todo seguro para armazenar credenciais de banco de dados.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Banco de Dados**: MySQL
- **IDE**: Visual Studio 2022
```
