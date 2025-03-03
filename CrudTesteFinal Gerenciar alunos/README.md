

```markdown
# CRUD - Gerenciamento de Alunos

Este projeto é um sistema CRUD (Criar, Ler, Atualizar e Excluir) para gerenciamento de alunos, desenvolvido em C# e MySQL. O objetivo é criar uma aplicação simples que permita registrar, editar, excluir e listar alunos em um banco de dados MySQL.

## Configuração do Banco de Dados

### 1. Editar a String de Conexão

Antes de rodar o projeto, você precisa configurar a string de conexão para o banco de dados. Para isso, siga os passos abaixo:

1. Abra o arquivo `Conexao.cs` na sua IDE.
2. Localize a seguinte linha, onde está a string de conexão com o banco de dados:

   ```csharp
   string dadosDaConexao = "Persist Security info = false; server=change-me; database=change-me; user=change-me; pwd=change-me;";
   ```

3. Substitua os valores de `server`, `database`, `user` e `pwd` com as informações do seu banco de dados MySQL. Aqui está um exemplo de como deve ficar a string de conexão após a edição:

   ```csharp
   string dadosDaConexao = "Persist Security info = false; server=localhost; database=GerenciamentoEstudantes; user=root; pwd=12345678;";
   ```

   - **server**: O endereço do servidor do banco de dados. Para banco local, use `localhost` ou `127.0.0.1`.
   - **database**: O nome do banco de dados. Se o nome do banco for `GerenciamentoEstudantes`, como no exemplo acima, use esse nome.
   - **user**: O nome de usuário do MySQL. O usuário padrão é `root`, mas você pode utilizar outro nome de usuário, caso tenha configurado um diferente.
   - **pwd**: A senha do usuário. Substitua `12345678` pela senha correta do seu banco de dados.

### 2. Criar o Banco de Dados e Tabelas no MySQL

Certifique-se de que o MySQL está instalado e rodando na sua máquina. Caso o banco de dados ainda não esteja criado, siga os seguintes passos:

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

   Isso criará um banco de dados chamado `GerenciamentoEstudantes` com uma tabela `Alunos`, que tem as colunas: `id`, `nome`, `idade`, `curso` e `nota_final`.

### 3. Rodando o Projeto

Após configurar corretamente a string de conexão e o banco de dados, você pode rodar o projeto:

1. Abra o Visual Studio 2022 e carregue o projeto.
2. Compile e execute a aplicação.
3. O sistema estará pronto para realizar operações CRUD no banco de dados, como adicionar, editar, excluir e listar alunos.

### 4. Importante: Segurança das Credenciais

**Aviso Importante**: Não compartilhe sua string de conexão com informações sensíveis (como o usuário e a senha do banco de dados) em repositórios públicos ou com outras pessoas. Em um projeto real, é altamente recomendável usar variáveis de ambiente ou outro método seguro para armazenar credenciais de banco de dados.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Banco de Dados**: MySQL
- **IDE**: Visual Studio 2022
```
