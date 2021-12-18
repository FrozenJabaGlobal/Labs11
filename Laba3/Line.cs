using System;
using System.Collections.Generic;

namespace Laba3
{
    [Serializable]
    public class Lists
    {
        public Lists()
        {
            Lines = new List<Line>()
            {
                new Line() {Num = "1", StringValue = "m"},
                new Line() {Num = "2", StringValue = ","},
                new Line() {Num = "3", StringValue = "."},
                new Line() {Num = "4", StringValue = "/"},
            };
        }
        public List<Line>? Lines { get; set; }
    }
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