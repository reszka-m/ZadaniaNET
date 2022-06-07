// See https://aka.ms/new-console-template for more information
using zaj3;

public class Program 
{
    public static void Main()
    {
        //Odkomentuj ktore zadanie chcesz odpalic
       // zad2.Delta();
        Szyfr();

    }

    public static void Szyfr()
    {
        Console.WriteLine("Jezeli chcesz wyjsc to nacisniej esc lub q, jezeli nie to kliknij nyle co");
        var loop = true;
        while (loop)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Q)
            {
                loop = false;
                return;
            }
            Console.WriteLine("dawaj litere");
            var litera = Console.ReadLine();



            string encryptedTxt = encrypt(litera, 1);
            string decryptedTxt = decrypt(litera, -1);
            Console.WriteLine("encrypted o jedno do przodu = {0}", decryptedTxt);

        }
    }
    private static String encrypt(String txt, int key)
    {
        String encrypted = "";

        for (int i = 0; i < txt.Length; i++)
        {
            if (Char.IsUpper(txt[i]))
            {
                int characterIndex = txt[i] - (char)('A');
                int characterShifted = (characterIndex + key) % 26 + (char)('A');
                encrypted += (char)(characterShifted);
            }
            else if (Char.IsUpper(txt[i]))
            {
                int characterIndex = txt[i] - (char)('a');
                int characterShifted = (characterIndex + key) % 26 + (char)('a');
                encrypted += (char)(characterShifted);
            }
            else if (Char.IsDigit(txt[i]))
            {
                int characterNew = (int)(txt[i] + key) % 10;
                encrypted += (char)(characterNew);
            }
            else
            {
                encrypted += txt[i];
            }
        }
        return encrypted;
    }

    private static String decrypt(String txt, int key)
    {
        String decrypted = "";
        key = key % 26;

        for (int i = 0; i < txt.Length; i++)
        {
            if (Char.IsUpper(txt[i]))
            {
                int characterIndex = txt[i] - (char)('A');
                int characterOrgPos = (characterIndex - key) % 26 + (char)('A');
                decrypted += (char)(characterOrgPos);
            }
            else if (Char.IsLower(txt[i]))
            {
                int characterIndex = txt[i] - (char)('a');
                int characterOrgPos = (characterIndex - key) % 26 + (char)('a');
                decrypted += (char)(characterOrgPos);
            }
            else if (Char.IsDigit(txt[i]))
            {
                int characterOrgPos = (txt[i] - key) % 10;
                decrypted += (char)(characterOrgPos);
            }
            else
            {
                decrypted += txt[i];
            }
        }
        return decrypted;
    }
}