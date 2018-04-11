using System;
using System.Collections.Generic;

namespace Anuncio
{
    public class Banda
    {
        public string Nome { get; set; }
        public List<Musico> MusicoList { get; set; } = new List<Musico>();

        public void AdicionarMusico()
        {
            string nome = PegaTextoDoUsuario("Qual o nome do músico?");
            string instrumento = PegaTextoDoUsuario("Qual o instrumento?");
            AdicionarMusico(nome, instrumento);
        }

        public void AdicionarMusico(string nome)
        {
            while (true)
            {
                string msg = "O nome do membro \"" + nome + "\" está correto? (Sim ou Não)";
                string nomeCorreto = PegaTextoDoUsuario(msg);
                nomeCorreto = nomeCorreto.ToLower();

                if (nomeCorreto == "sim")
                    break;
                
                if (nomeCorreto == "não")
                {
                    AdicionarMusico();
                    return;
                }
                
                Console.WriteLine("Responda somente com \"Sim\" ou \"Não\"!");
            }
            string instrumento = PegaTextoDoUsuario("Qual o instrumento?");
            AdicionarMusico(nome, instrumento);
        }

        public void AdicionarMusico(string nome, string instrumento)
        {
            Musico musico = new Musico();
            musico.Nome = nome;
            musico.Instrumento = instrumento;
            MusicoList.Add(musico);
            var msg = "Músico \"" + nome + "\" foi adicionado com sucesso!";

            // Músico "<nome do cara>" foi adicionado com sucesso
            Console.WriteLine(msg);
        }

        private string PegaTextoDoUsuario(string pergunta)
        {
            string retorno;
            while (true)
            {
                Console.WriteLine(pergunta);
                retorno = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(retorno))
                    return retorno;
                
                Console.WriteLine("Informe um texto!");
            }
        }
    }
}
