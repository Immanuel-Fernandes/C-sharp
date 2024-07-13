public class BusLogic
{
    private int n;
    private string result;

    public void SetVal(int num)
    {
        n = num;
        CheckPrime();
    }

    private void CheckPrime()
    {
        bool isPrime = true;
        for (int i = 2; i <= n / 2; i++)
        {
            if ((n % i) == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            result = n + " is a prime number";
        }
        else
        {
            result = n + " is not a prime number";
        }
    }

    public string Display()
    {
        return result;
    }
}

class Prime
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();

        int num = int.Parse(args[0]);
        obj.SetVal(num);

        System.Console.WriteLine(obj.Display());
    }
}


/*

Output:

Prime.exe 10
10 is not a prime number

Prime.exe 97
97 is a prime number

*/

