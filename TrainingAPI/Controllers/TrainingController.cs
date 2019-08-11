using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingClassLibrary;

namespace TrainingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : Controller
    {
        // POST api/values
        [HttpPost]
        public TrainingCourseSaveStatus Post([FromBody] string name, [FromBody] DateTime startDate, [FromBody] DateTime endDate)
        {
            var errorMessage = "";
            int lengthDays = -1;
            try
            {
                var trainingCourse = new TrainingCourse(name, startDate, endDate);
                var trainingCourseDataStore = new TrainingDataStoreDB();
                trainingCourseDataStore.Save(trainingCourse);
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
            }
            
            return new TrainingCourseSaveStatus() { errorMessage = errorMessage, lengthDays = lengthDays };
        }

        public class TrainingCourseSaveStatus
        {
            public int lengthDays;
            public string errorMessage;
        }
    }
}