# Calculadora Multilíngue em C#

## Visão Geral

Este repositório contém o código de uma calculadora simples desenvolvida em C#. Embora calculadoras sejam frequentemente usadas como um exercício introdutório para programadores, este projeto se destaca por incluir suporte a múltiplos idiomas, o que demonstra a aplicação prática de conceitos como internacionalização e modularidade.

## Funcionalidades

- **Operações Matemáticas**: A calculadora realiza as quatro operações aritméticas básicas: adição, subtração, multiplicação e divisão.
- **Suporte Multilíngue**: A interface da calculadora está disponível em três idiomas: inglês, espanhol e português. O usuário pode selecionar o idioma de sua preferência logo ao iniciar a aplicação.
- **Interface de Linha de Comando**: A aplicação é executada via console, permitindo uma experiência simples e direta.

## Demonstração

Após iniciar a aplicação, o usuário é solicitado a selecionar o idioma:

```csharp
Console.WriteLine($"{Global.SelectLanguage}: ");
Console.WriteLine($"1 - {Global.English}");
Console.WriteLine($"2 - {Global.Spanish}");
Console.WriteLine($"3 - {Global.Portuguese}");
```

Depois de escolher o idioma, a calculadora exibe o menu de operações, onde o usuário pode selecionar a operação desejada:

```csharp
Console.WriteLine(Global.SelectOperationType);
Console.WriteLine($"1 - {Global.Addition}");
Console.WriteLine($"2 - {Global.Subtraction}");
Console.WriteLine($"3 - {Global.Multiplication}");
Console.WriteLine($"4 - {Global.Division}");
```

O resultado da operação é então calculado e exibido ao usuário na língua escolhida.

## Estrutura do Projeto

- **`Program.cs`**: Contém a lógica principal da aplicação, incluindo a seleção de idioma e operação.
- **`Language/SelectLanguage.cs`**: Gerencia a seleção do idioma e define as culturas (`CultureInfo`) para a aplicação.
- **`Service/CalculatorService.cs`**: Implementa as operações aritméticas básicas.
- **`EnumHelpers.cs`**: Fornece utilitários para trabalhar com enums e seus atributos.
- **`Operation.cs`**: Define as operações disponíveis como enums e seus respectivos nomes traduzidos.

## Tecnologias Utilizadas

- **C#**: Linguagem principal de desenvolvimento.
- **.NET Core**: Framework para a execução da aplicação.
- **`CultureInfo` e `Thread.CurrentThread.CurrentUICulture`**: Utilizados para implementar a internacionalização.

## Possíveis Melhorias

Algumas melhorias planejadas para versões futuras incluem:

- **Novas Operações Matemáticas**: Como exponenciação e cálculo de raízes.
- **Interface Gráfica**: Migração para uma interface de usuário gráfica utilizando WPF ou WinForms.
- **Testes Automatizados**: Implementação de testes unitários para garantir a robustez do código.

## Como Executar

1. Clone este repositório:

    ```bash
    git clone https://github.com/Wmedrado/Calculator.git
    ```

2. Navegue até o diretório do projeto:

    ```bash
    cd Calculator
    ```

3. Compile e execute a aplicação:

    ```bash
    dotnet run
    ```

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias, correções ou novas funcionalidades.
