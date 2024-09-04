# SeleniumCSharpAutomation

Projeto de automação de testes de interface web utilizando **Selenium WebDriver** com **C#**.

## Estrutura do Projeto

- **Drivers/**: Gerenciamento dos WebDrivers (ex: ChromeDriver, FirefoxDriver).
- **Pages/**: Implementação do padrão **Page Object Model (POM)**, representando as páginas web.
- **Tests/**: Scripts de testes organizados por funcionalidade.
- **Utils/**: Funções auxiliares (ex: leitura de configurações, geração de dados de teste).
- **Reports/**: Relatórios de execução de testes.

## Requisitos

- .NET SDK 6.0+
- Selenium WebDriver
- NUnit (ou outro framework de testes)

## Como Executar

Clone o repositório:

```bash
git clone https://github.com/seuprojeto/SeleniumCSharpAutomation.git


Instale as dependências:

```bash
dotnet restore
```

Execute os testes:

```bash
dotnet test 
```

#  Configurações
Atualize o arquivo appsettings.json com as URLs e credenciais necessárias para execução dos testes.
