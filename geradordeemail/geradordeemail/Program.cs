using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geradordeemail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Luan","thiago","jao","noia","pexe"};
            string[] numero = { "1" + "2" + "3" + "4" + "5" + "6" + "7" + "8" + "9" + "10" };
            string[] provedores = {"gmail.com","hotmail.com", "outlook.com"};
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Voce deseja utilizar qual dominio, 1 para gmail, 2 para hotmail, 3 para outlook");
                string opçao = Console.ReadLine();

                string nome = nomes[random.Next(nomes.Length)];
                string numeros = numero[random.Next(numero.Length)];
                string provedor = string.Empty;

                switch (opçao)
                {
                case "1":
                        provedor = provedores[0];


                        break;

                case "2":

                        provedor = provedores[1];

                        break;


                case "3":
                        provedor = provedores[2];

                        break;

                case "4":
                        string provedor4 = provedores[random.Next(numero.Length)];

                        break;

                    default:
                        Console.WriteLine("Opção inválida ou nao correspondente ");
                        continue;
                }

                string email = nome +"."+ numeros + "@" +provedor;
                Console.WriteLine("Seu email gerado é :" + email);
                break;  
                
                
            }

        }
    }
}
