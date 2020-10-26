using System;
using System.Collections.Generic;

namespace pooJogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            //Pergunta que sera exibida
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];
            //Lógica da resposta
            int tentativas = 0;
            bool flag = false;
            string resposta = "";
            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.WriteLine("Resposta: ");
                resposta = Console.ReadLine();

                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Que pena, você errou"+pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true) { Console.WriteLine("Parabéns, você acertou."); }
            else { Console.WriteLine("Que pena, você perdeu"); }
            Console.ReadKey();
        }

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta p = new NovaPergunta("Qual é a cor do céu?", "Azul", "Letra A");
            lista.Add(p);
            p = new NovaPergunta("Qual o endereço do site do Google?", "google.com", " ******.com");
            lista.Add(p);
            p = new NovaPergunta("Aplicativo para assistir filme", "Netflix", "Letra N");
            lista.Add(p);
            p = new NovaPergunta("Deus ajuda quem cedo...", "madruga", "Ato de acordar");
            lista.Add(p);
            return lista;
        }
    }
}
