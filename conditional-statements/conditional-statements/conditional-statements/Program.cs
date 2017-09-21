 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma antaa joko pos, neg tai nolla");
            Console.Write("Syötä numero: ");

            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            Console.WriteLine("Syötit arvon {0}", userInput);
            Console.WriteLine($"Syötit arvon: {userInput}");

            if(evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
            }

            else if (evaluatedNumber > 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
            }

            else if (evaluatedNumber == 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on nolla");
            }

            Console.ReadKey();
        }
    }
}
