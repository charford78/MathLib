using System;


namespace StringLibrary
{
    public static class StringLib
    {
        public static string Reverse(string s)
        {
            var charArr = s.ToCharArray();
            var reversedString = "";
            for (var idx = 0; idx < s.Length; idx++)
            {
                var idx2 = s.Length - idx - 1;
                reversedString += charArr[idx2];
            }
            return reversedString;
        }

        public static string Rotate(string a)
        {
            var charArr = a.ToCharArray();
            return charArr[a.Length - 1] + a.Substring(0, 3);
        }

        public static string RemoveVowels(string a)
        {
            var vowels = new char[]
            {
                'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var pos = a.IndexOfAny(vowels);
            while (pos > -1)
            {
                a = a.Remove(pos, 1);
                pos = a.IndexOfAny(vowels);
            }
            return a;
        }
    }
}
