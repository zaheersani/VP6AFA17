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
            EmpTask task = new EmpTask()
            {
                Code = 444,
                Description = "Upload VS Project to GitHub"
            };

            dc.EmpTasks.InsertOnSubmit(task);
            dc.SubmitChanges();

        }

        private void btnShowData_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDataClassesDataContext dc = new EmployeeDataClassesDataContext();

            var tasks = dc.EmpTasks.Where(x => x.Id > 0);

            this.tasksGrid.ItemsSource = tasks.ToList();
            //this.tasksGrid.set

            var r = dc.Employees.Where(x => x.Id > 0)
                                .OrderBy(x => x.Salary);

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
    }
}
