using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEg
{
    class CustomException
    {
        public class AgeNotValid:ApplicationException
        {
            public AgeNotValid(string Message):base(Message)
            {

            }
        }

        class Student
        {
            public string Name { get; set; }
            public int Age { set; get; }
        
            internal Student(string Name , int Age)
            {
                  this.Name= Name;
                  this.Age= Age;
            }
            public void AgeCheck()
            {
                string Result;
                try
                {
                    if (Age > 20)
                    {
                        Console.WriteLine( "Registered");
                    }
                    else
                    {
                        throw new AgeNotValid("Age should be greater then 20");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
            static void Main()
        {
            Student student = new Student("Raj", 22);
            student.AgeCheck();
            Console.ReadLine();
        }
    }
}
