using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TextMatch.Models
{
    public class Text
    {
        [Required]
        public string SearchPhrase { get; set; }
        [Required]
        public string Input { get; set; }
        public List<int> Results { get; set; }
    }
}