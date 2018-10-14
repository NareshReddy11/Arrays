using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class multidimentinal
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 3, 4 }, { 7, 4, 9 }, { 4, 0, 6 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
