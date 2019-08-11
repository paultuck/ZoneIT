using System;
using System.Collections.Generic;

namespace TrainingDataLayer.Models
{
    public partial class TrainingCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
