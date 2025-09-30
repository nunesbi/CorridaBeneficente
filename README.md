# **🏃‍♂️ Gerenciador de Inscrições para Corrida Beneficente**

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white) ![WPF](https://img.shields.io/badge/WPF-512BD4?style=for-the-badge&logo=windows&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

---

## **💻 Sobre o Projeto**
Software de desktop desenvolvido para a disciplina de **Programação Orientada a Objetos (POO)**.  
Permite **cadastrar, listar e remover participantes** de uma corrida beneficente organizada por uma **ONG de proteção animal**, com **estatísticas em tempo real**.

---

## **✨ Objetivos e Conceitos de POO Aplicados**
- **Abstração:** Entidades (*Pessoa, Participante, Corrida*) modeladas em classes, abstraindo características essenciais.  
  `Pessoa` é **abstract**, representando um conceito genérico não instanciável.
- **Encapsulamento:** Atributos privados acessados via propriedades públicas (`{ get; set; }`) para proteger o estado interno dos objetos.
- **Herança:** `Participante` herda de `Pessoa`, reutilizando atributos e adicionando informações de inscrição.
- **Polimorfismo:** Estrutura que permite tratar diferentes tipos de `Pessoa` de forma uniforme.

---

## **✨ Funcionalidades**
- **Cadastro de Participantes:** Nome, CPF, Email, Telefone e Idade  
- **Seleção de Valor de Inscrição:** Diferentes valores de inscrição/doação  
- **Listagem de Inscritos:** Exibição em DataGrid  
- **Remoção de Participantes:** Exclusão direta da lista  
- **Estatísticas em Tempo Real:** Total de inscritos e valor arrecadado

---

## **🚀 Tecnologias**
- **Linguagem:** C#  
- **Framework:** .NET  
- **GUI:** WPF  
- **IDE:** Visual Studio  

---

## **📂 Estrutura do Projeto**
```text
Models/
├─ Pessoa.cs               # Classe base abstrata
├─ Participante.cs         # Representa um participante
├─ Corrida.cs              # Representa a corrida
GerenciadorInscricoes.cs   # Lógica de negócios
MainWindow.xaml / MainWindow.xaml.cs  # Interface e interação com usuário

