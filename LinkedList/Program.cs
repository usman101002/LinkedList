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

            foreach (var node in list)
            {
                Console.WriteLine(node);
            }
            
            
        }
    }
}
