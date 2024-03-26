using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Testic
{
    public partial class Test : Page
    {
        List<Que> que = new List<Que>();
        int i = 0;
        int correctAnswersCount = 0;
        public Test()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            que = serdes.Des<List<Que>>(path);
            LoadQuestion(0);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Window1).framee.Content = new RedTest();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(CorrectAnswer.First, que[i].CorrectAnswer);
            i++; 
            LoadQuestion(i);
        }

        private void second_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(CorrectAnswer.Second, que[i].CorrectAnswer);
            i++; 
            LoadQuestion(i); 
        }

        private void _3_Click(object sender, RoutedEventArgs e)
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
                Title.Text = currentQuestion.Title;
                Description.Text = currentQuestion.Description;
                first.Content = currentQuestion.Option1;
                second.Content = currentQuestion.Option2;
                _3.Content = currentQuestion.Option3;
            }
            else
            {
                Title.Text = "";
                Description.Text = "Правильных ответов: " + correctAnswersCount;
                first.Content = "";
                second.Content = "";
                _3.Content = "";
                first.IsEnabled = false;
                second.IsEnabled = false;
                _3.IsEnabled = false;
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
