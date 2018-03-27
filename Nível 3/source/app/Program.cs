using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome da sua banda?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos integrantes ela possui?");
            int numeroMembros = 0;
            int.TryParse(Console.ReadLine(), out numeroMembros);

            if (numeroMembros < 1)
            {
                Console.WriteLine("A banda tem que ser composta por pelo menos 1 membro");
                Environment.Exit(0);
            }
            else if (numeroMembros == 1)
                Console.WriteLine(nome + " é uma monobanda :D");
            else if (numeroMembros == 2)
                Console.WriteLine(nome + " é uma dupla");
            else
                Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
        }
    }
}
