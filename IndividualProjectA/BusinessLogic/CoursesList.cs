using IndividualProject.BusinessLogic;
using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectA.BusinessLogic
{
    class CoursesList : CommandPromptUtils
    {

        public Courses GetCourseDetails()
        {
            Courses courses = new Courses();
            List<string> subjects = new List<string>() { "C#", "Java", "Python", "Javascript", "PHP" };
            courses.Title = AskDetail("What is the course title");
            courses.Stream = AskDetail("What is the stream name", subjects);
            courses.Type = AskDetail("What course type is it");
            courses.StartDates = AskDates("When does the course start");
            courses.EndDates = AskDates("When does the course end");
            return (courses);
        }
        public void PrintCoursesList(List<Courses> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }

        }
    }
}
