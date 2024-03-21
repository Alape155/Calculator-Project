public  class Program
{


    private static void Main(string[] args)
    {
      
        foreach (string s in args)
        {
            Console.WriteLine(s);
    
        }

        Result( 45,72,98);
        Calculator();
        
    }
    private static void Result(int value1,int value2, int value3)
    {

        int result = value1 + value2 - value3;
        Console.WriteLine(result);
    }
    private static void Alphabets(int value1,string value2,bool value3)
    {

        Console.WriteLine();
    }
    private static void Calculator ()
    {
        Console.WriteLine();
    }
}