class A
{
	public void demo(double p)
	{
		double a=p;
		double b=(a-32)/7.58;
		System.Console.WriteLine("{0} c",b);
	}
}
class B
{
	public static void Main(string[] args)
	{
		A u =new A();
		double l=System.Convert.ToDouble(args[0]);
		u.demo(l);
		
	}
}