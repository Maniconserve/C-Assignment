namespace cognine.program1
{

    class Program
    {
        public static void Main()
        {
            SubStringCount subStringCount = new SubStringCount();
            Validations validations = new Validations();
            string source = validations.ValidateInput("Enter the first string: ");
            string pattern = validations.ValidateInput("Enter the second string: ");

            // Find occurrences of the second string in the first string.
            (int[] positions,int count) = subStringCount.SubstringOccurrences(source, pattern);

            // Output the number of occurrences and their starting positions.
            Console.WriteLine("Number of occurrences = " + count);
            if (positions.Length > 0)
            {
                Console.Write("Index positions = ");
                for(int index = 0;index<count;index++)
                {
                    Console.Write(positions[index] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}