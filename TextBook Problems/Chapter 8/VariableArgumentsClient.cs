class Params 
{
	public void SetVal(int []x)
	{
		
	 	Parray(x) ; 
	 	Parray(); 
	 	Parray(100,200);
	} 

	private static void Parray(params int []arr)
	{
		System.Console.Write("Array elements are:");
		foreach (int i in arr)
			System.Console.Write(" "+ i);
		System.Console.WriteLine();
	}	
}

class  VariableArgumentsClient
{
	public static void Main()
	{
		Params a = new Params();
		int []x = { 11, 22, 33 };
		a.SetVal(x);
	}
}

/* 

Output: 

Array elements are: 11 22 33
Array elements are:
Array elements are: 100 200

*/