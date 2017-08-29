using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MinMaxSum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int64.Parse);
            var result = new Int64[arr.Length];
            var strRes = string.Empty;
            var length = arr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i <= length)
                {
                    result[i] = arr.Where(e => e != arr[i]).ToArray().Sum() != 0 ?
                        arr.Where(e => e != arr[i]).ToArray().Sum() :
                        arr.Skip(1).Where(e => e == arr[i]).ToArray().Sum();
                }
            }

            strRes = result.Min() + " " + result.Max();
            Console.WriteLine(strRes);
            Console.ReadLine();
        }
    }
}