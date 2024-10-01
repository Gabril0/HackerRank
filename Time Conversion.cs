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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    private static string RemoveHoursAndRemovesEnd(string ogString, string textToRemove){
        string stringRemaining = ogString.Remove(0, 2);
        stringRemaining = stringRemaining.Replace(textToRemove,"");
        return stringRemaining;
    }
    public static string timeConversion(string s)
    {
        int hours;
        string hoursString = s[0].ToString() + s[1].ToString();
        if(int.TryParse(hoursString, out hours)){
            if(s.EndsWith("PM")){
                string stringRemaining = RemoveHoursAndRemovesEnd(s, "PM");
                if(hours == 12){
                    return $"{hours}{stringRemaining}";
                }
                return $"{hours + 12}{stringRemaining}";
            
            }
            if(s.EndsWith("AM")){
                string stringRemaining = RemoveHoursAndRemovesEnd(s, "AM");
                if(hours == 12){             
                    return $"00{stringRemaining}";
                }
                if(hours < 10){
                        return $"0{hours}{stringRemaining}";
                    }
                return $"{hours}{stringRemaining}";
                
            }
                
        };
        
        return "Error";
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
