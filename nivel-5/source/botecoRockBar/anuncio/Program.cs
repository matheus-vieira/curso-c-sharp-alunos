using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            // var n = 0;
            
            // while (n < 10)
            // {
            //     Console.WriteLine(++n + ": Hello World! ");
            // }
            
            // // incrementar depois
            // int i = 0;
            // while(i < 2)
            //     Console.WriteLine(n++ + ": Hello World");

            // // incrementar antes
            // i = 0;
            // while(i < 2)
            //     Console.WriteLine(++n + ": Hello World");

            // // decrementar depois
            // int i = 2;
            // while(i > 0)
            //     Console.WriteLine(n-- + ": Hello World");

            // // decrementar antes
            // i = 2;
            // while(i > 0)
            //     Console.WriteLine(--n + ": Hello World");

            // n = 0;
            // while (n < 10)
            // {
            //     // somente mostra valores pares
            //     // onde o resto da divisão é igual a zero
            //     if (n % 2 == 0)
            //         Console.WriteLine(n + ": Hello World! ");
            //     n++;
            // }

            // n = 0;
            // while (n < 10)
            // {
            //     // somente mostra valores pares
            //     // onde o resto da divisão é diferente de zero
            //     if (n % 2 != 0)
            //         Console.WriteLine(n + ": Hello World! ");
            //     n++;
            // }

            // n = 0;
            // do
            // {
            //     Console.WriteLine(++n + ": Hello World! ");
            // } while (n < 10)

            // for (int i = 1; i < 11; i += 2)
            // {
            //     Console.WriteLine(n + ": Hello World! "); 
            // }

            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            // for (int i = 0; i < fibarray.Length; i++)
            // {
            //     System.Console.WriteLine(fibarray[i]);
            // }

            
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}