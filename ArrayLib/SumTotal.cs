using System.Collections.Generic;
using System.Linq;
namespace ArrayLib
{
    public class SumTotal
    {
        int[] numbers = { 1, 7, 2, 3, 4 };
        int target = 11;
        public SumTotal() {

            Console.WriteLine(GetSumTotal().Item1+" "+GetSumTotal().Item2);
        }
        public (int,int) GetSumTotal()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if(dict.ContainsKey(target - numbers[i]))
                {
                    return (dict[target - numbers[i]] ,i );
                }
                dict.Add(numbers[i], i);
            }
            return (-1, -1);

        }

    }
}
