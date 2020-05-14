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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для Books_Menu.xaml
    /// </summary>
    public partial class Books_Menu : Window
    {
        private readonly LibraryEntities _libdb;
        private readonly Window _main;
        public Books_Menu(Window main)
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
            _main = _main;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cb_Book_Genres.ItemsSource = _libdb.Book_Genres.Where(bg => bg.Is_Deleted == false).Select(bg => new Cb_Genres
            {
                Genre_Name = bg.Genre_Name,
            }).ToArray();

            FillCb();
        }

        private void FillCb()
        {
            cb_Book_Genres.ItemsSource = _libdb.Book_Genres.ToArray();
        }

        private async void btn_Add_Book_Click(object sender, RoutedEventArgs e)
        {
            string Author_Name = txt_Author_Name.Text.Trim();
            string Author_Surname = txt_Author_Surname.Text.Trim();
            string Author_Patronymic = txt_Author_Patronymic.Text.Trim();
            string Book_Name = txt_Book_Name.Text.Trim();

            Authors author = new Authors();
            author.Author_Name = Author_Name;
            author.Author_Surname = Author_Surname;
            author.Author_Patronymic = Author_Patronymic;

            Books book = new Books();
            book.Book_Name = Book_Name;


            _libdb.Authors.Add(author);
            await _libdb.SaveChangesAsync();
        }
    }
}
