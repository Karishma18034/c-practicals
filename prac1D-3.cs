

class Program
{
	static void Main()
    	{
		char ch;
		ch=System.Convert.ToChar(args[0]);
		if(ch=="A" || ch=="E" || ch=="I" || ch=="O" || ch=="U" || ch=="a" || ch=="e" || ch=="i" || ch=="o" || ch=="u")
			System.Console.WriteLine("{0} is a Vowel ",ch);
		else
			System.Console.WriteLine("{0} is not Vowel ",ch);
	}
}