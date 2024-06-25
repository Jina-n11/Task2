using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LinkedList
{
    public class Node<T>
    {
        public T? _data { get; set; } 
        public Node<T>? _next { get; set; }
        public Node<T>? _prev { get; set; }

        public Node(T? data)
        {
            _data = data;
        }

        public void DisplayNode() 
        {
            if (_data != null)
            {
                Console.WriteLine(_data);
            }
            else
            {
                Console.WriteLine("dont have data");
            }
        }
    }
}
