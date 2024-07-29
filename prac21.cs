
class B
{
	public static void demo(float Amt ,int cloth)
	{
		double disAmt ,rent,dis= 0.0;   
        		switch (cloth)
        		{
            			case 1:
				switch(Amt)
				{
					case (Amt > 0 && Amt<=100):  	dis = 0.0;
								    	break;
					case (Amt >=101 && Amt<=200):  	dis = 5.0;
								   	 break;
					case (Amt >=201 && Amt<=300):  	dis =7.5;
								    	break;
					case (Amt>300):  			dis = 10.0;
								    	break;
                			
                			}
                    				

            			case 2: 
                			switch(Amt)
				{
					case(Amt > 0 && Amt<=100):  	dis = 0.0;
								    	break;
					case(Amt >=101 && Amt<=200):  	dis = 5.0;
								   	 break;
					case(Amt >=201 && Amt<=300):  	dis =7.5;
								    	break;
					case(Amt>300):  			dis = 10.0;
								    	break;
                			
                			}
                    				

            			default:
                			System.Console.WriteLine("Invalid cloth type !! ");
                			break;
        		}
        		disAmt = Amt * (dis / 100);
         		rent= Amt - disAmt;        
        		System.Console.WriteLine("Purchasing Amount:{0} ",Amt);
         		System.Console.WriteLine("Discount (%):{0} % ",dis);
         		System.Console.WriteLine("Discount Amount:{0}",disAmt);
         		System.Console.WriteLine("Rent Amount to be Paid: {0}",rent);
    	}
}

class A
{
    	public static void Main(string[] args)
    	{
        		float a = float.Parse(args[0]);		
        		int b = System.Convert.ToInt32(args[1]);	
		B.demo(a,b);      
	
	}
}

