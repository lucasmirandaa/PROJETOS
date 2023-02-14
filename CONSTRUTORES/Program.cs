using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUTORES
{
    class Funcionario
    {
       private string _ID;

       public  string ID
       {
            get{return _ID;}
            //set {_ID = value;}
       }

        private string _Nome;

        public string Nome 
        {
            get{return _Nome;}
            set{_Nome = value;}
        }
         private double _Salario;

        public double Salario
        {
            get{return _Salario;}
            set{_Salario = value;}
        }

        //CONSTRUTOR

        public Funcionario()
        {
            _ID = Guid.NewGuid().ToString().Substring(4,4).ToUpper();
        }

        public Funcionario(string id)
        {
            _ID = id;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Funcionario[] CadFunc = new Funcionario[3];
                for (int i = 0; i < 3; i++)
                {
                    Funcionario xFunc = new Funcionario(); 
                    Console.WriteLine($"\nFuncionário {i+1} - ID: {xFunc.ID} ");

                    Console.Write("Nome.....: ");
                    xFunc.Nome = Console.ReadLine();

                    Console.Write("Salário.....: ");
                    xFunc.Salario = double.Parse(Console.ReadLine());

                    CadFunc[i] = xFunc;
                }

                Console.Clear();

                foreach (Funcionario F in CadFunc)
                {
                    Console.WriteLine($"\n{F.Nome} ({F.ID}: )");
                    Console.WriteLine($"Salário: R${F.Salario:F2} ");
                }

                Console.ReadKey();
            }
        }


    }
}