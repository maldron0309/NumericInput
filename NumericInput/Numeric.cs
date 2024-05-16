namespace NumericInput
{
    public class Numeric
    {
        public static string ReadInput()
        {
            string input = Console.ReadLine();

            return input;
        }

        public static bool IsValidNum(string input)
        {
            double res;

            return double.TryParse(input, out res);
        }

        public static int ReadInteger()
        {
            string input;
            int value;

            while (true)
            {
                input = ReadInput();
                if (int.TryParse(input, out value)) return value;
                else Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        public static double ReadDouble()
        {
            string input;
            double value;

            while (true)
            {
                input = ReadInput();
                if (double.TryParse(input, out value)) return value;
                else Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
