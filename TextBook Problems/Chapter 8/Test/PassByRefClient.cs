using System;
class PassByRef
{
static void Swap (ref int x, ref int y )
{
int temp = X;

x=y;
y = temp;
public static void Main()
f
int m = 100:
int n = 200;
Console.Writeline ("Before Swapping:");
Console.WriteLine("m = "+ m);
Console.WriteLine("n = "t n);
Swap( ref m,ref n );
}
}
Console.WriteLine ("After Swpaping:");
Console.WriteLine ("m = "+ m);
Console.WriteLine ("n= "+ n);
}
}

class PassByRefClient