using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;
using Microsoft.Win32;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            List<string> Subjects = new List<string>() { "trainers", "students", "courses", "assignments" };
            cpUtils.Questions(Subjects);
        }
        // Create appropriate methods in order to ask 
        // from the user data for the four main classes       
    }

}
