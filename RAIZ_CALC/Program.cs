using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIZ
{
    class Eq2Grau
    {
        private double _a;
        public double a
        {
            get{return _a;}
            set{_a = value;}
        }

        private double _b;
        public double b
        {
            get{return _b;}
            set{_b = value;}
        }

        private double _c;
        public double c
        {
            get{return _c;}
            set{_c = value;}
        }

        private double _Delta;
        public double Delta
        {
            get{return _Delta;}
            //set{_Delta = value}
        }

        private double _Raiz1;
        public double Raiz1
        {
            get{return _Raiz1;}
            //set{_Delta = value}
        }

        
        private double _Raiz2;
        public double Raiz2
        {
            get{return _Raiz2;}
            //set{_Delta = value}
        }
        
        private void CalcDelta()
        {
            _Delta = Math.Pow(b,2) - 4 * a * c;
        }

        public bool CalcRaizes()
        {
            CalcDelta();

            if(TestaDelta())
            {
                _Raiz1 = (-b + Math.Sqrt(Delta)) / (2*a);
                _Raiz2 = (-b - Math.Sqrt(Delta)) / (2*a);

                return true;
            }
            else
            {
                return false;
            }

        }
        private bool TestaDelta()
        {
            if (_Delta < 0)
                return false;
            else
                return true;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau equacao = new Eq2Grau();

            Console.Write("a = ");
            equacao.a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            equacao.b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            equacao.c = double.Parse(Console.ReadLine());

            if(equacao.CalcRaizes())
            {
                Console.WriteLine($"\nDelta = {equacao.Delta:F2}\n");

                Console.WriteLine($"Raiz1 = {equacao.Raiz1:F2} ");
                Console.WriteLine($"Raiz2 = {equacao.Raiz2:F2} ");
            }
            else
            {
                Console.WriteLine("\nA equação não posssui Raízes Reais. ");
            }

            Console.ReadKey();

        }
    }
}