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
using System.Windows.Shapes;

using ConsoleApplication6A;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            ((TextBox)this.listbox.Items[0]).Text = "Box";

            this.listboxS.Items.Add(new Student()
            {
                FirstName = "Zanab",
                LastName = "Iqbal",
                RegNo = new RegNo(Batch.FA,2010,ProgramCIIT.BCS,123)
            });

            this.listboxS.Items.Add(new Student()
            {
                FirstName = "Something",
                LastName = "New",
                RegNo = new RegNo(Batch.FA, 2010, ProgramCIIT.BCS, 123)
            });
        }


        public Window2(List<Student> sList)
        {
            InitializeComponent();
            foreach (var item in sList)
            {
                Console.WriteLine(item.RegNo);
            }
        }

        private void listboxS_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(((Student)this.listboxS.SelectedItem).ToString());
        }
    }
}
