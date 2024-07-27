namespace Program1
{

    class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        public static void Main()
        {
            PatternFinder patternFinder = new PatternFinder();
            string firstString = patternFinder.GetValidatedInput("Enter the first string: ");
            string secondString = patternFinder.GetValidatedInput("Enter the second string: ");

            // Find occurrences of the second string in the first string.
            int[] positionsArray = patternFinder.FindSubstringOccurrences(firstString, secondString);

            // Output the number of occurrences and their starting positions.
            Console.WriteLine("Number of occurrences = " + positionsArray.Length);
            Console.Write("Index positions = ");
            foreach (int position in positionsArray)
            {
                Console.Write(position + " ");
            }
            Console.WriteLine();
        }
    }
}