{% include niveis.md %}

# [Métodos](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods)

Métodos são sequencias de comandos.

>
> ## Definição da documentação Microsoft
>
> Um método é um bloco de código que contém uma série de instruções.
>
> Um programa faz com que as instruções sejam executadas chamando o método
> e especificando os argumentos de método necessários.
>
> No C#, todas as instruções executadas são realizadas no contexto de um método.
>
> O método Main é o ponto de entrada para todos os aplicativos C#
> e é chamado pelo CLR (Common Language Runtime) quando o programa é iniciado.
>

Todos os métodos são compostos por

* Modificador de acesso
* Tipo de retorno
* Nome do método
* Parâmetros (opicional e separado por vírgula)
* Corpo do método

```csharp
<modificador de acess> <tipo de retorno> <nome do método>(<lista de parâmetros>)
{
    <corpo do método>
}
```

```csharp
public class Funcionario : Pessoa
{
    // código existente

    public void MudaSalario(float novoSalario)
    {
        Salario = novoSalario;
    }
}
```

## Acessando métodos

Acessamos da mesma forma que é feita com o as propriedades, ou seja, utilizando o `.`

```csharp
Funcionario funcionario = new Funcionario();
funcionario.MudaSalario(2125,66);
```

## Assinatura

Estão entre os parênteses e são separados por vírgula. Caso não haja parametros veremos `()`

```csharp
public void MudaSalario(float novoSalario)
{
    Salario = novoSalario;
}
public void MudaSalario(float novoSalario, float percentual)
{
    Salario = novoSalario;
    Salario += Salario * percentual;
}
```

Os métodos acima possuem as assinaturas

```csharp
void MudaSalario(float)
void MudaSalario(float, float)
```

Em outras palavras, mudando o nome dos parâmetros não temos diferentes assinaturas

{% include niveis.6.md %}