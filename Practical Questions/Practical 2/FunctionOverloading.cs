class BusLogic
{
    private int result;

    public void Add(int a, int b)
    {
        result = Add2(a, b);
        DisplaySum();
    }

    public void Add(int a, int b, int c)
    {
        result = Add3(a, b, c);
        DisplaySum();
    }

    private int Add2(int a, int b)
    {
        return a + b;
    }

    private int Add3(int a, int b, int c)
    {
        return a + b + c;
    }

    private void DisplaySum()
    {
        System.Console.WriteLine("The sum is: " + result);
    }
}

class FunctionOverloading
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();

        if (args.Length >= 2)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            obj.Add(a, b);
        }        

        if (args.Length >= 3)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);
            obj.Add(a, b, c);
        }        
    }
}

