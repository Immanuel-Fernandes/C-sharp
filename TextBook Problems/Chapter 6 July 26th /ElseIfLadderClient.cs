class ElseIfLadder
{
	private int[] rollNumber;
	private int[] marks;

	public void SetVal(int[] rno, int[] m)
	{
		rollNumber=rno;
		marks=m;
		Check();		
	}
	
	private void Check()
	{
		for (int i = 0; i < rollNumber.Length; i++)
		{
			if (marks[i] > 79)
				System.Console.WriteLine(rollNumber[i] + " Honours");
			else if (marks[i] > 59)
				System.Console.WriteLine(rollNumber[i] + " I Division");
			else if (marks[i] > 49)
				System.Console.WriteLine(rollNumber[i] + " II Division");
			else
				System.Console.WriteLine(rollNumber[i] + " FAIL");
		}
	}
}


class ElseIfLadderClient
{
	public static void Main(string[] args)
	{
		int[] rno={111, 222, 333, 444 };
		int[] m={ 81,75, 43, 58 };
		ElseIfLadder obj = new ElseIfLadder();
		obj.SetVal(rno,m);
	}
}
