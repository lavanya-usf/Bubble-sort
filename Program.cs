using System;

int[] bubble_sort_numbers = { 5, 72, 3, 14, 7, 1 };
Console.WriteLine("");

Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}

Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
Bubble_Sort(bubble_sort_numbers);
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Press any key to exit the program ...");
Console.ReadKey(true);

static void Bubble_Sort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int x = 0; x < arr.Length - i - 1; x++)
        {
            if (arr[x] > arr[x + 1])
            {
                int temp = arr[x];
                arr[x] = arr[x + 1];
                arr[x + 1] = temp;
            }
        }
    }
}