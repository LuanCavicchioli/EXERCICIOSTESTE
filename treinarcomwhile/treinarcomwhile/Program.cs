using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinarcomwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tente adivinhar o numero digitado acima:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Clear();

            while (numero != numero1) 
            {
            Console.WriteLine("Digite um numero novamente");
                numero = int.Parse(Console.ReadLine());
            Console.Write("Digite um numero novamente:");
            }
            Console.WriteLine("Digitou corretamente");
  
        }
        
    }
}
