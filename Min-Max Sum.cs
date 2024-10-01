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

    public static void miniMaxSum(List<int> arr)
    {
        //minsum is always the sum of the 4 first sorted numbers
        arr.Sort();
        Int64 min_sum = 0;
        Int64 max_sum = 0;
        for(int i = 0; i < arr.Count; i++ ){
            if(i <= 3){
                min_sum += arr[i];
            }
            if(i > 0) max_sum += arr[i];
            
        }
        Console.WriteLine($"{min_sum} {max_sum}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
