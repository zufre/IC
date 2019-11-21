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

class Solution {

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        
        
        // elements automatically initialized to 0
        // int[] letterCounts = new int[26];
        
        // foreach (char c in a) { letterCounts[c - 'a']++; }
        // foreach (char c in b) { letterCounts[c - 'a']--; }
        // return letterCounts.Sum(x => Math.Abs(x));

    string restA = "";
    foreach(char c in a.ToCharArray())
    {
        // if b doesn't contain char from a, we add that char to restA
        if (b.IndexOf(c) == -1) restA += c;
        // if b contain char from a, we remove that char from b
        else b = b.Remove(b.IndexOf(c), 1);
    }

    return restA.Length + b.Length;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
