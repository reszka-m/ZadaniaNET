public class Zaj7
{
    public static void Main(string[] args)
    {
        int[] doPosortownia = { 42, 41, 43, 25, 26 };
        SortArray(doPosortownia);
        PrintArray(doPosortownia);
    }

    private static void SortArray(int[] data)
    {
        for (int i = 1; i < data.Length; ++i)
        {
            int tabCurrent = data[i];
            int j = i - 1;

            while (j >= 0 && data[j] > tabCurrent)
            {
                data[j + 1] = data[j];
                j = j - 1;
            }

            data[j + 1] = tabCurrent;
        }
    }

    private static void PrintArray(int[] data)
    {
        Console.Write("Posortowana tablica:");

        for (int i = 0; i < data.Length; ++i)
            Console.Write(data[i] + " ");

        Console.Write("\n");
    }
}