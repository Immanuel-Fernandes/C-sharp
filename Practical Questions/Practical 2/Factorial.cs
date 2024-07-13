class BusLogic
{
    private int n,f;
    private string result;

    public void SetVal(int num)
    {
        n = num;
        Fact();
    }

    private void Fact()
    {
        f = 1;
        for (int i = 1; i <= n; i++)
        {
            f *= i;
        }

        result = "Factorial of "+ n +" is: "+ f;
    }

    public string Display()
    {
        return result;
    }
}

class Factorial
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();
        System.Console.Write("Enter a number: ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        obj.SetVal(n);
        System.Console.WriteLine(obj.Display());
    }
}


/* 

Output: 

Enter a number: 5
Factorial  of 5 is: 120

*/