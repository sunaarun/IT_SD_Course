// See https://aka.ms/new-console-template for more information

class Fibonacci
{
    public int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }

    public  void PrintFibonacciSequence(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(FibonacciRecursive(i) + " ");
        }
    }

   
}