using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class ReplaceSubStringTransformation(string lookupText, string replaceWithText) : TextTransformation
    {
        public string LookupText { get; } = lookupText ?? throw new ArgumentNullException(nameof(lookupText));

        public string ReplaceWithText { get; } = replaceWithText ?? throw new ArgumentNullException($"{nameof(replaceWithText)}");

        public override string ApplyTransformation(string text)
        {
            if (text == null) 
            {
                return string.Empty;
            }

            string result = text.Replace(LookupText, ReplaceWithText);

            return result;
        }
    }
}
