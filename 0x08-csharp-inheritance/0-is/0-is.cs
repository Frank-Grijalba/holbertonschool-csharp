using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj == null)
            return false;

        if(obj.GetType() == typeof(int)){
            return true;
        }
        else{
            return false;
        }
    }
}
