{% include niveis.md %}

# Variáveis

Como funcionam as variáveis em C#

## Melhorando a aplicação

Vamos trabalhar com um programa gerenciador de uma casa de shows.

Para isso iremos:

* Iremos solicitar o nome da banda
* Número de integrantes
* De posse dessas informações iremos anunciar a banda

### Set

Utilizaremos variáveis para armazenar as informações em memória, para futuramente utilizar

O nome da banda iremos armazenar em uma variável chamada `nome`

O número de integrantes iremos armazenar em uma variável chamada `numeroMembros`

### Get

Para anunciar a banda iremos necessitar buscar as informações salvar nas variáveis `nome` e `numeroMembros`

## Codificação

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");

    Console.WriteLine("Quantos integrantes ela possui?");

    Console.WriteLine("<nome> possui <numeroMembros> membros.");
}
```

## Declarando Variáveis

Para que possamos utilizar uma variável devemos declará-la.

> Padrões
> Variáveis em C# seguem o padrão [CamelCase](https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/capitalization-conventions)

No código abaixo temos o tipo de dado e o nome da variável.

```csharp
string nome;
```

Para atribuirmos (set) um valor utilizamos o operador `=`.

O que está à direita será armazenado na variável à esquerda.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();

    Console.WriteLine("Quantos integrantes ela possui?");
    int numeroMembros = Console.ReadLine();

    Console.WriteLine(nome + " possui <numeroMembros> membros.");
}
```

## Tipos de Dados

Atualmente temos 15 tipos de dados no C#

No momento nos interessa apenas os tipos

* `string`
> Sequência de caracteres `"Matheus", "Costa", "Vieira"`
* `int`
> Números inteiros, positivos e negativos `-100,985,2,-459`
* `bool`
> Valores verdadeiros e falsos `true, false` (sempre minúsculas)

É possível converter `string` em `int`, porém isso não ocorre automaticamente

Para isso devemos utilizar o método `int.Parse`

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();

    Console.WriteLine("Quantos integrantes ela possui?");
    int numeroMembros = int.Parse(Console.ReadLine());

    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
}
```

Executando nossa aplicação temos:

```bash
dotnet run
```

Saída

```bash
Qual o nome da sua banda?

```

Informe o nome da banda

```bash
Metallica
```

Saída

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
```

Informe o número de integrantes da banda

```bash
4
```

Saída

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
4
Metallica possui 4 membros.
```

---

## Recapitulando

Variáveis são utilizadas para armazenar valores para o uso posterior

* Chamamos de SET quando armazenamos valores em uma variável
  * Para `setar` uma valor utilizamos `=` seguido do valor desejado
* Chamamos de GET quando lemos o valor de uma variável
  * Pegamos o valor utilizando apenas o nome da variável
* Nem todos os tipo de dados podem ser convertidos implicitamente, para isso temos métodos `Parse`

{% include niveis.md %}