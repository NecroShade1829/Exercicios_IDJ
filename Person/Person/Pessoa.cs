using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
   public class Pessoa
    {
        private string name;
        private int age;

        protected virtual string Name
        {
            get => name;
            set
            {
                if (value.Length <=2) throw new ArgumentException("Please insert a valid name!");
                name = value;
            }
        }

        protected virtual int Age
        {
            get => age;
            set
            {
                if (value <= 0) throw new ArgumentException("Please insert a real age!");

                age = value;
            }
        }
        
        protected Pessoa (string nome, int idade)
        {
            Name = nome;
            Age = idade;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {name}, Age: {age}"));
            return stringBuilder.ToString();
        }
    }
}
