﻿using TextTransformations.Library;

namespace TextTransformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is the original text";

            string result = TransformationEngine.ApplyAllTransformations(text);

            Console.WriteLine(result);
        }
    }
}