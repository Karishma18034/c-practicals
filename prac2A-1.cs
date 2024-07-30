class A
{
    public static void Main(string[] args)
    {
        double InrRate = 75.5;
        double USD = System.Convert.ToDouble(args[0]);
	
      
        double amount= B.demo(USD,InrRate);

        System.Console.WriteLine("Amount in USD: {0}",USD);
        System.Console.WriteLine("Amount in INR: {0}",amount);
    }
}
class B
{
    public static double demo(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
}