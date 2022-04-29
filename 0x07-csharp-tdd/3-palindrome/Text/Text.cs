using System;

namespace Text
{

    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            if(s == null || s.Length == 0 || s == "")
                return true;

            string onlyAlpha = "";
            string inverse = "";
            string chr;
            int asciiCode;

            foreach (char c in s) {
                asciiCode = (int) c;
                if (asciiCode <= 96 || asciiCode >=123)
                    continue;
                onlyAlpha += c;
            }

            for (int iterator = onlyAlpha.Length-1; iterator >= 0; iterator-- )
            {
                chr = onlyAlpha.Substring(iterator, 1);
                inverse += chr;
            }
            Console.WriteLine(inverse);
            if (onlyAlpha == inverse)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
