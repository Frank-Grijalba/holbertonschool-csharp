﻿using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This is the function</summary>
    public static double[] Add(double[] vector1, double[] vector2){
        double[] add = new double[2];
        
        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 
        || vector2.Length > 3 || vector1.Length != vector2.Length)
        {
            add[0] = -1;
            add[1] = -1;
            return add;
        }
        
        double[] result = new double[vector1.Length];
        int i = 0;
        
        for (i = 0; i < vector1.Length; i++){
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}
