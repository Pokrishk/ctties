using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using Testic.ViewModel.Helpers;

namespace Testic.ViewModel
{
    internal class TestViewModel
    {
        private ObservableCollection<Que> que = new ObservableCollection<Que>();
        private ObservableCollection<Que> Que
        {
            get { return que; }
            set
            { que = value; }
        }
        private int I;
        private int i
        {
            get { return I; }
            set { I = value; }
        }
        int correctAnswersCount = 0;
        public BindableCommand Command1 { get; set; }
        public BindableCommand Command2 { get; set; }
        public BindableCommand Command3 { get; set; }
        public TestViewModel()
        {
            Command1 = new BindableCommand(_ => Fi());
            Command2 = new BindableCommand(_ => Se());
            Command3 = new BindableCommand(_ => Th());
            i = 0;
            correctAnswersCount = 0;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            que = serdes.Des<ObservableCollection<Que>>(path);
            LoadQuestion(0);
        }
        public void Fi()
        {
            CheckAnswer(CorrectAnswer.First, que[i].CorrectAnswer);
            i++;
            LoadQuestion(i);
        }

        public void Se()
        {
            CheckAnswer(CorrectAnswer.Second, que[i].CorrectAnswer);
            i++;
            LoadQuestion(i);
        }

        public void Th()
        {
            CheckAnswer(CorrectAnswer.Third, que[i].CorrectAnswer);
            i++;
            LoadQuestion(i);
        }
        private void LoadQuestion(int index)
        {
            if (index >= 0 && index < que.Count)
            {
                Que currentQuestion = que[index];
            }
        }
        private void CheckAnswer(CorrectAnswer selectedAnswer, CorrectAnswer correctAnswer)
        {
            if (selectedAnswer == correctAnswer)
            {
                correctAnswersCount++;
            }
        }
    }
}
