using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Laba3
{
    
    public class XmlSerializ
    {
        public static void SerializeList(string line, Lists lists)
        {
            using (var stream = new FileStream(line, FileMode.OpenOrCreate))
            {
                var XML = new XmlSerializer(typeof(List<Line>));
                XML.Serialize(stream, lists.Lines);
            }
        }
    }
    public class XMLDerialize
    {
        public static void DerializeList(Lists _lists)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "top_txt.xml");
            XmlSerializer xs = new XmlSerializer(typeof(List<Line>));
            using (var stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                _lists.Lines = (List<Line>) xs.Deserialize(stream)!;
            }
            
            Console.WriteLine("\n" + "Список линий: \n");
            for (int i = 0; i < _lists.Lines.Count; i++)
            {
                Console.WriteLine($"Номер строки: {_lists.Lines[i].Num}, длинна строки: {_lists.Lines[i].StringValue.Length}, строка: {_lists.Lines[i].StringValue}");
            }
        }
    }
}