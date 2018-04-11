{% include niveis.md %}

# [Propriedades](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties)

Uma propriedade, em C#, combina [campos](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/fields) e [métodos](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods).

Segundo a definição na própria documentação da Microsoft

>
> Uma propriedade é um membro que oferece um mecanismo flexível para
> ler, gravar ou calcular o valor de um campo particular.
>
> As propriedades podem ser usadas como se fossem membros de dados públicos,
> mas na verdade elas são métodos realmente especiais chamados acessadores.
>
> Isso permite que os dados sejam acessados facilmente
> e ainda ajuda a promover a segurança e a flexibilidade dos métodos.
>

Para o usuário de um objeto a propriedade é utilizada como uma campo/variável.

```csharp
Funcionario funcionario = new Funcionario();
funcionario.Nome = "Fulano";
```

# Adicionando propriedades

Existem diversas maneiras de declararmos propriedades em uma classe C#.

Propriedade sucinta

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
```

Propriedade completa

```csharp
public class Pessoa
{
    private string nome; // campo nome
    public string Nome   // propriedade Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }
}
```

Em versões mais antigas da linguagem, inicializávamos os campos com algum valor padrão

```csharp
public class Pessoa
{
    private string nome = "Sem nome";
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
```

A partir da versão 6 do C#, a inicialização de uma propriedade foi facilitada

```csharp
public class Pessoa
{
    public string Nome { get; set; } = "Sem nome";
}
```

{% include niveis.6.md %}