using System;

/*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/

class Find
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNum = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNum = int.Parse(Console.ReadLine());
        bool presenceOfZeroSubset = false;

        if (firstNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, secondNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, thirdNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, thirdNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, thirdNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, fourthNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (fourthNum + fifthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, firstNum);
            presenceOfZeroSubset = true;
        }
        if (fourthNum + fifthNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, secondNum);
            presenceOfZeroSubset = true;
        }
        if (fourthNum + fifthNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, thirdNum);
            presenceOfZeroSubset = true;
        }
        if (thirdNum + fourthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, fourthNum, firstNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fourthNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNum, thirdNum, fourthNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (thirdNum + fourthNum + fifthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", thirdNum, fourthNum, fifthNum, firstNum);
            presenceOfZeroSubset = true;
        }
        if (fourthNum + fifthNum + firstNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", fourthNum, fifthNum, fifthNum, secondNum);
            presenceOfZeroSubset = true;
        }
        if (firstNum + secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNum, secondNum, thirdNum, fourthNum, fifthNum);
            presenceOfZeroSubset = true;
        }
        if (!presenceOfZeroSubset)
        {
            Console.WriteLine("There is no subset with sum 0");
        }
    }
}