using System;

namespace Ex_Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string worker = Console.ReadLine();
                string[] words = worker.Split();
                Worker w = new Worker(words[0], words[1]);
                w.WeekSalary = double.Parse(words[2]);
                w.WorkHPD = double.Parse(words[3]);

                string student = Console.ReadLine();
                string[] studentwords = student.Split();
                Student s = new Student(studentwords[0], studentwords[1]);
                s.IdNumber = int.Parse(studentwords[2]);

                Console.WriteLine("");
                Console.WriteLine(w);
                Console.WriteLine($"Week Salary: {w.WeekSalary}");
                Console.WriteLine($"Hours per day:{w.WorkHPD}");
                Console.WriteLine($"Salary per hour: {w.SalaryPerHour()}");
                Console.WriteLine("");

                Console.WriteLine(s);
                Console.WriteLine($"Faculty Number: {s.IdNumber}");
                
            }
            catch(ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
