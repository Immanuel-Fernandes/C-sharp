/* 

Question: Task 3

Write a C# program to Declare 3 variables b1, b2, b3 of byte datatype 
And assign 100 to b1, 200 to b2, sum of b1 and b2 to b3 
Develop a program to achieve this and print all values 
if the compiler gives any error modify till you get the correct output

*/

class TaskQ3
{
    static void Main()
    {
        byte b1 = 100;
        byte b2 = 200;

        // byte b3 = b1 + b2; // Error: Cannot implicitly convert type 'int' to 'byte'. An explicit conversion exists (are you missing a cast?)        
        byte b3 = (byte)(b1 + b2);

        
        System.Console.WriteLine("Value b1: " + b1);
        System.Console.WriteLine("Value b2: " + b2);
        System.Console.WriteLine("Sum of b1 and b2 = b3: {0}", b3);
    }
}

/* 

Output: 

Value b1: 100
Value b2: 200
Sum of b1 and b2 = b3: 44  // reason byte hold values from 0 to 255 so b3 will hold the value 44 (300 % 256).

*/