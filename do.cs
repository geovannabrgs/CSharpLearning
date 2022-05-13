using System;

public class Program
{
	public static void Main()
	{
    		string text;
    		do {
        		text = Console.ReadLine();
        		Console.WriteLine(text);
        	}while(!string.IsNullOrEmpty(text));
	}
}
