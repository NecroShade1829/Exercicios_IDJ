using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Mankind
{
   public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                if(char.IsLower(value[0])) throw new ArgumentException("Expected uppercase letter! Argument: firstName");
                if(value.Length<4) throw new ArgumentException("Expected lenght at least 4 letters! Argument: firstName");
                firstName = value;
            }
        }
        public virtual string LastName
        {
            get => lastName;
            set
            {
                if (char.IsLower(value[0])) throw new ArgumentException("Expected uppercase letter! Argument: lastName");
                if (value.Length < 3) throw new ArgumentException("Expected lenght at least 4 letters! Argument: firstName");
            }            
        }
        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();

            sB.Append("First Name: ").Append(firstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(lastName);

            return sB.ToString();
        }
    }
}
