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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        Dictionary<char, bool> alphabetCheck = new Dictionary<char, bool>();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach(char c in alphabet){
            alphabetCheck[c] = false;
        }
        foreach(char c in s.ToLower()){
            alphabetCheck[c] = true;
            
        }
        foreach(bool status in alphabetCheck.Values){
            if(!status) return "not pangram";
            
        }
        return "pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
