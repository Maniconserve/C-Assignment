namespace cognine.program2
{
    class MaximumProduct
    {
        /// <summary>
        /// Finds the maximum product of four consecutive digits in a numeric string.
        /// </summary>
        /// <param name="numericString">The numeric string to analyze.</param>
        /// <returns>The maximum product of four consecutive digits.</returns>
        public long MaxProduct(string numericString)
        {
            long maxProduct = 0;

            // Calculate the maximum product of four consecutive digits.
            for (int index = 0; index < numericString.Length - 3; index++)
            {
                long product = 1;
                for (int inc = 0; inc < 4; inc++)
                {
                    product *= numericString[index + inc] - '0';
                }
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }
    }
}