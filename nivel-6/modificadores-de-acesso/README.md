{% include niveis.md %}

# [Modificadores de acesso](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)

Formas de acesso ao código de uma classe, por padrão o modificador utilizado, se não informado é o `private`.

>
> ## Definição da documentação Microsoft
>
> Todos os tipos e membros de tipo têm um nível de acessibilidade,
> que controla se podem ser usados de outro código no seu assembly ou outros assemblies.
>
> Você pode usar os modificadores de acesso a seguir para especificar
> a acessibilidade de um tipo ou membro quando você o declarar:
>
> * [public](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/public)
> * [private](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/private)
> * [protected](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/protected)
> * [internal](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/internal)
> * [protected internal](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/protected-internal)
> * [private protected](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/private-protected)

## Público

O modificador de acesso `public` dá acesso total ao membro, mesmo fora do seu contexto.

O acesso não é restrito.

```csharp
class MinhaClasse
{
    public int x; // sem restrição de acesso
}
```

## Privado

O modificador de acesso `private` restringe o acesso ao seu contexto apenas.

O acesso é limitado ao tipo recipiente.

```csharp
class MinhaClasse
{
    public int x;  // sem restrição de acesso
    private int y; // somente pode ser utilizado dentro da classe MinhaClasse
    double z;      // somente pode ser utilizado dentro da classe MinhaClasse
}
```

## Protegido

O modificador de acesso `protected` restringe o acesso ao seu contexto e de classes derivadas (herança)

O acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.

```csharp
class MinhaClasse
{
    public int x;       // sem restrição de acesso
    private int y;      // somente pode ser utilizado dentro da classe MinhaClasse
    double z;           // somente pode ser utilizado dentro da classe MinhaClasse
    protected string w; // somente pode ser utilizado dentro da classe MinhaClasse e classes derivadas
}
```

```csharp
class A
{
    protected int x = 123;
}

class B : A
{
    static void Main()
    {
        A a = new A();
        B b = new B();

        // Error CS1540
        // X somente pode ser acessado
        //  por classes derivadas de A
        // a.x = 10;

        // Como essa classe deriva de A
        // então o acesso é permitido
        b.x = 10;
    }
}
```

## Interno

O modificador de acesso `internal` somente é acessível no mesmo assembly

```csharp
class MinhaClasse
{
    public int x;       // sem restrição de acesso
    private int y;      // somente pode ser utilizado dentro da classe MinhaClasse
    double z;           // somente pode ser utilizado dentro da classe MinhaClasse
    protected string w; // somente pode ser utilizado dentro da classe MinhaClasse e classes derivadas
    internal string a;  // somente dentro da dll gerada
}
```

## Protegido Interno

O modificador de acesso `protected internal` somente é acessível no mesmo assembly, porém o `protected` dá acesso às classes derivadas

```csharp
// Assembly1.cs
namespace Assembly1
{
    class ClasseBase
    {
        protected internal string nome;  // somente dentro da dll gerada
    }
    class Program
    {
        static Main(string[] args)
        {
            ClasseBase classeBase = new ClasseBase();
            Console.WriteLine(classeBase.nome);
        }
    }
}
```

```csharp
using Assembly1;
class ClasseDerivada : ClasseBase
{
}
class Program
{
    static Main(string[] args)
    {
        ClasseBase classeBase = new ClasseBase();
        ClasseDerivada classeDerivada = new ClasseDerivada();

        // Error CS1540
        // o acesso somente pode ser feito por heranças
        // classeBase.nome = 10;

        // Por herdar não há problemas
        classeDerivada.nome = 10;
    }
}
```

## Privado Interno

O modificador de acesso `private internal` somente é acessível no mesmo assembly.

```csharp
// Assembly1.cs
// Compile with: /target:library
public class ClasseBase
{
    private protected int valor = 0;
}

public class ClasseDerivada : BaseClass
{
    void Access()
    {
        BaseClass baseObject = new BaseClass();

        // Error CS1540, somente utilizado em classes derivadas.
        // baseObject.valor = 5;

        // Sem problemas já que é uma herança
        valor = 5;
    }
}
```

```csharp
 // Assembly2.cs
 // Compile with: /reference:Assembly1.dll
 class ClasseDerivada2 : BaseClass
 {
     void Access()
     {
         // Error CS0122, somente em classes derivadas dentro do mesmo assembly
         // valor = 10;
     }
 }
```

{% include niveis.6.md %}