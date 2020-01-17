using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Name
        {
            get { return _name; }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should be not less than 3 symbols!");
                }

                _name = value;
            }
        }

        public virtual int Age
        {
            get { return _age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                _age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}";
        }
    }
}
