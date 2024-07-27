class CityGuide
{
	private string name;

	public void Select()
	{
		System.Console.WriteLine("Select your choice");
		System.Console.WriteLine("London");
		System.Console.WriteLine("Bombay");
		System.Console.WriteLine("Paris");
		System.Console.WriteLine("Type your choice");
		name = System.Console.ReadLine();
		Guide();
	}

	private void Guide()
	{
		switch(name)
		{
			case "Bombay":
				System.Console.WriteLine("Bombay:Guide 5");
				break;
			case "London":
				System.Console.WriteLine("London:Guide 10");
				break;
			case "Paris":
				System.Console.WriteLine("Paris:Guide 15");
				break;
			default:
				System.Console.WriteLine ("Invalid choice");
				break;
		}
	}

}


class CityGuideClient
{
	public static void Main(string[] args)
	{
		CityGuide obj = new CityGuide();
		obj.Select();
	}
}

/* 

Output: 

Select your choice
London
Bombay
Paris
Type your choice
London
London:Guide 10

*/