using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student info: ");
            string[] studentInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Worker info: ");
            string[] workerInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]),decimal.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
