class A
{
	public void demo(int a,int b,int c,int d)
	{
		int answer1=a*b+c/d;
		int answer2=a*(b+c)/d;

		System.Console.WriteLine("\n order of Evaluation");
		System.Console.WriteLine(" a*b+c/d="+answer1);
		System.Console.WriteLine(" a*(b+c)/d="+answer1);
	}

	public void memo(int a,int c,float x,float y)
	{
		int answer3=a%c;
		float answer4=x%y;
		
		System.Console.WriteLine("\n Modulo Operations ");
		System.Console.WriteLine(" a%c="+answer3);
		System.Console.WriteLine("x%y="+answer4);
	}

	public void lemo(int a,int b,int c,int d)
	{
		bool bool1 = a>b && c>d;
		bool bool2 = a<b && c>d;
		bool bool3 = a<b || c>d;
		bool bool4 = !(a-b==c);

		System.Console.WriteLine("\n Logical  Operations ");
		System.Console.WriteLine(" a>b && c>d ="+bool1);
		System.Console.WriteLine("a<b && c>d ="+bool2);
		System.Console.WriteLine("a<b || c>d ="+bool3);
		System.Console.WriteLine("!(a-b==c) ="+bool4);
		
	}

}
class Expressions
{
	public static void Main()
	{
		int p=10,q=5,r=8 ,s=2;
		float i=6.4F ,j=3.0F;
		A a=new A();
		a.demo(p,q,r,s);
		a.memo(p,r,i,j);
		a.lemo(p,q,r,s);
		
	}
}