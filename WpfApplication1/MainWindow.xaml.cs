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

using ConsoleApplication6A;

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            RegNo rObj = new RegNo(Batch.SP, 2015, ProgramCIIT.BCS, 34);
            MessageBox.Show(rObj.Program.ToString());
            // Create a student object
            Student sObj = new Student()
            {
                FirstName = this.txtFirstName.Text,
                LastName = this.txtLastName.Text,
                //RegNo = this.txtRegNo.Text,
                Age = byte.Parse(this.comboAge.SelectedItem.ToString())
            };
            MessageBox.Show(sObj.ToString());
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            for (int i = 18; i < 30; i++)
            {
                this.comboAge.Items.Add(i);
            }
        }

    }
}
