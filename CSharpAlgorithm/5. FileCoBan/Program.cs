namespace _5._FileCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            DriveInfo driveInfo = new DriveInfo("C");

            string path = "DirectoryTest";
            
            if (Directory.Exists(path)) 
            {
                Console.WriteLine($"{path} - ton tai");
            }
            else
            {
                Console.WriteLine($"{path} - khong ton tai");
            }

            Directory.Delete(path);
        }
    }
}