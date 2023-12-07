namespace DynamicProgramming
{
    public class FibonacciNumberSolution
    {
        Dictionary<int,int> dict = new Dictionary<int, int> ();

        public FibonacciNumberSolution()
        {
            Console.WriteLine(getFib(5));
        }
        public int getFib(int n) {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            int last = getFib(n - 1) + getFib(n-2);
            dict.Add(n, last);
            return last;
        }
    }
}
