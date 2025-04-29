using Task01.Interfaces;

namespace Task01.Models
{
    public class WebPage : ISearchable
    {
        public string Content { get; set; }

        public WebPage(string content)
        {
            Content = content;        
        }

        public bool Search (string word)
        {
            return Content != null && Content.ToLower().Contains(word.ToLower());
        }
    }
}
