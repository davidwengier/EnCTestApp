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

            M();

            PrintMembersWithParameters();

            Thread.Sleep(500);
        }
    }

    public static void M()
    {
        Console.WriteLine(M2().ToString());

        //string L(int x, long y)
        //{
        //    return $"""
        //        x is:
        //            - {x.GetType().Name}
        //            - equal to '{x}'

        //        """ +
        //             $"""
        //        y is
        //            - {y.GetType().Name}
        //            - equal to '{y}'

        //        """ +
        //             $"""
        //        this method is
        //            - named '{GetMethodName()}'
        //        """;
        //}
    }

    private static string M2()
    {
        var sb = new StringBuilder();
        sb.Append($"""
            this method is
                - named '{GetMethodName()}'
            """);
        return sb.ToString();
    }
}