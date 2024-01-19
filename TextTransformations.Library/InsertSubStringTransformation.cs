using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class InsertSubStringTransformation(int index, string subString) : TextTransformation
    {
        public int Index { get; } = index < 0 ? throw new ArgumentOutOfRangeException(nameof(index)) : index;

        public string SubString { get; } = subString ?? throw new ArgumentNullException(nameof(subString));

        public override string ApplyTransformation(string text)
        {
            // text = text ?? string.Empty;
            // or, alternatively:
            if (text == null)
            {
                return string.Empty;
            }

            // if (Index < text.Length || (Index == 0 && text.Length == 0))
            // or, simpler:
            if (Index < text.Length || Index == 0)
            {
                string result = text.Insert(Index, SubString);

                return result;
            }

            throw new IndexOutOfRangeException($"{nameof(Index)} {Index} must be grater than (or equal to) 0 and less than {text.Length}");
        }
    }
}
