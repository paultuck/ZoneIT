using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainingClassLibrary;

namespace TrainingTest
{
    [TestClass]
    public class TrainingCourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Start date is after end date.")]
        public void DateValidation()
        {
            // is an error thrown if the start date is after the end date

            // Arrange
            var name = "Test Training Course";
            var startDate = DateTime.Now.AddDays(1);
            var endDate = DateTime.Now;
            // Act
            var trainingCourse = new TrainingCourse(name, startDate, endDate);
            // Assert
            // An exception should be thrown, see test method's attribute.
        }

        [TestMethod]
        public void TrainingCourseSave()
        {
            // can we save a Training Course to the ITrainingData and retrieve it?
            // Arrange
            var name = "test";
            var startDate = DateTime.Now.AddDays(1);
            var endDate = DateTime.Now.AddDays(2);
            var trainingCourse = new TrainingCourse(name, startDate, endDate);
            TrainingCourse retrievedTrainingCourse;
            ITrainingDataStore trainingData = new TrainingDataStoreMock();

            // Act
            var id = trainingData.Save(trainingCourse);
            retrievedTrainingCourse = trainingData.Get(id);

            // Assert
            Assert.AreEqual(name, retrievedTrainingCourse.name);
            Assert.AreEqual(startDate, retrievedTrainingCourse.startDate);
            Assert.AreEqual(endDate, retrievedTrainingCourse.endDate);
        }
    }
}
