namespace InterpreterExample
{
    public abstract class Interpreter
    {
        public void Interpret(RomanNumeral numeral)
        {
            if (numeral.Input.Length == 0)
                return;

            if (numeral.Input.StartsWith(Nine()))
            {
                numeral.Output += (9 * Multiplier());
                numeral.Input = numeral.Input.Substring(2);
            }
            else if (numeral.Input.StartsWith(Four()))
            {
                numeral.Output += (4 * Multiplier());
                numeral.Input = numeral.Input.Substring(2);
            }
            else if (numeral.Input.StartsWith(Five()))
            {
                numeral.Output += (5 * Multiplier());
                numeral.Input = numeral.Input.Substring(1);
            }

            while (numeral.Input.StartsWith(One()))
            {
                numeral.Output += (1 * Multiplier());
                numeral.Input = numeral.Input.Substring(1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }
}