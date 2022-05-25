using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This is the function</summary>
     public static double[] Multiply(double[] vector, double scalar){
        
        double[] add = new double[2];
        if (vector.Length < 2 || vector.Length > 3)
        {
            add[0] = -1;
            add[1] = -1;
            return add;
        }
        
        double[] result = new double[vector.Length];
        
        for (int i = 0; i < vector.Length; i++){
            result[i] = vector[i] * scalar;
        }
        
        return result;
    }
}
