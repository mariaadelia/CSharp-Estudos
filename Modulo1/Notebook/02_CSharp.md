##### <u>15/05/2022</u>

# BaltaIO - Fundamentos C# - C#

- **C#** é uma linguagem de programação *tipada, compilada e gerenciada*
- O criador é o mesmo criador do **typescript** 

## Código gerenciado

- Significa que sua execução depende de um gerenciador, também conhecido como **Runtime**

- No C# o *runtime* é chamado de **CLR ou CLR Runtime** [^1]

- É ele responsável por gerenciar a memória, segurança, entre outros recursos básicos (não sendo necessário que nos preocupemos com isso)

## Compilação e Gerenciamento

- Como a Microsoft possui outras linguagens (e todas suportam o .Net), a manutenção seria muito complicada se cada linguagem tivesse seu gerenciador

- Por isso, como solução, a Microsoft criou um ecossistema em que cada linguagem tem seu compilador, só que a compilação inicial não gera o código final(o código binário). 

- Para que se tenha apenas um compilador final, a Microsoft criou a  *Intermediate Language(IL)* [^2]. Quando as linguagens com seus compiladores fazem a primeira compilação, elas traduzem para essa linguagem intermediária e essa *IL* será compilada (pelo compilador final) para o código binário 
  
  - **_Intermediate Language (IL)_**
    
    - o gerenciamento, a alocação e a execução de instruções do processador são iguais
    
    - independente da linguagem, o resultado da compilação do IL é sempre o mesmo
    
    - A conversão do ***IL*** para **binário** é conhecido como **JIT** [^3]

- Por causa disso, apenas um gerenciador é necessário e podemos ter outras linguagens dentro de um mesmo projeto, nunca no mesmo arquivo (por exemplo, C# e VB.Net(Visual Basic))

### Notas de Rodapé

[^1]: CLR: é a sigla para **Common Language Runtime** ou Gerenciador de Linguagem comum

[^2]: IL: sigla para *Intermediate Language* ou linguagem intermediária

[^3]: JIT: sigla para **Just In Time**
