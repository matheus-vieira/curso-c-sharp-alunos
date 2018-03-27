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
            int numeroMembros = int.Parse(Console.ReadLine());

            Console.WriteLine(nome + " possui " + numeroMembros +" membros.");
        }
    }
}
