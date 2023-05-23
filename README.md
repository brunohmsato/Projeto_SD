# Projeto - Sistemas Distribuídos

Implementação de API Rest, com conexão a banco PostgreSQL.

## Autores

- [@brunohmsato](https://github.com/brunohmsato)
- [@gustavossantos](https://github.com/Gustavo-02)

## Documentação da API

#### Retorna todos os itens

```http
  GET /api/items
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `api_key` | `string` | **Obrigatório**. A chave da sua API |

#### Retorna um item

```http
  GET /api/items/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do item que você quer |

#### add(num1, num2)

Recebe dois números e retorna a sua soma.

## Pacotes necessários

Para rodar esse projeto, é necessário adicionar os seguintes pacotes pelo NuGet:

`Microsoft.EntityFrameworkCore`

`Microsoft.EntityFrameworkCore.Tools`

`Npgsql.EntityFrameworkCore.PostgreSQL`
## Observação

Se houverem erros ao realizar o clone do projeto, deve-se seguir os seguintes passos:

`Limpe a solução;`

`Recompile-o;`

Depois, em "Ferramentas" > "Gerenciador de Pacotes Nuget" > "Console do Gerenciador de Pacotes": `update-package -reinstall`