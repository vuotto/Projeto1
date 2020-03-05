using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1
{
    public class Candidato
    {
        public string Nome { get; set; }
        public int Numero { get; }
        public TipoCandidato Tipo { get; set; }
        public Candidato(string nome, int num, TipoCandidato tipo)
        {
            Nome = nome;
            Numero = num;
            Tipo = tipo;
        }
    }
}
