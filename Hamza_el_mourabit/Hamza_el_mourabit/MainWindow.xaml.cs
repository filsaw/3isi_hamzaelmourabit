using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Hamza_el_mourabit
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            string name = textBox1.Text;
            string ageStr = textBox2.Text;
            string email = textBox3.Text;
            double height = slider1.Value;
            double width = slider2.Value;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageStr) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if  ( int.Parse(ageStr) < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer for age.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int age = int.Parse(ageStr);


            listBox1.Items.Add("Name :"+name);
            listBox1.Items.Add("Age :"+age);
            listBox1.Items.Add("email :"+email);
            listBox1.Items.Add("height :"+height);
            listBox1.Items.Add("width :"+width);
        }
    }
}
