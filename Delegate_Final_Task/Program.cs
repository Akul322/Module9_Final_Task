using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Final_Task
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exception = new Exception[5];
            exception[0] = new OverflowException();
            exception[1] = new FormatException();
            exception[2] = new ArgumentException();
            exception[3] = new RankException();
            exception[4] = new MyException();
            foreach (Exception ex in exception)
            {
                try
                {
                    throw ex;
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
