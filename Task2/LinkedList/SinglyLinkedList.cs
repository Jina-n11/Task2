using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T>? head { get; set; }
        public Node<T>? tail { get; set; }

        //Create Node
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            // هنا معناه اول نوداية
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                // هنا لمن اضيف نوديات ثانية
                tail._next = newNode;
                tail = newNode;
            }
        }

        public void DisplayList() {
            Node<T> current = head;
            while (current != null) {
                current.DisplayNode();
                current = current._next;
            }
        }

        public Node<T> GetLinkedList() {
            return head;
        }

        public void DisplayReverseOrderList(Node<T> current)
        {
            // لمن يتحقق شرط الركيرجن حتبدي الطباعة العكسية   
            if (current == null) return;
            DisplayReverseOrderList(current._next);
            current.DisplayNode();

        }

        public int CountNodesInLinkedList(Node<T> current)
        {
            var countNode = 0;
            while (current != null)
            {
                countNode++;
                current = current._next;
            }
            return countNode;
        }

        public void AddNodeInPosition(Node<T> node, int postion, T data)
        {

        }

        public void AddFirstNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode._next = head;
                head = newNode;
            }
        }

        public void AddLastNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail._next = newNode;
                tail = newNode;
            }
        }

        public dynamic? GetNode(int index)
        {
            Node<T> current = head;

            if (CountNodesInLinkedList(current) > index)
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
        public void DumpList() => head = null;


        public void RemoveFirstElement() {
            if (head == null) return;
            head = head._next;
        }
        public void RemoveLastElement()
        {
            Node<T> current = head;
            while (current._next._next != null)
            {
                current = current._next; 
            }
            current._next = null;
        }

    }
}
