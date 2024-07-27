namespace Program3
{
    /// <summary>
    /// Provides methods for binary operations including conversion and addition.
    /// </summary>
    public class BinaryCalculator
    {
        /// <summary>
        /// Converts an integer to its binary representation.
        /// </summary>
        /// <param name="number">The integer to convert.</param>
        /// <returns>A binary string representation of the integer.</returns>
        public string IntToBinary(int number)
        {
            if (number == 0) return "0";

            string result = "";
            while (number > 0)
            {
                result = (number % 2) + result;
                number /= 2;
            }
            return result;
        }

        /// <summary>
        /// Converts a floating-point number to its binary representation (fractional part).
        /// </summary>
        /// <param name="number">The floating-point number to convert.</param>
        /// <returns>A binary string representation of the fractional part of the number.</returns>
        public string FloatToBinary(float number)
        {
            if (number == 0) return "0";

            string binary = "";
            while (number > 0)
            {
                number *= 2;
                if (number >= 1)
                {
                    binary += "1";
                    number -= 1;
                }
                else
                {
                    binary += "0";
                }
            }
            return binary;
        }

        /// <summary>
        /// Adds two binary strings and returns the result as a binary string.
        /// </summary>
        /// <param name="bin1">The first binary string.</param>
        /// <param name="bin2">The second binary string.</param>
        /// <returns>The sum of the two binary strings as a binary string.</returns>
        public string AddBinary(string bin1, string bin2)
        {
            string result = "";
            int carry = 0;
            int i = bin1.Length - 1;
            int j = bin2.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += bin1[i] - '0';
                if (j >= 0) sum += bin2[j] - '0';
                result = (sum % 2) + result;
                carry = sum / 2;
                i--;
                j--;
            }

            return result;
        }

        /// <summary>
        /// Converts a binary string to its decimal integer representation.
        /// </summary>
        /// <param name="binary">The binary string to convert.</param>
        /// <returns>The decimal integer representation of the binary string.</returns>
        public int BinaryToInt(string binary)
        {
            int result = 0;
            int power = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                int digit = binary[i] - '0';
                result += digit * power;
                power *= 2;
            }

            return result;
        }

        /// <summary>
        /// Converts a binary string representing a fractional part to its decimal floating-point representation.
        /// </summary>
        /// <param name="binary">The binary string to convert.</param>
        /// <returns>The decimal floating-point representation of the binary string.</returns>
        public float BinaryToFloat(string binary)
        {
            float result = 0;
            float power = 0.5f;

            foreach (char c in binary)
            {
                if (c == '1')
                {
                    result += power;
                }
                power /= 2;
            }

            return result;
        }
    }
}