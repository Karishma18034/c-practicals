class A
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("velocity");
		string time=System.Console.ReadLine();
		System.Console.ReadLine();
		float t=float.parse(time);
		
		System.Console.WriteLine("acceleration");
		string acceleration=System.Console.ReadLine();
		
		float a=float.parse(acceleration);
		float displacement=u*t+0.5f*a*t*t;
		System.Console.WriteLine("total displacement after {0} seconds is : {1}meter ",t,displacement);
	}

}