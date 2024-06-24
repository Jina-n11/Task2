using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.PackageTask
{
    public class Package
    {
        public bool isFragile { get; set; }
        public int weight { get; set; }
        public Package(bool IsFragile, int Weight)
        {
            isFragile = IsFragile;
            weight = Weight;
        }
    }
}
