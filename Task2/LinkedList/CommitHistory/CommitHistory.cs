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


        public CommitData? GetCommitById(string? id)
        {
            Node<CommitData> current = head;

                while (current != null)
                {
                    if (current._data.id == id)
                    {
                        return current._data;
                    }
                    current = current._next;
                }

            return null;
        }

        public CommitData? GetCommitByMessage(string? message)
        {
            Node<CommitData> current = head;

            while (current != null)
            {
                if (current._data.message == message)
                {
                    return current._data;
                }
                current = current._next;
            }

            return null;
        }


        public void AddNewCommit(CommitData data , string referenceTo)
        {
            data.referenceTo = referenceTo;
            Node<CommitData> newNode = new Node<CommitData>(data);

                tail._next = newNode;
                newNode._prev = tail;
                tail = newNode;
                count++;

                AddToHistoryCommitFile(data);
        }


        public void AddToHistoryCommitFile(CommitData data)
        {
            const string commitPath = @"../../../LinkedList/CommitHistory/CommitHistoryFile.txt";
            if (!Directory.Exists("../../../LinkedList/CommitHistory/"))
            {
                Directory.CreateDirectory("../../../LinkedList/CommitHistory/");
            }
            try
            {
                string descripation = $"\n{data.id}\n message: {data.message}\n Auther : {data.auther}\n DateTime: {data.dateTime}\n ReferenceTo: {data.referenceTo} \n ############################## \n \n";
                File.AppendAllText(commitPath, descripation);
            }
            catch (Exception)
            {
            }
        }

    }
}
