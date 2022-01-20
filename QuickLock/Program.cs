namespace QuickLock
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }
    }
}
