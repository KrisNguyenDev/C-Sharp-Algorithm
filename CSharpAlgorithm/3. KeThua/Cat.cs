using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._KeThua
{
    public class Cat: Animal
    {
        public string Food { get; set; }

        public void Eat()
        {
            Console.WriteLine($"Cat eat {Food}");
        }

        public override void ShowLeg()
        {
            Console.WriteLine($"Cat have {this.Legs} legs");
        }
    }
}
