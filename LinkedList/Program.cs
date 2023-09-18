using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(150);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Loop(x => Console.WriteLine(x));
            Console.WriteLine("----");

            LinkedList<string> list2 = new LinkedList<string>("Usman");
            list2.Add("Kuramshin");
            list2.Loop(x => Console.WriteLine(x)); 
        }
    }
}
