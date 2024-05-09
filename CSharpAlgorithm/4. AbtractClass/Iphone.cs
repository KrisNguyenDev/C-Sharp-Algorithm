using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._AbtractClass
{
    public class Iphone : Product
    {
        public override string Name { get; set; }

        public override void Info()
        {
            Console.WriteLine(Name);
        }
    }
}
