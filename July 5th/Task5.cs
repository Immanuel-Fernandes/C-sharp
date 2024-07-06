         /* 

Question:

Write a C# program for The Total distance travelled by vehicle in T seconds is given by displacement=UT+AT^2/2.
 Where the U is the initial Velocity meters per second, A is the acceleration meters per second square. 

*/

class Task5
{
    public  static void Main(string[] args)
    {
        System.Console.Write("Velocity: ");
        string velocity = System.Console.ReadLine();
        float U = float.Parse(velocity);

        System.Console.Write("Acceleration: ");
        string acceleration = System.Console.ReadLine();
        float A = float.Parse(acceleration);

        System.Console.Write("Time (Seconds): ");
        string time = System.Console.ReadLine();          
        float T = float.Parse(time);

        float displacement = U * T + 0.5f * A * T * T;
        System.Console.WriteLine("Total displacement after {0} seconds is: {1} meters", T, displacement);
        
    }
}



/* 

Output: 

Velocity: 10
Acceleration: 2.3
Time (Seconds): 7.8
Total displacement after 7.8 seconds is: 147.966 meters

*/