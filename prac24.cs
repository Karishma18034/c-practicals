 class A
{
	public A()
    	{
        		System.Console.WriteLine("object is created ");
    	}
    	~A()
    	{
        		System.Console.WriteLine("object is destroyed");
    	}
}

class B
{
    	public static void Main(string[] args)
    	{        
  		A obj=new A();
        		System.Console.WriteLine("Inside Main method.");        
    	}
}
