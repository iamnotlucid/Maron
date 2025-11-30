using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maron
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            List<StudySet> studySets = new List<StudySet>
            {
                new StudySet("Biology Basics", "Biology", DateTime.Now.AddDays(3)),
                new StudySet("World War II", "History", DateTime.Now.AddDays(5))
            };

            StudySets.ItemsSource = studySets;
        }
    }

    public class StudySet 
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime DueDate { get; set; }
        public static int TotalSets { get; set; } = 0;
        public static int SetsCompletedToday { get; set; } = 0;

        public StudySet(string name, string subject, DateTime duedate)
        {
            Name = name;
            Subject = subject;
            DueDate = duedate;

            TotalSets++;
        }

        

    }
}
