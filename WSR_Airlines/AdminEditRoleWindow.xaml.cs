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
using WSR_Airlines.MainSetTableAdapters;
using WSR_Airlines.Models;

namespace WSR_Airlines
{
    /// <summary>
    /// Логика взаимодействия для AdminEditRoleWindow.xaml
    /// </summary>
    public partial class AdminEditRoleWindow : Window
    {
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        MainSet mainSet;

        int? currentRole;
        User currentUser; 
        public AdminEditRoleWindow(User user)
        {
            InitializeComponent();
            mainSet = new MainSet();
            officesTableAdapter.Fill(mainSet.Offices);
            usersTableAdapter.Fill(mainSet.Users);
            emailTB.Text = user.Email;
            firstnameTB.Text = user.Firstname;
            lastnameTB.Text = user.Secondname;
            firstnameTB.Text = user.Firstname;

            currentUser = user; 

            officeCB.ItemsSource = mainSet.Offices.DefaultView;
            officeCB.SelectedValuePath = "ID";
            officeCB.DisplayMemberPath = "Title";
            officeCB.SelectedValue = user.OfficeId;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            currentRole = (bool)User.IsChecked ? 2 : 1;
           // MessageBox.Show($"Role: {currentRole}");
        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentRole == null)
                    throw new Exception("Выберите роль!");

                usersTableAdapter.UpdateQuery((int)currentRole, currentUser.OfficeId, currentUser.Email, currentUser.Password, currentUser.Firstname,
                    currentUser.Secondname, currentUser.Birthdate, currentUser.Active, currentUser.UserId);

                MessageBox.Show("Роль успешно обновлена", "Внимание!", MessageBoxButton.OK);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Внимание!", MessageBoxButton.OK);
            }
        }

        private void cancelBTN_Click(object sender, RoutedEventArgs e)
        {
            new AdminMenuWindow().Show();
            Close();
        }
    }
}
