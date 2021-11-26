using System;
using System.IO;
using System.Text;


public class one
{

    public static void Main ()

    {
        FileStream f = new FileStream("Prince.txt",FileMode.OpenOrCreate);
        StreamWriter s = new StreamWriter(f);

        s.WriteLine("\nPrince is a playboy. Md.Raiyan Mahmud Rahat also a playboy");
        f.WriteByte(65);

        s.Close();
        f.Close();

          
        
    }

}