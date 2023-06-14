using System;
using System.Linq;



public class BubbleSort
{
    public static void Main()
    {
        Console.WriteLine("Geben Sie die Anzahl der Zahlen ein:");
        int count = int.Parse(Console.ReadLine());

        int[] array = new int[count];

        Console.WriteLine("Geben Sie die Zahlen ein:");

        for (int i = 0; i < count; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Unsortiertes Array:");
        PrintArray(array);
        bubbleSort(array);
        Console.WriteLine("Sortiertes Array:");
        PrintArray(array);
    }



    public static void bubbleSort(int[] array)
    {
        int n = array.Length;



        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Tausche array[j] und array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }



    public static void PrintArray(int[] array)
    {
        int maxValue = array.Max();



        foreach (int element in array)
        {
            int barLength = (int)((double)element / maxValue * 40); // Skaliert die Länge der Balken relativ zum Maximum

            string bar = new string('█', barLength); // Verwende ein Unicode-Blockelement für den Balken

            Console.WriteLine($"{element,3} | {bar}");
            Console.WriteLine(); // Leerzeile hinzufügen
        }
    }
}
