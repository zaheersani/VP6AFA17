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
    /// Interaction logic for CommonControls1.xaml
    /// </summary>
    public partial class CommonControls1 : Window
    {
        public CommonControls1()
        {
            InitializeComponent();
            //Student sOBj = new Student() {
            //    FirstName = "Jahanzaib",
            //    LastName = "Ahmad",
            //    RegNo = new RegNo(Batch.FA,2010,ProgramCIIT.BCS,123),
            //    Age = 19
            //};
            //this.comboStudent.Items.Add(sOBj);
            //Student sOBj2 = new Student()
            //{
            //    FirstName = "Ahmad",
            //    LastName = "Raza",
            //    RegNo = new RegNo(Batch.FA, 2013, ProgramCIIT.BSE, 90),
            //    Age = 19
            //};
            //this.comboStudent.Items.Add(sOBj2);
            //this.comboStudent.DisplayMemberPath = "RegNo";
        }

        private void comboStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.comboStudent.SelectedItem is Student)
            {
                Student s = (Student)this.comboStudent.SelectedItem;
                MessageBox.Show(s.ToString());
            }
        }
    }
}
