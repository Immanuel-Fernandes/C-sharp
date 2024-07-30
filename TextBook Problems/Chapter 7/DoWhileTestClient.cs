class DoWhileTest
{
	private int row, column, y,z;

	public void SetVal(int x)
    {
        z=x;
        row = 1;
        Display();
    }

    private void Display()
	{		
		System.Console.WriteLine("Multiplication Table \n");
		do
		{
			column = 1;

			do
			{
				y = row * column;
				System.Console.Write(" " + y);
				column = column + 1;
			}
			while (column <= z);

			System.Console.WriteLine("\n");
			row = row + 1;
		}

		while (row <= 10);
	}
}

class DoWhileTestClient
{
    public static void Main(string[] args)
    {
        DoWhileTest obj = new DoWhileTest();

        System.Console.Write("Enter a number: ");
        int x = int.Parse(System.Console.ReadLine());
        obj.SetVal(x);        
    }
}


/* 

Output: 

Enter a number: 1
Multiplication Table

 1 2 3

 2 4 6

 3 6 9

*/