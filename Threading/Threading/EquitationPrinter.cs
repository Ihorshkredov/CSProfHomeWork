using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class EquitationPrinter
    {
        public static void PrintResult(EquitationResult result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Your equitation roots: X1 = {result.RootX1}, X2 = {result.RootX2}");
            Console.WriteLine($"{result.Comment}");
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();
        }

    }
}
