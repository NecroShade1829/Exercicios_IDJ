using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Mankind
{
   public class Student:Human
    {
        private int idNumber;

        public int IdNumber
        {
            get => idNumber;
            set
            {
                if (value.ToString().Length < 5 || value.ToString().Length > 10)throw new ArgumentException("Invalid faculty number!");
                idNumber = value;
            }
        }
        public Student(string firstName, string lastName) : base(firstName, lastName) { }
    }
}
