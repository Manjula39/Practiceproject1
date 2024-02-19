using Practiceproject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunitproject1
{
    [TestFixture]
    public class Stud
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Manju";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Manju", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Gandhinagar 4th cross Bly";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Gandhinagar 4th cross Bly", studentAddress);
        }
    }
}