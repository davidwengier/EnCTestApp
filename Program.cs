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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine();

            try
            {
                Console.ResetColor();
                Console.WriteLine("Calling A");
                Console.ForegroundColor = ConsoleColor.Cyan;
                A();
                Console.ResetColor();
                Console.WriteLine("After Calling A");

                Console.ResetColor();
                Console.WriteLine("Calling B");
                Console.ForegroundColor = ConsoleColor.Cyan;
                B();
                Console.ResetColor();
                Console.WriteLine("After Calling B");

                Console.ResetColor();
                Console.WriteLine("Calling C");
                Console.ForegroundColor = ConsoleColor.Cyan;
                C();
                Console.ResetColor();
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