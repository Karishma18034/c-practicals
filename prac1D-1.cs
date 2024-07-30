
class Program
{
	public static void Main(string[] args)
    	{
        		int count =  System.Convert.ToInt32(args[0]);        
         		System.Console.WriteLine("Fibonacci Series:");
        		for (int i = 0; i < count; i++)
        		{
             			System.Console.Write(B.Fibonacci(i) + " ");
        		}
    	}
}
    	
class B
{
	public static int Fibonacci(int n)
    	{
        		if (n <= 1)
            			return n;
        		else
            			return Fibonacci(n - 1) + Fibonacci(n - 2);
    	}
}
