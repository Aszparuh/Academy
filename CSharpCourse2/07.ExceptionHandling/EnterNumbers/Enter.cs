﻿namespace EnterNumbers
{
    using System;

    /*Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
      If an invalid number or non-number text is entered, the method should throw an exception.
      Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

    class Enter
    {
        static int EnterNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }

        static void Main()
        {
            int[] numbers = new int[10];
            Console.WriteLine("You will enter 10 numbers (0 < i < 100) in increasing seqence");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter {0,2} number: ", i + 1);
                try
                {
                    if (i == 0)
                    {
                        numbers[i] = EnterNumber(0, 90 + i);
                    }
                    else
                    {
                        numbers[i] = EnterNumber(numbers[i - 1], 90 + i);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input number is too big or too small to fit in int data type");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be in range {0} - {1}. Try again.", i == 0 ? 0 : numbers[i - 1] + 1, 90 + i);
                    i--;
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Cannot convert this input to int. Try again.");
                    i--;
                    continue;
                }
            }
        }
    }
}