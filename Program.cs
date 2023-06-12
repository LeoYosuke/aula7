using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2, nota3;
            Console.WriteLine("digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a terçeira nota:");
            nota3 = double.Parse(Console.ReadLine());
            double maior = nota1;
            if(nota2 > maior) 
            {
                maior = nota2;
                
            }
            if (nota3> maior) 
            {
                maior = nota3;
            }
            Console.WriteLine($"A maior nota é: {maior}");
            Console.ReadKey();



        }
        void atividade04() 
            {
                double nota1;
                double nota2;
                double media;
                Console.WriteLine("digite a primeira nota:");
                nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("digite a segunda nota:");
                nota2 = double.Parse(Console.ReadLine());
                media = (nota1 + nota2) / 2;
                if (media >= 6)
                {
                    Console.WriteLine($"VOCÊ TIROU {media}");

                    Console.WriteLine("PARABENS, PASSOU DE ANO");

                }
                else
                {
                    Console.WriteLine($"VOCÊ TIROU {media}");

                    Console.WriteLine("REPROVADO...");

                }

                Console.ReadKey();

        }
     void atividade03() 
        {
            string nome;
            double nota;

            Console.WriteLine("ESCREVA NOME DO ALUNO");
            nome = (Console.ReadLine());
            Console.WriteLine("DIGITE SUA NOTA:");
            nota = double.Parse(Console.ReadLine());
            if (nota >= 6)
            {
                Console.WriteLine("PARABENS, APROVADO");

            }
            else
            {
                Console.WriteLine("REPROVADO...");

            }
            Main(null);

        }
        private static void atividade02()
        {
              double number;

              Console.WriteLine("DIGITE UM NUMERO!");
              number = double.Parse(Console.ReadLine());
              if (number > 100)
              {
                  Console.WriteLine($"{number + 150}");

              }
              else
              {
                  Console.WriteLine("numero menor que 100...");

              }
              Console.ReadKey();

              
        }
        void atividade01() 
        {
            atividade 01
            double number;

            Console.WriteLine("DIGITE UM NUMERO!");
            number = Double.Parse(Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine($"{number * 0.1}");

            }
            else
            {
                Console.WriteLine("numero menor que 10... error");

            }
            


        }
    }

}
