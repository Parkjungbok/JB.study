using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Array
    {
        static void Main33(string[] args)
        {
            // 배열 복습

            int[] array = { 1, 3, 5, 4, 2 };

            int length = array.Length;   // 배열의 크기
            int max = array.Max();       // 배열의 최대값
            int min = array.Min();       // 배열의 최소값


            char[] chars = { 'a', 'b', 'c', 'd', 'e' };

            for (int i = 0; i < array.Length; i++)
            {                
                Console.WriteLine($"반복{array[i]}");
            }

            //문자를 받아와 단어로 배열을 만듬
            string input = Console.ReadLine();
            char[] a = input.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            { Console.Write($"{a[i]} "); }

        }
    }
}