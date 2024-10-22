using System;
public static class Program
{    
    public static void Main()
    {
        // Write1ThroughN_While(12);
        // Write1ThroughN_For(12);
        //WriteNThrough1_While(12);
        // WriteNThrough1_For(12);
        // WriteEvensThrough100();
        // FindSum(12);
        // FindSumOfEvenNumbers();
        // FindSumOfOddNumbers();
        OutputRightTriangle(5);
    }
    public static void Write1ThroughN_While(int n)
    {
        int i = 1;
        while (i < n)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteNThrough1_While(int n)
    {
        int i = n; 
        while (i > 0)
        {
            Console.WriteLine(i);
            i--;
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteEvensThrough100()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0){Console.WriteLine(i);} else{}
        }
    }
    public static void FindSum(int n)
    {
        // for (int i = n; i > 0; i--)
        // {
        //    Console.WriteLine(i);
        // }
    }

    public static void OutputRightTriangle(int _base)
    {
        if (_base > 0)
        {
            for (int i = 0; i < _base; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (_base == 0)
        {

        }
        else
        {
            for (int i = (_base * -1); i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}