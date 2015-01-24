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

        if (firstNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, secondNum);
        }
        if (firstNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, thirdNum);
        }
        if (firstNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fourthNum);
        }
        if (firstNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNum, fifthNum);
        }
        if (secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, thirdNum);
        }
        if (secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fourthNum);
        }
        if (secondNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNum, fifthNum);
        }
        if (thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fourthNum);
        }
        if (thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNum, fifthNum);
        }
        if (fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNum, fifthNum);
        }
        if (firstNum + secondNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, thirdNum);
        }
        if (firstNum + secondNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fourthNum);
        }
        if (firstNum + secondNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fifthNum);
        }
        if (secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fourthNum);
        }
        if (secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fifthNum);
        }
        if (thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, fourthNum, fifthNum);
        }
        if (fourthNum + fifthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, firstNum);
        }
        if (fourthNum + fifthNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, secondNum);
        }
        if (fourthNum + fifthNum + thirdNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", fourthNum, fifthNum, thirdNum);
        }
        if (thirdNum + fourthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, fourthNum, firstNum);
        }
        if (firstNum + secondNum + thirdNum + fourthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fourthNum);
        }
        if (firstNum + secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNum, secondNum, thirdNum, fifthNum);
        }
        if (secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNum, thirdNum, fourthNum, fifthNum);
        }
        if (thirdNum + fourthNum + fifthNum + firstNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", thirdNum, fourthNum, fifthNum, firstNum);
        }
        if (fourthNum + fifthNum + firstNum + secondNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", fourthNum, fifthNum, fifthNum, secondNum);
        }
        if (firstNum + secondNum + thirdNum + fourthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNum, secondNum, thirdNum, fourthNum, fifthNum);
        }
    }
}