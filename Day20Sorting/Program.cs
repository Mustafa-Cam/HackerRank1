using System;
using System.Collections.Generic;
using System.Linq;

class Solution5
{
    public static void swappProcessing(List<int> list)
    {
        int numberOfSwaps = 0;
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                    numberOfSwaps++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {list[0]}");
        Console.WriteLine($"Last Element: {list[list.Count - 1]}");
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        swappProcessing(a);
    }
}
// 2. yol
// class Solution
// {
//     public static int[] swap(int a, int b)
//     {
//         int temp = a;
//         a = b;
//         b = temp;
//         return new int[] { a, b };
//     }

//     public static int firstname = 0;
//     public static int lastname = 0;
//     public static int numberOfSwaps = 0;
//     public static int countlist = 0;

//     public static void swappProcessing(List<int> list)
//     {
//         for (int i = 0; i < list.Count; i++)
//         {
//             for (int j = 0; j < list.Count - 1; j++)
//             {
//                 if (list[j] > list[j + 1])
//                 {
//                     int[] result = swap(list[j], list[j + 1]);
//                     list[j] = result[0];
//                     list[j + 1] = result[1];
//                     numberOfSwaps++;
//                 }
//             }
//         }

//         countlist = list.Count;
//         lastname = list[countlist - 1];
//         firstname = list[0];
//         Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
//         Console.WriteLine($"First Element: {firstname}");
//         Console.WriteLine($"Last Element: {lastname}");
//     }

//     public static void Main(string[] args)
//     {
//         int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//         swappProcessing(a);
//     }
// }
