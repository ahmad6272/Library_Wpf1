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
using Library.Extention;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для Login_List.xaml
    /// </summary>
    public partial class Login_List : Window
    {
        private readonly LibraryEntities _libdb;
        public Login_List()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration_List registration = new Registration_List();
            registration.ShowDialog();
        }

        private void btn_Login_LoginList_Click(object sender, RoutedEventArgs e)
        {
            string User_Name = txt_Login_UserName.Text.Trim();
            string password = txt_Login_Password.Password.Trim();

            if (User_Name == "" || password == "")
            {
                MessageBox.Show("Пожалуйста заполните эти поля !!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Sellers seller = _libdb.Sellers.FirstOrDefault(s => s.Seller_Email == User_Name);

            if (!Is_Valid(seller, password))
            {
                return;
            }

            if (seller.Is_Admin)
            {
                Admin_Panel admin = new Admin_Panel(this);
                admin.Show();
                return;
            }
            if (seller.Is_Activated)
            {
                Menu_List menu = new Menu_List();
                menu.Show();
                return;
            }
                       
        }

        private bool Is_Valid(Sellers seller, string password)
        {
            if (seller == null)
            {
                MessageBox.Show("This email is not exists!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (seller.Is_Deleted)
            {
                MessageBox.Show("You don`t have account!!!", "Warning",  MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!seller.Is_Activated)
            {
                MessageBox.Show("Please vait!!!", "Warning",  MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (seller.Seller_Password==password.HashPassword())
            {
                MessageBox.Show("This password is incorrect!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }


            return true;
        }
    }
}
