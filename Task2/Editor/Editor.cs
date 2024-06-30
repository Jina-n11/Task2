using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Editor
{

    /*  stack =  [hhhhh ,hhhhh] => file
     *
     */

    public class Editor<T>
    {
        public List<T> data { get; set;}
        private int top = -1;

        public Editor(List<T>? Data)
        {
            data = Data;
        }


        // اضافة الداتا الى الاستاك ومن ثم اضافته الى الفايل
        // same add
        public void Push(T? data)
        {
            this.data.Add(data);
            top++;
            //add to file
            AddToFile(data as string);

        }

        // add to file
        public void AddToFile(string data)
        {
            const string path = @"../../../Editor/EditorFile.txt";

            if (!Directory.Exists("../../../Editor/"))
            {
                Directory.CreateDirectory("../../../Editor/");
            }

            File.AppendAllText(path, data);
        }

        // same undo
        public dynamic? pop()
        {
            //
            if(top == -1)
            {
                Console.WriteLine("stack is Empty");
                return null;
            }    

            return this.data[top--];
        }

        /// <summary>
        /// hdjhjg  ///
        /// hdghsjdgh
        /// </summary>
        // لمن ارجع خطوة سابقة
        public void undo()
        {
            //
            if (top == -1)
            {
                Console.WriteLine("stack is Empty");
            }

            top--;


            /// add to file 
            for (int i = 0; i< top; i++)
            {
                AddToFile(this.data[top--] as string);
            }
           
        }

    }
}
