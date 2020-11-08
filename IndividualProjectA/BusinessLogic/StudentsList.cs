using IndividualProject.BusinessLogic;
using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectA.BusinessLogic
{
    class StudentsList: CommandPromptUtils
    {

        public Students GetStudentDetails()
        {
            Students students = new Students();
            students.FirstName = AskDetail("Give me the first name");
            students.LastName = AskDetail("Give me the last name");
            students.DateOfBirth = AskDates("Give me the  date of birth");
            students.TuitionFees = Convert.ToDouble(AskDetail("Give me the students tuition fees"));
            return (students);
        }
        public void PrintStudentList(List<Students> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }
    }
}
