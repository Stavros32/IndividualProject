using IndividualProject.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProjectA.BusinessLogic 
{
    class TrainersList: CommandPromptUtils
    {

        public Trainer GetTrainerDetails()
        {
            List<string> subjects = new List<string>() { "C#", "Java", "Python", "Javascript", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me the first name");
            trainer.LastName = AskDetail("Give me the last name");
            trainer.Subject = AskDetail("Give me the subject you teach ", subjects);
            return (trainer);
        }
        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
