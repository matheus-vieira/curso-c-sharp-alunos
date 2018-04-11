using System;

namespace Anuncio
{
    class Program
    {
        static Banda banda = new Banda();
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o nome da banda:");
            banda.Nome = Console.ReadLine();

            Console.WriteLine("Digite 'Adicionar' para adicionar um músico.");
            Console.WriteLine("Digite 'Anunciar' para anunciar a banda.");
            Console.WriteLine("Digite 'Sair' para sair da aplicação.");

            while (true)
            {
                Console.WriteLine("Adicionar, Anunciar ou Sair?");
                string[] argumentos = Console.ReadLine().Split(' ');

                string acao = argumentos[0].ToLower();

                if (acao == "sair")
                    break;

                if (acao == "adicionar")
                {
                    AdicionarMusico(argumentos);
                    continue;
                }

            }
        }

        static void AdicionarMusico(string[] args)
        {
            // Adicionar
            if (args.Length == 1)
                banda.AdicionarMusico();
            // Adicionar <nome do caboclo>
            else if (args.Length == 2)
                banda.AdicionarMusico(args[1]);
            // Adicionar <nome do caboclo> <instrumento>
            else if (args.Length == 3)
                banda.AdicionarMusico(args[1], args[2]);
        }
    }
}
