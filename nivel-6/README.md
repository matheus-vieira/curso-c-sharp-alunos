{% include niveis.md %}

# Laços de Repetição

Quando precisamos repetir a execução de um bloco de código utilizamos laços de repetição

---

## [While](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/while)

O bloco de código é utilizado enquanto a condição da expressão for verdadeira (`true`)

> Sintaxe
>
> ```csharp
> while (<condição>)
> {
>    // código a ser repetido
> }
> ```

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine(++n + ": Hello World! ");
            }
        }
    }
}
```

Saída

```bash
1: Hello World!
2: Hello World!
3: Hello World!
4: Hello World!
5: Hello World!
6: Hello World!
7: Hello World!
8: Hello World!
9: Hello World!
10: Hello World!
```

> Incrementar
>
> n++
> utiliza a variável e depois incrementa em 1
>
> ```csharp
> int n = 0;
> while(n < 2)
> {
>     Console.WriteLine(n++ + ": Hello World");
> }
> ```
>
> Saída
> ```bash
> 0: Hello World!
> 1: Hello World!
> ```
>
> ++n
> incrementa a variável em 1 e utiliza o valor posteriormente
>
> ```csharp
> int n = 0;
> while(n < 2)
> {
>     Console.WriteLine(++n + ": Hello World");
> }
> ```
>
> Saída
> ```bash
> 1: Hello World!
> 2: Hello World!
> ```
>
> Decrementar
>
> n--
> utiliza a variável e depois decrementa em 1
>
> ```csharp
> int n = 2;
> while(n > 0)
> {
>     Console.WriteLine(n-- + ": Hello World");
> }
> ```
>
> Saída
> ```bash
> 2: Hello World!
> 1: Hello World!
> ```
>
> --n
> decrementa a variável em 1 e utiliza o valor posteriormente
>
> ```csharp
> int n = 2;
> while(n > 0)
> {
>     Console.WriteLine(--n + ": Hello World");
> }
> ```
>
> Saída
> ```bash
> 1: Hello World!
> 0: Hello World!
> ```

### Utilizando controle de fluxo

Mostrando valores pares

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            while (n < 10)
            {
                // somente mostra valores pares
                // onde o resto da divisão é zero
                if (n % 2 == 0)
                    Console.WriteLine(n + ": Hello World! ");
                n++;
            }
        }
    }
}
```

Saída

```bash
0: Hello World!
2: Hello World!
4: Hello World!
6: Hello World!
8: Hello World!
```

Mostrando valores ímpares

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            while (n < 10)
            {
                // somente mostra valores pares
                // onde o resto da divisão é zero
                if (n % 2 != 0)
                    Console.WriteLine(n + ": Hello World! ");
                n++;
            }
        }
    }
}
```

Saída

```bash
1: Hello World!
3: Hello World!
5: Hello World!
7: Hello World!
9: Hello World!
```

## [Do..While](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/do)

O bloco de código é executado e enquanto a condição da expressão for verdadeira (`true`) a execução é repetida

> Sintaxe
>
> ```csharp
> do
> {
>    // código a ser repetido
> } while (<condição>)
> ```

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            do
            {
                Console.WriteLine(++n + ": Hello World! ");
            } while (n < 10)
        }
    }
}
```

## [For](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/for)

Quando sabemos o número de vezes que precisamos executar a instrução `for` é a melhor opção

> Sintaxe
>
> ```csharp
> for (<inicializador>; <condição>; <iterador>)
> {
>    // código a ser repetido
> }
> ```

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n + ": Hello World! "); 
            }
        }
    }
}
```

## [foreach, in](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)

O bloco de instrução é repetido para cada elemento em uma lista. A lista utilizada deve implementar ou `System.Collections.IEnumerable` ou `System.Collections.Generic.IEnumerable<T>`

Ao utiliza a instrução `foreach` não devemos modificar a lista original, evitando assim problemas inesperados. Para modificar uma lista utilize `for`.

> Sintaxe
>
> ```csharp
> for (<inicializador>; <condição>; <iterador>)
> {
>    // código a ser repetido
> }
> ```

```csharp
using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n + ": Hello World! "); 
            }
        }
    }
}
```

## Recapitulando

Utilizando laços de repetição

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

{% include niveis.md %}