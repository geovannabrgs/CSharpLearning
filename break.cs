using System;

public class Program
{
	public static void Main()
	{
        while(true){
            string s = Console.ReadLine();
        }
        if(string.IsNullOrEmpty(s)){
            break;
        }
        Console.WriteLine(s);
	}
}
