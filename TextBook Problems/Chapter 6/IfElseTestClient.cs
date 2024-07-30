class IfElseTest
{
	private int even = 0, odd = 0;
	private int[] number;

	public void SetVal(int[] a)
	{
		number=a;
		Count();		
	}

	private void Count()
	{
		for (int i = 0; i < number.Length; i++)
		{
			if ((number[i] % 2) == 0) // use of modulus operator
			{
				even += 1; // counting EVEN numbers
			}
			else
			{
				odd += 1; // counting ODD numbers
			}
		}
		
		System.Console.WriteLine("Even Numbers : "+ even);
		System.Console.WriteLine("Odd Numbers : "+ odd);	
	}	
}


class IfElseTestClient
{
	public static void Main(string[] args)
	{

		int[] number={50, 65, 56, 71, 81};
		IfElseTest obj = new IfElseTest();
		obj.SetVal(number);
	}
}

/* 

Output: 

Even Numbers : 2
Odd Numbers : 3

*/
