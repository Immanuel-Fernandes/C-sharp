public class Add
{
    private int result;
    public Add(int a, int b)
    {
        result = Add2(a, b);
        DisplaySum();
    }
    public Add(int a, int b, int c)
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

public class ConstructorOverloading
{
    public static void Main(string[] args)
    {
        int a, b, c;
        a = 10;
        b = 20;
        c = 30; 

        Add obj1 = new Add(a, b);
        Add obj2 = new Add(a, b, c);
    }
}
