using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i=97; i <=122; i++){
            
            if (i == 101 || i == 113){
                continue;
            }
            else{               
                char ch = Convert.ToChar(i);
                Console.Write("{0}", ch);
            }
        }
    }
}
