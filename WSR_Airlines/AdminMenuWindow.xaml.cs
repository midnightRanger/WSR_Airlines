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

namespace WSR_Airlines
{
    /// <summary>
    /// Логика взаимодействия для AdminMenuWindow.xaml
    /// </summary>
    public partial class AdminMenuWindow : Window
    {
        MainSet mainSet = new MainSet();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter(); 
        public AdminMenuWindow()
        {
            InitializeComponent();
            usersTableAdapter.Fill(mainSet.Users);

            UserDataGrid.ItemsSource = mainSet.Users.DefaultView;
            UserDataGrid.SelectedValuePath = "Id";
            UserDataGrid.CanUserAddRows = false;
            UserDataGrid.CanUserDeleteRows = false;
            UserDataGrid.SelectionMode = DataGridSelectionMode.Single;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Data.Columns[0].Visibility = Visibility.Hidden;
            //Data.Columns[5].Visibility = Visibility.Hidden;
            //Data.Columns[6].Visibility = Visibility.Hidden;
            //Data.Columns[7].Visibility = Visibility.Hidden;
            //Data.Columns[8].Visibility = Visibility.Hidden;

            //Data.Columns[1].Header = "Название спортивного клуба";
            //Data.Columns[2].Header = "Доступ";
            //Data.Columns[3].Header = "Эмблема";
            //Data.Columns[4].Header = "Описание";

            for (int i = 0; i < mainSet.Users.Rows.Count; i++)
            {
                if(mainSet.Users.Rows[i]["Active"] == "0")
                {
                   
                }
            }

        }

        private void MenuItemAddUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
