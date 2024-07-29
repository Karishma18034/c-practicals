class B
{
	public static void demo(float dRate,float sCost,float hCost)
	{
		float EOQ = (float)System.Math.Sqrt((2 * dRate * sCost) / hCost);
        		float  TBQ = (float)System.Math.Sqrt((2 * sCost) / (dRate * hCost));
        		System.Console.WriteLine("\nResults:");
        		System.Console.WriteLine("Economic Order Quantity (EOQ): " + EOQ);
        		System.Console.WriteLine("Total Best Quantity (TBQ): " + TBQ);
	}
}
class A
{
	public static void Main(string[] args)
    	{
   	 	float dRate,sCost,hCost;    
        		dRate = float.Parse(args [0]);       
        		sCost = float.Parse(args[1]);         
        		hCost = float.Parse(args[2]);   
 
        		B.demo(dRate,sCost,hCost);
    	}
}
