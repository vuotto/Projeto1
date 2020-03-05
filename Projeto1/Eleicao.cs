using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1
{
    public static class Eleicao
    {
        public static void Votar(Candidato c)
        {
            Program.votos.Add(c);
        }

        public static void Contagem()
        {
            double cand1 = 0;
            double cand2 = 0;
            double branco = 0;
            double nulo = 0;
            foreach (var item in Program.votos)
            {
                if (item == Program.candidatos[0])
                {
                    cand1++;
                }
                else if (item == Program.candidatos[1])
                {
                    cand2++;
                }
                else if (item == Program.candidatos[2])
                {
                    branco++;
                }
                else
                {
                    nulo++;
                }
            }
            double total = cand1 + cand2 + branco + nulo;
            if (cand1>cand2)
            {
                Console.WriteLine($"Total de votos: {total}\nPorcentagem de nulos: {nulo / total * 100}%\nPorcentagem de brancos: {branco / total * 100}%\nPontos por candidatos: Candidato 1: {cand1}/Candidato 2: {cand2}\nCandidato Vencendor: {Program.candidatos[0].Nome}");
            }
            else
            {
                Console.WriteLine($"Total de votos: {total}\nPorcentagem de nulos: {nulo / total * 100}%\nPorcentagem de brancos: {branco / total * 100}%\nPontos por candidatos: Candidato 1: {cand1}/Candidato 2: {cand2}\nCandidato Vencendor: {Program.candidatos[1].Nome}");
            }
        }
    }
}
