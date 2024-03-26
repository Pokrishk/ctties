using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testic
{
    internal class Que
    {
        public string Title { get; set; }         
        public string Description { get; set; }   
        public string Option1 { get; set; }       
        public string Option2 { get; set; } 
        public string Option3 { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
        public Que(string title, string description, string option1, string option2, string option3, CorrectAnswer correctAnswer)
        {
            Title = title;
            Description = description;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            CorrectAnswer = correctAnswer;
        }
    }
}
