using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDesSis05Aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento: ");
            int nasc = int.Parse(Console.ReadLine());
            int idade;
            idade = nasc - 2024;

            Console.WriteLine("Digite o ano que você entrou na empresa: ");
            int traba = int.Parse(Console.ReadLine());
            int anosServ;
            anosServ = 2024 - traba;

            if ((idade >= 65 | traba >= 30) | (idade >= 60 && traba >= 25)) 
            {
                Console.WriteLine("Você trabalha na empresa a: " + anosServ);
                Console.WriteLine("Pode se aposentar!");
            }
            else 
            {
                Console.WriteLine("Você trabalha na empresa a: " + anosServ);
                Console.WriteLine("Ainda não pode aposentar.");
            }

            Console.ReadKey();
        }
    }
}
