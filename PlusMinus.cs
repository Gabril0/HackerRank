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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeroes = 0;
        
        foreach(int item in arr){
            if(item == 0) zeroes ++;
            if(item > 0) positives ++;
            if(item < 0) negatives ++;
            
        }
        Console.WriteLine($"{(float)positives/arr.Count:F6}");
        Console.WriteLine($"{(float)negatives/arr.Count:F6}");
        Console.WriteLine($"{(float)zeroes/arr.Count:F6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
