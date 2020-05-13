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
    /// Логика взаимодействия для Registration_List.xaml
    /// </summary>
    public partial class Registration_List : Window
    {
        private readonly LibraryEntities _libdb;
        public Registration_List()
        {
            InitializeComponent();
            _libdb = new LibraryEntities();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_Name_Registration.Text.Trim();
            string surname = txt_Surname_Registration.Text.Trim();
            string patronymic = txt_Patronymic_Registration.Text.Trim();
            string email = txt_Email_Registration.Text.Trim();
            string password = txt_Password_Registration.Password.Trim();
            string confirm_password = txt_Confirm_Password_Registration.Password.Trim();

            bool Email_is_Db = _libdb.Sellers.Any(s => s.Seller_Email == email);
            if (Email_is_Db)
            {
                MessageBox.Show("Этот эмэил пользуется другим пользователем!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Sellers seller = new Sellers();
            seller.Seller_Name = name;
            seller.Seller_Surname = surname;
            seller.Seller_Patronymic = patronymic;
            seller.Seller_Email = email;
            seller.Seller_Password = password.HashPassword();

            _libdb.Sellers.Add(seller);
            await _libdb.SaveChangesAsync();

            if(Is_Valid(name, surname, patronymic, email, password, confirm_password))
            {
                MessageBox.Show("Ваша решистрация прошла успешно!!!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                return;
            }

        }
        private bool Is_Valid(string name, string surname, string patronymic, string email,  string password, string confirm_password)
        {
            if (name ==""|| surname=="" || patronymic=="" || email=="" ||  password=="" || confirm_password=="")
            {
                MessageBox.Show("Пожалуйста заполните все пустые ячкйки !!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            if (!email.Is_Email())
            {
                MessageBox.Show("Данный эмеилa не является эмэил адресом!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (password == confirm_password)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пожалуйста внесите одинаковые пароли !!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
        }
    }
}
