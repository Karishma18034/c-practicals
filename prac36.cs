class ElseIfLadder
{
	public static void Main()
	{
		int[] rollnumber={111, 222, 333, 444 };
		int[] marks={81, 75, 43, 58};
		for(int i=0;i<rollnumber.length;i++)
		{
			if(marks[i]>79)
				System.Console.WriteLine(rollnumber[i]+" honours");
			else if(marks[i]>59)
				System.Console.WriteLine(rollnumber[i] + " I division");
			else if(marks[i]>49)
				System.Console.WriteLine(rollnumber[i] + " II division");
			else 
				System.Console.WriteLine(rollnumber[i] + " FAIL");
			
		}
	}
}

