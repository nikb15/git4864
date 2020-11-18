using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ConstEg {
        public const float pi = 3.14F;
        
     internal   void peri(int r)
        {
            Console.WriteLine("{0}", 2 * pi + r);
        }
    }
class ReadOnlyEg
    {
        internal readonly string SchoolName;
        internal static readonly string OrgName = "L&T";
        internal ReadOnlyEg(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }
    
        
    }

    class Constant_and_ReadOnly
    {
        
        static void Main()
        {
            ConstEg constEg = new ConstEg();
            constEg.peri(3);
            Console.ReadLine();
        }
    }
}
