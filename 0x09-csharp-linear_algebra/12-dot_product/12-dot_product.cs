using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This is the class object.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 
        || vector2.Length > 3 || vector1.Length != vector2.Length)
        {
            return(-1);
        }

        double result = 0;
        int i = 0;
        
        for (i = 0; i < vector1.Lenght ; i++)
            result += (vector1[i] * vector2[i]);

        return result;
    }
}
