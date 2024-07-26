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
/*3. Input: Consider n, and m as two float inputs

Implementation: Convert float inputs to binary and perform addition and convert the result back to float.

Output: Print the float result*/
using System;
public class Program
{
    public static string DtoB(int a)
    {
        string result = "";
        while (a > 0)
        {
            result = (a % 2) + result;
            a /= 2;
        }
        return result;
    }
    public static String DtoB(float a)
    {
        String b2 = "";
        int count = 0;
        while (a != 1.0)
        {
            b2 = b2 + (int)(a * 2);
            a = a * 2;
            if (a > 1) a = a - 1;
        }
        return b2;
    }
    public static String AddBinary(String s1, String s2)
    {
        String res = "";
        int carry = 0;
        int i = s1.Length - 1;
        int j = s2.Length - 1;
        while (i >= 0 || j >= 0)
        {
            int sum = carry;
            if (i >= 0) sum += s1[i] - '0';
            if (j >= 0) sum += s2[j] - '0';
            res += (sum % 2);
            carry = sum / 2;
            i--; j--;
        }
        if (carry != 0) res += carry;
        String res1 = "";
        for (int l = res.Length - 1; l >= 0; l--)
        {
            res1 += res[l];
        }
        return res;
    }
    public static int BintoDec(string s)
    {
        int res = 0;
        int j = 0;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            int k = s[i] - '0';
            res +=(int) (k*Math.Pow(2, j));
            j++;
        }
        return res;
    }
    public static float BintoFloat(string s)
    {
        int i = -1;
        float res = 0.0f;
        for(int j = 0; j < s.Length; j++)
        {
            int t = s[j]-'0';
            res +=(float) (t * Math.Pow(2, i));
            i--;
        }
        return res;
    }
    public static void Main()
    {
        String num1 = Console.ReadLine();
        String num2 = Console.ReadLine();
        String[] arr1 = num1.Split(".");
        String[] arr2 = num2.Split(".");
        int i_num1 = int.Parse(arr1[0]);
        Console.WriteLine(i_num1);
        arr1[1] = "0." + arr1[1];
        float d_num1 = float.Parse(arr1[1]);
        Console.WriteLine(d_num1);
        String i_bin1 = DtoB(i_num1);
        Console.WriteLine(i_bin1);
        String d_bin1 = DtoB(d_num1);
        Console.WriteLine(d_bin1);
        Console.WriteLine();
        int i_num2 = int.Parse(arr2[0]);
        Console.WriteLine(i_num2);
        arr2[1] = "0." + arr2[1];
        float d_num2 = float.Parse(arr2[1]);
        Console.WriteLine(d_num2);
        String i_bin2 = DtoB(i_num2);
        Console.WriteLine(i_bin2);
        String d_bin2 = DtoB(d_num2);
        Console.WriteLine(d_bin2);
        if (d_bin1.Length > d_bin2.Length)
        {
            int diff = d_bin1.Length - d_bin2.Length;
            for (int i = 1; i <= diff; i++)
            {
                d_bin2 += "0";
            }
        }
        else
        {
            int diff = d_bin2.Length - d_bin1.Length;
            for (int i = 1; i <= diff; i++)
            {
                d_bin1 += "0";
            }
        }
        String t_bin1 = i_bin1 + d_bin1;
        String t_bin2 = i_bin2 + d_bin2;
        String res = AddBinary(t_bin1, t_bin2);
        char[] charArray = res.ToCharArray();
        Array.Reverse(charArray);
        string a_res = new string(charArray);
        Console.WriteLine(a_res);
        string after_dot = "";
        string befo_dot = "";
        int count = d_bin1.Length;
        for(int j = a_res.Length - 1; count > 0; j--)
        {
            after_dot += a_res[j];
            count--;
        }
        for(int k=0;k<(a_res.Length - d_bin1.Length); k++)
        {
            befo_dot += a_res[k];
        }
        char[] charArray1 = after_dot.ToCharArray();
        Array.Reverse(charArray1);
        string a_after_dot = new string(charArray1);
        Console.WriteLine(a_after_dot);
        Console.WriteLine(befo_dot);
        int first_res = BintoDec(befo_dot);
        Console.WriteLine(first_res);

        float sec_res = BintoFloat(a_after_dot);
        Console.WriteLine(sec_res);

        float final_res = first_res + sec_res;
        Console.WriteLine(final_res);
    }
}
