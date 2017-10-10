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

            Box b1 = new Box()
            {
                Length = 5,
                Breadth = 5,
                Height = 5
            };
            Box b2 = new Box()
            {
                Length = 5,
                Breadth = 5,
                Height = 5
            };

            Box result = b1 + b2;
            string output = "Vol B1: " + b1.getVolume() +
                "\nVol B2: " + b2.getVolume() +
                "\nVol B3: " + result.getVolume();

            MessageBox.Show(output);


            //RegNo rObj1 = new RegNo(Batch.SP, 2015, ProgramCIIT.BCS, 34);
            //RegNo rObj2 = new RegNo(Batch.FA, 2015, ProgramCIIT.BCS, 34);
            //if (rObj1 != rObj2)
            //    MessageBox.Show("Reg1 and Reg2 are NOT equal");
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            RegNo rObj = new RegNo(Batch.SP, 2015, ProgramCIIT.BCS, 34);
            if (rObj.Program == ProgramCIIT.BCS)
                MessageBox.Show("Welcome to BCS-6A", "Welcome", MessageBoxButton.YesNoCancel, MessageBoxImage.Information, MessageBoxResult.Yes, MessageBoxOptions.DefaultDesktopOnly);
            else
                MessageBox.Show("Why are you here?");
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
