using System;


public class two 
{
    int a;
    int b;
    int final;

 public two(int x,int y)
    {
        this.a = x;
        this.b = y;
    }
    public int sum ()
    {
        return (this.a)+(this.b);
    }

    ~two()
    {
        final = ((this.a) + (this.b))-1;
        Console.WriteLine(final);
    }
}






public class one
{

    public static void Main ()

    {
        Console.WriteLine("Mushi Mushi");

        two obj1 = new two(30,20);


        Console.WriteLine(obj1.sum());


    }

}