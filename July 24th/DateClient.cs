/* 

Question:

Write a Csharp program to design a class named date with the following Data members day, month, year
A constructor to provide value to the data member using 3 parameters
A method to display dd/MM/yyyy

*/


public class Date
{
    private int day;
    private int month;
    private int year;
    private System.DateTime dt;

    public Date()
    {
        this.dt = System.DateTime.Now;
    }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
        this.dt = new System.DateTime(year, month, day);
    }

    public void Display()
    {
        System.Console.WriteLine(this.dt.ToString("dd/MM/yyyy"));
    }
}

class DateClient
{
    public static void Main(string[] args)
    {
        Date obj1 = new Date(23, 7, 2024);
        obj1.Display(); 

        Date obj2 = new Date();
        obj2.Display(); 
    }
}


/* 

Output: 

23-07-2024
25-07-2024

*/