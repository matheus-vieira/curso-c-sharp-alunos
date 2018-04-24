# interfaces

1. Defina uma interface para padronizar as assinaturas dos métodos das contas do banco.

arquivo `IConta.cs`

```csharp
//  prefixo I para  seguir a convenção
interface  IConta
{
  void  Deposita(double  valor);
  void  Saca(double  valor);
  double  Saldo { get; set; }
}
```

2. Agora, crie algumas classes para modelar tipos diferentes de conta.

arquivo `ContaCorrente.cs`

```csharp
class  ContaCorrente : IConta
{
  public  double  Saldo { get; set; }
  private  double  taxaPorOperacao = 0.45;
  public  void  Deposita(double  valor)
  {
    this.Saldo  +=  valor  - this.taxaPorOperacao;
  }
  public  void  Saca(double  valor)
  {
    this.Saldo  -= valor + this.taxaPorOperacao;
  }
}
```

arquivo `ContaPoupanca.cs`

```csharp
class  ContaPoupanca : IConta
{
    public  double  Saldo { get; set; }

    public  void  Deposita(double  valor)
    {
        this.Saldo  +=  valor;
    }

    public  void  Saca(double  valor)
    {
        this.Saldo  -= valor;
    }
}
```

3. Faça um teste simples com as classes criadas anteriormente.

arquivo `Program.cs`

```csharp
class  Program
{
    static  void  Main()
    {
        ContaCorrente  c1 = new  ContaCorrente ();
        ContaPoupanca  c2 = new  ContaPoupanca ();
        c1.Deposita (500);
        c2.Deposita (500);
        c1.Saca (100);
        c2.Saca (100);
        System.Console.WriteLine(c1.Saldo);
        System.Console.WriteLine(c2.Saldo);
    }
}
```

Teste o que foi feito!

4. Altere a assinatura do método `Deposita` na classe `ContaCorrente`. Você pode acrescentar um “r” no nome do método. O que acontece?
Obs: desfaça a alteração depois deste exercício

5. Crie um gerador de extratos com um método que pode trabalhar com todos os tipos de conta.

arquivo `GeradorDeExtrato.cs`

```csharp
class  GeradorDeExtrato
{
    public  void  GeraExtrato(IConta c)
    {
        System.Console.WriteLine("EXTRATO");
        System.Console.WriteLine("SALDO: " + c.Saldo);
    }
}
```

6. Teste o gerador de extrato. Crie uma classe chamada `TestaGeradorDeExtrato`
para isso.

arquivo `TestaGeradorDeExtrato.cs`
```csharp
class  TestaGeradorDeExtrato
{
    static  void  Main()
    {
        ContaCorrente  c1 = new  ContaCorrente ();
        ContaPoupanca  c2 = new  ContaPoupanca ();
        c1.Deposita (500);
        c2.Deposita (500);
        GeradorDeExtrato g = new  GeradorDeExtrato ();
        g.GeraExtrato(c1);
        g.GeraExtrato(c2);
    }
}
```
