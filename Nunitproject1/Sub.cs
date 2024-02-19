using Practiceproject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunitproject1
{
    [TestFixture]
    public class Sub
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubName = "English";

            // Act
            string subjectName = subject.SubName;

            // Assert
            Assert.AreEqual("English", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubId = 2;

            // Act
            int subjectId = subject.SubId;

            // Assert
            Assert.AreEqual(2, subjectId);
        }
    }
}