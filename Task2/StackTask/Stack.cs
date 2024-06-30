using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2.StackTask
{
    public class Stack<T>
    {
        private List<T>? items = new List<T>(7);
        private int top = 0;

        public Stack(List<T> Items) 
        {
            items = Items;
        }

        public void push( T data)
        {
            if (isOverFlow())
            {
                Console.WriteLine("Stack Overflow");
            }
            else 
            { 
                items?.Add(data);
                top++;
            }
        }


        public dynamic? pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                return this.items[top--];
            }
            return null;
        }

        public bool isEmpty() => top == -1;

        public bool isOverFlow() => top > this.items?.Count;


        public void DisplayDescendingOrder()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                foreach (var item in this.items.OrderByDescending(item=> item))
                {
                    Console.WriteLine($"{item}");
                }
            }
        }

        public void DisplayAscendingOrder()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                foreach (var item in this.items.Order())
                {
                    Console.WriteLine($"{item}");
                }
            }
        }

        public void DisplayReverse()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for(int i = top; i > 0; i++)
                {
                    Console.WriteLine($"{items[i]}");
                }
            }
        }


        public void ReverseStack()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                // أخذ اخر عنصر واول عنصر حتى اسويلهم سواب
                int startItemPostion = 0;
                int endItemPostion = top;
                T temp = this.items[startItemPostion];

                // 
                while (startItemPostion < endItemPostion)
                {
                  // عمليةالسوابنك
                    temp = this.items[startItemPostion];
                    this.items[startItemPostion] = items[endItemPostion];
                    this.items[endItemPostion] = temp;

                    // اقلل من اخر عنصر وازيد من اول عنصر حتى تمشي اللست من البداي و والنهاية واقلب بينهم
                    endItemPostion--;
                    startItemPostion++;
                }
            }
        }


        public T? FindMinimumItem()
        {
            // أخذ اول عنصر حتى اقارن بي كاصغر عنصر
            int firstItemPostion = 0;
            T minimumItem = this.items[firstItemPostion];

            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
               
            }
            else
            {
                // 
                for (int i = 0; i<this.items.Count;i++)
                {

                    // item is less than minimumItem
                    if (Comparer<T>.Default.Compare(this.items[firstItemPostion] , minimumItem) < 0) 
                    {
                        minimumItem = this.items[firstItemPostion];
                    }
                }
                
            }

            return minimumItem;
        }



        public T? FindMaximumItem()
        {
            // أخذ اول عنصر حتى اقارن بي كاصغر عنصر
            int firstItemPostion = 0;
            T maximumItem = this.items[firstItemPostion];

            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");

            }
            else
            {
                for (int i = 0; i < this.items.Count; i++)
                {
                    // item is greater than  maximumItem
                    if (Comparer<T>.Default.Compare(this.items[firstItemPostion] , maximumItem) > 0)
                    {
                        maximumItem = this.items[firstItemPostion];
                    }
                }

            }

            return maximumItem;
        }




        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                foreach (var item in this.items)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }

        public void RemoveStack() 
        { 
            this.items.Clear();

            top = -1;
        }
        public int SizeOfStack() => top;
        public void RemoveItem(int index)
        {
            this.items.RemoveAt(index);
            top--;
        }

        public int CountItem(T data)
        {
            int count = 0;
            foreach (var item in this.items)
            {
                //هنا معناه متشابهين
                if (Comparer<T>.Default.Compare(item, data) == 0)
                {
                    count++; 
                }
            
            }
            return count;
        }

        public void RemoveDuplicateItems()
        {
            List<T>? list =  this.items ;
          list.Order();
            for (int i = 0; i< list.Count()- 1; i++ )
            {
                // متشابهين
                if (Comparer<T>.Default.Compare(list[i], list[i + 1]) == 0)
                {
                    /*[6 6 6 8]
                     * i=0
                     *  6==6
                     *    remove list[i] = [6 6 8]
                     */
                    list.RemoveAt(i);   
                    top--;
                }
            }
        }

    }
}
