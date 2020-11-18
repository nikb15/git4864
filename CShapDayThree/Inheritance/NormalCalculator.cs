using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface NormalCalculator
    {
        //by Default the are Abstrac

        string CalciName(string Name); 
        int Add(int data1, int data2);

        int Subtraction(int data1, int data2);

    }
}
