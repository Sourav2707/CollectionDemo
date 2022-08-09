using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class CollectionSample
    {
        public static void dosetDemo()
        {
            Console.WriteLine("In dosetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add(null);
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void doqueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Ral");
            queue.Enqueue("Jaishankar");
            Console.WriteLine($"Hear: {queue.Peek()}");
            Console.WriteLine("Interacting the queue elements");
            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine($"Dequeue element: {dequeue}");
            Console.WriteLine("Interacting the queue elements after dequeue one element");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
                {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void doDictionaryDemo()
        {
            Console.WriteLine("In doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine($"Access value using ket(key=100): {dictionary[100]}");
            Console.WriteLine("Interacting Dictionary");
            foreach(var element in dictionary)
            {
                Console.WriteLine($"keys ={element.Key} & value ={element.Value}");
            }
            Dictionary<int, string>.Enumerator obj = dictionary.GetEnumerator();
            while(obj.MoveNext())
            {
                Console.WriteLine(obj.Current);
            }
        }
        public static void doStackDemo()
        {
            Console.WriteLine("In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garina");
            stack.Push("Ayush");
            string pop = stack.Pop();
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"Poped element: {pop}");
        }
        public static void doListDemo()
        {
            Console.WriteLine("In doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list[3]);
        }
    }
}
