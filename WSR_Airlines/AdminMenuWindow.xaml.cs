using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();

        UsersOfficeTableAdapter usersOfficeTableAdapter = new UsersOfficeTableAdapter();
        public AdminMenuWindow()
        {
            InitializeComponent();
            usersTableAdapter.Fill(mainSet.Users);
            officesTableAdapter.Fill(mainSet.Offices);

            usersOfficeTableAdapter.Fill(mainSet.UsersOffice);

            var today = DateTime.Today;

            for (int i = 0; i < mainSet.UsersOffice.DefaultView.Table.Rows.Count; i++)

            {
                string birthdate = mainSet.UsersOffice.Rows[i]["Birthdate"].ToString();
                mainSet.UsersOffice.Rows[i]["Birthdate"] = today.Year - Convert.ToDateTime(birthdate, CultureInfo.InvariantCulture).Year;
            }

            UserDataGrid.ItemsSource = mainSet.UsersOffice.DefaultView;
            UserDataGrid.SelectedValuePath = "Id";
            UserDataGrid.CanUserAddRows = false;
            UserDataGrid.CanUserDeleteRows = false;
            UserDataGrid.SelectionMode = DataGridSelectionMode.Single;

            mainSet.Offices.Rows.Add("0", "0", "All", "0", "0");

            officeCB.ItemsSource = mainSet.Offices.DefaultView;
            officeCB.DisplayMemberPath = "Title";
            officeCB.SelectedValuePath = "ID";

            officeCB.SelectedIndex = mainSet.Offices.Rows.Count - 1;
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



        }

        private void MenuItemAddUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void officeCB_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void officeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (officeCB.SelectedValue.ToString() == "0")
            {
                UserDataGrid.ItemsSource = mainSet.UsersOffice.DefaultView;
                UserDataGrid.SelectedValuePath = "Id";
            }
            else
            {
                DataTable filteredDt = new DataTable();

                for (int i = 0; i < mainSet.UsersOffice.Columns.Count; i++)
                {
                    filteredDt.Columns.Add(mainSet.UsersOffice.Columns[i].ColumnName);
                }
                
                int persistanceRowsCount = mainSet.UsersOffice.Rows.Count;

                for (int i = 0; i < persistanceRowsCount; i++)

                {
                    string officeId = mainSet.UsersOffice.Rows[i]["ID_Office"].ToString();
                    if (officeId == officeCB.SelectedValue.ToString())
                    {
                        filteredDt.Rows.Add(mainSet.UsersOffice.Rows[i].ItemArray);
                    }
                }


                UserDataGrid.ItemsSource = filteredDt.DefaultView;
                UserDataGrid.SelectedValuePath = "Id";
            }
        }

        private void changeRoleBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void changeLoginBTN_Click(object sender, RoutedEventArgs e)
        {
           
            int updatedActive = Convert.ToInt32(mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Active"]) == 1 ? 0 : 1; 
            usersTableAdapter.UpdateQuery(Convert.ToInt32(mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Role"]),
                Convert.ToInt32(mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Office"]), mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Email"].ToString(), mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Password"].ToString(),
                mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Firstname"].ToString(), 
                mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Secondname"].ToString(),
                mainSet.Users.Rows[UserDataGrid.SelectedIndex]["Birthdate"].ToString(), 
                updatedActive.ToString(), Convert.ToInt32(mainSet.UsersOffice.Rows[UserDataGrid.SelectedIndex]["Id"]));

            usersOfficeTableAdapter.Fill(mainSet.UsersOffice);

            UserDataGrid.ItemsSource = mainSet.UsersOffice.DefaultView;
            UserDataGrid.SelectedValuePath = "Id";

        }
    }
}
