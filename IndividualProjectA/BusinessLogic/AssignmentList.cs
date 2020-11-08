using IndividualProject.BusinessLogic;
using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectA.BusinessLogic
{
    class AssignmentList : CommandPromptUtils
    {

        public Assignments GetAssignmentDetails()
        {
            Assignments Assignment = new Assignments();
            Assignment.Title = AskDetail("What is the assignment title");
            Assignment.Description = AskDetail("What is the assignment description");
            Assignment.SubDateTimes = AskDates("When was the assignment due");
            Assignment.OralMark = AskDetail("What was the oral mark");
            Assignment.TotalMark = AskDetail("What was the total mark");
            return (Assignment);
        }

        public void PrintAssignmentList(List<Assignments> Assignment)
        {
            foreach (var item in Assignment)
            {
                Console.WriteLine(item);
            }

        }
    }
}
