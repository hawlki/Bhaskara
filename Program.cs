using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            Console.Beep();

            Console.WriteLine("------------------------------");
            Console.WriteLine("           Bhaskara           ");
            Console.WriteLine("------------------------------");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite um valor para A: ");
            bool valorAValido = double.TryParse(Console.ReadLine(), out double A);
            Console.Write("Digite um valor para B: ");
            bool valorBValido = double.TryParse(Console.ReadLine(), out double B);
            Console.Write("Digite um valor para C: ");
            bool valorCValido = double.TryParse(Console.ReadLine(), out double C);
            Console.ResetColor();
            Console.WriteLine();

            if(!valorAValido || !valorBValido || !valorCValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente números");
                Console.ResetColor();
                Environment.Exit(1);
            }

            if(A == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível calcular uma equação de segundo grau com o valor A sendo igual a zero");
                Console.ResetColor();
                Environment.Exit(1);
            }

            double delta = Math.Pow(B, 2) - 4 * A * C;

            if(delta < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O delta ({delta}) não vai possuir raízes reais no fim da equação");
                Console.ResetColor();
                Environment.Exit(1);
            }

            double valorX1 = (- B + Math.Sqrt(delta)) / 2 * A;
            double valorX2 = (- B - Math.Sqrt(delta)) / 2 * A;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O valor de X1 = {valorX1}");
            Console.WriteLine($"O valor de X2 = {valorX2}");
            Console.ResetColor();
            Environment.Exit(1);
        }
    }
}
