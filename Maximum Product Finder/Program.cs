namespace Program2
{
    class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        static void Main()
        {
            MaximumProductFinder maximumProductFinder = new MaximumProductFinder();
            // Prompt user for input and validate it.
            string input = maximumProductFinder.GetValidatedNumericInput("Enter a numeric string: ");

            // Calculate the maximum product of four consecutive digits.
            long maxProduct = maximumProductFinder.FindMaxProductOfFourConsecutiveDigits(input);

            // Output the result.
            Console.WriteLine("Maximum product of four consecutive digits is: " + maxProduct);
        }
    }
}