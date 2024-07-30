Method overloading
using System;
class Overl oading
{
public static void Main(
Console.WriteLine (volume (10));
Console.Writeline (volume(2.5 F, 8)):
Methods in C# 137
Console.WriteLine(vol ume (100L,75,15));
static
int volume (int x ) |/cube
return (x* x * x ) ;
{
static double volume (float r,int h )
return(3.14519* r *r*h):
/ cylinder
static long volume (long 1, int b ,int h ) |/box
return (1*b* h );