using System;

namespace anuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            while (n < 10)
            {
                if (n % 2 != 0)
                    Console.WriteLine(n + ": Hello World! ");
		n++;
            }
        }
    }
}
