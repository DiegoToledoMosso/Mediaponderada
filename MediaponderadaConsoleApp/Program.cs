﻿namespace MediaponderadaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos calcular a média ponderada de suas provas");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar das notas de sua prova:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite a medida do raio do cilindro");

                //var r = Convert.ToInt32(Console.ReadLine());
                r = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite a medida da altura do cilindro ");

                //var h = Convert.ToDecimal(Console.ReadLine());
                h = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("----------------------------------------");




                var volume = Math.PI * Math.Pow(r, 2) * h;


                Console.WriteLine($"Volume do cilindro é {volume:0.##}");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
    }
}
