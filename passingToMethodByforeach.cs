﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class passingToMethodByforeach
    {
        static void arr(int[] x)
        {
            Console.WriteLine("the array elements is ");
            foreach(int ss in x)
            {
                Console.WriteLine(x[ss]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 2, 1, 0, 5, 4, 7, };
            int[] arr2 = { 3, 5, 4, 7, 6, 8, 9, 1, 2, 0, 10, };
            arr(arr1);
            arr(arr2);
        }
    }
}