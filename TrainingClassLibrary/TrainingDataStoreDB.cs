using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingClassLibrary
{
    public class TrainingDataStoreDB : ITrainingDataStore
    {
        TrainingDataLayer.Models.TrainingDBContext trainingDBContext = new TrainingDataLayer.Models.TrainingDBContext();

        public TrainingCourse Get(int id)
        {
            var trainingCourseModel = trainingDBContext.TrainingCourse.Find(new { id = id });
            var trainingCourse = new TrainingCourse(trainingCourseModel.Name, trainingCourseModel.StartDate, trainingCourseModel.EndDate);
            trainingCourse.id = trainingCourseModel.Id;
            return trainingCourse;
        }

        public int Save(TrainingCourse trainingCourse)
        {
            var trainingCourseModel = new TrainingDataLayer.Models.TrainingCourse();
            trainingCourseModel.Name = trainingCourse.name;
            trainingCourseModel.StartDate = trainingCourse.startDate;
            trainingCourseModel.EndDate = trainingCourse.endDate;
            trainingDBContext.TrainingCourse.Add(trainingCourseModel);
            trainingDBContext.SaveChanges();
            return trainingCourseModel.Id;
        }
    }
}
