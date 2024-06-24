using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LinkedList.CommitHistory
{
    public class CommitData
    {
        public Guid id { get; set; }
        public Guid? referenceTo { get; set; }
        public string? message { get; set; }
        public string? auther { get; set; }
        public DateTime? dateTime { get; set; }

        public CommitData(Guid ReferenceTo , string Message , string Auther)
        {
            id = Guid.NewGuid();
            referenceTo = ReferenceTo;
            message = Message;
            auther = Auther;  
            dateTime = DateTime.Now;
        }
    }
}
