using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1
{
    class Program
    {
        public static List<Candidato> candidatos = new List<Candidato>();
        public static List<Candidato> votos = new List<Candidato>();
        static void Main(string[] args)
        {
            CriarCandidatos();
            StringBuilder builder = new StringBuilder();
            builder.Append("1 - Votar");
            builder.Append("\n2 - Conferir contagem");
            builder.Append("\n3 - Sair");
            int menu = 0;
            do
            {
                Console.WriteLine(builder);
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception d)
                {
                    Console.WriteLine("Error: "+d.Message);
                }
                
                if (menu == 1)
                {
                    int voto;
                    bool sucesso = false;
                    foreach (var item in candidatos)
                    {
                        Console.WriteLine($"\n{item.Nome} - {item.Numero}");
                    }
                    voto = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in candidatos)
                    {
                        if (voto == item.Numero)
                        {
                            sucesso = true;
                            Eleicao.Votar(item);
                        }
                    }
                    if (sucesso)
                    {
                        Console.WriteLine("Voto computado com sucesso");
                    }
                    else
                        Console.WriteLine("Opção inválida. Tente novamente");
                }
                else if (menu == 2)
                {
                    Eleicao.Contagem();
                }
            } while (menu != 3);
        }

        static void CriarCandidatos()
        {
            Candidato candidato1 = new Candidato("Enzo", 1, TipoCandidato.Valido);
            Candidato candidato2 = new Candidato("Valentina", 2, TipoCandidato.Valido);
            Candidato branco = new Candidato("Branco", 3, TipoCandidato.Branco);
            Candidato nulo = new Candidato("Nulo", 4, TipoCandidato.Nulo);
            candidatos.Add(candidato1);
            candidatos.Add(candidato2);
            candidatos.Add(branco);
            candidatos.Add(nulo);
        }
    }
}
