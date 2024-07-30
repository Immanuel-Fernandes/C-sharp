class WhileTest
{
	private int n ,z;

	public void SetVal(int x)
    {
        z = x;
        n = 1;
        Display();
    }

    private void Display()
	{
		
		while (n <= z)
		{
			if (n%2 == 0)
			{
				n++;
			}
			else
			{
				System.Console.Write(" "+n);
				n++;
			}
		}
	}
}

class WhileTestClient
{
    public static void Main(string[] args)
    {
        WhileTest obj = new WhileTest();

        System.Console.Write("Enter a number: ");
        int x = int.Parse(System.Console.ReadLine());
        obj.SetVal(x);        
    }
}

/* 

Output: 

Enter a number: 10
 1 3 5 7 9

*/