using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class findmaxpassingToFunction
    {
        static void arr(int[] x)
        {
            int max=0;
            for(int i=0;i<x.Length;i++)
            {
                if(x[i]>=max)
                {
                    max = x[i];
                }

            }
            Console.WriteLine("max element is:" +max);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 10, 22, 44, 23, 555, 67, 89, 99 };
            arr(arr1);
        }
    }
}
