# Perguntinhas

Alguns exercícios

> Para executar um programa console com parâmetros utilize
>
> ```dotnet run "Blood Rock Bar" "4"```

## Utilizando as condições

Crie uma condição if que irá anunciar no console quando o método `TryParse` retornar `true`

Use `int.TryParse` para setar o valor argumentoBanda.

Crie uma condição `else` com o seguinte text `"Não conseguimos determinar o número de bandas que se apresentarão nessa noite, por favor tente novamente."`

```csharp
using System;

public class Program
{
    static void Main(string[] args)
    {
        string local = args[0];
        string argumentoBanda = args[1];
        int bandas;
        // Crie a condição if...

        Console.WriteLine(local + " terá " + bandas + " bandas se apresentando esta noite!");

        // Crie também a condição else...

    }
}
```

## Utilizando séries de condições

Caso o usuário informe `0` mostre a mensagem `"Não haverá apresentações nessa noite."`
Caso o usuário informe `1` mostre a mensagem `"Teremos um show incrível nessa noite!"`
Caso não seja nenhuma condição acima mostre a mensagem `"Teremos várias bandas incríveis nessa noite!"`