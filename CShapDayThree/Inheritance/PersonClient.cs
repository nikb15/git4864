using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
        class BankEmploye : Employee
    {
        internal BankEmploye(string Name,int Age,string Gender,int Eid,int SalaryPerHour) :base(Name,Age,Gender,Eid,SalaryPerHour)
        {

        }
    }
    class PersonClient
    {
      static void Main()
        {
            BankEmploye bankEmploye = new BankEmploye("Duke", 25, "Male", 1001, 500);
            bankEmploye.DisplayNameGender();
            Console.ReadLine();
        }
    }
}
