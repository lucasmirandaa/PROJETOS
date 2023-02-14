namespace CADASTRO
{
    

    struct Funcionário
    {
        public string Matrícula;
        public string Nome;
        public double Salário;
        public string DataNasc;
    }
    static void Main(string[] args)
    {
        Funcionário xFunc;

        xFunc.Matrícula = "5783";
        xFunc.Nome = "Gustavo Gomes de Souza";
        xFunc.Salário = 3456.78;
        xFunc.DataNasc = "22/07/1978";
    }
    Funcionário[] xFunc = new Funcionário[5];

    for (int i = 0; i < 5; i++)
    {
        Console.Write("Matrícula do Funcionário: ");
        xFunc[i].Matrícula = Console.ReadLine();

        Console.Write("Nome....................: ");
        xFunc[i].Nome = Console.ReadLine();

        Console.Write("Salário.................: ");
        xFunc[i].Salário = double.Parse(Console.ReadLine());

        Console.Write("Data de Nascimento......: ");
        xFunc[i].DataNasc = Console.ReadLine();
    }

}