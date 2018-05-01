using System;
using System.Collections.Generic;

namespace InterpreterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string stringNumeral = "MMMCMLXVIII";
            var romanNumeral = new RomanNumeral(stringNumeral);

            var tree = new List<Interpreter>
            {
                new ThousandsInterpreter(),
                new HundredsInterpreter(),
                new TensInterpreter(),
                new OnesInterpreter()
            };

            foreach (var numeral in tree)
            {
                numeral.Interpret(romanNumeral);
            }

            Console.WriteLine("{0} = {1}", stringNumeral, romanNumeral.Output);
        }
    }
}
