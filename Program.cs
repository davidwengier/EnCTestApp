using System.Text;
using static EnCTestApp.Helpers;

namespace EnCTestApp;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine();

            try
            {
                Console.WriteLine("Calling A");
                A();
                Console.WriteLine("After Calling A");

                Console.WriteLine("Calling B");
                B();
                Console.WriteLine("After Calling B");

                Console.WriteLine("Calling C");
                C();
                Console.WriteLine("After Calling C");
            }
            catch
            {
                Console.WriteLine("A problem happened!");
            }

            PrintMembers();

            Thread.Sleep(500);
        }
    }

    public static void A()
    {
        Console.WriteLine("Hello from A");
    }

    public static void B()
    {
        Console.WriteLine("Hello from B");
    }

    public static void C()
    {
        Console.WriteLine("Hello from C");
    }
}