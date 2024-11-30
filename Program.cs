using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 34, 13, 45,67,78,90,1213,45,134};
            int n=arr.Length;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
                Console.WriteLine("After sorting");
                for (int k = 0; k < n; k++)
                {
                    Console.Write(arr[k] + " ");
                }

                Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
