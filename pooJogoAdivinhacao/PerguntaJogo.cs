 using System;
using System.Collections.Generic;
using System.Text;

namespace pooJogoAdivinhacao
{
    public class PerguntaJogo
    {
        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";
        }
        public PerguntaJogo(string pergunta, string resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

        public string Pergunta { get; set; }
        public string Resposta { get; set; }
    }
}
