using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerApp
{
    public class Student : Human
    {
        private string _facNum;

        public Student(string firstName, string lastName, string facNum)
            : base(firstName, lastName)
        {
            FacNum = facNum;
        }

        public string FacNum
        {
            get { return _facNum; }

            private set
            {
                if (!value.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("Invalid faculty number!");
                }

                _facNum = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Faculty number: {_facNum}");

            return sb.ToString();
        }
    }
}
