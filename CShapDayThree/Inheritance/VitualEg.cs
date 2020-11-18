using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class RBIBAnk
    {
        public virtual string HomeLoan()
        {
            return "9%";
        }

         //public abstract void Test();
        public void Test()
        {
            Console.WriteLine("INside RBI");
        }
    }
    
    class SBI: RBIBAnk
    {
        public override string HomeLoan()
        {
            return "10.5%";
        }
/*        public override void Test()
        {
            Console.WriteLine("Sample Method of SBI");
        }
*/
        public new void Test()
        {
            Console.WriteLine("Test of SBI");
        }
    }

    class RBI : RBIBAnk
    {
        public override string HomeLoan()
        {
            return "7.5%";
        }

    }

    class VitualEg
    {
        static void Main()
        {
            RBIBAnk rBIBAnk = new RBIBAnk();
            Console.WriteLine("{0}", rBIBAnk.HomeLoan());
            rBIBAnk.Test();

            SBI sBI = new SBI();
            Console.WriteLine("{0}", sBI.HomeLoan());
            sBI.Test();

            Console.ReadLine();
        }
    }

}
