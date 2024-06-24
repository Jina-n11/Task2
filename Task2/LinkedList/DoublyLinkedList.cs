using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T>? head { get; set; }
        public Node<T>? tail { get; set; }
        public int count { get; set; } = 0;

        // head<=(|prev|data|next|)=>tail
        // head<=|prev|data|next|-----|prev|data|next|=>tail

        //Create Node
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            // هنا معناه اول نوداية
            if (head == null)
            {
                head = tail = newNode;
                count++;
            }
            else
            {
                // هنا لمن اضيف نوديات ثانية
                tail._next = newNode;
                newNode._prev = tail;
                tail = newNode;

                count++;
            }
        }

        public Node<T> GetLinkedList()
        {
            return head;
        }

        public void DisplayList() {
            Node<T> current = head;
            while (current != null) {
                current.DisplayNode();
                current = current._next;
            }
        }

        //1
        public void DisplayReverseOrder()
        {
            Node<T> current = tail;
            while (current != null)
            {
                current.DisplayNode();
                current = current._prev;
            }
        }

        //2
        public void DisplayReverseOrderList(Node<T> current)
        {
            // لمن يتحقق شرط الركيرجن حتبدي الطباعة العكسية   
            if (current == null) return;
            DisplayReverseOrderList(current._next);
            current.DisplayNode();

        }


        public void AddFirstNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
                count++;
            }
            else
            {
                // head <==| prev | data | next |---| prev | data | next | -----| prev | data | next |=> tail
                newNode._next = head;
                head = newNode;
                count++;
            }
        }


        public dynamic? GetNode(int index)
        {
            Node<T> current = head;

            if (count > index || index < 0)
            {
                int counter = 0;
                while (counter < index)
                {
                    counter++;
                    current = current._next;
                }
                return current._data;

            }
            return "out of the range";
        }


        public int GetIndexOfElement(T data)
        {
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current._data, data))
                    return index;

                index++;
                current = current._next; ;
            }

            return -1;
        }

        public bool IsEmpty() => head == null;
        public void DumpList()
        {
            head = null;
            count = 0;
        }


        public void RemoveFirstElement() {
            if (head == null) return;
            head = head._next;
            count--;
        }

        //1
        //public void RemoveLastElement()
        //{
        //    Node<T> current = head;
        //    while (current._next._next != null)
        //    {
        //        current = current._next; 
        //    }
        //    current._next = null;

        //    count--;
        //}

        //2
        public void RemoveLastElement()
        {
            // head <==| prev | data | next |---| prev | current | next | -----| prev | data | next |=> tail
            Node<T> current = tail._prev;
            tail = current;
            current._next = null;
            count--;
        }

        public void AddNodeInPosition(int postion, T data)
        {
            Node<T> current = head;
            Node<T> newNode = new Node<T>(data);
            int index = 0;

             if (postion < 0)
            {
                AddFirstNode(data);
            }
            else
            {
                while (current != null)
                {
                    if (postion == index)
                    {
                        //postion = 2
                        // 0---1---2---3
                        // 0---1---node -- 2---3
                        // head <==| prev | data | next |---| prev | data | next | --| prev | data | next |--| prev | data | next |=> tail
                        // head <==| prev | data | next |---| prev | data | next | -  | |newNode| |    -| prev | data | next |--| prev | data | next |=> tail
                        newNode._next = current;
                        newNode._prev = current._prev;
                        current._prev._next = newNode;


                    }
                    index++;
                    current = current._next;
                }

                count++;
            }
        }
        public void RemoveNodeInPosition(int postion)
        {
            Node<T> current = head;
            int index = 0;

                while (current != null)
                {
                    if (postion == index)
                    {
                    //postion = 2
                    // 0---1---2---3
                    // 0---1-- 2---3
                    // head <==| prev | data | next |---| prev | data | next | --| prev | current | next |--| prev | data | next |=> tail
                        current._prev._next = current._next;
                        current._next = null;
                    }
                    index++;
                    current = current._next;
                }

                count++;
        }

    }
}
