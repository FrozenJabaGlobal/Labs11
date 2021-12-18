using System.Collections.Generic;
using System.Text;

namespace BLL.Tests
{
    public class EntityServiceTests
    {
        [Fact]
        public void Add_Success()
        {
            var student = new Student("AK12435456",3,"Liuda","Ross","06/04/20",new Study());
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.WriteData(student)).Verifiable();
            var service = new EntityService<Student>(mock.Object);
            service.Add(student);
            mock.Verify(x => x.WriteData(student), Times.Once);
        }



        [Fact]
        public void Search_Success()
        {
            var student = new Student("AK12435456", 3, "Liuda", "Ross", "06/04/20", new Study());
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.ReadData()).Returns(GetTestStudents());
            var service = new EntityService<Student>(mock.Object);
            var result = service.Search(student);
            Assert.IsType<Student>(result);
            Assert.Equal(student, result);
        }

        [Fact]
        public void Show_Success()
        {
            var mock = new Mock<IDataReadWriteService<Student>>();
            mock.Setup(x => x.ReadData()).Returns(GetTestStudents());
            var service = new EntityService<Student>(mock.Object);
            var result = service.Show();
            Assert.IsType<string>(result);
        }

        private List<Student> GetTestStudents()
        {
            var students = new List<Student>
            {
                new Student("AK12435456",3,"Liuda","Ross","06/04/20",new Study()),
                new Student("GB12345678",2,"Mike","Lenf","25/10/2001",new DoMoney())
            };

            return students;
        }

        private string GetTestStudentsString()
        {
            StringBuilder data = new StringBuilder();
            foreach (var item in GetTestStudents())
                data.Append(item.ToString());
            return data.ToString();
        }
    }
}
