using System;

namespace tip_donusumleri
{
class Program
{
static void Main(string[] args)
{       // Implicit Conservesion (Bilincsiz Donusum)
    Console.WriteLine("*****Implicit Conservation********") ;
    byte a = 5;
    sbyte b = 30; 
    short c= 10;

    int d= a + b+c ;

    Console.WriteLine("d:" + d);

    long h =d ;
    Console.WriteLine("h:" + h);

    float i= h ;
    Console.WriteLine("i:" + i);

    string e = "baris demirkap";
    char f= 'k' ;
    object g =e+f+d ;
    Console.WriteLine("g:" + g);
    // Explicit Conservesion (Bilincli Donusum)

    Console.WriteLine("*****Explicit Conservation********") ;
    int x = 4;
    byte y = (byte)x ;
    Console.WriteLine("y:"+y) ;
    int z =100 ;
    byte t= (byte)z ;
    Console.WriteLine("z:"+z) ;
    float w = 10.3f;
    byte v = (byte)w ;
    Console.WriteLine("v:"+v) ;

    
}

}

}