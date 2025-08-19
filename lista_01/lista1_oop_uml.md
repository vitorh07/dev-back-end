![senai_logo](https://transparencia.sp.senai.br/Content/img/logo-senai.png)

# Exercícios de aula 01: POO + UML (parte 1)

Profº.: Cainã Antunes Silva  
Faculdade de Tecnologia **SENAI Sorocaba**  
Tecnólogo em Análise e Desenvolvimento de Sistemas (ADS)
___


> O objetivo desta aula é exercitar a habilidade de abstrair objetos em classes utilizando-se notações em UML.  

O paradigma de desenvolvimento de software intitulado Programação Orientada à Objetos é uma ferramenta poderosa que auxilia na construção de sistemas complexos. A abstração é um recurso indispensável para programadores que almejam dominar esta poderosa técnica de programação. Além disso o uso de diagramas UML é indispensavel para representar estas abstrações e guiar os desenvolvidores na hora da implementação.

Para mais informações acesse [Aula 01: Paradigma POO.](https://cainaantunes.notion.site/Aula-01-Paradigma-POO-23fbde521b3b80149a11f08e9d1eac02?source=copy_link)

***

1. **Carro:**<br>
Pense em um carro do cotidiano. Como ele pode ser descrito em termos de informação e comportamento?
Crie um diagrama de classe UML que represente essa entidade.

    ```mermaid
        classDiagram
        class Carro {
            -Cor: string
            -Velocidade: int
            +Acelerar(incremento: int): void
            +Frear(decremento: int): void
        }
    ```
   
2. **Cachorro:**<br>
Um cachorro de estimação pode ser identificado de várias formas e interagir com o ambiente. <br>
Represente essa ideia por meio de uma classe UML com atributos e métodos que façam sentido.

    ```mermaid
        classDiagram
        class Cachorro {
            -PosX: int
            -PosY: int
            -Sprite: Image
            -Raca: string
            -Cor: string
            +Andar(incX: int, direcao: string, sprite: Image): void
            +Sentar(tempo: int, sprite: Image): void
            +Pular(incY: int, sprite: image): void
        }
    ```

3. **Jogador de Videogame:**<br>
Considere um personagem controlado por um jogador em um jogo eletrônico. Quais informações podem ser armazenadas sobre ele? Que ações ele pode realizar?<br>
Modele uma classe que represente esse jogador.

    ```mermaid
        classDiagram
        class Personagem {
            -Nome: string
            -Vida: int
            -Velocidade: int
            -Armadura: int
            -Arma: string
            -Municao: int
            -PosX: int
            -PosY: int
            +Andar(incX: int, direcao: string, velocidade: int): void
            +Correr(incX: int, direcao: string, velocidade: int): void
            +Atirar(decMunicao: int, direcao: string): void
        }
    ```

4. **Produto de Loja:**<br>
Imagine um produto exposto em uma loja, seja física ou virtual. Quais dados são importantes para representá-lo? Que tipo de operações podem ser feitas sobre ele?<br>
Crie uma classe UML com base nessas reflexões.

    ```mermaid
        classDiagram
        class Produto {
            -Id: int
            -Nome: string
            -Descricao: string
            -Preco: double
            -Estoque: int
            +Vender(qtd: int): bool
            +Repor(qtd: int): bool
            +Criar(id: int, nome: string, descricao: string, preco: double, estoque: int): bool
            +Ler(id: int): string
            +Atualizar(nome: string, descricao: string, preco: double, estoque: int): bool
            +Deletar(id: int): bool
        }
    ```

5. **Livro:**<br>
Pense em como você descreveria um livro para um sistema digital (como uma biblioteca ou livraria online).
Quais dados o sistema precisaria guardar sobre esse livro? Que ações poderiam ser realizadas com ele?

    ```mermaid
        classDiagram
        class Livro {
            -Id: int
            -Titulo: string
            -Autor: string
            -Genero: string
            +Pesquisar(titulo: string, autor: string): Livro
            +Filtrar(genero: string): Livro
            +Emprestar(id: int, data: DateTime): DateTime
            +Renovar(id: int, data: DateTime): DateTime
        }
    ```

6. **Conta Bancária:**<br>
Considere como um sistema bancário representa uma conta de um cliente. Quais dados são essenciais? Que operações a conta deve suportar?<br>
Modele isso como uma classe UML.

    ```mermaid
        classDiagram
        class Conta {
            -Numero: int
            -Dono: string
            -Senha: double
            -Saldo: string
            +Transferir(number: int, valor: double): bool
            +Depositar(number: int, valor: double): bool
            +Sacar(valor: double: senha: string): bool
        }
    ```

7. **Usuário de Sistema:**<br>
Um sistema informatizado permite que pessoas se cadastrem, acessem recursos e atualizem suas informações.<br>
Crie uma classe que represente esse "usuário" de forma genérica, com seus atributos e comportamentos.

    ```mermaid
        classDiagram
        class Usuario {
            -Username: string
            -Email: string
            -Senha: string
            +Create(username: sring, email: string: senha: string): bool
            +Update(username: string, email: string): bool
            +Login(username: string: senha: string): bool
            +Logout(): bool
        }
    ```

8. **Pedido de Compra:**<br>
Em um sistema de compras online ou presencial, como um pedido de compra pode ser estruturado em uma classe?<br>
Pense em quais informações estão envolvidas em um pedido e quais ações podem ser realizadas com ele.

    ```mermaid
        classDiagram
        class Pedido {
            -Id: int
            -Produtos: []Produto
            -Data: DateTime
            -Valor: double
            +AdicionarItem(produto: Produto, qtt: int): bool
            +RemoverItem(idProduto: int): bool
            +CalcularTotal(): double
            +Desconto(code: string): double
        }
    ```

9. **Sessão de Login:**<br>
Quando um usuário entra em um sistema, uma sessão é iniciada. Como essa sessão poderia ser representada em uma classe?<br>
Reflita sobre os dados e comportamentos necessários para modelar esse conceito.

    ```mermaid
        classDiagram
        class Login {
            -Token: string
            -Time: DateTime
            -Status: bool
            +Start(time: DateTime): void
            +End(): void
        }
    ```

10. **Repositório Git:**<br>
Pense em como um sistema como o GitHub representa um repositório de código. Quais dados ele precisa manter? Que ações podem ser realizadas sobre ele?<br>
Modele esse objeto como uma classe UML.

    ```mermaid
        classDiagram
        class Repositorio {
            -Nome: string
            -Url: string
            -Dono: Usuario
            -Colaborador: Usuario
            -File: Object
            +CRUD(): -
            +CreateBranch(name: string): bool
            +Commit(m: string): bool
            +Push(url: string): bool
            +Pull(url: string): bool
        }
    ```

