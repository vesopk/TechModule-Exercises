using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 4, 5, 6, 7, 8 };
            List<int> results = new List<int>();
            var end = nums.Count;
            if (nums.Count % 2 != 0)
            {
                end = nums.Count - 1;
            }
     
            for (int i = 0; i < end; i += 2)
            {
                results.Add(nums[i] + nums[i + 1]);
            }
                
            if (nums.Count % 2 != 0)
            {
                results.Add(nums.Last());
            }
                
            nums = results;
            Console.WriteLine(string.Join(" ",results));
        }
    }
}

                