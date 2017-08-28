using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        string[] result = new string[arr.Length];
        var strRes = string.Empty;
        
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr.Where(val => val != arr[i]).Sum().ToString();
        }
        strRes = result.Min() + " " + result.Max();
        Console.WriteLine(strRes);
        Console.ReadLine();
    }
}
