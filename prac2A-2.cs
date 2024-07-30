class A
{
	public static int demo(int n)
    	{
        		int factorial = 1;
        		for (int i = 1; i <= n; i++)
        		{
            		factorial *= i;
        		}
        		return factorial;
   	}
}

class B
{
	public static void Main(string[] args)
    	{
        		int n = System.Convert.ToInt32(args[0]);
       		 int  factorial = A.demo(n);
        		System.Console.WriteLine("Factorial of {0} is: {1}",n,factorial);     
    	}
}