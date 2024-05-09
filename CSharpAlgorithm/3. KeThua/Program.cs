namespace _3._KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat() { Food = "fish", Legs = 4, Weight = 3 };
            cat.ShowLeg();
            cat.Eat();
        }
    }
}