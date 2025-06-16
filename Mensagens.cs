using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal static class Mensagens
    {
        public static void Texto(string t, string cor)
        {
            if (cor == "red") { Console.ForegroundColor = ConsoleColor.Red; }
            if (cor == "blue") { Console.ForegroundColor = ConsoleColor.Blue; }
            Console.WriteLine(t);
            Console.ResetColor();
        }
    }
}
