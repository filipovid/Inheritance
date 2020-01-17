using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerApp
{
    public class Human
    {
        private string _firstName;
        private string _lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        protected string FirstName
        {
            get { return _firstName; }

            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Expected upper case letter! Argument: First Name");
                }

                _firstName = value;
            }
        }

        protected string LastName
        {
            get { return _lastName; }

            set
            {
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Expected upper case letter! Argument: Last Name");
                }

                _lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {_firstName}");
            sb.AppendLine($"Last Name: {_lastName}");

            return sb.ToString();
        }
    }
}
