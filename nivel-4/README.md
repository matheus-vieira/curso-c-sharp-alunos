# Solution

Como criar projetos e soluções com a interface de linha de comando [CLI](https://docs.microsoft.com/pt-br/dotnet/core/tools/?tabs=netcore2x)

---

## Criando a solução

Para criar qualquer projetos devemos utilizar o comando [dotnet new][https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-new?tabs=netcore2x] com mais alguns parâmetros

```bash
dotnet new
```

### Sintaxe

```bash
dotnet new <TEMPLATE> [--force] [-i|--install] [-lang|--language] [-n|--name] [-o|--output] [-u|--uninstall] [Template options]
dotnet new <TEMPLATE> [-l|--list] [--type]
```

Para um detalhamento utilize

```bash
dotnet new -h
```
```bash
dotnet new --help
```

Saída

```
Usage: new [options]

Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Specifies the language of the template to create.


Templates                                         Short Name       Language          Tags
--------------------------------------------------------------------------------------------------------
Console Application                               console          [C#], F#, VB      Common/Console
Class library                                     classlib         [C#], F#, VB      Common/Library
Unit Test Project                                 mstest           [C#], F#, VB      Test/MSTest
xUnit Test Project                                xunit            [C#], F#, VB      Test/xUnit
ASP.NET Core Empty                                web              [C#], F#          Web/Empty
ASP.NET Core Web App (Model-View-Controller)      mvc              [C#], F#          Web/MVC
ASP.NET Core Web App                              razor            [C#]              Web/MVC/Razor Pages
ASP.NET Core with Angular                         angular          [C#]              Web/MVC/SPA
ASP.NET Core with React.js                        react            [C#]              Web/MVC/SPA
ASP.NET Core with React.js and Redux              reactredux       [C#]              Web/MVC/SPA
ASP.NET Core Web API                              webapi           [C#], F#          Web/WebAPI
global.json file                                  globaljson                         Config
NuGet Config                                      nugetconfig                        Config
Web Config                                        webconfig                          Config
Solution File                                     sln                                Solution
Razor Page                                        page                               Web/ASP.NET
MVC ViewImports                                   viewimports                        Web/ASP.NET
MVC ViewStart                                     viewstart                          Web/ASP.NET


Examples:
    dotnet new mvc --auth Individual
    dotnet new viewstart
    dotnet new --help
```

## Solução

Serve para agrupar projetos de mesmo objetivo

Ex.:

```bash
E-Commerce/
├── DAL
│   ├── Class1.cs
│   ├── DAL.csproj
├── Models
│   ├── Class1.cs
│   ├── Models.csproj
├── Servico
│   ├── Program.cs
│   └── Servico.csproj
└── Web
    ├── appsettings.Development.json
    ├── appsettings.json
    ├── bundleconfig.json
    ├── Controllers
    │   └── HomeController.cs
    ├── Models
    │   └── ErrorViewModel.cs
    ├── Program.cs
    ├── Startup.cs
    ├── Views
    │   ├── Home
    │   │   ├── About.cshtml
    │   │   ├── Contact.cshtml
    │   │   └── Index.cshtml
    │   ├── Shared
    │   │   ├── Error.cshtml
    │   │   ├── _Layout.cshtml
    │   │   └── _ValidationScriptsPartial.cshtml
    │   ├── _ViewImports.cshtml
    │   └── _ViewStart.cshtml
    ├── Web.csproj
    └── wwwroot
        ├── css
        │   ├── site.css
        │   └── site.min.css
        ├── favicon.ico
        ├── images
        │   ├── banner1.svg
        │   ├── banner2.svg
        │   ├── banner3.svg
        │   └── banner4.svg
        ├── js
        │   ├── site.js
        │   └── site.min.js
        └── lib
            ├── bootstrap
            │   ├── dist
            │   │   ├── css
            │   │   │   ├── bootstrap.css
            │   │   │   ├── bootstrap.css.map
            │   │   │   ├── bootstrap.min.css
            │   │   │   ├── bootstrap.min.css.map
            │   │   │   ├── bootstrap-theme.css
            │   │   │   ├── bootstrap-theme.css.map
            │   │   │   ├── bootstrap-theme.min.css
            │   │   │   └── bootstrap-theme.min.css.map
            │   │   ├── fonts
            │   │   │   ├── glyphicons-halflings-regular.eot
            │   │   │   ├── glyphicons-halflings-regular.svg
            │   │   │   ├── glyphicons-halflings-regular.ttf
            │   │   │   ├── glyphicons-halflings-regular.woff
            │   │   │   └── glyphicons-halflings-regular.woff2
            │   │   └── js
            │   │       ├── bootstrap.js
            │   │       ├── bootstrap.min.js
            │   │       └── npm.js
            │   └── LICENSE
            ├── jquery
            │   ├── dist
            │   │   ├── jquery.js
            │   │   ├── jquery.min.js
            │   │   └── jquery.min.map
            │   └── LICENSE.txt
            ├── jquery-validation
            │   ├── dist
            │   │   ├── additional-methods.js
            │   │   ├── additional-methods.min.js
            │   │   ├── jquery.validate.js
            │   │   └── jquery.validate.min.js
            │   └── LICENSE.md
            └── jquery-validation-unobtrusive
                ├── jquery.validate.unobtrusive.js
                └── jquery.validate.unobtrusive.min.js
```


Para criar uma solution:

```bash
mkdir BotecoRockBar
cd BotecoRockBar
dotnet new sln
```

## Criação de projetos

Agora dentro da nossa solução vamos criar um projeto do tipo console

```bash
dotnet new console -o Anuncio
```

Saída

```
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on Anuncio/Anuncio.csproj...
  Restoring packages for /mnt/c/Users/opet/Documents/github/curso-c-sharp-alunos/nivel-4/so
urce/botecoRockBar/Anuncio/Anuncio.csproj...
  Generating MSBuild file /mnt/c/Users/opet/Documents/github/curso-c-sharp-alunos/nivel-4/s
ource/botecoRockBar/Anuncio/obj/Anuncio.csproj.nuget.g.props.
  Generating MSBuild file /mnt/c/Users/opet/Documents/github/curso-c-sharp-alunos/nivel-4/s
ource/botecoRockBar/Anuncio/obj/Anuncio.csproj.nuget.g.targets.
  Restore completed in 840.02 ms for /mnt/c/Users/opet/Documents/github/curso-c-sharp-aluno
s/nivel-4/source/botecoRockBar/Anuncio/Anuncio.csproj.


Restore succeeded.
```



## Recapitulando

Como criar projetos e soluções via [CLI](https://docs.microsoft.com/pt-br/dotnet/core/tools/?tabs=netcore2x)

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