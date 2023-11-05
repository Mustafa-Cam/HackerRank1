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



class Solution7
{
    public static void Main(string[] args)
    {
        string? S = Console.ReadLine();
        try
        {
            if(S!=null){
            int number = int.Parse(S);
            Console.WriteLine(number);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Bad String");
        }
        
        
    }
    
}
