using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLASSTAD
{
    class Veiculo
    {
        public string Nome;
        public string Marca;
        public string AnoFab;
        public string Placa;
        public double PrecoFIP;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] CadVeiculo = new Veiculo[3];

            for (int i = 0; i<3; i++)
            {
                Veiculo x = new Veiculo();
                
                Console.WriteLine($"\nNome do Veículo{i+1}.....:");
                x.Nome = Console.ReadLine();

                Console.Write($"\nMarca.....:");
                x.Marca = Console.ReadLine();

                Console.Write($"Ano de Fabricação....:");
                x.AnoFab = Console.ReadLine();

                Console.Write($"Placa.....:");
                x.Placa = Console.ReadLine();

                Console.Write($"Preço FIP (R$).....:");
                x.PrecoFIP = double.Parse(Console.ReadLine());

                CadVeiculo[i] = x;

            }

            Console.Clear();

            foreach(Veiculo V in CadVeiculo)
            {
                System.Console.WriteLine($"\n{V.Nome} - Ano: {V.AnoFab} ");
                System.Console.WriteLine($"Marca: {V.Marca} ");
                System.Console.WriteLine($"Placa: {V.Placa} ");
                System.Console.WriteLine($"Preço - TABELA FIP - R${V.PrecoFIP:F2}");
                
            }
        
            Console.ReadKey();
        }
    }
}