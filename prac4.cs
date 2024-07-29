class DisTravel
{
	public static void Main(string[] args)
	{
	int u = System.Convert.ToInt32(args[0]);
	int a = System.Convert.ToInt32(args[1]);
	int t = System.Convert.ToInt32(args[2]);
	int b = a*t;
	int dis = u*t + b*b/ 2;
	System.Console.WriteLine("Distance Travel" + dis);
	}	

}