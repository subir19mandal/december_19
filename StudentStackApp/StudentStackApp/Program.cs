using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStackApp
{
    class Program
    {
        //Stack<Student> students = new Stack<Student>();
        static void Main(string[] args)
        {
            Stack<Student> students = new Stack<Student>();
            
            Student student1 = new Student();
            student1.firstName = "Salman";
            student1.lastName = "Kobir";

            Student student2 = new Student();
            student2.firstName = "Salman";
            student2.lastName = "Kobir";

            students.Push(student1);
            students.Push(student2);
            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.GetFullName());
            }
            
            Console.ReadLine();

        }
    }
}
