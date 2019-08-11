using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLibrary
{
    public interface ITrainingDataStore
    {
        int Save(TrainingCourse trainingCourse);
        TrainingCourse Get(int id);
    }
}
