using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithum
{
    internal class InsertionSort
    {
        public void DisplayInsertionSort()
        {
            int[] arr = new int[5] { 23, 9, 12, 30, 17 };
            int n = 5, j, i, val, flag;

            Console.WriteLine("InsertionSort");
            Console.WriteLine("Initial array is : ");
            for(i= 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for(i=1;i<n;i++)
            {
                val = arr[i];
                flag=0;
                for(j=i-1;j>=0&&flag!=1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag= 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sorted array is : ");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
