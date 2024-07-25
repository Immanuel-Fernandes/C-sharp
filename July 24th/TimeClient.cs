/*

Question:

Define a Time class having 2 int data members 2 overloaded constructors
1 Method to display the data members
First Constructor takes 2 int parameters to assign value to 2 datamembers 
other constructor takes 1 int representing total number of minutes and convert to hours and minutes 
add the Following two methods increment that increments the time by 1 minute 
and decrement that decrements the time by 1 minute

*/


public class Time
{
    private int hours;
    private int minutes;

    public Time(int hours, int minutes)
    {
        this.hours = hours;
        this.minutes = minutes;
        System.Console.Write("Time: ");
        Display();
        Increment();
        Decrement();
    }

    public Time(int Min)
    {
        this.hours = Min / 60;
        this.minutes = Min % 60;
        System.Console.Write("Time: ");
        Display();
        Increment();
        Decrement();
    }

    public void Display()
    {
        System.Console.WriteLine(this.hours + " : " + this.minutes);
    }

    private void Increment()
    {
        this.minutes++;
        System.Console.Write("Increment: ");
        Display();
    }

    private void Decrement()
    {
        this.minutes--;
        this.minutes--;
        System.Console.Write("Decrement: ");
        Display();        
    }
}

public class TimeClient
{
    public static void Main(string[] args)
    {
        Time time1 = new Time(10, 45);
        
        Time time2 = new Time(78); 
    }
}


/* 

Output: 

Time: 10 : 45
Increment: 10 : 46
Decrement: 10 : 44
Time: 1 : 18
Increment: 1 : 19
Decrement: 1 : 17

*/
