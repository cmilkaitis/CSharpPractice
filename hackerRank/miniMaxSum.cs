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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        Array.Sort(arr);
        UInt64 [] newArr = new UInt64[5];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = Convert.ToUInt64(arr[i]);
        }

        UInt64[] maxSum = newArr.Skip(1).ToArray();
        UInt64[] minSum = newArr.Take(newArr.Count() - 1).ToArray();
        
        Console.WriteLine($"{minSum.Aggregate((a,c) => a + c)} {maxSum.Aggregate((a,c) => a + c)}");
        
    }