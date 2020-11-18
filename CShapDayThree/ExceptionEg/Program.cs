using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEg
{
    class ExceptionEg
    {
        internal int value = 20;
        string[] Book = { "Java", "Cpp", "DBMS" };
    
        public void calculation()
        {
            try
            {
                //    value = value / 0;
                Console.WriteLine("array {0}", Book[5]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionEg exceptionEg = new ExceptionEg();
            exceptionEg.calculation();
            Console.ReadKey();
        
        }
    }
}
