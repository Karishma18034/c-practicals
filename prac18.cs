class B
{
	public static void demo(double purchase, int years,double salvage)
	{ 
        		double dep = (purchase - salvage) / years;
        		System.Console.WriteLine("The yearly depreciation of the item is: {0}",dep);	
	}
}
class A
{
	public static void Main(string[] args)
    	{

        		double purchase;  
        		int years;   
        		double salvage;    
		purchase =double.Parse(args[0]);  
        		years =int.Parse(args[1]);    
        		salvage = double.Parse(args[2]);   
		B.demo(purchase,years,salvage);
       
        	}
}
