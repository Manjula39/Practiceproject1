using Practiceproject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunitproject1
{
    [TestFixture]
    public class Teach
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherID = 104;
            teacher.TeacherName = "Mrs.Savitha";

            // Act & Assert
            Assert.AreEqual(104, teacher.TeacherID);
            Assert.AreEqual("Mrs.Savitha", teacher.TeacherName);
        }
    }
}