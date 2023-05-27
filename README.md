# Projeto - Sistemas Distribuídos - Trabalho Avaliativo 7º SI

Implementação de API Rest, com CRUD simples e conexão a banco PostgreSQL.

## Autores

- [@brunohmsato](https://github.com/brunohmsato)
- [@gustavossantos](https://github.com/Gustavo-02)
- [@murilorissos](https://github.com/murilorissos)

## Documentação da API

Bem-vindos à documentação da API do projeto. 
Esta API permite acessar e gerenciar os dados das tabelas propostas para esse projeto.

A seguir, trazemos informações sobre os endpoints disponíveis, 
parâmetros esperados e exemplos de uso.

### Autenticação e Autorização
Para acessar os endpoints desta API, não é necessário fornecer credenciais válidas. 

### Endpoints

#### (1) Retorna todos os itens da tabela desejada

```http
  GET /api/[Controller]
```

##### Parâmetros de consulta
Nenhum parâmetro adicional é necessário.



#### (2) Retorna somente um item da tabela desejada, baseado no ID fornecido

```http
  GET /api/[Controller]/${id}
```

##### Parâmetros de consulta

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
|   `id`      |   `int`    | **Obrigatório**. O ID do item que você quer |



#### (3) Atualiza um item da tabela, baseado no ID fornecido

```http
  PUT /api/[Controller]/${id}
```

##### Parâmetros de consulta

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
|   `id`      |   `int`    | **Obrigatório**. O ID do item que você quer |

##### Corpo da solicitação
Forneça os dados atualizados do item no corpo da solicitação.



#### (4) Insere item na tabela

```http
  POST /api/[Controller]
```

##### Corpo da solicitação
Forneça os dados do novo item no corpo da solicitação.



#### (5) Deleta um item da tabela desejada, baseado no ID fornecido

```http
  DELETE /api/[Controller]/${id}
```

##### Parâmetros de consulta

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
|   `id`      |   `int`    | **Obrigatório**. O ID do item que você quer |


### Códigos de status
A API pode retornar os seguintes códigos de status HTTP:

- 200 OK: Solicitação bem-sucedida.
- 400 Bad Request: A solicitação está mal formatada ou contém parâmetros inválidos.
- 401 Unauthorized: Falha na autenticação ou falta de credenciais.
- 404 Not Found: O recurso solicitado não foi encontrado.
- 500 Internal Server Error: Ocorreu um erro interno no servidor.


## Pacotes necessários
Para rodar esse projeto, é necessário adicionar os seguintes pacotes pelo NuGet:

`Microsoft.EntityFrameworkCore`

`Microsoft.EntityFrameworkCore.Tools`

`Npgsql.EntityFrameworkCore.PostgreSQL`


obs: Para fazer a implementação dos Controllers (Adicionar > Controlador... > opção "Controlador API com ações, usando o Entity Framework"), serão necessário os seguintes pacotes:

`Microsoft.EntityFrameworkCore.SqlServer`

`Microsoft.VisualStudio.Web.CodeGeneration.Design`

## Caso erro:

Se houverem erros ao realizar o clone do projeto, deve-se seguir os seguintes passos:

`Limpe a solução;`

`Recompile-o;`

Depois, em "Ferramentas" > "Gerenciador de Pacotes Nuget" > "Console do Gerenciador de Pacotes": `update-package -reinstall`
