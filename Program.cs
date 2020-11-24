using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
           int anterior = 0, atual = 1, soma;

           Console.WriteLine();

           Console.Write("0 1 ");

           
        do {
            soma = anterior + atual;

            anterior = atual;

            atual = soma; 
            
            Console.Write($"{soma} " );
            
            }
                  
            while (atual < 500);      

            Console.WriteLine(".");
        }
    }
}
