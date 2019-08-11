using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TrainingClassLibrary
{
    public class TrainingDataStoreMock : ITrainingDataStore
    {
        private int idCounter = 1;
        private List<TrainingCourse> trainingCourses = new List<TrainingCourse>();
        public TrainingCourse Get(int id)
        {
            return trainingCourses.Where(tc => tc.id == id).FirstOrDefault();
        }

        public int Save(TrainingCourse trainingCourse)
        {
            if(trainingCourse.id == -1)
            {
                trainingCourse.id = idCounter;
                idCounter++;
            }
            trainingCourses.Add(trainingCourse);
            return trainingCourse.id;
        }
    }
}
