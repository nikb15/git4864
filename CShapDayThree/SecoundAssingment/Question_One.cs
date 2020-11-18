using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecoundAssingment
{
    class Student
    {
        public int id { get;   set; }
        public string name { get;  set; }
        public string dob { get; set; }
        internal Student(int id,string name,string dob)
        {
             this.id=id;
             this.name=name;
             this.dob=dob;
        }
        internal Student(int id)
        {
            this.id = id;
        }
        internal Student()
        {

        }
    }

    class Course
    {
        internal int id; 
        internal string name; 
        internal int duration;
        internal int fees;
        internal Course(int id,string name,int duration,int fees)
        {
            this.id = id;
            this.fees = fees;
            this.name = name;
            this.duration = duration;
        }
        internal Course()
        {

        }
    }

    public class Enroll
    {
        // tking the new valus
        private Student student1 =new Student();
        private Course course1=new Course();
        AppEngine ap = new AppEngine();
        internal Enroll(int id,string name ,string dob, int cid,string cname,int duration ,int fees)
        {
            student1.id = id;
            student1.name = name;
            student1.dob = dob;
            course1.id = cid;
            course1.name = cname;
            course1.duration = duration;
            course1.fees = fees;
        }
        

        internal void printCourse()
        {
            
            ap.introduce(course1);
        }

        internal void prnintStudent()
        {
            ap.register(student1);
        }

    }

    class AppEngine
    {
       public void introduce(Course course)
        {
            Console.WriteLine("Courses Available are \n {0}",course.name);       
        }
        public void register(Student student)
        {
            Console.WriteLine("Student name -: {0}", student.name);
        }

        public Student[] listStudents()
        {
            Student[] ss = new Student[5];
            ss[0] =new Student( 0,"Nik","8769");
            return ss;
        }

        public Course[] listCoues()
        {
            Course[] cs = new Course[5];
            cs[0] = new Course();
            return cs;

        }
    }

    class Info
    {
        public void displayDetails(Student student)
        {
            Console.WriteLine("{0} || {1} || {2}", student.id, student.name, student.dob);
        }
         
        public void displayCourseDetails(Course course)
        {
            Console.WriteLine("{0} || {1} || {2} || {3}", course.id, course.name, course.fees,course.duration);

        }
    }

    class Scernarios{
        

        Info info = new Info();

        internal void scenario1()
        {
            Student s1 = new Student(1, "Nik", "15-05-98");
            Student s2 = new Student(2, "xyz", "16-06-98");
            info.displayDetails(s1);
            info.displayDetails(s2);
        }

        internal void scenario2()
        {
            // In this case i need to taek multiple students 
            Student[] studentsArray = new Student[2];
            studentsArray[0] = new Student(1, "Nik", "15-05-98");
            studentsArray[1] = new Student(2, "xyz", "16-06-98");

            foreach(Student s in studentsArray)
            {
                info.displayDetails(s);
            }

        }

        public void senario3()
        {

            Student[] studentArray = new Student[2];
            for(int i =0; i < 2; i++)
            {

                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                string nme = Console.ReadLine();

                Console.WriteLine("Enter dob");
                string dob = Console.ReadLine();

                studentArray[i] = new Student(id,nme,dob);
            
            
            }
            foreach (Student s in studentArray)
            {
                info.displayDetails(s);
            }

        }
    }

    class Question_One
    {
        static void Main()
        {
            /*
             * Scenario 1
                Student s1 = new Student(2, "Nik", "15-05-08");
                Info info = new Info();
                info.displayDetails(s1);
                Console.ReadLine();
            */
            /*Scenario 2*/
            /*
            Course course = new Course(21, ".Net", 3, 2300);
            Info info = new Info();
            info.displayCourseDetails(course);
            Console.ReadLine();
        */

            //    Scernarios sc = new Scernarios();
            //sc.scenario1();
            //sc.scenario2();
            //      sc.senario3();
            Enroll enroll = new Enroll(100,"Nik","15-04-98",01,"SQL",2,1200);
            enroll.printCourse();
            enroll.prnintStudent();

            Console.ReadLine();
        }
    }
}
