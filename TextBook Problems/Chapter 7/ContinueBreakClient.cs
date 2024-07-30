class ContinueBreak
{
	private int n;

	public void SetVal(int z)
    {
        n=z;
        Display();
    }

    private void Display()
    {
		while ( n < 200 )
		{
			if ( n < 50 )
			{
				System.Console.Write(" " + n);
				n = n + 10;
				continue;
			}

			if (n == 50)
			{
				System.Console.WriteLine( );
				n = n + 10;
				continue;
			}

			if (n > 90) break;
			System.Console.Write(" " + n);
				n = n + 10;
		}
		System.Console.WriteLine( );
	}
}

class ContinueBreakClient
{
    public static void Main(string[] args)
    {
        ContinueBreak obj = new ContinueBreak();
		System.Console.Write("Enter a number: ");
        int x = int.Parse(System.Console.ReadLine());
        obj.SetVal(x); ;        
    }
}

/* 

Output: 

Enter a number: 10
 10 20 30 40
 60 70 80 90

*/