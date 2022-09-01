##### <u>09/06/2022</u>

# BaltaIO - .NET

- _Sugestão para windows_ instalar o terminal **Windows Terminal**

- Para checar se ainstalação do **.Net** está correta: 
  
  - vai no terminal
  - `dotnet -- version`

### CLI

- Command Line Interfaces

- Interface de linha de comando, são comandos adicionais adicionados ao nosso terminal

- **Dotnet CLI**
  
  - Tudo que executar no terminal como _dotnet_ alguma coisa, estarei utilizando o **dotnet CLI**
  
  - Todos os botões da interface estão interagindo, por baixo dos panos, com comandos do dotnet CLI
  
  - Exemplo de comandos[^1]:
    
    - ```dotnet
          dotnet --list-sdks      -> lista os SDKs intalados
          dotnet --list-runtimes -> lista os Runtimes instalados
          dotnet help             -> exibe ajuda e uma lista de comandos disponíveis
      
      ### Tipos de Projeto
      ```

- **Class Library**
  
  - Cria uma _.dll_
  - Cria uma biblioteca que pode ser acessada por outros projetos
  - Não possui uma interface
  - Criando o projeto pelo **CLI**
    - `dotnet new classlib `

- **Console Aplication**
  
  - É uma aplicação que roda no console(no terminal)
  - É um _.exe_
  - É possível receber dados(input) do usuário
  - Criando o projeto pelo **CLI**
    - `dotnet new console `

- **Projeto Web**
  
  - ASP .NET Web
    - Criando o projeto pelo **CLI**
      - `dotnet new web `
  - ASP .NET MVC
    - Criando o projeto pelo **CLI**
      - `dotnet new mvc`
  - ASP .NET WebAPI
    - Criando o projeto pelo **CLI**
      - `dotnet new webapi `

- **Projeto Teste**
  
  - Microsoft Tests
    - Criando o projeto pelo **CLI**
      - `dotnet new mstest`

### Fluxo de Execução

- **Dotnet restore**
  - esse comando irá buscar todos os pacotes necessários para executar aquela aplicação
  - sempre que baixar uma aplicação _.Net_ é necessário rodar esse comando
  - executa esse comando dentro da pasta que tem o arquivo `.csproj`
- **Dotnet build**
  - para compilar nossa aplicação rodamos esse comando dentro da pasta que tem o arquivo `.csproj`
  - no _build_ vemos se tem algum aviso e/ou erro em nossa aplicação
- **Dotnet clean**
  - limpa todos os arquivos de _cache_ da aplicação
  - para compilar nossa aplicação rodamos esse comando dentro da pasta que tem o arquivo `.csproj` 
  - é recomendado fazer isso de vez em quando (sempre antes de executar um _build_ é indicado)
- **Dotnet run**
  - para rodar nossa aplicação
  - para compilar nossa aplicação rodamos esse comando dentro da pasta que tem o arquivo `.csproj`
  - este comando não executa depuração (Debug), ou seja, não irá parar nos break points

### Variáveis de Ambiente

- **Ambiente** se refere a onde nossa aplicação está rodando
  - **Ambiente de Desenvolvimento**
    - Nossa máquina seria esse ambiente
  - **Ambiente de Teste**
    - Não são todas as empresas que tem, mas tem empresas que tem esse ambiente de teste _antes_ do ambiente de Homologação
  - **Ambiente de Homologação(staging)**
    - É responsável por simular o ambiente de produção para ver se as alterações não quebraram nada
  - **Ambiente de Produção**
    - O ambiente oficial, onde nosso cliente irá acessar nossa API
- Cada _ambiente_ possui suas **configurações**, suas _chaves de acesso externo_ e _conexões com o banco de dados_
- As **variáveis de ambiente** são variáveis específicas para cada ambiente, por exemplo, o acesso ao banco de dados específico de homol ou de prod, as keys específicas de cada um, etc.
- Para rodarmos a aplicação nos ambientes específicos fazemos: `dotnet run --environment= *ambienteDesejado* `(não sendo necessário fazer isso para prod)

### Estruturas do Console

- **Arquivo.csproj**
  
  - Formato XML
    
    - Para ver o XML, abre pelo visual studio ou botão direito nele
  
  - É ele que abre a pasta dos projetos no Visual Studio
  
  - Presente em todo projeto .NET
  
  - O nome da Pasta é o nome que é dado nesse arquivo
  
  - *OutpuType* - tipo do executável disponível, como esse arquivo será executado
  
  - *Target Framework* - o framework atual do projeto

- **Arquivo.cs**
  
  - Arquivo principal C#
  
  - Primeiro a ser executada

- **Pasta Bin**
  
  - Pasta onde fica os binários

- **Pasta obj**
  
  - é utilizada para o nosso Debug

# 

### Dicas

- **VSCode:**
  - procurando por Shell Command (em ctrl/cmd + shift + P), clicando em install (no caso do Mac e do Linux) ou selecionando a última opção ao instalar o VSCode (no Windows), ao digitar `code`, abre o VSCode
  - **cmd/ctrl** + **,** : aparece os _settings_ (na parte superior, à direita, tem a opção de abrir o settings em Json)
  - `code .` abre a aplicação no VS Code (quando perguntar sobre o _build_ e o _debug_ colocar yes)
  - lá no *settings* procurando por *format on save* e selecionando essa opção, quando formos salvar o arquivo é identado automaticamente
- **Criando um projeto pelo CLI**: para criar uma pasta onde ficará a aplicação _.NET_ (_dotnet new..._) colocamos: `dotnet new ..(console/MVC/etc).. -o nomeDaPasta`

### Notas de Rodapé

[^1]: --: "--" é chamado de dash dash