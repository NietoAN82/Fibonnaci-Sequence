namespace Fibonnaci_Sequence
{
    public class Program
    {
        static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return fib(n - 1) + fib(n - 2);
        }

        static int fib2(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }
            int slast = 0;
            int last = 1;
            int curPos = 2;

            while (curPos <= n) {
                int temp = last;
                last = last + slast;
                slast = temp;
                curPos++;
            }
            return last;
        }
        public static void Main(String[] args)
        {
            System.Diagnostics.Debug.WriteLine(fib(11));
            System.Diagnostics.Debug.WriteLine(fib2(11));
        }
    }
}