    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fin = true;
            while (fin)
            {


                Console.Write("Votre age : ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.Write("Vous ête majeur.");
                }
                else
                {
                    Console.Write($"Vous êtes mineur et serez majeur dazsn {18 - age} ans: ");
                }
                Console.Write("Continuer 0/1 : ");
                fin = bool.Parse(Console.ReadLine());
            }
            Console.ReadLine();

        }
    }
}
