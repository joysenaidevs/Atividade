using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
	        // A. A Média do aluno
	        // B. A quantidade de Aprovados (Média >=7)
	        // C. A quantidade de Reprovados (Méida < 7)
	        // D. A Média geral dos 10 aluno

            string[] nome = new string[10];
            float[] notas = new float[4];
            float[] media = new float [10];

            for (var i = 0; i <10; i++)
            {   
                Console.WriteLine("Digite seu nome");
                nome [i] = Console.ReadLine();

                for (var x = 0; x <4; x++)
                {
                    Console.WriteLine("Digite a "+(x+1)+" nota: ");
		            notas[x] = float.Parse(Console.ReadLine());
                }

                media[i] = (notas[0]+notas[1]+notas[2]+notas[3]) / 4;
            }

            //laços condicionais

            foreach (string nomes in nome){
                Console.WriteLine(nome);

            }

            
            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Nome: {nome[i]} - Média : {media[i]} ");
            }

        }
    }
}
