using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geradordesenhasaleatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = string.Empty;
            int tamanhoSenha = 0;
            string caractersSenha = string.Empty;
            Random random = new Random();

           

            while (true) {
                Console.WriteLine("Digite a senha de 1 a 10 ;");
                string opção = Console.ReadLine();
                switch (opção)
                {
                    case "1":
                        tamanhoSenha = 1;

                        caractersSenha = "ABCD1234@##!";

                        break;


                    case "2":
                        tamanhoSenha = 2;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                        break;



                    case "3":
                        tamanhoSenha = 3;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "4":
                        tamanhoSenha = 5;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "5":
                        tamanhoSenha = 5;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "6":
                        tamanhoSenha = 6;
                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;
                    case "7":
                        tamanhoSenha = 7;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "8":
                        tamanhoSenha = 8;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "9":
                        tamanhoSenha = 9;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    case "10":
                        tamanhoSenha = 10;

                        caractersSenha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789100";

                        break;

                    default:
                        Console.WriteLine("Opção invalida ou nao disponivel");
                        continue;

                }
                break;
                }
           
            for (int i = 0; i < tamanhoSenha; i++)
            {
                int index = random.Next(caractersSenha.Length);
                senha += caractersSenha[index];
            }
            Console.WriteLine("Senha gerada: " + senha);

        }
        
            
    }
}
