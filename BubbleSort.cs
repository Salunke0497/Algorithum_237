﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithum
{
    internal class BubbleSort
    {
        public void DisplayBubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for(int j = 0; j <= arr.Length; j++)
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted : ");
            foreach(int p in arr)
            {
                Console.WriteLine(p);
            }
        }
        
    }
}
