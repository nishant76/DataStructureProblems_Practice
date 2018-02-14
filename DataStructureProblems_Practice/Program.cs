using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge2ArraysinDesc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 7, 8, 44, 55, 65 };
            int[] arr2 = { 2, 4, 6 };
            Merge2ArraysinDesc(arr1, arr2);
            Console.ReadKey();
        }
        private static void Merge2ArraysinDesc(int[] arr1, int[] arr2)
        {
            int j = 0;
            int k = 0;
            int totalLength = arr1.Length + arr2.Length;
            int[] resultarr = new int[arr1.Length + arr2.Length];
            for (int i = resultarr.Length - 1; i >= 0; i--)
            {
                if (arr1.Length == j)
                {
                    resultarr[i] = arr2[k++];
                }
                else if (arr2.Length == k)
                {
                    resultarr[i] = arr1[j++];
                }
                else if (arr1[j] <= arr2[k])
                {
                    resultarr[i] = arr1[j++];
                }
                else if (arr1[j] > arr2[k])
                {
                    resultarr[i] = arr2[k++];
                }

            }
            foreach (var i in resultarr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
