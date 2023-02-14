using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void main(string[] args)
    {
        int[] vetor = new int[10];
        for(int i =0;i<10;i++)
        {
            Console.write($"Digite o {i+1}o. Elemento vetor:
            ");
            vetor[i] = int.parse(Console.ReadLine());
        }

        int soma;
        int qtde;

        soma= somapares(vetor);
        qtde= contaimpar(vetor);

        Console.writeline();

        Console.writeline($"Soma dos numeros pares :{soma}");
        Console.writeline($"Quantidade de números impares: {qtde}");
        Console.ReadKey();
    }
    }

    static int somapares(int[]V)
    {
        int s=0; //variavel para somar os pares
        for(int i =0;i<10;i++)
        {
            if(V[i]%2==0 )   //validar se ele é par
            s+=V[i];            // acumula para validar o resto da matriz
        }
        return s;       //retorna a soma
    }

    static int contaimpar(int[]V);
    {
        int q=0;
        for(int i =0;i< V.length;i++)
        {
            if(V[i]%2!=0)
            q++;
        }
    }
