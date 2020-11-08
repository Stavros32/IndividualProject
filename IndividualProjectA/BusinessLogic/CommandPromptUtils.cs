using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProjectA.BusinessLogic;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {       
        public string AskDetail(string message, List<string> subjects = null)
        {
            string result = "";
            Console.Write(message + ": ");
            if (subjects != null)
            {
                result = Subjects(subjects);
            }
            else
            {
                result = Console.ReadLine();
            }
            if (result == "")
            {
                result = Randomizer(message);
            }

            return (result);
        }
        public DateTime AskDates(string message)
        {
            string result;
            Console.Write(message + ": ");
            result = Console.ReadLine();
            if (result == "")
            {
                result = RandomDate();
            }
            return (Convert.ToDateTime(result));
        }
        private string Subjects(List<string> subjects)
        {

            int counter = 1;
            Console.WriteLine();
            foreach (var item in subjects)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int subjectNum = (Convert.ToInt32(Console.ReadLine()));
            while (subjectNum > subjects.Count)
            {
                Console.WriteLine("give a valid responce");
                subjectNum = (Convert.ToInt32(Console.ReadLine()));
            }
            string result = subjects.ElementAt(subjectNum - 1);
            return result;

        }

        
        public void Questions(List<string> Subjects)
        {

            Console.WriteLine("Whrite the type of data you would like to insert");
            int counter = 1;
            foreach (var item in Subjects)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int data = Convert.ToInt32(Console.ReadLine());
            while (data > Subjects.Count)
            {
                Console.WriteLine("give a valid responce");
                data = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("how many entries?");
            int noOfEntries = Convert.ToInt32(Console.ReadLine());
            TypesOfData(data, noOfEntries);

        }
        private void TypesOfData(int data, int noOfEntries)
        {
            for (int i = 0; i < noOfEntries; i++)
            {
                if (data == 1)
                {
                    List<Trainer> trainers = new List<Trainer>();
                    TrainersList trainerList = new TrainersList();
                    trainers.Add(trainerList.GetTrainerDetails());
                    trainerList.PrintTrainersList(trainers);
                }
                else if (data == 2)
                {
                    List<Students> students = new List<Students>();
                    StudentsList studentsList = new StudentsList();
                    students.Add(studentsList.GetStudentDetails());
                    studentsList.PrintStudentList(students);
                }
                else if (data == 3)
                {
                    List<Courses> courses = new List<Courses>();
                    CoursesList courseList = new CoursesList();
                    courses.Add(courseList.GetCourseDetails());
                    courseList.PrintCoursesList(courses);
                }
                else
                {
                    List<Assignments> Assignment = new List<Assignments>();
                    AssignmentList assignmentList = new AssignmentList();
                    Assignment.Add(assignmentList.GetAssignmentDetails());
                    assignmentList.PrintAssignmentList(Assignment);
                }

            }

        }
        private string Randomizer(string message)
        {
            Random random = new Random();
            int x;
            if (message == "Give me the first name")
            {
                List<string> randomFirstName = new List<string> { "Ahst", "Clerence", "Angorn", "Eustase", "Zack"};
                x = random.Next(5);
                return randomFirstName[x];
            }
            else if(message == "Give me the last name")
            {
                List<string> randomLastName = new List<string> { "Tredder", "Thorne", "Bain", "Black", "Doe" };
                x = random.Next(5);
                return randomLastName[x];
            }
            else if(message== "Give me the students tuition fees" || message == "What was the oral mark" || message == "What was the total mark")
            {
                x = random.Next(100);
                return (Convert.ToString(x));
            }
            else if (message == "What is the assignment title")
            {
                List<string> randomTitle = new List<string> { "CB12", "CB11", "CB10"};
                x = random.Next(3);
                return randomTitle[x];
            }
            else if (message == "What course type is it")
            {
                List<string> randomType = new List<string> { "Full-Time", "Part-Time" };
                x = random.Next(2);
                return randomType[x];
            }
            else
            {
                List<string> randomDesc = new List<string> { "Desc1", "desc2", "desk3", "desk4", "desk5" };
                x = random.Next(5);
                return randomDesc[x];
            }

        }
        private String RandomDate()
        {
            Random random = new Random();
            List<string> randomTime = new List<string> { "01/02/2000", "11/10/2004", "03/12/1995", "09/07/1999", "07/06/2013" };
            int x = random.Next(5);
            return randomTime[x];
        }

    }
}
