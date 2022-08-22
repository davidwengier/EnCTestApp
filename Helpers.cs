using System.Diagnostics;

namespace EnCTestApp;

public static class Helpers
{
    public static void PrintMembersWithParameters()
    {
        int row = 2;
        int col = 50;
        var t = typeof(Program);
        foreach (var m in t.GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.DeclaredOnly))
        {
            Console.SetCursorPosition(col, ++row);
            Console.Write($"Method '{m.Name}'");
            Console.SetCursorPosition(col, ++row);
            Console.Write($"  Return Type: '{m.ReturnType.Name}'");

            Console.SetCursorPosition(col, ++row);
            Console.Write($"  Parameters: {m.GetParameters().Length}");

            foreach (var p in m.GetParameters())
            {
                Console.SetCursorPosition(col, ++row);
                Console.Write($"   - {p.Name}: {p.ParameterType.Name}");
            }
        }
    }

    public static string GetMethodName()
    {
        return new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "(null)";
    }
}
