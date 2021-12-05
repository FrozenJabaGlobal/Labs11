using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Laba3;

public class List
{
    public List<Line> Lines = new List<Line>()
    {
        new Line() {Num = "1", StringValue = "m"},
        new Line() {Num = "2", StringValue = ","},
        new Line() {Num = "3", StringValue = "."},
        new Line() {Num = "4", StringValue = "/"},
    };
}

