using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLibrary
{
    public class TrainingCourse
    {
        public int id;
        public string name;
        public DateTime startDate;
        public DateTime endDate;


        public TrainingCourse(string name, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Start date is after end date.");
            }
            this.id = -1;   // its a new training course
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
