using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffFilter
{
    public static int[] Diff(int[] input)
    {
        if (input == null || input.Length == 0)
        {
            return new int[0];
        }

        int[] result = new int[input.Length];
        result[0] = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            result[i] = Mathf.Abs(input[i] - input[i - 1]);
        }

        return result;
    }
}

