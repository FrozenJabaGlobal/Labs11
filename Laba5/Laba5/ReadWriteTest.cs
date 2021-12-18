using System.Collections.Generic;
using Xunit;
using Moq;
using DAL;

namespace BLL.Tests
{
    public class ReadWriteServiceTests
    {
        [Fact]
        public void Read_Success()
        {
            var mock = new Mock<IDataContext<Student>>();
            mock.Setup(x => x.GetData()).Returns(GetTestStudents());
            var service = new ReadWriteService<Student>(null, null);
            service._dataContext = mock.Object;
            var result = service.ReadData();
            Assert.IsType<List<Student>>(result);
            Assert.Equal(GetTestStudents(), result);
        }

        [Fact]
        public void Write_Success()
        {
            var student = new Student("AK12435456", 3, "Liuda", "Ross", "06/04/20", new Study());
            var mock = new Mock<IDataContext<Student>>();
            mock.Setup(x => x.SetData(student)).Verifiable();
            var service = new ReadWriteService<Student>(null, null);
            service._dataContext = mock.Object;
            service.WriteData(student)
            mock.Verify(x => x.SetData(student), Times.Once);
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
    }
}