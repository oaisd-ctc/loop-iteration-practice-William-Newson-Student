﻿using System;
public static class Program
{    
    public static void Main()
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        
        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        
        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);

        WriteEvensThrough100();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        
        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }
    public static void Write1ThroughN_While(int n)
    {
        if (n <= 0)
        {
            OutofRangeMessage(n);
        }
        int i = 1;
        while (i < (n + 1))
        {
            Console.WriteLine(i);
            i++;
        }
        
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i < (n + 1); i++)
        {
            Console.WriteLine(i);
        }
        if (n <= 0)
        {
            OutofRangeMessage(n);
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
        if (n <= 0)
        {
            OutofRangeMessage(n);
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        if (n <= 0)
        {
            OutofRangeMessage(n);
        }
    }
    public static void WriteEvensThrough100()
    {
        for (int i = 1; i < 101; i++)
        {
            if (i % 2 == 0){Console.WriteLine(i);} else{}
        }
    }
    public static void FindSum(int n)
    {
        int Sum = 0;
        for (int i = n; i > 0; i--)
        {
            Sum += i;
        }
        if (n < 0)
        {
            Sum = 1;
        }
        for (int i = n; i < 0; i++)
        {
            Sum += i;
        }
        Console.WriteLine(Sum);
    }
    public static void FindSumOfEvenNumbers(int n)
    {
        int Sum = 0;
        for (int i = n; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Sum += i;
            }
        }
        for (int i = n; i < 0; i++)
        {
            if (i % 2 == 0)
            {
                Sum += i;
            }
        }
        Console.WriteLine(Sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int Sum = 0;
        for (int i = n; i > 0; i--)
        {
            if (i % 2 == 1)
            {
                Sum += i;
            }
        }
        if (n < 0)
        {
            Sum = 1;
        }
        for (int i = n; i < 0; i++)
        {
            if ((i * -1) % 2 == 1)
            {
                Sum += i;
            }
        }
        Console.WriteLine(Sum);
    }

    public static void OutputRightTriangle(int _base)
    {
        if (_base > 0)
        {
            for (int i = 0; i < _base; i++)
            {
                for (int j = (i + 1); j > 0; j--)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }
        }
        else if (_base == 0)
        {
            OutofRangeMessage(_base);
        }
        else
        {
            for (int i = (_base * -1); i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }
        }
    }
    public static void OutofRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range");
    }

}