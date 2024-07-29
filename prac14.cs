class ElseIfLadder
{
	public static void Main(string[] args)
	{
		int[] rollnumber = {111,222,333,444};
		int[] marks = {81,75,43,58};
		for(int i=0; i<rollnumber.Length;i++)
		{
			if(marks[i]>79)
			System.Console.WriteLine(rollnumber[i]+ "Honours");
			else if(marks[i]>59)
			System.Console.WriteLine(rollnumber[i]+ "I Divison");
			else if(marks[i]>49)
			System.Console.WriteLine(rollnumber[i]+ "II Division");
			else
			System.Console.WriteLine(rollnumber[i]+ "Fail");
		}
			
	}
}