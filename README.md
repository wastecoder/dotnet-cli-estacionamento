# 🚗 Sistema de Estacionamento em C# – CLI

Este projeto foi desenvolvido para **praticar conceitos de orientação a objetos e boas práticas com C#**,
simulando as operações básicas de um estacionamento em um aplicativo de terminal (CLI).

A ideia é ter um sistema simples, com **menu interativo**, permitindo cadastrar, listar e remover veículos,
aplicando o **princípio da responsabilidade única (SRP)** ao separar responsabilidades em classes distintas.


---


## 📂 Estrutura do Projeto

```
donet-cli-estacionamento/
├── Models/
│   └── Estacionamento.cs
├── Services/
│   └── EstacionamentoService.cs
├── UI/
│   └── Menu.cs
└── Program.cs
```

> O ponto de entrada é o **Program.cs**, que inicializa o sistema e exibe o menu principal.


---


## 🛠️ Funcionalidades

- [x] Cadastro de veículos
  - [x] Adicionar veículo ao estacionamento

- [x] Remoção de veículos
  - [x] Calcular valor total com base no tempo estacionado
  - [x] Remover veículo do estacionamento

- [x] Listagem de veículos
  - [x] Exibir todos os veículos estacionados
  - [x] Mensagem quando não houver veículos

- [x] Estrutura em camadas
  - [x] Model (`Estacionamento`) para regras de negócio
  - [x] Service (`EstacionamentoService`) para orquestração
  - [x] View (`Menu`) para interação com o usuário via console


---


## ⚙️ Tecnologias Utilizadas

- **.NET SDK 9.0:** framework utilizado para rodar a aplicação.
- **C#:** linguagem de programação.
- **Rider:** IDE principal usada no desenvolvimento.


---


## 🧪 Como Executar

Clone o repositório e entre na pasta do projeto:

```bash
git clone git@github.com:wastecoder/dotnet-cli-estacionamento.git
cd dotnet-cli-estacionamento
dotnet build
dotnet run
```
