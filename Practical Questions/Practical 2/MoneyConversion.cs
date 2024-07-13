public class BusLogic
{
    private float rupees,paise;
    private string result;

    public void SetVal(float amount)
    {
        rupees = amount;
        ConvertToPaise();
    }

    private void ConvertToPaise()
    {
        paise = rupees * 100;
        result =rupees + " Rs. is equal to " + paise + " Paise";
    }

    public string Display()
    {
        return result;
    }
}

public class MoneyConversion
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();

        System.Console.Write("Enter price in Rs.: ");
        float amt = float.Parse(System.Console.ReadLine());
        obj.SetVal(amt);
        System.Console.WriteLine(obj.Display());
    }
}

/* 

Output: 

Enter price in Rs.: 12.34
12.34 Rs. is equal to 1234 Paise

*/