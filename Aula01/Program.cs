
namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i+1}o. Elemento vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int soma;
            int qtde;

            soma= somapares(vetor);
            qtde= contaimpar(vetor);

            Console.WriteLine();

            Console.WriteLine($"Soma dos numeros pares :{soma}");
            Console.WriteLine($"Quantidade de números impares: {qtde}");
            Console.ReadKey();
        }
        
        static int somapares(int[] V)
        {
            int s = 0; 
            for (int i = 0; i < 10; i++)
            {
                if(V[i] % 2 == 0 )
                s+=V[i];           
            }
            return s;  
        }

        static int contaimpar(int[]V)
        {
            int q=0;
            for(int i =0;i< V.Length;i++)
            {
                if(V[i]%2!=0)
                q++;
            }
            return q;
        }
    }    
}        
