using System;
using System.Collections;

public class SamplesArrayList
{
    private ArrayList myAL;

    public SamplesArrayList()
    {
        myAL = new ArrayList{};
        myAL.Add( "the" );
        myAL.Add( "quick" );
        myAL.Add( "brown" );
        myAL.Add( "fox" );
        myAL.Add( "jumps" );
        myAL.Add( "over" );
        myAL.Add( "the" );
        myAL.Add( "lazy" );
        myAL.Add( "dog" );
        myAL.Add( "in" );
        myAL.Add( "the" );
        myAL.Add( "barn" );
    }

    public void Add1()
    {
        Console.WriteLine("Enter a value to add:");
        string value = Console.ReadLine();
        myAL.Add(value);
        Console.WriteLine("Added: "+value);
        ListContents();
    }

    public void FindIndexOf()
    {
        Console.WriteLine("Enter a word: ");
        string value = Console.ReadLine();
        SearchValue(value);
    }

    public void CheckContains()
    {
        Console.WriteLine("Enter a word: ");
        string value = Console.ReadLine();
        CheckContains(value);
    }

    public void CountOfElements()
    {
        Console.WriteLine("Count:"+ myAL.Count);
    }

    public void Reverse()
    {
        ReverseArrayList();
    }

    public void Sort1()
    {
        SortArrayList();
    }

    public void RemoveByIndex()
    {
        Console.WriteLine("Enter an index to be removed: ");
        int index = Int32.Parse(Console.ReadLine());
        RemoveValueAt(index);
    }

    public void RemoveByValue()
    {
        Console.WriteLine("Enter a value to be removed:");
        string value = Console.ReadLine();
        RemoveValue(value);
    }

    public void ListContents()
    {
        Console.WriteLine("Current contents of the ArrayList:");
        PrintIndexAndValues();
    }

    private void SearchValue(string value)
    {
        int index = myAL.IndexOf(value);
        Console.WriteLine("The first occurrence of "+value+" is at index {index}.");
    }

    private void CheckContains(string value)
    {
        bool contains = myAL.Contains(value);
        Console.WriteLine(contains ? "The ArrayList contains "+ value : "The ArrayList does not contain " + value);
    }

    private void SortArrayList()
    {
        myAL.Sort();
        Console.WriteLine("After sorting:");
        PrintIndexAndValues();
    }

    private void ReverseArrayList()
    {
        myAL.Reverse();
        Console.WriteLine("After reversing:");
        PrintIndexAndValues();
    }

    private void RemoveValueAt(int index)
    {
        myAL.RemoveAt(index);
        Console.WriteLine("After removing at index: "+ index);
        PrintIndexAndValues();        
    }

    private void RemoveValue(string value)
    {
        myAL.Remove(value);
        Console.WriteLine("After removing "+value);
        PrintIndexAndValues();        
    }

   public void PrintIndexAndValues()
    {
        int i = 0;
        foreach (Object obj in myAL)
            Console.WriteLine("   [{0}]:    {1}", i++, obj);
        Console.WriteLine();
    }
}

public class SamplesArrayListTest
{
    public static void Main()
    {
        SamplesArrayList obj1 = new SamplesArrayList();

        while (true)
        {
            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Find Index of");
            Console.WriteLine("3. Contains");
            Console.WriteLine("4. Count of Elements");
            Console.WriteLine("5. Reverse");
            Console.WriteLine("6. Sort");
            Console.WriteLine("7. Remove by Index");
            Console.WriteLine("8. Remove by Value");
            Console.WriteLine("9. List Contents");
            Console.WriteLine("10. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    obj1.Add1();
                    break;

                case "2":
                    obj1.FindIndexOf();
                    break;

                case "3":
                    obj1.CheckContains();
                    break;

                case "4":
                    obj1.CountOfElements();
                    break;

                case "5":
                    obj1.Reverse();
                    break;

                case "6":
                    obj1.Sort1();
                    break;

                case "7":
                    obj1.RemoveByIndex();
                    break;

                case "8":
                    obj1.RemoveByValue();
                    break;

                case "9":
                    obj1.ListContents();
                    break;

                case "10":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
