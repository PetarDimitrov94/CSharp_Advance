using Task01.Interfaces;

namespace Task01.Models
{
    public class Document : ISearchable
    {
        public string Text {  get; set; }

        public Document(string text)
        {
            Text = text;
        }

        public bool Search (string word)
        { 
            return Text != null && Text.ToLower().Contains(word.ToLower()); 
        }
    }
}
