<h1 align="center">
     :computer: <a href="#" alt="site do ecoleta">Projeto K </a>
</h1>

<h3 align="center">
    Aplicação para Cadastro de Produtos e Gestão de Estoque.
</h3>

</p>

<h4 align="center">
	🚧   Concluído 🚀 🚧
</h4>

Tabela de conteúdos
=================
<!--ts-->
   * [Sobre o projeto](#-sobre-o-projeto)
   * [Funcionalidades](#-funcionalidades)
   * [Como executar o projeto](#-como-executar-o-projeto)
     * [Pré-requisitos](#pré-requisitos)
     * [Rodando a Aplicação](#user-content--rodando-a-aplicação)
   * [Tecnologias](#-tecnologias)
   * [Autor](#-autor)
   * [Licença](#user-content--licença)
<!--te-->


## 💻 Sobre o projeto

:computer: Projeto K - é uma aplicação base para cadastro de produtos e gestão de estoque.

A aplicação serve de base e de modelo para sistemas Web de gerenciamento em geral. Contando com o registro de produtos e movimentações de entrada e saída. 
Assim como, listagem das movimentações realizadas.<br/><br/>
O sistema conta com diversas possibilidades de aprimoramento e implementações que podem ser realizadas em cima do Projeto.

---

## ⚙️ Funcionalidades

  - [x] Login
  - [x] Cadastro de usuários
  - [x] Cadastro de categorias
  - [x] Cadastro de produtos
  - [x] Listagem de produtos (Estoque)
  - [x] Movimentações de Estoque - Entradas / Saídas
  - [x] Listagem das movimentações realizadas

---

## 🚀 Como executar o projeto

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina a seguinte ferramenta:
[Git](https://git-scm.com). 
Além disto, é bom ter uma IDE ou editor para trabalhar com o código como [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) no caso de Windows ou 
[VSCode](https://code.visualstudio.com/) para demais plataformas.

#### 🎲 Rodando a aplicação

```bash
Visual Studio 2019 -

  Clone este repositório
$ git clone https://github.com/Abraham2908/ProjetoK

# Abra seu VS 2019, selecione a opção abrir um projeto ou uma solução, vá até o diretorio onde 
# o projeto foi clonado e selecione o ProjetoK1.sln.

Entity Framework Core

# Agora vamos instalar o EF Core, Para instalar o Entity Framework em nosso projeto vamos usar a opção do 
# menu Tools-> Nuget Package Manager ->  Package Manage Console.

# Vamos instalar o provider para o SQL Server.

# Digite o seguinte comando : Install-Package Microsoft.EntityFrameworkCore.SqlServer

# A seguir vamos instalar o Microsoft.EntityFrameworkCore.Tools para ter acesso às ferramentas de Scaffolding e 
# usar o Migrations em nosso projeto.

# Digite o comando : Install-Package Microsoft.EntityFrameworkCore.Tools

Banco de Dados - SQL Server

# O banco de dados está configurado para o LocalDB, versão mais leve do mecanismo do SQL Server destinado
# ao ambiente de desenvolvimento. 
# Para mudar a conexão se necessário, é só ir até o arquivo appsettings.json e alterar a Connection string como desejar.

# Abra o Package Manager Console e digite o comando: Update-database

# Abra o SQL Server Object Explorer e em seguida clique no (localdb), vá ate o banco de dados projetok1
# e verifique a aba tables para verificar se as tables foram criadas.
# Caso não, digite no Package Manager Console o comando: Add-migration (nome) e em seguida Update-database

# Execute o projeto teclando Ctrl + F5.

# O servidor inciará na https://localhost:44379/ 

```
---

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

#### **Front-End**  ([HTML](https://developer.mozilla.org/pt-BR/docs/Web/HTML)  +  [CSS](https://developer.mozilla.org/pt-BR/docs/Web/CSS) + [Bootstrap](https://getbootstrap.com/))


#### **Back-End**  ([C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)  +  [.NET Core 3.1](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0))

-   **[Sistema de Cadastro/Autenticação - Framework Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)**

#### **Banco de Dados**  ([SQL Server](https://www.microsoft.com/pt-br/sql-server/))

#### [](https://github.com/tgmarinho/Ecoleta#utilit%C3%A1rios)**Utilitários**

-   Tema: **[AdminLTE](https://adminlte.io//)**
-   Ícones: **[Font Awesome](https://fontawesome.com/)**

---

## 🦸 Autor

<a href="https://blog.rocketseat.com.br/author/thiago/">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/85251911?s=400&u=879b9dbf2180c63fc98bde28f93c6d85c17ee215&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Abraham França</b></sub></a> <a href="https://blog.rocketseat.com.br/author/thiago/" title="Rocketseat">🚀</a>
 <br />

[![Linkedin Badge](https://img.shields.io/badge/-Abraham-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/abraham-franca/)](https://www.linkedin.com/in/abraham-franca/) 
[![Gmail Badge](https://img.shields.io/badge/-abrahampedrog@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:abrahampedrog@gmail.com)](mailto:abrahampedrog@gmail.com)

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito por Abraham França 👋🏽 [Entre em contato!](https://www.linkedin.com/in/abraham-franca/)
