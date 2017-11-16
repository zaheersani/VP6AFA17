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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for AddressBook2GUI.xaml
    /// </summary>
    public partial class AddressBook2GUI : Window
    {
        public AddressBook2GUI()
        {
            InitializeComponent();
            this.listBox.ItemsSource = this.cList;
        }

        List<Contact> cList = new List<Contact>();

        private void img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            fd.Filter = "JPEG|*.jpeg|PNG|*.png|All Files|*.*";
            if (fd.ShowDialog() == true)
            {
                this.img.Source = new BitmapImage(new Uri(fd.FileName));
                MessageBox.Show(fd.FileName);

            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.listBox.ItemsSource = this.cList;
            Contact c = new Contact()
            {
                Name = this.txtName.Text,
                Photo = this.img.Source
            };
            cList.Add(c);
            //this.listBox.ItemsSource = null;
            //this.listBox.ItemsSource = this.cList;
            this.listBox.Items.Refresh();
            Console.WriteLine(cList[cList.Count - 1].Name);
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.listBox.ItemsSource = this.cList.FindAll(x => x.Name.Contains(this.txtSearch.Text));
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public ImageSource Photo { get; set; }
    }

}

