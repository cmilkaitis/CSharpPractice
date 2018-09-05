using System;

class Solution {

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {

        int first = 0;
        int second = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            first += arr[i][i];
            second += arr[i][(arr.Length - 1) - i];
        }
        
        return Math.Abs(first - second);
    }