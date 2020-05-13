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
    /// Логика взаимодействия для Admin_Panel.xaml
    /// </summary>
    public partial class Admin_Panel : Window
    {
        private readonly LibraryEntities _libdb;

        private enum Case { Activated = 0, Admin = 1, Deleted = 2 }
        public Admin_Panel(Login_List login_List)
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }

        public Admin_Panel()
        {
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
             FillDataGrid();
             cb_Case.ItemsSource = Enum.GetValues(typeof(Case));
        }
        private void FillDataGrid()
        {
            dgv_Sellers.ItemsSource = _libdb.Sellers.Select(s => new
            {
                Name = s.Seller_Name,
                Email = s.Seller_Email,
                Admin = s.Is_Admin,
                Active = s.Is_Activated,
                Delete = s.Is_Deleted,
            }).ToList();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Sellers seller = _libdb.Sellers.First(s => s.Seller_Name == txt_User_Name.Text.Trim());
            int Selected_Case = cb_Case.SelectedIndex;

            switch (Selected_Case)
            {
                case (int)Case.Activated:
                    seller.Is_Activated = true;
                    seller.Is_Admin = false;
                    seller.Is_Deleted = false;
                    break;
                case (int)Case.Admin:
                    seller.Is_Activated = true;
                    seller.Is_Admin = true;
                    seller.Is_Deleted = false;
                    break;
                case (int)Case.Deleted:
                    seller.Is_Activated = false;
                    seller.Is_Admin = false;
                    seller.Is_Deleted = true;
                    break;
                default:
                    break;
            }
            await _libdb.SaveChangesAsync();
            txt_User_Name.Text = " ";
        }

        private void dgv_Sellers_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Sellers seller = (Sellers)dgv_Sellers.SelectedItem;
            txt_User_Name.Text = seller.Seller_Name;
        }

        private void Open_Books_Menu(object sender, RoutedEventArgs e)
        {
            Books_Menu books = new Books_Menu(this);
            books.Show();;
        }
    }
}
