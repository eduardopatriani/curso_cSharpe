using System;
using System.Collections.Generic;

namespace secao06_exercicio_fixacao_conjuntos_aula83
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> D = new HashSet<int>();
            D.UnionWith(A);
            D.UnionWith(B);
            D.UnionWith(C);
            Console.WriteLine("Total de Alunos: " + D.Count);
            Console.ReadLine();
        }
    }
}
