class GotoLabel
{
	private int x;

	public void SetVal(int z)
    {
        x=z;
        Display();
    }

    private void Display()
    {
		for (int i = 1; i < x; i++)
		{
			System.Console.WriteLine(" ");
			if (i >= 10)
			break;
			for (int j = 1; j < x; j++)
			{
				System.Console.Write(" * ");
				if (j == i)
				goto loop1;
			}
			loop1:continue;
		}
		System.Console.WriteLine("Termination by BREAK");
	}
}

class GotoLabelClient
{
    public static void Main(string[] args)
    {
        GotoLabel obj = new GotoLabel();
		System.Console.Write("Enter a number: ");
        int x = int.Parse(System.Console.ReadLine());
        obj.SetVal(x); ;        
    }
}

/* 

Output: 

Enter a number: 100

 *
 *  *
 *  *  *
 *  *  *  *
 *  *  *  *  *
 *  *  *  *  *  *
 *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *  *
Termination by BREAK

*/