using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Course choice;
        private List<Course> courses;
        private int totalCredits = 0;
        private const int MaxCredits = 9;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            courses = new List<Course>
            {
                new Course("IT 145"),
                new Course("IT 200"),
                new Course("IT 201"),
                new Course("IT 270"),
                new Course("IT 315"),
                new Course("IT 328"),
                new Course("IT 330")
            };

            foreach (var course in courses)
            {
                this.comboBox.Items.Add(course);
            }

            this.textBox.Text = "0";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);

            if (choice == null)
            {
                this.label3.Content = "Please select a course.";
                return;
            }

            if (choice.IsRegisteredAlready())
            {
                this.label3.Content = "You have already registered for this course.";
                return;
            }

            if (totalCredits + 3 > MaxCredits)
            {
                this.label3.Content = "You cannot register for more than 9 credit hours.";
                return;
            }

            choice.SetToRegistered();
            totalCredits += 3;
            this.textBox.Text = totalCredits.ToString();
            this.label3.Content = $"Successfully registered for {choice.getName()}.";

            UpdateRegisteredCoursesList();

            // Optionally update the ComboBox to reflect registration status
            this.comboBox.Items.Remove(choice);
        }

        private void UpdateRegisteredCoursesList()
        {
            this.listBox.Items.Clear();
            foreach (var course in courses)
            {
                if (course.IsRegisteredAlready())
                {
                    this.listBox.Items.Add(course.getName());
                }
            }
        }
    }
}
