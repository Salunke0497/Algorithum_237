using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.DisplayBubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            //insertionSort.DisplayInsertionSort();
            //Console.ReadLine();
        }
    }
}
