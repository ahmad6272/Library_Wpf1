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
using Library.Create_and_Delete_Books;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для Menu_List.xaml
    /// </summary>
    public partial class Menu_List : Window
    {
        private readonly LibraryEntities _libdb;
        public Menu_List()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }

        private void Open_Books_Menu(object sender, RoutedEventArgs e)
        {
            Books_Menu books = new Books_Menu(this);
            books.Show();
        }

        private void Open_Create_and_Update_Books(object sender, RoutedEventArgs e)
        {
            Create_and_Update_Books create = new Create_and_Update_Books();
            create.Show();
        }

        private void Open_Delete_Books(object sender, RoutedEventArgs e)
        {
            Delete_Books delete = new Delete_Books();
            delete.Show();
        }
    }
}
