using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class ISOstandarts
    {
        public abstract void Term();
    }

    abstract class MobileStandart:ISOstandarts
    {
        public int EmployeeCount = 20;
        internal abstract void Call();

        internal void MobileStandartEmplyee()
        {
            Console.WriteLine("{0}", EmployeeCount);
        }
    }


    class Apple : MobileStandart
    {
        internal override void Call()
        {
            Console.WriteLine("Applee Calls");
        }

        public override void Term()
        {
            Console.WriteLine("Apple terms");
        }
    }

    class Samsung : MobileStandart
    {
        internal override void Call()
        {
            Console.WriteLine("Samsung Calls");
        }
        public override void Term()
        {
            Console.WriteLine("Samsung terms");
        }

    }

        class AbstractEg
        {
            // creating an abstract class this abstract class must now make object as subch
            static void Main()
            {
            /*
             * Methods 1
                Apple ap = new Apple();
                        ap.Call();
             */
            MobileStandart mobileStandart;
            mobileStandart = new Apple();
            mobileStandart.Call(); // Will talk about Aple

            mobileStandart = new Samsung();
            mobileStandart.Call(); // call out for samsungs


            mobileStandart.Term(); // will show samsung terms
            Console.ReadLine();
            }
        }
    
}
