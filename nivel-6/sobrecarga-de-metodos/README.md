{% include niveis.md %}

# [Sobrecarga de Métodos](https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/member-overloading)

Sobrecarga de métodos são métodos de mesmo nome porém com diferentes assinaturas

> ## Definição da documentação Microsoft
>
> Membro sobrecarga significa criar dois ou mais membros do mesmo tipo
> que diferem apenas o número ou tipo de parâmetros,
> mas que têm o mesmo nome.
>
> Por exemplo, em seguida, o WriteLine método está sobrecarregado:
>
> ```csharp
> public static class Console
> {
>     public void WriteLine();
>     public void WriteLine(string value);
>     public void WriteLine(bool value);
>     //...
> }
> ```
>
> Como somente métodos, construtores e propriedades indexadas podem ter parâmetros, somente os membros podem ser sobrecarregados.

## Fazer e não fazer

- [x] Tente usar nomes de parâmetro descritivo para indicar o padrão usado por sobrecargas mais curto.
- [ ] Evite arbitrariamente diversos nomes de parâmetro em sobrecargas. Se um parâmetro em uma sobrecarga representa a mesma entrada como um parâmetro em outra sobrecarga, os parâmetros devem ter o mesmo nome.
- [ ] Evite inconsistentes na ordem de parâmetros na sobrecarga membros. Parâmetros com o mesmo nome devem aparecer na mesma posição em todas as sobrecargas.
- [X] Fazer somente a maior sobrecarga virtual (se extensibilidade é necessária). Sobrecargas menores devem simplesmente chamar por meio de uma sobrecarga maior.
- [ ] Não usar ref ou out modificadores para sobrecarregar membros.
> Alguns idiomas não é possível resolver chamadas para sobrecargas assim. Além disso, essas sobrecargas geralmente tem semântica completamente diferente e provavelmente não devem ser sobrecargas mas dois métodos separados em vez disso.
- [ ] Não têm sobrecargas com parâmetros na mesma posição e tipos semelhantes, mas com semânticas diferentes.
- [x] Permitir null a serem passados para os argumentos opcionais.
- [x] Usar membro sobrecarga em vez de definir membros com argumentos padrão

{% include niveis.6.md %}