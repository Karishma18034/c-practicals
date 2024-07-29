class FloatPoint 
{
	public static void Main()
	{
		float a=20.5F,b=6.4F;
		A p=new A();
		p.demo(a,b);
	}

}
class A
{
	public void demo(float a,float b)
	{
		System.Console.WriteLine(" a = "+a);
		System.Console.WriteLine(" b = "+b);
		System.Console.WriteLine(" a+b = "+(a+b));
		System.Console.WriteLine(" a-b = "+(a-b));
		System.Console.WriteLine(" a*b = "+(a*b));
		System.Console.WriteLine(" a/b = "+(a/b));
		System.Console.WriteLine(" a%b = "+(a%b));
	}

}