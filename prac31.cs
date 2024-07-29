class MathTest
{
	public static void Main()
	{
		A a=new A();
		a.demo();
	}

}
class A
{
	public void demo()
	{
		System.Console.WriteLine("sines of angels from 0 to 90 degrees");
		for(double theta=0.0 ; theta<=90.00; theta+=15)
		{
			double x=System.Math.Sin(theta * System.Math.PI/180);
			System.Console.Write("sin "+theta);
			System.Console.WriteLine("  ={0.F4}"+x);
		}
	}
}