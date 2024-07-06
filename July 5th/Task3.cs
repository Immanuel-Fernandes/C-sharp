/* 

Question:

The Straight Line Method of computing the yearly depriciation of the value of an item is given by depriciation = (purchase price-Salvage value)/years of service. 
Write a Csharp program to determine the depriciation of an item where the purchase price, years of service and the salvage value are given

*/


class Task3
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Purchase_Price:");
		string p = System.Console.ReadLine();
		float Purchase_Price = System.Single.Parse(p);

		System.Console.WriteLine("Salvage Value:");
		string s = System.Console.ReadLine();
		float Salvage = System.Single.Parse(s);

		System.Console.WriteLine("Years of Use:");
		string y = System.Console.ReadLine();
		float year = System.Single.Parse(y);

		float dep =(Purchase_Price-Salvage)/year;

		System.Console.WriteLine("Depreciation: {0}", dep);
	}
}





/* 

Output: 

Purchase_Price:
1500
Salvage Value:
150
Years of Use:
5
Depreciation: 270

*/