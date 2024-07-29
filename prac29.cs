class A
{
	public  void demo( float sum)
	{
		int i;
		for(i=1;i<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.WriteLine(" i = "+i);
		  	System.Console.WriteLine(" sum = "+sum);
				
		}
	}
}
class Casting
{
	public static void Main()
	{
		float sum;
		sum=0.0F;
		A a=new A();
		a.demo(sum);
	}
}