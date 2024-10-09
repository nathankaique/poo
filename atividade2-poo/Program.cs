using System;

namespace meuvalorfuturo
{
    public class ValorFuturo
    {
        // Construtor
        public ValorFuturo()
        {
            this.valorp = 2000;
            this.taxaj = 2.5;
            this.periodo = 12;
        }

        // Campo privado para valor presente
        private double _valorp;
        public double valorp
        {
            get { return _valorp; }
            set { _valorp = value >= 0 ? value : 0; }
        }

        // Campo privado para taxa de juros
        private double _taxaj;
        public double taxaj
        {
            get { return _taxaj; }
            set { _taxaj = value >= 0 ? value : 0; }
        }

        // Campo privado para período
        private double _periodo;
        public double periodo
        {
            get { return _periodo; }
            set { _periodo = value >= 0 ? value : 0; }
        }

        // Propriedade que calcula o valor futuro
        public double valorf
        {
            get { return valorp * (Math.Pow((taxaj / 100) + 1, periodo)); }
        }

        // Método para exibir os dados
        public void ExibeDados()
        {
            Console.WriteLine("Valor Presente: " + this.valorp.ToString("F2"));
            Console.WriteLine("Taxa de Juros (%): " + this.taxaj);
            Console.WriteLine("Período: " + this.periodo);
            Console.WriteLine("Valor Futuro: " + this.valorf.ToString("F2")); // Exibe com 2 casas decimais
        }
    }
}



namespace meuvalorfuturo
{
    class Program
    {
        static void Main(string[] args)
        {
            ValorFuturo valorFuturo = new ValorFuturo();
            Console.WriteLine("Calcula o valor futuro:");
            valorFuturo.ExibeDados();

            Console.ReadKey();
        }
    }
}
