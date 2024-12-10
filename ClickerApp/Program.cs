using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;

    static void Main(string[] args)
    {
        while (true)
        {
            // Simular clique do mouse
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Console.WriteLine("Mouse click simulated at " + DateTime.Now);

            // Esperar por 1 minuto (60.000 milissegundos)
            Thread.Sleep(60000);
        }
    }
}