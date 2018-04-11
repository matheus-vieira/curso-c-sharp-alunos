{% include niveis.md %}

# Herança

Herança é quando uma classe herda todos os membros da classe base

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
public class Funcionario : Pessoa
{
    public string Cargo { get; set; }
    public float Salario { get; set; }
}
```

No exemplo acima todo objeto criado utilizando a classe `Funcionario` terá, além das sua próprias propriedades `Cargo` e `Salario`, temos acesso às propriedades `Nome`e `Idade`.

```csharp
Funcionario funcionario = new Funcionario();
funcionario.Nome = "Fulano";
funcionario.Idade = 21;
funcionario.Cargo = "Estagiário";
funcionario.Salario = 1958.36;
```

{% include niveis.6.md %}