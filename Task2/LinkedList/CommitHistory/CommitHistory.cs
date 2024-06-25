using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Task2.LinkedList.CommitHistory;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2.LinkedList
{
    public class CommitHistory<T>
    {
        public Node<CommitData>? head { get; set; }
        public Node<CommitData>? tail { get; set; }
        public int? count { get; set; }

        public void Add(CommitData data)
        {
            Node<CommitData> newNode = new Node<CommitData>(null);

            if (head == null)
            {
                newNode._data = data;
                head = tail = newNode;
                count++;
                AddToHistoryCommitFile(data);
            }
            else
            {
                data.referenceTo = tail._data.id ;
                newNode._data = data;
                tail._next = newNode;
                newNode._prev = tail;
                tail = newNode;

                count++;

                AddToHistoryCommitFile(data);
            }
        }

        public Node<CommitData> GetLinkedList()
        {
            return head;
        }

        public void DisplayList()
        {
            Node<CommitData> current = head;
            while (current != null)
            {
                string descripation = $"\n{current._data.id}\n Message: {current._data.message}\n Auther : {current._data.auther}\n DateTime: {current._data.dateTime}\n ReferenceTo: {current._data.referenceTo} \n ############################## \n";
                Console.WriteLine( descripation );
                current = current._next;
            }
        }


        public dynamic? GetNode(int index)
        {
            Node<CommitData> current = head;

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


        //public int GetIndexOfElement(T data)
        //{
        //    Node<CommitData> current = head;
        //    int index = 0;
        //    while (current != null)
        //    {
        //        if (EqualityComparer<CommitData>.Default.Equals(current._data, data))
        //            return index;

        //        index++;
        //        current = current._next; ;
        //    }

        //    return -1;
        //}

        public void AddFirstNode(CommitData data)
        {
            Node<CommitData> newNode = new Node<CommitData>(data);
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


        public void AddNodeInPosition(int postion, CommitData data)
        {
            Node<CommitData> current = head;
            Node<CommitData> newNode = new Node<CommitData>(data);
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
            Node<CommitData> current = head;
            int index = 0;

            while (current != null)
            {
                if (postion == index)
                {
                    current._prev._next = current._next;
                    current._next = null;
                }
                index++;
                current = current._next;
            }

            count++;
        }



        public void AddToHistoryCommitFile(CommitData data)
        {
            const string commitPath = @"File\CommitHistoryFile.txt";

            try
            {
                string descripation = $"{data.id}\n message: {data.message}\n Auther : {data.auther}\n DateTime: {data.dateTime}\n ReferenceTo: {data.referenceTo} \n ############################## \n";
                File.AppendAllText(commitPath, descripation);
            }
            catch (Exception)
            {
            }
        }

    }
}
