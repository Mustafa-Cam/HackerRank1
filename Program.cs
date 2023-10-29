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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */
    public static void staircase(int n)
    {
        int m = n;
        int k =1;
        while(m!=0){
        for(int a=k; a<n; a++){
            Console.Write(" ");
        }
        k++;
        for(int b=0;b<=n-m;b++){
            Console.Write("#");
        }
        Console.WriteLine("");
        if(m!=0){
                m--;
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı gir");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
