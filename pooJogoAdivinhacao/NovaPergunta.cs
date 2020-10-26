using System;
using System.Collections.Generic;
using System.Text;

namespace pooJogoAdivinhacao
{
    public class NovaPergunta:PerguntaJogo
    {
        public NovaPergunta() : base()
        {
            this.Dica = "";

        }
        public NovaPergunta(string pergunta, string resposta, string dica) : base(pergunta, resposta)
        {
            this.Dica = dica;
        }
        public string Dica { get; set; }
    }
}
