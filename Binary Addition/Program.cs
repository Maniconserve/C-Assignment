namespace cognine.program3
{
    class Program
    {
        public static void Main()
        {
            NormOps normOps = new NormOps();
            BinaryCalculator calculator = new BinaryCalculator();

            (int firstInteger, float firstFractional) = normOps.ParseNumber("Enter the first number (format: integer.fraction): ");
            (int secondInteger, float secondFractional) = normOps.ParseNumber("Enter the second number (format: integer.fraction): ");

            string firstBinaryInt = calculator.IntToBinary(firstInteger);
            string firstBinaryFrac = calculator.FloatToBinary(firstFractional);
            string secondBinaryInt = calculator.IntToBinary(secondInteger);
            string secondBinaryFrac = calculator.FloatToBinary(secondFractional);

            int maxFractionLength = Math.Max(firstBinaryFrac.Length, secondBinaryFrac.Length);

            // Pad fractional parts to align them
            string firstPaddedFrac = normOps.PadBinary(firstBinaryFrac, maxFractionLength);
            string secondPaddedFrac = normOps.PadBinary(secondBinaryFrac, maxFractionLength);

            // Combine integer and fractional parts
            string firstCombined = firstBinaryInt + firstPaddedFrac;
            string secondCombined = secondBinaryInt + secondPaddedFrac;

            // Add binary strings
            string binarySum = calculator.AddBinary(firstCombined,secondCombined);

            // Extract integer and fractional parts from the result
            (string sumIntegerPart, string sumFractionPart) = normOps.SplitBinarySum(binarySum, maxFractionLength);

            // Convert back to integer and fractional parts
            int integerPart = calculator.BinaryToInt(sumIntegerPart);
            float fractionalPart = calculator.BinaryToFloat(sumFractionPart);

            Console.WriteLine($"Final result: {integerPart + fractionalPart}");
        }

    }
}
