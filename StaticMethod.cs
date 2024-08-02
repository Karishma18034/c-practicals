class StaticMethod
{
	public static void Main(string[] args)
	{
		double y = Square(2.5F);
		System.Console.WriteLine(y);
	}
	static double Square(float x)
	{
		return(x * x);
	}
}