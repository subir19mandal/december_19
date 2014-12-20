using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.regNo = "10";
            student1.firstName = "Leo";
            student1.lastName = "Messi";

            Student student2 = new Student();
            student2.regNo = "7";
            student2.firstName = "C.";
            student2.lastName = "Ronalro";

            Student student3 = new Student();
            student3.regNo = "11";
            student3.firstName = "Neymar";
            student3.lastName = "Jr.";

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
           

            foreach (Student astudent in students)
            {
                Console.WriteLine(astudent.regNo + " " + astudent.GetFullName());
            }

            Console.ReadLine();
        }
    }
}
