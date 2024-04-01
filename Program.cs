using System;
using System.Threading;
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int c = 1;
            Console.WriteLine("-------------------------------------------");

            try
            {
                do
                {

                    // Tamanho dos Vetores   
                    Yellow();
                    Console.WriteLine("Digite o tamanho dos seus vetores A e B:");
                    Console.ResetColor();
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // Vetor A
                    int[] A = new int[x];
                    for (int i = 0; i < x; i++)
                    {
                        Red();
                        Console.WriteLine($"Digite o {c}º valor de seu vetor A:");
                        Console.ResetColor();
                        c++;
                        A[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();

                    // Vetor B
                    c = 1;
                    int[] B = new int[x];

                    for (int i = 0; i < x; i++)
                    {
                        Blue();
                        Console.WriteLine($"Digite o {c}º valor de seu vetor B:");
                        Console.ResetColor();
                        c++;
                        B[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();

                    // Resultado
                    c = 1;
                    Console.WriteLine("Loading...");
                    Console.WriteLine();


                    for (int i = 0; i < x; i++)
                    {
                        Magenta();
                        int soma = A[i] + B[i];
                        int subs = A[i] - B[i];
                        int mult = A[i] * B[i];
                        float divs = A[i] / B[i];
                        int expo = (int)Math.Pow(A[i], B[i]);
                        Thread.Sleep(1500);

                        Console.WriteLine($"Resultados do {c}º valor");
                        Console.ResetColor();
                        Console.WriteLine($"soma: {soma}");
                        Console.WriteLine($"subtração: {subs}");
                        Console.WriteLine($"multiplicação: {mult}");
                        Console.WriteLine($"divisão: {divs}");
                        Console.WriteLine($"exponencial: {expo}");
                        Console.WriteLine();
                        c++;
                    }

                    Thread.Sleep(800);
                    Console.WriteLine("Deseja fazer outro cálculo? S/N");
                    continuar = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();

                } while (continuar == 'S');
            }

            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro no programa {0}", ex.Message);
                throw ex;
            }
            
            
        }
        // Cores
        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void Magenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        
    }
}