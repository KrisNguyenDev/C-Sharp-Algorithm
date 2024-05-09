namespace _4._AbtractClass
{
    interface IHinhHoc
    {
        double TinhChuVi();
        double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {
        public double a { get; set; }
        public double b { get; set; }

        public HinhChuNhat()
        {

        }
        public HinhChuNhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double TinhChuVi()
        {
            return (a + b) * 2;
        }

        public double TinhDienTich()
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Iphone ip = new Iphone() { Name = "Iphone 13" };
            ip.Info();

            Console.WriteLine("-------------------");

            HinhChuNhat hinhChuNhat = new HinhChuNhat(2,4);
            Console.WriteLine($"Chu vi hình chu nhat: {hinhChuNhat.TinhChuVi()}");
        }
    }
}