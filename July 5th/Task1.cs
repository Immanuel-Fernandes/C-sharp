/* 

Question:

Write a Csharp program to read the price ofd a item in decimal form and print the Output in Paise (75.96)

*/


class Task1
{
	public static void Main(string[] args)
	{
		//float a=75.95f;
		System.Console.Write("Price in Rs. :");
        string Price = System.Console.ReadLine();
        float p =  float.Parse(Price);

		System.Console.WriteLine("{0} Paise",p*100);
	}
}


/* 

Output: 

Price in Rs. :25
2500 Paise

*/