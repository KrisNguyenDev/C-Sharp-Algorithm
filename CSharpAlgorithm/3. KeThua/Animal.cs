using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._KeThua
{
    public class Animal
    {
        public int Legs { get; set; }
        public float Weight { get; set; }

        public virtual void ShowLeg()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}
