using TextTransformations.Library;

namespace TextTransformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            string result = TransformationEngine.ApplyAllTransformations(text, new InsertSubStringTransformation(0, "This is the original text"), new ReplaceSubStringTransformation("original", "modified"), new RemoveSubStringTransformation("This "));

            Console.WriteLine($"Result: {result}");
        }
    }
}
