class PassByValue
{
	static void Change(int m)
	{
		m=m+10;
	}
	public static void Main(string[] args)
	{
		int x = 100;
		Change(x);
		System.Console.WriteLine("x="+x);
	}
}