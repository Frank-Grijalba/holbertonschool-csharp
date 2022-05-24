using System;
class VectorMath
{
    public static double Magnitude(double[] vector){
        double add = 0;
        double result = 0;
        if (vector.Length < 2 || vector.Length > 3)
            return -1;

        for (int i = 0; i < vector.Length; i++){
            add += (Math.Pow(vector[i], 2));
        }

        result = Math.Round(Math.Sqrt(add), 2);
        return result;
    }
}
