namespace _2._Class
{
    class Student
    {
        public int MyProperty { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi();

            VuKhi vuKhi2 = new VuKhi() { Name = "Sung Truong", DoSatThuong = 5};

            Console.ReadKey();
        }
    }
}