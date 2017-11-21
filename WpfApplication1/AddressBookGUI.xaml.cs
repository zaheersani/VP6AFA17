using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for AddressBookGUI.xaml
    /// </summary>
    public partial class AddressBookGUI : Window
    {
        public AddressBookGUI()
        {
            InitializeComponent();
            this.listBox.ItemsSource = this.cList;
            this.defaultImg = img.Source;
        }
        
        ImageSource defaultImg;
        List<Contact> cList = new List<Contact>();
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!this.listBox.ItemsSource.Equals(this.cList))
            {
                this.listBox.ItemsSource = this.cList;
            }
            cList.Add(new Contact()
            {
                Name = this.txtName.Text,
                Photo = this.img.Source
            });
            this.listBox.Items.Refresh();
            this.txtName.Text = "";
            this.img.Source = this.defaultImg;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            //fd.Filter = "JPEG|*.jpeg";
            bool? result = fd.ShowDialog();
            if (result == true)
            {
                //this.img.Source = new BitmapImage(new Uri(fd.FileName));
                this.img.Source = new BitmapImage(new Uri(fd.FileName));
            }

        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.listBox.ItemsSource = this.cList.FindAll(x => x.Name.Contains(this.txtSearch.Text));
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtSearch.Text = "";
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public ImageSource Photo { get; set; }
    }

}
