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

namespace WpfSamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students = new List<Student>
        {
            new Student("Ken", "Field", 26, 'M'),
            new Student("Bart", "Roels", 38, 'M'),
            new Student("Jennifer", "Lawrence", 35, 'F')
        };

        public MainWindow()
        {
            InitializeComponent();
            lvLijst.ItemsSource = Students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MessageBox.Show("De muis is er uit!");
        }

        private void lvLijst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Je hebt een nieuwe aangeklikt");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbTextBox.Background = Brushes.Yellow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyNewWindow myNewWindow = new MyNewWindow(tbTextBox.Text);
            myNewWindow.Show();
        }
    }

    public class Student
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        public int Age { get; set; }
        private char _gender { get; set; }

        public Student(string firstName, string lastName, int age, char gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
            _gender = gender;
        }

        public string FullName { get { return _firstName + " " + _lastName; } }
    }
}
