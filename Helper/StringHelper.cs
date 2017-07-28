using System;
using System.Collections.Generic;

namespace Helper
{
    public class StringHelper
    {
        /// <summary>
        /// Reports the indexes of every occurrence of the specified string in this instance
        /// </summary>
        /// <param name="text">The string provided by the user</param>
        /// <param name="searchPhrase">The string to match</param>
        /// <returns>A list of integers containing the matching position(s), or an empty list if there are no matches or the text/searchPhrase are null or empty</returns>
        public List<int> TextMatchPosition(string text, string searchPhrase)
        {
            var responseList = new List<int>();
            if (String.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchPhrase))
                return responseList;

            var matchPosition = 0;
            var j = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (string.Equals(text[i].ToString(), searchPhrase[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    //Here we verify if a matching position has been found, if this element = 0 it means this is a possible starting point and it needs to be saved 
                    if (matchPosition == 0)
                        matchPosition = i + 1;
                    /*If we reach the lenght of our search phrase then the match is completed, and we initialize the search variables for a new search
                    otherwise we increment the search phrase index to continue the matching*/
                    if (j == searchPhrase.Length - 1)
                    { responseList.Add(matchPosition); matchPosition = 0; j = 0; }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    //If an incomplete match is reached, then we reset the search variables and continue the search 
                    if (matchPosition == 0) continue;
                    i--; matchPosition = 0; j = 0;
                }
            }

            return responseList;
        }
    }
}
