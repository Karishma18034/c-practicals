class B
{
	public static void Main(string[] args)
	{
		int p=1000,n=1;
		float r,v=0;
		r=0.10F;
		while(v>=0)
		{
			if(p<=10000 && r<=0.20 && n<=10)
			{
				v=p*(1+r)*n;
				p=p+1000;
				r=r+1;
				n=n+1;
				//System.Console.WriteLine("\n "+v);
			}
			System.Console.WriteLine("\n "+v);
		}
	}
}