using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public static class TransformationEngine
    {
        public static string ApplyAllTransformations(string text, params TextTransformation[] textTransformations)
        {
            string result = text;
            foreach (var transformation in textTransformations)
            {
                result = transformation.ApplyTransformation(result);
            }

            return result;
        }
    }
}
