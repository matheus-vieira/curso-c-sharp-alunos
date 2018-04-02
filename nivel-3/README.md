# Condicionais

Como funcionam as condicionais em C#

## Tratando Entradas Inválidas

Supondo que nosso incrível usuário, com toda sua maestria executa nossa aplicação e faz isso

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
Quatro
```

Saída

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
Quatro

Unhandled Exception: System.FormatException: Input string was not in a correct format.
   at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   at AppCSharp.Program.Main(String[] args) in /path/to/AppCSharp/Program.cs:line 13
```

O sistema estava esperando um número não uma string!!!

```chsarp
...
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();
    Console.WriteLine("Quantos integrantes ela possui?");
    // Exceção ocorreu nesse ponto
    int numeroMembros = int.Parse(Console.ReadLine());
    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
}
...
```

Para resolver podemos utilizar o método `int.TryParse()`, da seguinte forma

```chsarp
...
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();
    Console.WriteLine("Quantos integrantes ela possui?");
    int numeroMembros = 0;
    int.TryParse(Console.ReadLine(), out numeroMembros);
    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
}
...
```

Nesse momento queremos mudar o comportamento da aplicação caseo não consiga realizar a conversão

Para o nosso exemplo podemos utilizar o comando condicional `if`

```csharp
if (pronto)
{
    FaçaCasoTrue();
}

ExecuteSempre();
```

No caso da variável `pronto` esteja com o valor `true` teremos a seguinte execução

```csharp
FaçaCasoTrue();
ExecuteSempre();
```

No caso da variável `pronto` esteja com o valor `false` teremos a seguinte execução

```csharp
ExecuteSempre();
```

Já que nosso método `int.TryParse` retorna um `bool` podemos escrever dessa forma

```chsarp
...
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();
    Console.WriteLine("Quantos integrantes ela possui?");
    int numeroMembros = 0;
    if (int.TryParse(Console.ReadLine(), out numeroMembros))
    {

    }
    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
}
...
```

Para, talvez, termos um código mais claro podemos inverter o valor do retorno do método `int.TryParse()`

```chsarp
...
static void Main(string[] args)
{
    Console.WriteLine("Qual o nome da sua banda?");
    string nome = Console.ReadLine();
    Console.WriteLine("Quantos integrantes ela possui?");
    int numeroMembros = 0;
    if (!int.TryParse(Console.ReadLine(), out numeroMembros))
    {
        Console.WriteLine("Entrada não é válida");
        // O zero indica que a aplicação finalizará tendo sida executada com sucesso
        Environment.Exit(0);
    }
    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
}
...
```

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
Quatro
```

Saída

```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
Quatro
Entrada não é válida
```

## Expressões

Muitas vezes precisamos realizar comparações.

* Igualdade entre duas variáveis.
* Desigualdade entre duas variáveis.
* Se uma variável é maior ou menor que outra.

### Exemplos

Temos apenas um membro na banda?

```csharp
numeroMembros = 1;
numeroMembros == 1 // return true
```

Temos algum membro na banda?

```csharp
numeroMembros = 0;
numeroMembros > 0 // return true
```

A banda não é o Metallica?

```csharp
nome = "Megadeth";
nome != "Metallica" // return true
```

## Else

Quando queremos tratar o valor contrário da nossa condição utilizamos o bloco de código chamado `else`

```csharp
if (pronto)
{
    FaçaSeTrue();
}
else
{
    FaçaSeFalse();
}
```

## Else If

Quando queremos tratar diversas condições utilizamos o bloco de código chamado `else if`

```csharp
if (pronto)
{
    FaçaSeTrue();
}
else if (nome == "Metallica")
{
    FaçaSeFalseBandaMetallica();
}
else
{
    FaçaSeFalseBandaNaoMetallica();
}
```

Utilizando as condições podemos declarar o tipo de banda que irá se apresentar

> Quando temos apenas um comando os parênteses são desnecessários, porém recomendo sempre utilizar

```csharp
...
int numeroMembros = 0;
int.TryParse(Console.ReadLine(), out numeroMembros);

if (numeroMembros < 1)
{
    Console.WriteLine("A banda tem que ser composta por pelo menos 1 membro");
    Environment.Exit(0);
}
else if (numeroMembros == 1)
    Console.WriteLine(nome + " é uma monobanda :D");
else if (numeroMembros == 2)
    Console.WriteLine(nome + " é uma dupla");
else
    Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
...
```

## Executando a aplicação

Nossa aplicação está um pouco mais inteligente.

Adicionamos duas funcionalidades:

* Mostramos o tipo de banda (monobanda, dupla), baseado na quantidade de membros
* Tratamos entrada errada do usuário


```bash
Qual o nome da sua banda?
Metallica
Quantos integrantes ela possui?
4
Metallica possui 4 membros.
```

```bash
Qual o nome da sua banda?
The White Stripes
Quantos integrantes ela possui?
2
The White Stripes é uma dupla
```

```bash
Qual o nome da sua banda?
Rob Zombie
Quantos integrantes ela possui?
1
Rob Zombie é uma monobanda :D
```

---

## Recapitulando

Utilizando condições e expressões conseguimos mudar o fluxo de execução

> ### if
> O bloco de código `if` somente é executado se a condição for `true`
>
> ### else
> O bloco de código `else` somente é executado se a condição o bloco `if` for `false`
>
> ### expressões
> * `==` esquerda é igual à direita
>   * `1 == 1`
> * `!=` esquerda é diferente à direita
>   * `1 != 2`
> * `!` inverte o valor da expressão
>   * `!false`

[Página Inicial](/curso-c-sharp-alunos/)

[Nível 1](/curso-c-sharp-alunos/nivel-1/)

[Nível 2](/curso-c-sharp-alunos/nivel-2/)