using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Adition add = new Adition();
            add.Mul();
            add.sum();
        }
    }
}
