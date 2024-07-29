class A
{
	public void demo(int a,int b,int c)
	{
		
		System.Console.WriteLine("largest value is :");
		if(a>b)
		{
			if(a>c)
			{
				System.Console.WriteLine(a);
			}
			else
			{
				System.Console.WriteLine(c);
			}
		}
		else	
		{
			if(c>b)
			{
				System.Console.WriteLine(c);
			}
			else
			{
				System.Console.WriteLine(b);
			}
		}
	}
}

class IfElseNesting
{
	public static void Main()
	{
		int p=325,q=712,r=478;
		A m=new A();
		m.demo(p,q,r);
	}
}