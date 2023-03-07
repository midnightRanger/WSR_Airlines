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
        MainSet mainSet; 
        public AdminEditRoleWindow(User user)
        {
            InitializeComponent();
            mainSet = new MainSet();
            officesTableAdapter.Fill(mainSet.Offices);
            emailTB.Text = user.Email;
            firstnameTB.Text = user.Firstname;
            lastnameTB.Text = user.Secondname;
            firstnameTB.Text = user.Firstname;

            officeCB.ItemsSource = mainSet.Offices.DefaultView;
            officeCB.SelectedValuePath = "ID";
            officeCB.DisplayMemberPath = "Title";
            officeCB.SelectedValue = user.OfficeId;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
