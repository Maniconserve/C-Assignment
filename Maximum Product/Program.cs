namespace cognine.program2
{
    class Program
    {
        public static void Main()
        {
            MaximumProduct maximumProduct = new MaximumProduct();
            Validations validations = new Validations();
            // Prompt user for input and validate it.
            string input = validations.ValidateInput("Enter a numeric(more than three digits): ");

            // Calculate the maximum product of four consecutive digits.
            long maxProduct = maximumProduct.MaxProduct(input);

            // Output the result.
            Console.WriteLine("Maximum product of four consecutive digits is: " + maxProduct);
        }
    }
}