using System;
using MathLib;
using StringLibrary;

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            7.ConcatInt(3).ConcatInt(5).Print();            
            var x = "Fred";
            x.Print();
            (87).Print();
            "Fred's friend.".Print();

            
            //var noVowels = StringLib.RemoveVowels("Abracadabra");
            //Console.WriteLine($"{noVowels}");
            
            //var rotatedString = StringLib.Rotate("abcd");
            //Console.WriteLine($"{rotatedString}");
            //rotatedString = StringLib.Rotate($"{rotatedString}");
            //Console.WriteLine($"{rotatedString}");
            
            //var reversedString = StringLib.Reverse("tacocat");
            //Console.WriteLine($"{reversedString}");

            //Console.WriteLine($"{MathLibrary.About}");
            //Console.WriteLine($"{MathLibrary.Inverse(5)}");
        }
    }
}
