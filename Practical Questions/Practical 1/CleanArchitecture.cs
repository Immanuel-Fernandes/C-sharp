class BusLogic
{
    private int a;
    private string result;

    public void SetVal(int n1)
    {
        a=n1;
        Method();
    }

    private void Method()
    {
        result = a + "Access Private data Members and Functions with the Help of Public member functions of the same class.";        
    }

    public string Display()
    {
        return result;
    }
}

class CleanArchitecture
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();
        
        int a = int.Parse(args[0]);
        obj.SetVal(a);
        System.Console.WriteLine(obj.Display());

        System.Console.Write("Enter number b: ");
        b = System.Convert.ToInt32(System.Console.ReadLine());
        obj.SetVal(b);
        System.Console.WriteLine(obj.Display());
    }
}