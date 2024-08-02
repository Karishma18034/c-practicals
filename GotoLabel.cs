class GotoLabel
{
	public static void Main()
	{
	   for (int i=1;i<100;i++)
		{
		   System.Console.WriteLine(" ");
		   if(i>=10)
			break;
		   for(int j=1;j<100;j++)
		     {
			System.Console.WriteLine(" + ");
			if(j==1)
			   goto loop1;
		     }
		     loop1:continue;
		}
		System.Console.WriteLine("termination by BREAK");
	}
}