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
using System.Windows.Shapes;

using ConsoleApplication6A;

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for PhoneBookGUI.xaml
    /// </summary>
    public partial class PhoneBookGUI : Window
    {
        public PhoneBookGUI()
        {
            InitializeComponent();

            PhoneBook2 pb2 = new PhoneBook2();
            pb2.Add("new contact","0333302342");
            this.listPhoneBook.ItemsSource = pb2.toList();

            Student s1 = new Student()
            {
                RegNo = new RegNo(Batch.FA,2010,ProgramCIIT.BCS,123)
            };
            Student s2 = new Student()
            {
                RegNo = new RegNo(Batch.FA, 2011, ProgramCIIT.BCS, 12)
            };

            List<Student> slist = new List<Student>();
            slist.Add(s1);
            slist.Add(s2);
            slist.Add(new Student()
            {
                RegNo = new RegNo(Batch.FA, 2012, ProgramCIIT.BCS, 12)
            });

        }

        PhoneBook pb = new PhoneBook(10);
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            pb.Add(this.txtName.Text, int.Parse(this.txtNumber.Text));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Return all names and numbers when user search
            MessageBox.Show(pb[this.txtName.Text].ToString());
        }
    }
}
