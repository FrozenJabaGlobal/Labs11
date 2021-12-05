namespace Laba3
{
    public class Line
    {
        public Line( string stringValue, string num)
        {
            StringValue = stringValue;
            Num = num;
        }

        public Line()
        {
            
        }

        public string StringValue { get; set; }
        public string Num { get; set; }
    }
}