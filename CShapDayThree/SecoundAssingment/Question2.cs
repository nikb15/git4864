using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecoundAssingment
{
    class Question2
    {
        static void Main()
        {
            string x;
            int cow = 0, bull = 0 ,attemp=5;
            Console.WriteLine("Enter the string");
            x = Console.ReadLine();
            for(int i = attemp; i > 0; i--)
            {
                Console.WriteLine("Player Enter your Letter ");
                char compute = Convert.ToChar(Console.ReadLine());
                if (x.IndexOf(compute) == -1)
                {
                    bull++;
                }
                else
                {
                    cow++;
                }
                Console.WriteLine("Cow :{0}  Bull:{1}", cow, bull);
                Console.WriteLine("Attemps Remaining :{0}", i-1);
            }
            Console.WriteLine("Final Score \n cows {0}  bull {1}", cow, bull);
            if (bull > cow)
            {
                Console.WriteLine("Bull wins");
            }   
            else
            {
                Console.WriteLine("Cow wins");
            }
            Console.ReadLine();
        }
    }
}
