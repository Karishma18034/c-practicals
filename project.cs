class Bank
{
	public void create()
	{
		int phone,date,ch;
		string name,add;
		System.Console.WriteLine("Enter your full name :");
		name=System.Console.ReadLine();
		System.Console.WriteLine("Enter your Birth date (dd/mm/yyyy) :");
		date=System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Enter your address :");
		add=System.Console.ReadLine();
		System.Console.WriteLine("Enter your phone number:");
		phone=System.Convert.ToInt32(System.Console.ReadLine());
		m:
		System.Console.WriteLine("Choose account type ");
		System.Console.WriteLine("\t\t\t 1.Savings Account \n\t\t\t2.Business Account \n\t\t\t3.Joint Account \n\t\t\t 4.Checking Account");
		ch=System.Convert.ToInt32(System.Console.ReadLine());
		switch(ch)
		{
			case 1 : saving();break;
			case 2 : business();break;
			case 3 : joint();break;
			case 4 : checking();break;
			default : System.Console.WriteLine("invalid input !! ");
				goto m;
		}
		
		
	}
	public static void Main(string[] args)
	{
		int a;
		System.Console.WriteLine("\t\t\t WELCOME TO BANK MANAGEMENT SYSTEM");
		System.Console.WriteLine("\t\t\t what do you want :");
		a=System.Convert.ToInt32(System.Console.ReadLine());
		switch(a)
		{
			case 1 : create(); break;
			case 1 : create(); break;
			case 1 : create(); break;
			case 1 : create(); break;
			
	}
}

