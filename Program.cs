using System;
using Figgle;

namespace retpreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            string opu = "";
            string x = "Obrigada!";
            DateTime hr = DateTime.Now;

            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Exercício retângulo");
                Console.WriteLine("-------------------");
                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Iniciar programa  ");
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("0. Sair  ");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Digite sua opção --> ");
                opu = Console.ReadLine();
                Console.WriteLine();

                if (opu == "1")
                {
                    retpreenchido();
                }

            } while (opu != "0");

                    Console.WriteLine("Programa finalizado em "+hr);
                    Console.WriteLine(FiggleFonts.Standard.Render(x));

        }
         static void retpreenchido()
        {
            DateTime hr1 = DateTime.Now;
            Console.WriteLine("Programa iniciado em "+hr1);
            Console.WriteLine("Retângulo preenchido");
            
            int linha = 0;
            int coluna = 0;
            Console.Write("Quantas linhas: ");
            linha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas colunas: ");
            coluna = Convert.ToInt32(Console.ReadLine());

            int linha2 = 0;
            while(linha2 < linha)
            {
                linha2 += 1;

            int coluna2 = 0;
            while (coluna2 < coluna)

            {
                coluna2 += 1;
                if (linha2 == 1 || linha2 == linha)
                {
                     Console.Write("*");
                }
                else
                {
                    if(coluna2 == 1 || coluna2 == coluna)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

            }               
                Console.WriteLine();

            }

            Console.ReadKey(); 
        }
    }
}
