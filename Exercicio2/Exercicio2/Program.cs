using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while(command != "End")
            {
                Student a = new Student(command);
                StudentGroup.studentName.Add(a.Name);
                command = Console.ReadLine();
            }
            StudentGroup.uniqueStudentName = StudentGroup.studentName.Count;
            Console.WriteLine("Unique Student Names: "+ StudentGroup.uniqueStudentName);


          
        }
    }
}
