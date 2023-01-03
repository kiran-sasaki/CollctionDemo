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
        public static void DoQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Dazai");
            queue.Enqueue("Kunikida");
            queue.Enqueue("Kyoko");
            Console.WriteLine("Head "+queue.Peek());
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Element "+dequeue);
            Console.WriteLine("Itrating The Queue");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public static void DoSetDemo()
        {
            var set = new HashSet<string>();
            set.Add("Kakashi");
            set.Add("Orochimaru");
            set.Add("Hashirama");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while( enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
