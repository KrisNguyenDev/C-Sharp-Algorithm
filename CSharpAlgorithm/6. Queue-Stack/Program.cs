namespace _6._Queue_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Queue
           Queue<string> hoSos = new Queue<string>();

            hoSos.Enqueue("Ho so 1");
            hoSos.Enqueue("Ho so 2");
            hoSos.Enqueue("Ho so 3");

           var hoSo = hoSos.Dequeue();
            Console.WriteLine($"Xu ly ho so: {hoSo} - {hoSos.Count()}");

            // Stack
            Stack<string> hangHoas  = new Stack<string>();

            hangHoas.Push("mat hang 1");
            hangHoas.Push("mat hang 2");
            hangHoas.Push("mat hang 3");

            hangHoas.Pop();

            foreach (var item in hangHoas) 
            {
                Console.WriteLine(item);
            }

            // LinkedList
            LinkedList<string> baihocs = new LinkedList<string>();

            var bh1 = baihocs.AddFirst("Bai hoc 1");
            baihocs.AddLast("Bai hoc 3");
            var bh2 = baihocs.AddAfter(bh1, "Bai hoc 2");
            baihocs.AddLast("Bai hoc 4");
            baihocs.AddLast("Bai hoc 5");

            var bh3 = bh2.Next;

            foreach (var item in baihocs)
            {
                Console.WriteLine(item);
            }
        }
    }
}