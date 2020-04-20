using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child:Pessoa
    {
        protected override int Age 
        { 
            get => base.Age;

            set
            {
                if(value>15) throw new ArgumentException("Child's age must be less than 15!");
                base.Age = value;
            }
        }
        public Child(string name, int age) : base(name, age)
        {           
            base.Name = name;
            base.Age = Age;
        }
    }
}
