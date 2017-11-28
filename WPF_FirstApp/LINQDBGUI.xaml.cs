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

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for LINQDBGUI.xaml
    /// </summary>
    public partial class LINQDBGUI : Window
    {
        public LINQDBGUI()
        {
            InitializeComponent();

            EmployeeDataClassesDataContext dc = new EmployeeDataClassesDataContext();
            
            Task task = new Task()
            {
                Code = 444,
                Description = "Upload VS Project to GitHub"
            };

            dc.Tasks.InsertOnSubmit(task);
            dc.SubmitChanges();

        }

        private void btnShowData_Click(object sender, RoutedEventArgs e)
        {
            //EmployeeDataClassesDataContext dc = new EmployeeDataClassesDataContext();

            //var tasks = dc.EmpTasks.Where(x => x.Id > 0);

            //this.tasksGrid.ItemsSource = tasks.ToList();
            ////this.tasksGrid.set

            //var r = dc.Employees.Where(x => x.Id > 0)
            //                    .OrderBy(x => x.Salary);

            //var r = from emp in dc.Employees
            //        where emp.Salary > 200000
            //        select new
            //        {
            //            EmployeeName = emp.Name,
            //            emp.Designation
            //        };
            //foreach (var item in tasks)
            //{
            //    MessageBox.Show(item.Code + "\n" + item.Description);
            //}
            //foreach (var item in r)
            //{
            //    MessageBox.Show(item.Name + "\n" + item.Designation);
            //}
        }

        SamosaPartyDataContext dc = new SamosaPartyDataContext();
        private void btnShowSamosaDefaulters_Click(object sender, RoutedEventArgs e)
        {
            //SamosaPartyDataContext dc = new SamosaPartyDataContext();
            //this.samosaGrid.ItemsSource = dc.Defaulters.Where(d => d.Paid == false).ToList();
            var result = from d in dc.StudentPenalties
                         select d;

            this.samosaGrid.ItemsSource = result.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (this.samosaGrid.SelectedItem is Penalty)
            {
                Penalty d = (Penalty)this.samosaGrid.SelectedItem;
                //d.RegNo = "SP15";
                dc.SubmitChanges();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (this.samosaGrid.SelectedItem is Penalty)
            {
                Penalty d = (Penalty)this.samosaGrid.SelectedItem;
                dc.Penalties.DeleteOnSubmit(d);
                if(MessageBoxResult.Yes == MessageBox.Show("Do you wish to delete "+d.ToString(),"Delete?",MessageBoxButton.YesNo,MessageBoxImage.Question,MessageBoxResult.No,MessageBoxOptions.None))
                    dc.SubmitChanges();
            }
        }

        private void samosaGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.btnEdit.IsEnabled = true;
            this.btnDelete.IsEnabled = true;
        }
    }
}
