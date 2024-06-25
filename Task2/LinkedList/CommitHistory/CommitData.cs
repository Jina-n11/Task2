using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LinkedList.CommitHistory
{
    public class CommitData
    {
        public string id { get; set; }
        public string? referenceTo { get; set; }
        public string? message { get; set; }
        public string? auther { get; set; }
        public DateTime? dateTime { get; set; }

        public CommitData(string? Message, string? Auther , string? Id = null)
        {
            id = Id != null ? Id : Guid.NewGuid().ToString();
            //referenceTo = ReferenceTo;
            message = Message;
            auther = Auther;
            dateTime = DateTime.Now;
        }
    }
}
