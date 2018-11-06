using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class randomNumber
    {
        static void Main(string[] args)
        {
            int num, cod;
            int attempts = 0;

            cod = codGenerate();
            Console.WriteLine("Generated code: {0} ", cod);
            do
            {
                attempts++;
                Console.Write("\n{0} Attempt", attempts);
                Console.Write("\nEnter generated code: ");
                num = int.Parse(Console.ReadLine());
                Situation(num, cod, attempts);
            } while (num != cod);



            Console.ReadLine();
        }

        //
        public static int codGenerate()
        {
            int aler;
            Random rd = new Random();

            return aler = rd.Next(1, 10);
        }

        //
        public static void Situation(int num, int cod, int attemptss)
        {
            //Console.WriteLine("\n");
            if (num > cod)
            {
                Console.WriteLine("The generated code is less than: {0} ", num);
            }
            else if (num < cod)
            {
                Console.WriteLine("The generated code is greater than: {0} ", num);
            }
            else
            {
                Console.WriteLine("Congratulations!!! you got it right in {0} attempts", attemptss);
            }
        }
    }
}
