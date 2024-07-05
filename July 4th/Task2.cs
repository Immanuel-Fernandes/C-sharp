

/* 

Question:

Write a Csharp program to Convert celsius to fahrenheit using the formula (F-32)/1.8 and display in tabular form

*/


class Task2
{
	public static void Main(string[] args)
	{
		System.Console.Write("Temperature in Fahrenheit: ");
		string str = System.Console.ReadLine();
		float far = System.Single.Parse(str);
		float cel = (far - 32) / 1.8f;
	
		System.Console.WriteLine("{0} degree Celsius", cel);
	}
}



/* 

Output: 

Temperature in Fahrenheit: 50
10 degree Celsius

*/