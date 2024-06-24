using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LinkedList.CommitHistory
{
    public class CommitData
    {
        public Guid id = Guid.NewGuid();
        public Guid? referenceTo { get; set; }
        public string? message { get; set; }
        public string? auther { get; set; }
        public DateTime? dateTime = new DateTime().Date;
    }
}
