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

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        arr.Sort();
        List<long> remainingfirstNumbers = arr.Skip(1).ToList();
        List<long> remainingLastNumbers = arr.Take(arr.Count - 1).ToList();
        long minsum=0;
        long maxsum=0;
        foreach(var number in remainingfirstNumbers)
        {
         minsum += number;    
        }
        
        foreach(var number in remainingLastNumbers)
        {
         maxsum += number;
        }
        Console.WriteLine(maxsum+" "+minsum);
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("lütfen aralıklı 5 sayı giriniz");
        List<long>? arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}}
