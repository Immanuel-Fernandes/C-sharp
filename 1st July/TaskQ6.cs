/* 

Question: Task 5

Write a C# program to implement the following int m=100, long n=200, int l=m+n 
System.Console.WriteLine("l = ",l);
if the compiler gives any error modify till you get the correct output

*/

class TaskQ6
{
    static void Main()
    {
        int m = 100;
        long n = 200;

     // int l = m + n; //Error: Cannot implicitly convert type 'long' to 'int'. An explicit conversion exists (are you missing a cast?)

        int l = (int)(m + n); // Casting the result to int to fit.

        
        System.Console.WriteLine("Sum of {0} and {1} is: {2}", m, n, l);
        System.Console.WriteLine("l = {0}",l);
    }
}



/* 


Output: 

Sum of 100 and 200 is: 300
l = 300

*/