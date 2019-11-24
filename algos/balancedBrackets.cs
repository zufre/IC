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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {
        int l = s.Length;
       string res = "No";
       var list = s.ToCharArray().ToList();
            for(int i=0; i<l-1;i++)
            {
                if (list[i].Equals('{'))
                {
                    if (list.IndexOf('}') != -1)
                    {
                        res = "Yes";
                        list[list.IndexOf('}')]='q';
                    }
                    else
                    {
                    res= "No";
                    }
                    
                }
                else if (list[i].Equals('['))
                {
                    if (list.IndexOf(']') != -1)
                    {
                        res = "Yes";
                        list[list.IndexOf(']')]='q';
                    }
                    else
                    {
                    res= "No";
                    }
                    
                }
                else if (list[i].Equals('('))
                {
                    if (list.IndexOf(')') != -1)
                    {
                        res = "Yes";
                        list[list.IndexOf(')')]='q';
                    }
                    else
                    {
                    res= "No";
                    }
                    
                }
                
               
            }
            foreach(var c in list)
            {
                Console.WriteLine(c);
            }
            return res;
        }
        
        
    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
