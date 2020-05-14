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
    /// Логика взаимодействия для Delete_Books.xaml
    /// </summary>
    public partial class Delete_Genres : Window
    {
        private readonly LibraryEntities _libdb;
        public Delete_Genres()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillCb();

            cb_Delete.ItemsSource = _libdb.Book_Genres.Where(bg => bg.Is_Deleted == false).Select(bg => new Cb_Genres
            {
                ID = bg.ID,
                Genre_Name = bg.Genre_Name,
            }).ToArray();
        }
        private void FillCb()
        {
            cb_Delete.ItemsSource = _libdb.Book_Genres.ToArray();
        }

        private async void btn_Delete_Click(object sender, RoutedEventArgs e)
        {


            int id = ((Cb_Genres)cb_Delete.SelectedItem).ID;

            Book_Genres genre = _libdb.Book_Genres.Find(id);
            genre.Is_Deleted = true;
            await _libdb.SaveChangesAsync();

            MessageBox.Show("Данный тип успешно удален!!!", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            cb_Delete.Text = "";
        }
    }
}
