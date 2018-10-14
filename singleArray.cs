using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class singleArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[1] = 55;
            arr[4] = 44;
            arr[0] = 22;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("the array elements is:" + arr[i]);
            }
        }
    }
}
