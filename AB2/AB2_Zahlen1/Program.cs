namespace AB2_Zahlen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadIntInRange("Enter an integer between 1 and 100: ", 1, 100);
        }

        static int ReadIntInRange(string prompt, int min, int max) 
        {
            int result;
            bool isValid;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result) && result >= min && result <= max)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            } while (!isValid);
            return result;
        }
    }
}
