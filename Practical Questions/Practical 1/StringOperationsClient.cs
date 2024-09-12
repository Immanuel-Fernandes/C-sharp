class StringOperations
{
    string str1, str2;
    public void SetVal()
    {
        str1 = "Hello, World!";
        str2 = "Hello, C#";
        StringOp();
    }

    private void StringOp()
    {
        System.Console.WriteLine("Select an operation:");
        System.Console.WriteLine("1: Length");
        System.Console.WriteLine("2: Clone");
        System.Console.WriteLine("3: Compare");
        System.Console.WriteLine("4: Concat");
        System.Console.WriteLine("5: Contains");
        System.Console.WriteLine("6: EndsWith");
        System.Console.WriteLine("7: Replace");
        System.Console.WriteLine("8: Split");
        System.Console.WriteLine("9: Substring");
        System.Console.WriteLine("10: TrimEnd");
        System.Console.WriteLine("0: Exit");

        while (true)
        {
    
        System.Console.Write("Enter your choice: ");
        int choice = System.Convert.ToInt32(System.Console.ReadLine());

        if (choice == 0)
        {            
            break; // Exit
        }

        switch (choice)
        {
            case 1: // Length
                System.Console.WriteLine("Length of str1: " + str1.Length);
                break;

            case 2: // Clone
                object clonedStr = str1.Clone();
                System.Console.WriteLine("Cloned string: " + clonedStr.ToString());
                break;

            case 3: // Compare
                int comparison = string.Compare(str1, str2);
                if (comparison == 0)
                {
                    System.Console.WriteLine("Strings are equal");
                }
                else if (comparison < 0)
                {
                    System.Console.WriteLine("str1 comes before str2");
                }
                else
                {
                    System.Console.WriteLine("str1 comes after str2");
                }
                break;

            case 4: // Concat
                string concatenated = string.Concat(str1, " ", str2);
                System.Console.WriteLine("Concatenated string: " + concatenated);
                break;

            case 5: // Contains
                bool containsWord = str1.Contains("World");
                System.Console.WriteLine(containsWord ? "str1 contains 'World'" : "str1 does not contain 'World'");
                break;

            case 6: // EndsWith
                bool ends = str1.EndsWith("!");
                System.Console.WriteLine(ends ? "str1 ends with '!'" : "str1 does not end with '!'");
                break;

            case 7: // Replace
                string replacedStr = str1.Replace("World", "C#");
                System.Console.WriteLine("Replaced string: " + replacedStr);
                break;

            case 8: // Split
                string[] words = str1.Split(',');
                System.Console.WriteLine("Split string into words:");
                foreach (string word in words)
                {
                    System.Console.WriteLine(word.Trim());
                }
                break;

            case 9: // Substring
                string substring = str1.Substring(7, 5); 
                System.Console.WriteLine("Substring: " + substring);
                break;

            case 10: // TrimEnd
                string strWithSpaces = "Hello, World!   ";
                string trimmedStr = strWithSpaces.TrimEnd();
                System.Console.WriteLine("Trimmed string: '" + trimmedStr + "'");
                break;

            default:
                System.Console.WriteLine("Invalid choice. Please select a valid operation.");
                break;
        }
        }        
    }
}


class StringOperationsClient
{
    public static void Main()
    {
        StringOperations a = new StringOperations();
        a.SetVal();
    }
}


/*

Output

Select an operation:
1: Length
2: Clone
3: Compare
4: Concat
5: Contains
6: EndsWith
7: Replace
8: Split
9: Substring
10: TrimEnd
0: Exit
Enter your choice: 1
Length of str1: 13
Enter your choice: 2
Cloned string: Hello, World!
Enter your choice: 3
str1 comes after str2
Enter your choice: 4
Concatenated string: Hello, World! Hello, C#
Enter your choice: 5
str1 contains 'World'
Enter your choice: 6
str1 ends with '!'
Enter your choice: 7
Replaced string: Hello, C#!
Enter your choice: 8
Split string into words:
Hello
World!
Enter your choice: 9
Substring: World
Enter your choice: 10
Trimmed string: 'Hello, World!'
Enter your choice: 0

*/