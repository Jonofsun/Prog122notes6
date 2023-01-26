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

namespace Prog122notes6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        // What is a Method? A block of code that is given a name, and runs when its called
        // what is its purpose? Ease of reuse
        Course csi122;
        public MainWindow()
        {
            InitializeComponent();
            csi122 = new Course("CSI 122", "Jonathan Reed");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double gradeCSI = double.Parse(txtCSI.Text);
            double gradeGenEd = double.Parse(txtGenEd.Text);

            //Student student = new Student(firstName, lastName, gradeCSI, gradeGenEd);
            // Add student to my list of students
            students.Add(new Student(firstName, lastName, gradeCSI, gradeGenEd));
            //Dot. operator to access
            // How do you display student FROM my list
            //rtbRunDisplay.Text = students[0].FirstName;

            
            //int lastStudentEntered = students.Count - 1;

            csi122.Enroll(students[students.Count - 1]);
            rtbRunDisplay.Text = "";
            rtbRunDisplay.Text = csi122.CourseName + " " + csi122.Teacher;
            foreach(Student student in csi122.CourseRoster)
            {
                rtbRunDisplay.Text += student + "\n";
            }
            //DisplayStudents();

        }
        public void DisplayStudents()
        {
            rtbRunDisplay.Text = ""; // clears display

            for (int i = 0; i < students.Count; i++)
            {
                rtbRunDisplay.Text += students[i] + "\n";
            } // shows all students
        }
    }
}
