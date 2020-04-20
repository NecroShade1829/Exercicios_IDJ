using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Mankind
{
   public class Worker:Human
    {
        private string lastName;
        private double weekSalary;
        private double workHPD;

        public override string LastName
        {
            get => base.LastName;
            set
            {
                if(value.Length<=3) throw new ArgumentException("Expected length more than 3 letters! Argument: lastName (Worker)");
                base.LastName = value;
            }
        }
        public double WorkHPD
        {
            get => workHPD;
            set
            {
                if(value<1||value>12) throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                workHPD = value;
            }
        }
        public double WeekSalary
        {
            get => weekSalary;
            set
            {
                if(value<10) throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                weekSalary = value;
            }
        
        }
        public Worker(string firstName, string lastName) : base(firstName, lastName) { }
        
        public double SalaryPerHour()
        {
            return Math.Round(weekSalary / (workHPD * 7), 2);
        }
    }
}
