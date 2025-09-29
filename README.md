Gerenciador de Inscrições para Corrida Beneficente
💻 Sobre o Projeto
Este projeto é um software de desktop desenvolvido como atividade para a disciplina de Programação Orientada a Objetos (POO). O objetivo é aplicar os conceitos fundamentais de POO para criar um sistema de gerenciamento de inscrições para uma corrida de rua beneficente, organizada por uma ONG de proteção animal.
O sistema permite cadastrar, visualizar e remover participantes, além de exibir estatísticas em tempo real, como o número total de inscritos e o valor arrecadado com as inscrições.
✨ Objetivos e Conceitos de POO Aplicados
O desenvolvimento deste software visou demonstrar o domínio dos seguintes pilares da Programação Orientada a Objetos:

    Abstração: As entidades do mundo real (Pessoa, Participante, Corrida) foram modeladas em classes, abstraindo suas características e comportamentos essenciais. A classe Pessoa foi criada como abstract para representar um conceito genérico que não pode ser instanciado diretamente.
    Encapsulamento: Todos os atributos das classes de modelo são privados e acessados através de propriedades públicas ({ get; set; }). Isso protege o estado interno dos objetos e garante que o acesso aos dados seja controlado.
    Herança: A classe Participante herda da classe Pessoa, reutilizando seus atributos (Nome, CPF, Email, Telefone) e estendendo-os com informações específicas da inscrição.
    Polimorfismo: Embora não explorado em profundidade, a estrutura com herança abre caminho para comportamentos polimórficos, onde diferentes tipos de Pessoa poderiam ser tratados de maneira uniforme.

🚀 Tecnologias Utilizadas

    Linguagem: C#
    Framework: .NET
    Interface Gráfica (GUI): Windows Presentation Foundation (WPF)
    IDE: Visual Studio

📂 Estrutura do Projeto
O projeto foi organizado com uma clara separação de responsabilidades:

    Models/: Contém as classes que representam os dados do sistema (as entidades).
        Pessoa.cs: Classe base abstrata.
        Participante.cs: Representa um participante inscrito.
        Corrida.cs: Representa o evento da corrida.
    GerenciadorInscricoes.cs: Classe de serviço que centraliza a lógica de negócios (cadastrar, remover, calcular estatísticas), servindo como uma ponte entre a interface e os modelos.
    MainWindow.xaml / MainWindow.xaml.cs: Camada de apresentação (View e Code-behind), responsável exclusivamente pela interação com o usuário e por delegar as ações ao GerenciadorInscricoes.

✨ Funcionalidades
O software implementa os seguintes requisitos funcionais:

    Cadastro de Participantes: Formulário para inserir Nome, CPF, Email, Telefone e Idade.
    Seleção de Valor de Inscrição: Permite escolher entre diferentes valores de inscrição/doação.
    Listagem de Inscritos: Um DataGrid exibe todos os participantes cadastrados com suas informações.
    Remoção de Participantes: É possível selecionar um participante na lista e removê-lo.
    Estatísticas em Tempo Real: Exibição do número total de inscritos e do valor total arrecadado, atualizados automaticamente após cada operação.
