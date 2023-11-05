using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result6
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        // dizi {1 1 2 2 2 3 3 3 3 3  4 4 4 4 4}
        var groups = arr.GroupBy(x => x); // Bu ifade, verilen diziyi elemanlarına göre gruplandırır. Her bir kuş türü için bir grup oluşturur. bizim grubu 1 2 3 ve 4 e göre gruplayacak. sql sorgusu gibi düşün x => x aslına bir şey yapmıyor diziye tekrar dönüyor 
        var maxCount = groups.Max(g => g.Count()); // burda en çok tekrar eden sayının kaç kere tekrarlandığı bulunuyor mesela 2 3 kere tekrarlanmış 2=>3 4, 5 kere tekrarlanımş 4=>5 bu şekilde bakıyor tekrar sayısına en çok tekrar eden saının tekrar sayısını alıyor. yani bizim dizimizde maxcount=5 dönecek.
        var mostFrequentNumbers = groups.Where(g => g.Count() == maxCount).Select(g => g.Key); // burda en çok tekrar eden sayıları bulur g.key ifadesi ise mesela 3 5 defa tekrar etmiş yani en çok tekrar eden sayı 3 ve 4 bunlar 5 kere tekrar etmiş key burda 3 ve 4 oluyor . 
        return mostFrequentNumbers.Min();// burda da 3 ve 5 karşılaştırılıyor 3 seçiliyor. 
       
    }

}

class Solution6
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result6.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
