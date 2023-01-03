using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public static class Colections
    {
        public static void DoListDemo()
        {
            Console.WriteLine("ListDemo");
            List<string> list = new List<string>();
            list.Add("Marco");
            list.Add("Reus");
            list.Add("Muller");
            list.Add("Thomas");
            list.Remove("Muller");
            foreach(var items in list)
            {
                Console.WriteLine(items);
            }
        }
        public static void DoStackDemo()
        {
            Console.WriteLine("\n Stack Demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Luffy");
            stack.Push("Zoro");
            stack.Push("Sanji");
            stack.Push("Nami");
            string pop=stack.Pop();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
