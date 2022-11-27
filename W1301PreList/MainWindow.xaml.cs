using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W1301PreList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem item = (ListViewItem)List.SelectedItem;
            TextBlock t = (TextBlock)((StackPanel)item.Content).Children[1];

            //MessageBox.Show(t.Text);

            //try
            //{
            //    // W1301PreList 대신 프로젝트명 사용할 것
            //    BitmapImage b = new BitmapImage(new Uri($"pack://application:,,,/W1301PreList;component/images/{t.Text}.jpg"));

            //    if (b != null)
            //        Image.Source = b;
            //    else
            //        Image.Source = null;
            //}
            //catch (IOException)
            //{
            //    Image.Source = null;
            //}

            BitmapImage b = new BitmapImage(new Uri($"images/{t.Text}.jpg",
                UriKind.RelativeOrAbsolute));
            Image.Source = b;
        }

        private void OnSelected(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = (TreeViewItem)List.SelectedItem;

            BitmapImage b = new BitmapImage(new Uri($"images/{item.Header}.jpg",
                UriKind.RelativeOrAbsolute));
            Image.Source = b;
        }
    }
}
