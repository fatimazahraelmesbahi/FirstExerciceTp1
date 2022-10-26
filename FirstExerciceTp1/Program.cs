using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExerciceTp1
{
    internal class Program
    {
        public static bool EstPremier(int premier)
        {
            if (premier < 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < premier; i++)
                {
                    if (premier % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
            static void Main(string[] args)
        {
            int premier = 0;
            do
            {
                Console.WriteLine("entered a number :");

            } while (!int.TryParse(Console.ReadLine(), out premier));

            if (EstPremier(premier))
            {
                Console.WriteLine("est premier");
            }
            else
            {
                Console.WriteLine("Pas premier");
            }
        }
    }
}
