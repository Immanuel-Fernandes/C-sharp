/* 

Question:

Write a Csharp program to read a real no. from the keyboard and print the following output in one line.
Small as integer it be a number,	Large as integer,	Not less than, Not greater than
*/


class Task4
{
	public static void Main(string[] args)
	{
		float a = float.Parse(args[0]);
		float b = float.Parse(args[1]);

		System.Console.Write("Min Value: {0}  Max Value: {1}  Not less than: {2:f}  Not greater than: {3:f}",
			System.Math.Min(a,b),System.Math.Max(a,b), System.Math.Floor((float)System.Math.Min(a,b)), 
			System.Math.Ceiling((float)System.Math.Max(a,b)));
	}
}


/* 

Output: 

Task4.exe 4.5 8.3
Min Value: 4.5 Max Value: 8.3 Not less than: 4.00 Not greater than: 9.00

*/