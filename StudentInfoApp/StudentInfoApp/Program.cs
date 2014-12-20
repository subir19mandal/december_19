using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            Student student1 = new Student();

            student1.regNo = "123";
            student1.firstName = "Leo";
            student1.lastName = "Messi";

            Student student2 = new Student();

            student2.regNo = "456";
            student2.firstName = "C.";
            student2.lastName = "Ronalro";

            Student student3 = new Student();
            student3.regNo = "789";
            student3.firstName = "Neymar";
            student3.lastName = "Jr.";

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach (Student astudent in students)
            {
                Console.WriteLine(astudent.regNo + " " + astudent.GetFullName());
            }

            Console.ReadLine();
        }
    }
}
