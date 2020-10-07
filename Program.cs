using System;
using System.Collections.Generic;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = (args.Length == 0 ? Console.ReadLine() : args[0]);

            List<byte> chars = new List<byte>();
            foreach (byte c in s)
            {
                if (!chars.Contains(c))
                {
                    Console.WriteLine($"{Convert.ToChar(c)} [0x{c.ToString("X2")}]: {s.Split(Convert.ToChar(c)).Length - 1}");
                    chars.Add(c);
                }
            }
            if (args.Length == 0) Console.ReadKey();
        }
    }
}
