namespace cognine.program3
{
    public class NormOps
    {
        /// <summary>
        /// Prompts the user for input and retrieves the input string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <returns>The user's input string.</returns>
        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Parses a numeric string into integer and fractional parts.
        /// </summary>
        /// <param name="number">The numeric string to parse.</param>
        /// <returns>A tuple containing the integer and fractional parts.</returns>
        public (int, float) ParseNumber(string number)
        {
            var parts = number.Split(".");
            if (parts.Length != 2) throw new Exception("Invalid input format.");

            int intPart = int.Parse(parts[0]);
            float fracPart = float.Parse("0." + parts[1]);
            return (intPart, fracPart);
        }

        /// <summary>
        /// Pads a binary string to the specified length with '0' characters.
        /// </summary>
        /// <param name="binary">The binary string to pad.</param>
        /// <param name="length">The length to pad the binary string to.</param>
        /// <returns>The padded binary string.</returns>
        public string PadBinary(string binary, int length)
        {
            return binary.PadRight(length, '0');
        }

        /// <summary>
        /// Splits a binary sum into integer and fractional parts.
        /// </summary>
        /// <param name="sumBinary">The binary sum to split.</param>
        /// <param name="fractionLength">The length of the fractional part.</param>
        /// <returns>A tuple containing the integer part and fractional part of the binary sum.</returns>
        public (string, string) SplitBinarySum(string sumBinary, int fractionLength)
        {
            string integerPart = sumBinary.Substring(0, sumBinary.Length - fractionLength);
            string fractionPart = sumBinary.Substring(sumBinary.Length - fractionLength);
            return (integerPart, fractionPart);
        }
    }
}
