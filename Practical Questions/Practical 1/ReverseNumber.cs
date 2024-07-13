class BusLogic
{
    private int number,rev,sd;
    private string result;

    public void SetVal(int num)
    {
        number = num;
        Reverse();
    }

    private void Reverse()
    {
        int n = number;
        rev = 0;
        sd = 0;
        
        while (n > 0)
        {
            int d = n % 10;
            rev = rev * 10 + d;
            sd += d;
            n /= 10;
        }
        result = "Reversed Number: "+rev+"\nSum of Digits: "+sd;
    }

    public string Display()
    {
        return result;
    }
}

class ReverseNumber
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

Enter a number: 1234
Reversed Number: 4321
Sum of Digits: 10

*/