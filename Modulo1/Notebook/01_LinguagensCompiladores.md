##### <u>13/05/2022</u> e <u>15/05/2022</u>

# BaltaIO - Fundamentos C# - Linguagens e Compiladores

- **Linguagem de programação**: comunicação entre a gente e o computador
- **Compilação**: "tradução" da linguagem de programação para a linguagem de máquina 
  - **Compilador**: agente que executa a compilação

## Linguagem de *Alto* e *Baixo* nível

#### Baixo nível

- Envia uma instrução ao computador (em formato binário)

- Quanto mais detalhada a necessidade, mais baixo o nível

- Exemplo: **Assembly**[^1]
  
          global _start
      
          sectition .text
       _start: mov rax,1
        mov rdi, 1
          rsi, message
          mov rdx, 13
          syscall
          mov rax, 60
          xor rdi, rdi
          syscall
      
          section  .data
          message: db "Hello, World",10

#### Alto nível

- Mais próxima aos desenvolvedores

- Exemplo: **C#**
  
  ```
  namespace   ConsoleApp1
  {
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World");
        }
    }
  }
  ```
  
  ## Linguagem de *Compilada* e *Interpretada*
  
  ### Linguagem Compilada

- Quando existe o processo de compilação => recebe um arquivo de texto e é transformada em binário
  
  ### Linguagem Interpretada

- Arquivos de texto que são lidos e interpretados (não são convertidos para binário)

- Essa interpretação é feita em tempo de execução[^2], ex: JavaScript
  
  ### Compilada x Interpretada

- **Interpretada**
  
  - **Prós**
    - Não precisa ser compilada
    - Correções mais fáceis de serem executadas
    - Mais simples de serem distribuídas
  - **Contras**
    - Erros só aparecem em tempo de execução (no exemplo do JS, aparece lá no cliente já)
    - Tamanho final da aplicação maior
    - Menor otimização da execução
    - Múltiplos arquivos   

- **Compilada**
  
  - **Prós**
    - Tempo de compilação 
    - Detecta os erros mais rapidamente
    - Tamanho menor das aplicações
    - Maior otimização da execução
    - Apenas um arquivo final
  - **Contras**
    - Precisa de um compilador
    - Pode ser mais burocrática

## Tipagem de dados

- Obrigam a especificar o *tipo de dado*[^3] da informação (inteiro, string, etc.)

- São chamadas de **fortemente tipadas**

- Menor liberdade e maior otimização, pois estamos padronizando os dados (tanto para nós quanto para o processador/memória)

```csharp
//C# - Fortemente Tipada e Compilada

int idade = 18; //Funciona
int idade = 18.2; //Não funciona porque não 
```

```javascript
//Javascript - Não tipada e interpretada (o "let" usa sempre o mesmo
// tamanho de alocação)

let idade = 18;//Funciona
let idade = 'x'; //Funciona também
```

### Definições

**_Trade off_**: é o custo benefício, o que você perde e ganha na sua escolha

**_Variável:_** informação que a gente declara que pode ser alterada posteriormente

**_Constante:_** informação que a gente declara que nunca poderá ser alterada

### Notas de Rodapé

[^1]:**Assembly**: Assembly ou linguagem de montagem é uma notação legível por humanos para o código de máquina que uma arquitetura de computador específica usa, utilizada para programar códigos entendidos por dispositivos computacionais, como microprocessadores e microcontroladores. (Fonte)[https://pt.wikipedia.org/wiki/Linguagem_assembly#:~:text=Assembly%20ou%20linguagem%20de%20montagem,computacionais%2C%20como%20microprocessadores%20e%20microcontroladores.]
[^2]:**Tempo de Execução**: é o que acontece durante a execução(leitura) do código pelo computador ou interpretador

[^3]:**Tipo de dado:** um tipo de dado define o formato dele, onde definimos por exemplo que aquela informação é um número, uma letra, uma cadeia de caracteres e assim por diante
