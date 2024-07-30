class A
{  
	public static void Main(string[] args)  
      	{  
          		int n, i, m=0, flag=0;    
          		n = int.Parse(args[0]);  
          		m=n/2;    
          		for(i = 2; i <= m; i++)    
          		{    
           			if(n % i == 0)    
            			{    
             				System.Console.Write(" {0}  is not Prime Number.",n);    
            				 flag=1;    
             				break;    
            			}    
          		}    
          		if (flag==0)    
           			System.Console.Write("{0} is Prime Number.",n);       
     	}  
}  