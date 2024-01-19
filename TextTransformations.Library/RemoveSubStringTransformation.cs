using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class RemoveSubStringTransformation(string lookupText) : TextTransformation
    {
        public string LookupText { get; } = lookupText ?? throw new ArgumentNullException(nameof(lookupText));

        public override string ApplyTransformation(string text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            string result = text.Replace(LookupText, string.Empty);

            return result;
        }
    }
}
