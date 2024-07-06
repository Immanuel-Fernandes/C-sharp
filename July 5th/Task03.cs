
/* 

Question:

The Straight Line Method of computing the yearly depriciation of the value of an item is given by depriciation = (purchase price-Salvage value)/years of service. 
Write a Csharp program to determine the salvage value of an item where the purchase price, years of service and the annual depriciation are given

*/

class Task03
{
    public static void Main(string[] args)
    {
        System.Console.Write("Purchase Price:");
        string p = System.Console.ReadLine();
        float purchasePrice = System.Single.Parse(p);

        System.Console.Write("Years of Service:");
        string y = System.Console.ReadLine();
        float yearsOfService = System.Single.Parse(y);

        System.Console.Write("Annual Depreciation:");
        string d = System.Console.ReadLine();
        float annualDepreciation = System.Single.Parse(d);

        float salvageValue = purchasePrice - (annualDepreciation * yearsOfService);

        System.Console.WriteLine("Salvage Value: {0}", salvageValue);
    }
}


/* 

Output: 

Purchase Price: 1500
Years of Service: 5
Annual Depreciation: 30
Salvage Value: 1350

*/