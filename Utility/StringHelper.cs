using System;
using System.Collections.Generic;

namespace Helper
{
    public class StringHelper
    {
        public List<int> TextMatchPosition(string text, string match)
        {
            var responseList = new List<int>();
            var pos = 0;
            var j = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (string.Equals(text[i].ToString(), match[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    if (pos == 0)
                        pos = i + 1;

                    if (j == match.Length - 1)
                    { responseList.Add(pos); pos = 0; j = 0; }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    if (pos == 0) continue;
                    i--; pos = 0; j = 0;
                }
            }

            return responseList;
        }
    }
}
