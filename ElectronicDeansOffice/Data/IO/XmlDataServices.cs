using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Data.IO
{
    public static class XmlDataServices
    {
        private const string StudentPath = "Students.xml";
        private const string GroupPath = "Groups.xml";
        private const string DormitoryPath = "Dormitories.xml";

        public static void SaveStudents(List<Student> students)
        {
            using (var stream = new FileStream(StudentPath, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Student>));
                XML.Serialize(stream, students);
            }
        }

        public static void SaveGroups(List<Group> groups)
        {
            using (var stream = new FileStream(GroupPath, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Group>));
                XML.Serialize(stream, groups);
            }
        }

        public static void SaveDormitories(List<Dormitory> dormitories)
        {
            using (var stream = new FileStream(DormitoryPath, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Dormitory>));
                XML.Serialize(stream, dormitories);
            }
        }

        public static List<Student> LoadStudents(List<Student> students)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            using (var stream = new FileStream(StudentPath, FileMode.OpenOrCreate))
            {
                return students = (List<Student>)xs.Deserialize(stream);
            }
        }

        public static List<Group> LoadGroups(List<Group> groups)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Group>));
            using (var stream = new FileStream(GroupPath, FileMode.OpenOrCreate))
            {
                return groups = (List<Group>)xs.Deserialize(stream);
            }
        }

        public static List<Dormitory> LoadDormitories(List<Dormitory> dormitories)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Dormitory>));
            using (var stream = new FileStream(DormitoryPath, FileMode.OpenOrCreate))
            {
                return dormitories = (List<Dormitory>)xs.Deserialize(stream);
            }
        }
    }
}
