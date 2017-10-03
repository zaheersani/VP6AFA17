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

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for MenuGUI.xaml
    /// </summary>
    public partial class MenuGUI : Window
    {
        public MenuGUI()
        {
            InitializeComponent();
        }

        private void btn_students_Click(object sender, RoutedEventArgs e)
        {
            StudentsGUI sgui = new StudentsGUI();
            sgui.Show();
        }
    }
}
