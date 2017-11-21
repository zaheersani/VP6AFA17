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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.grid.ItemsSource = list;
        }

        List<Student> list = new List<Student>();

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Create a student object
            Student sObj = new Student()
            {
                FirstName = this.txtFirstName.Text,
                LastName = this.txtLastName.Text,
                RegNo = new RegNo(Batch.FA,2010,ProgramCIIT.BCS,123), //this.txtRegNo.Text,
                Age = byte.Parse(this.comboAge.SelectedItem.ToString())
            };
            list.Add(sObj);
            //MessageBox.Show(sObj.ToString());
            this.grid.Items.Refresh();
            Window2 w2 = new Window2(list);
            w2.Show();
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