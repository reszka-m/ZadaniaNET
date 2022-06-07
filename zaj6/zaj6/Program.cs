// See https://aka.ms/new-console-template for more information


using zaj6;


public class Program : INww
{
    private int _a, _b;
    public int b { set => _b = value; get => _b; }
     public int a { set => _a = value; get => _a; }

    public int NWW(int a, int b)
    {
        while (a != b)
        {
            if (a == b)
                return a;
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        return a;
    }
    static void Main()
    {
        var Program = new Program();
        Console.WriteLine("Podaj wartosc a");
        Program.a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartosc b");
        Program.b = int.Parse(Console.ReadLine());
        
       Console.WriteLine("NWW {0}", Program.NWW(Program.a, Program.b));
    }

   
}
