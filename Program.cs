using System;

class program

{
    static void Main(string[] args)
    {
        var hora = DateTime.Now;
        Console.WriteLine(hora.ToString("t"));

        Console.ReadKey();  
    }
}