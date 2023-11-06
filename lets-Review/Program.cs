using System;
using System.Collections.Generic;
using System.IO;

class Solution8 {

   

    static void Main(String[] args) {
        
        string? num = Console.ReadLine();
        int number = int.Parse(num);
        
        List<string> strings = new List<string>();
        for (int i = 0; i < number; i++) {
            strings.Add(Console.ReadLine());
        }

        for (int i = 0; i < strings.Count; i++) {
            List<char> evenChars = new List<char>();
            List<char> oddChars = new List<char>();
            
            for (int j = 0; j < strings[i].Length; j++) {
                if (j % 2 == 0) {
                    evenChars.Add(strings[i][j]);
                } else {
                    oddChars.Add(strings[i][j]);
                }
            }
            
            Console.WriteLine(string.Join("", evenChars)+" "+ string.Join("",oddChars));
            
        }
    }
}