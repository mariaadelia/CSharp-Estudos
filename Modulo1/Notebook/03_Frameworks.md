##### <u>27/05/2022, 31/05/2022 e 09/06/2022</u>

# BaltaIO - Frameworks

## Framework

- *Framework* é uma estrutura, um alicerce. É um **conjunto de bibliotecas** que usamos como base para construir nossas aplicações (para que não seja necessário fazermos tudo do 0)

- ### .NET Framework
    - C# é a linguagem e o .Net(dot net) é o framework
    - Compatível somente com **_Windows_**
    - É considerado _legado_[^1]

- ### .NET Core
    - Versão mais atual do .Net Framework
    - Suporta diferentes sistemas operacionais como Linux e Mac
    - A recomendação atual da Microsoft é o _.Net Core_
    - Versão 3.1 será usada no curso, mas pode instalar as outras versões[^2]

- ### .NET Standard
    - Garante que tudo que for escrito rode tanto em _.NET Framework_ quanto em _.NET Core_ (já que há projetos que podem ter os dois juntos e pode ser que há coisas que funcionem em um, mas não no outro)
    - Ele **_NÃO É um Framework_**, é apenas um _contrato_ (Surface API) que garante que tudo que escrevemos será compatível com ambos os frameworks
    - É uma "biblioteca" meio que entre os frameworks e as commons infastructures ("_one library to rule them all(**framewors**)_")

- ### .NET 5
    - Unificação do _.NET Core_ e do _.NET Framework_
    - Agora, não terá mais o .NET Core nem o .NET Framework, será .NET 5, .NET 6, .NET 7, etc.

- ### Lançamentos
    - _.Net Core_
        - Eram lançamentos **semestrais**
        - Versões com finais **1** são LTS[^2], ex: 2.1, 3.1, etc.
    - _.Net 5 e futuros_
        - Lançamentos **anuais**
    
- ## Versionamento de Software

    - É uma versão semântica, ela é dividida em fases:

        - Alpha
            - bem longe da versão final, é um esboço
            - normalmente essa versão tem a _Major_ menor que 1

        - Beta
            - um pouco mais próxima da versão final, uma versão de testes
            - normalmente essa versão tem a _Major_ menor que 1

        - Release Candidate
            - versão candidata para ser a versão final (com bugs corrigidos, etc)

        - Final
            - versão final da aplicação

    - É dividido também em três fases (que são separadas pelo ponto ao falar de uma versão):

        - **Major.Minor.Patch** - (pode ter tbm)a/b/rc/f Numero (aqui estanis falando da versão semântica)
        - ex: **15.8.2** / **1.0.2 - rc1**

            - Major
                - significa que mudou a versão maior da sua aplicação;
                - pode conter incompatibilidade com versões anteriores ( _Breaking Changes_ ).

            - Minor
                - mudanças que são menores da aplicação;
                - é compatível com versões anteriores ( _Backward Compatibility_ ).

            - Patch
                - é uma correção de bugs e outros itens simples.

## Runtime e SDK

### Runtime

- Necessário para executar aplicações

- São divididos em 3 (C#):
    - ASP .NET para aplicações Web
    - Desktop para aplicações Desktop
    - .NET Core para qualquer outra aplicação:
        - Console, Batch, Serviço
        - Não possui uma interface, por exemplo
- Possui versões e a versão tem que ser compatível com a versão utilizada durante a codificação

- Apenas executa as aplicações (.exe/.dll), é usado somente para fazer a distribuição delas

- O tamanho é menor, otimizado para execução

### SDK

- Software Development Kit (SDK), é um kit para o desenvolvimento de software

- Possui tudo que é necessário para criar as aplicações e já vem com o _Runtime_ integrado

    - Podemos instalar o _runtime_ **sem** o SDK, mas **não podemos** instalar o SDK sem o _runtime_

- É maior que o _runtime_ e em produção mandamos/instalamos apenas o _runtime_





### Notas de Rodapé

[^1]: legado: softwares com um pouco mais de idade, que não conversam bem com novos recurso, arquiteturas, etc. É uma infraestrutura digital que foi construído sem uma arquitetura definida e passou por algumas etapas de crescimento sem muito planejamento.
[^2]: versões (lançamentos, releases): quando utilizando uma versão de software, buscar as versões **LTS (Long-term support)** que tem um período de suporte mais longo que o normal. É sempre melhor utilizar as versões LTS para produção
