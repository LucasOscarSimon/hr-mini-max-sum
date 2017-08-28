using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void Main(String[] args)
        {

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            string[] result = new string[arr.Length];
            string[] resultEqualNums = new string[arr.Length];
            var strRes = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr.Where(val => val != arr[i]).Sum().ToString();
                resultEqualNums[i] = arr.Where(val => val == arr[i]).Skip(1).Sum().ToString();
            }

            if (result.Any(x => !string.IsNullOrEmpty(x)))
                strRes = result.Min() + " " + result.Max();
            else
                strRes = resultEqualNums.Min() + " " + resultEqualNums.Max();

            Console.WriteLine(strRes);
            Console.ReadLine();
        }
    }
}
