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
                Console.WriteLine("Calling M1");
                M1();
                Console.WriteLine("After Calling M1");

                Console.WriteLine("Calling M2");
                M2();
                Console.WriteLine("After Calling M2");
            }
            catch
            {
                Console.WriteLine("A problem happened!");
            }

            PrintMembers();

            Thread.Sleep(500);
        }
    }

    public static void M1()
    {
        Console.WriteLine("I'm in M1 version 1");
    }

    public static void M2()
    {
        Console.WriteLine("I'm in M2 version 2");
    }
}