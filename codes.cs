/*1.      Take two strings as input and check whether the second string is a sub-string of the first or not. If yes, print 
the number of times occurred in S1 and 
print the index positions where the string appeared]

i/p : S1 = “abcdabcabd”

        S2 = “ab”

o/p: No.of times occurred = 3

        Index positions = 0 4 7*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string S1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string S2 = Console.ReadLine();

        List<int> positions = new List<int>();
        int j = 0;

        for (int i = 0; i < S1.Length; i++)
        {
            int k = 0;
            while (k < S2.Length && i + k < S1.Length && S1[i + k] == S2[k])
            {
                k++;
            }
            if (k == S2.Length)
            {
                positions.Add(i);
            }
        }

        Console.WriteLine("No. of times occurred = " + positions.Count);
        Console.Write("Index positions = ");
        foreach (int i in positions)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
/*2. Find the four adjacent digits in any given number that have the greatest product. What is the value of this product?

i/p: 1234568987458744574664554 (input can be any)
o/p: 8*9*8*7=4032*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        long maxProduct = 0;
        for (int i = 0; i < input.Length - 3; i++)
        {
            long product = 1;
            for (int j = 0; j < 4; j++)
            {
                product *= input[i + j] - '0';
            }
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        Console.WriteLine(maxProduct);
    }
}
