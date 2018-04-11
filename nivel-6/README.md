{% include niveis.md %}

# Classes e objetos

Para atingirmos uma boa organização de códigos recorremos à programação orientada a objetos.

Utilizamos classes com propriedades e métodos para agrupar coisa relacionadas.

---

## [Classes](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/classes)

Classes permitem a criação de tipos de objetos customizados.

```csharp
public class Pessoa
{
    //Fields, properties, methods and events go here...
}
```

## Declarando Classes

Dentro de uma classe agrupamos propridades relacionadas

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
```

## Criação de objetos

Classes, não estáticas, podem ser utilizadas como objetos ou instâncias através da palavra reservada `new`.

Com isso temos uma variável de [referência]({{ '/nivel-2' | relative_url }})

```csharp
Pessoa pessoa = new Pessoa();
```

Para acessarmos propriedades ou métodos de um objeto devemos utilizar `.`

```csharp
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Matheus"; // setando uma propriedade
Console.WriteLine(pessoa.Nome); // acessando uma propriedade

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Fulano"; // setando uma propriedade
Console.WriteLine(pessoa2.Nome); // acessando uma propriedade
```

{% include niveis.6.md %}