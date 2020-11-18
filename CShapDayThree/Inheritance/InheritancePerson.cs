using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritance
{
    // This is a single inheritance structure 
    //Having Base class and derived class

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string BankName = "SBI";

        internal Person(string Name,int Age,string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            Console.WriteLine("Person Class Construct ");
        }
    
         protected void  DisplayPerson()
        {
            Console.WriteLine("Name: {0}  || Age :{1} || Gender :{2}", Name, Age, Gender);
        }

        internal protected void DisplayNameGender()
        {
            Console.WriteLine("{0} || {1}", Name, Gender);
        }
        ~Person()
        {
            Console.WriteLine("Person Destructor");
        }
    }

    // Creating employee tht will inherite from Person 
   class Employee : Person
    {
        public int Eid { get;  set; }
        public int SalaryPerHour { get; set; }

        new public string  BankName = "HDFC";

        public Employee(string Name, int Age, string Gender,int Eid,int SalaryPerHour) :base(Name
            ,Age,Gender)
        {
            this.Eid = Eid;
            this.SalaryPerHour = SalaryPerHour;
            Console.WriteLine("Employee Class Construct ");
        }

        internal void DisplayEmployee()
        {
            DisplayPerson();
            Console.WriteLine("Name: {0}  || Eid :{1} || Salary :{2}", Name, Eid, SalaryPerHour);
            Console.WriteLine("Personal :{0} || Official: {1}", base.BankName, BankName);
        }     
    }

    class FullTimeEmployee : Employee
    {
        int WorkingHours { get; set; }
        int TotalSalary;
        internal FullTimeEmployee( string Name, int Age, string Gender, int Eid, int SalaryPerHour, int WorkingHours) :base(Name,Age,Gender,Eid,SalaryPerHour)
        {
          Console.WriteLine("------------Full Time Employee-------");
            this.WorkingHours = WorkingHours;   
        }
        internal void CalculateSalary()
        {
            TotalSalary = SalaryPerHour * WorkingHours;
            Console.WriteLine("Name :{0} || Hours Worked :{1} || PerHourSalary {2} ||Total Salary {3}",Name,WorkingHours,SalaryPerHour,TotalSalary);
        }

        ~FullTimeEmployee()
        {
            Console.WriteLine("Full Time Destructor");
        }
    }

    class PartimeEmployee : Employee
    {
        internal PartimeEmployee(string Name, int Age, string Gender, int Eid, int SalaryPerHour, int WorkingHours) : base(Name, Age, Gender, Eid, SalaryPerHour)
        {

        }
    }

    class InheritancePerson
    {
        static void Main()
        {
            FullTimeEmployee ful = new FullTimeEmployee("Duke", 25, "Male", 1001, 500,10);
            Console.WriteLine("------------Employee Details Display-------");
//            ful.DisplayEmployee();
            Console.WriteLine("------------Salary Calculated-------");
            ful.CalculateSalary();
            GC.Collect();
            Console.ReadLine();
        }
    }
}
