
class B
{
	public  void demo(int num1,int num2,int num3,int num4)
	{
		int product = num1 * num2 * num3 * num4;       
        		System.Console.WriteLine("The product   is: "+product);  
	}
}


 
class A
{
	public static void Main(string[] args)
    	{
        		int a, b, c, d;
        		a= int.Parse(args[0]);
        		b =int.Parse(args[1]);
        		c =  int.Parse(args[2]);
        		d =  int.Parse(args[3]);        
		B e=new B();
		e.demo(a,b,c,d);            
    	}
}
