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

using System.Threading.Tasks;
namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for CommonControls2.xaml
    /// </summary>
    public partial class CommonControls2 : Window
    {
        public CommonControls2()
        {
            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var t = Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    this.progbar.Value = i), null
                    );
                    System.Threading.Thread.Sleep(100);
                }
            });
        }
    }
}
