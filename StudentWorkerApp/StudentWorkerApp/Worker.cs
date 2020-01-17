using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerApp
{
    public class Worker : Human
    {
        private decimal _weekSalary;
        private decimal _workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return _weekSalary; }

            private set
            {
                if (value <= 10)
                {
                    Console.WriteLine("Expected value mismatch! Argument: weekSalary");
                }

                _weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return _workHoursPerDay; }

            private set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("Expected value mismatch! Argument: workHoursPerDay");
                }

                _workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Week Salary: {_weekSalary}");
            sb.AppendLine($"Hours per day: {_workHoursPerDay}");
            sb.AppendLine($"Salary per hour: {CalSalaryPerHour()}");

            return sb.ToString();
        }

        private decimal CalSalaryPerHour()
        {
            return _weekSalary / (5m * _workHoursPerDay);
        }
    }
}
