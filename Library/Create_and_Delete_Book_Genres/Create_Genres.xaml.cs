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

namespace Library.Create_and_Delete_Book_Genres
{
    /// <summary>
    /// Логика взаимодействия для Create_and_Update_Books.xaml
    /// </summary>
    public partial class Create_Genres : Window
    {
        private readonly LibraryEntities _libdb;
        public Create_Genres()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDGV();
        }
        private void FillDGV()
        {
            dgv_Book_Genres.ItemsSource = _libdb.Book_Genres.Where(bg => bg.Is_Deleted == false).Select(bg => new Dgv_Book_Genres
            {
                Genre_Name = bg.Genre_Name,
            }).ToList();
        }

        

        private async void btn_Created(object sender, RoutedEventArgs e)
        {
            string genre = txt_Create_Genre.Text.Trim();
            if (genre == "")
            {
                MessageBox.Show("Запоните это поле!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (_libdb.Book_Genres.Any(bg => bg.Genre_Name == genre))
            {
                MessageBox.Show("Такое тип уже имеется!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Book_Genres book_Genre = new Book_Genres
            {
                Genre_Name = genre
            };

            _libdb.Book_Genres.Add(book_Genre);
            await _libdb.SaveChangesAsync();

            MessageBox.Show("Данный тип успешно добавлен!!!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            txt_Create_Genre.Text = "";
        }

    }
}
