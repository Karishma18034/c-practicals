
class Program
{
    public static void Main()
    {
        int num1, num2, num3, num4;
        num1 =  Int32.Parse( args[0]);
        num2 =  Int32.Parse( args[1]);
        num3 =  Int32.Parse( args[2]);
        num4 =  Int32.Parse( args[3]);        
        int product = num1 * num2 * num3 * num4;       
        System.Console.WriteLine("The product   is: "+product);             
    }
}
