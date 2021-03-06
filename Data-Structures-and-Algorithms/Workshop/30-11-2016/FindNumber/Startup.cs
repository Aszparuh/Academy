﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindNumber
{
    public class Startup
    {
        public static void Main()
        {
            var nAndK = Console.ReadLine().Split(' ');
            var n = int.Parse(nAndK[0]);
            var k = int.Parse(nAndK[1]);


            var input = Console.ReadLine().Split(' ');
            List<string> result = QuickSort(input.ToList());
            Console.WriteLine(result[k]);
            //Console.WriteLine(string.Join(" ", result));
        }

        public static List<string> QuickSort(List<string> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            int pivotIndex = (input.Count / 2);
            string pivot = input[pivotIndex];

            var left = new List<string>();
            var right = new List<string>();

            for (int i = 0; i < pivotIndex; i++)
            {
                if (string.Compare(input[i], input[pivotIndex]) < 0)
                {
                    left.Add(input[i]);
                }
                else
                {
                    right.Add(input[i]);
                }
            }

            for (int i = pivotIndex + 1; i < input.Count; i++)
            {
                if (string.Compare(input[i], input[pivotIndex]) < 0)
                {
                    left.Add(input[i]);
                }
                else
                {
                    right.Add(input[i]);
                }
            }

            List<string> sortedLeft = QuickSort(left);
            List<string> sortedRight = QuickSort(right);

            //Task leftTask = Task.Run(() => sortedLeft = QuickSort(left));
            //Task rightTask = Task.Run(() => sortedRight = QuickSort(right));
            //Task.WaitAll(leftTask, rightTask);

            var result = new List<string>();
            result.AddRange(sortedLeft);
            result.Add(pivot);
            result.AddRange(sortedRight);

            return result;
        }
    }
}

