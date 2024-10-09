using System;

namespace AreaRetangulo
{
    class Retangulo
    {
        // Propriedades
        public double Altura { get; set; }
        public double Base { get; set; }

        // Método para calcular a área
        public double CalculaArea()
        {
            return Altura * Base;
        }

        // Método para exibir os dados
        public void ExibeDados()
        {
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Área: {CalculaArea()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Cálculo da área de um retângulo");
            
            // Leitura da altura
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            // Leitura da base
            Console.Write("Informe a base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());

            // Exibe os dados
            retangulo.ExibeDados();
            
            Console.ReadKey();
        }
    }
}
