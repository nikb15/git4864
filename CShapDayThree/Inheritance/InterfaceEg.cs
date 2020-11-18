using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
 
    interface scietific
    {
        int Add(int val,int va2);
        string calciName(string name);
    }
    class calculator : NormalCalculator,scietific
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        //string NormalCalculator.CalciName(string name)
        public string CalciName(string name)
        {
            Console.WriteLine("Normal Calci");
            Console.WriteLine("{0}", name);
            return name;
        }

        string scietific.calciName(string name)
        {
            Console.WriteLine("Scientific calci");
            Console.WriteLine("{0}", name);
            return name;
        }


    }
    
    
    class InterfaceEg
    {
        static void Main()
        {
            //            calculator cs = new calculator();
            //            Console.WriteLine("{0}", cs.Add(3, 5));
            // Next are dynamc 
            NormalCalculator normalCalculator = new calculator();
            normalCalculator.CalciName("RENO");
            scietific sc = new calculator();
            sc.calciName("RENO");
            Console.ReadKey();
        }
    }
}
