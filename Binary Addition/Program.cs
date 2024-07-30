namespace cognine.program3
{
    class Program
    {
        public static void Main()
        {
            try
            {
                NormOps normOps = new NormOps();
                BinaryCalculator calculator = new BinaryCalculator();
                string firstNumber = normOps.GetInput("Enter the first number (format: integer.fraction): ");
                string secondNumber = normOps.GetInput("Enter the second number (format: integer.fraction): ");

                (int integerPart1, float fractionalPart1) = normOps.ParseNumber(firstNumber);
                (int integerPart2, float fractionalPart2) = normOps.ParseNumber(secondNumber);

                string binaryIntegerPart1 = calculator.IntToBinary(integerPart1);
                string binaryFractionalPart1 = calculator.FloatToBinary(fractionalPart1);
                string binaryIntegerPart2 = calculator.IntToBinary(integerPart2);
                string binaryFractionalPart2 = calculator.FloatToBinary(fractionalPart2);

                string paddedBinary1 = normOps.PadBinary(binaryIntegerPart1 + binaryFractionalPart1, binaryFractionalPart1.Length);
                string paddedBinary2 = normOps.PadBinary(binaryIntegerPart2 + binaryFractionalPart2, binaryFractionalPart2.Length);

                string binarySum = calculator.AddBinary(paddedBinary1, paddedBinary2);

                (string sumIntegerPart, string sumFractionPart) = normOps.SplitBinarySum(binarySum, binaryFractionalPart1.Length);

                int resultIntegerPart = calculator.BinaryToInt(sumIntegerPart);
                float resultFractionalPart = calculator.BinaryToFloat(sumFractionPart);

                
                Console.WriteLine($"Final result: {resultIntegerPart + resultFractionalPart}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
