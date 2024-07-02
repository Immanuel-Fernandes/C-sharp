/* 

Question:

Write a C# program to perform Explicitly conversion using the Convert class

*/

class Convert_class
{
    public static void Main(string[] args)
    {        
        float f = 12.34f;
        int i = System.Convert.ToInt32(f); // Explicit conversion using the Convert class

        System.Console.WriteLine("Float value: " + f);
        System.Console.WriteLine("Int value after explicit conversion using Convert class: " + i);
    }
}


/* 

Output: 

Float value: 12.34
Int value after explicit conversion using Convert class: 12

*/
