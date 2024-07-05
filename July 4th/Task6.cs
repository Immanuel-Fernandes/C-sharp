/* 

Question:

In Inventory Management the economic order for the single item is given by 
EOQ=sqrt(2*demand rate*setup cost)/(holding cost per item per unit time) 
and the optimal time between orders 
PPO=sqrt(2*setup cost)/(demand rate*holding cost of per item per unit time).
Write a C# program to compute EOQ and PPO, given demand rate(items per unit time), Setup cost(per order), holding cost(per item per unit time).

*/

class Task6
{
    static void Main(string[] args)
    {
        System.Console.Write("Demand rate (items per unit time):");
        string DR = System.Console.ReadLine();
        float demandRate = float.Parse(DR);

        System.Console.Write("Setup cost per order:");
        string SC = System.Console.ReadLine();
        float setupCost = float.Parse(SC);

        System.Console.Write("Holding cost per item per unit time:");
        string HC = System.Console.ReadLine();
        float holdingCost = float.Parse(HC);

        float EOQ = (float)(System.Math.Sqrt((2 * demandRate * setupCost) / holdingCost));
        float PPO = (float)(System.Math.Sqrt((2 * setupCost) / (demandRate * holdingCost)));

        System.Console.WriteLine("Economic Order Quantity (EOQ): {0}",EOQ);
        System.Console.WriteLine("Optimal Time Between Orders (PPO): {0}",PPO);
        
    }
}



/* 

Output: 

Demand rate (items per unit time):100
Setup cost per order:300
Holding cost per item per unit time:5
Economic Order Quantity (EOQ): 109.5445
Optimal Time Between Orders (PPO): 1.095445

*/