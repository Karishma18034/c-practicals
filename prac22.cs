class B
{
	public static void Reverse(int n)
    	{
        		int rev = 0;
        		while (n != 0)
        		{
            			int remainder = n % 10;
            			rev= rev* 10 + remainder;
            			n /= 10;
        		}
       		System.Console.WriteLine("Reversed number: "+rev);
    	}
}
class A
{
	public static void Main(string[] args)
    	{
        		int n;
        		n= int.Parse(args[0]);
       		B. Reverse(n);
        		
    	}
    	
}