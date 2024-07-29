class B
{
	static double a;
   	static string b;
	public static void paisa(string  m)
	{
		
		b=m;
		a = System.Double.Parse(b);
		System.Console.WriteLine("Amount in paise = " +(a*100));
	}

}

 class A
{
  	public static void Main(string[] args)
 	{
   		string j;
  		System.Console.WriteLine("Enter the amount in Rs. : ");
  		j= System.Console.ReadLine();
  		B.paisa(j);
		System.Console.ReadLine();
	 }
}
