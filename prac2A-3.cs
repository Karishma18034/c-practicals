class A
{
    	public static void Main(string[] args)
    	{        
        		double a = System.Convert.ToDouble(args[0]);
		double b = System.Convert.ToDouble(args[1]);       
        		double c = System.Convert.ToDouble(args[2]);  
		B.demo(a,b,c);
	}
}
class B
{
	public static void demo(double a,double b,double c)
	{      
        		double discriminant = b * b - 4 * a * c;
        		if (discriminant > 0)
        		{            
            		double root1 = (-b + System.Math.Sqrt(discriminant)) / (2 * a);
            		double root2 = (-b - System.Math.Sqrt(discriminant)) / (2 * a);
            		System.Console.WriteLine("Root 1: {0}",root1);
            		System.Console.WriteLine("Root 2: {0}",root2);
       		 }
        		else if (discriminant == 0)
        		{       
            		double root = -b / (2 * a);
            		System.Console.WriteLine("Root (double root):{0}" ,root);
        		}
        		else
        		{           
            		double realPart = -b / (2 * a);
            		double imaginaryPart = System.Math.Sqrt(-discriminant) / (2 * a);
            		System.Console.WriteLine("Root 1: {0} + {1}i",realPart,imaginaryPart);
            		System.Console.WriteLine("Root 2: {0} - {1}i",realPart,imaginaryPart);
        		}
   	 }
}