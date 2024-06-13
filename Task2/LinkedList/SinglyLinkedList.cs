using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T>? head {  get; set; } 
        public Node<T>? tail {  get; set; }

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
            if (current == null)  return;
            DisplayReverseOrderList(current._next);
            current.DisplayNode();

        }

        public void CountNodesInLinkedList(Node<T> current)
        {
            var countNode = 0;
            while (current != null)
            {
                countNode++;
                current = current._next;
            }
            Console.WriteLine($"Count the nodes in linledList = {countNode}");
        }

        public void AddNodeInPosition(Node<T> node , int postion , T data) 
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

    }
}
