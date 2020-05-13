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

namespace Library.Create_and_Delete_Books
{
    /// <summary>
    /// Логика взаимодействия для Delete_Books.xaml
    /// </summary>
    public partial class Delete_Books : Window
    {
        private readonly LibraryEntities _libdb;
        public Delete_Books()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillCb();
        }
        private void FillCb()
        {
            cb_Delete.ItemsSource = _libdb.Book_Genres.ToArray();
        }

        private void cb_Delete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int ID = (int)cb_Delete.SelectedValue;
            Book_Genres genres = (Book_Genres)cb_Delete.SelectedItem;
            MessageBox.Show(genres.Genre_Name);
        }
    }
}
