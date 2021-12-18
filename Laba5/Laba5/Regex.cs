using System.Text.RegularExpressions;

namespace BLL
{
    public class RegexService
    {
        string Format { get; set; }

        public RegexService(string format) { Format = format; }

        public bool Check(string data)
        {
            Regex regex = new Regex(Format);
            return regex.IsMatch(data);
        }
    }
}