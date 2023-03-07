using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AdminAddUserWindow.xaml
    /// </summary>
    
    public partial class AdminAddUserWindow : Window
    {
        MainSet mainSet = new MainSet();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        public AdminAddUserWindow()
        {
            InitializeComponent();
            usersTableAdapter.Fill(mainSet.Users);
            officesTableAdapter.Fill(mainSet.Offices);

            officeCB.ItemsSource = mainSet.Offices.DefaultView;
            officeCB.DisplayMemberPath = "Title";
            officeCB.SelectedValuePath = "ID";

            officeCB.SelectedIndex = 0;

        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(firstnameTB.Text) || String.IsNullOrWhiteSpace(lastnameTB.Text) || String.IsNullOrWhiteSpace(passwordTB.Text) ||
                    String.IsNullOrWhiteSpace(emailTB.Text))
                    throw new Exception("Заполните все обязательные поля!");
                if (officeCB.SelectedValue == null)
                    throw new Exception("Выберите офис!");
                if (birhtdateDT.SelectedDate == null)
                    throw new Exception("Выберите дату рождения!");

                string date = DateTime.ParseExact(birhtdateDT.SelectedDate.Value.Date.ToShortDateString(), "dd.MM.yyyy", 
                    CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

                usersTableAdapter.Insert(2, Convert.ToInt32(officeCB.SelectedValue), emailTB.Text, passwordTB.Text, firstnameTB.Text, lastnameTB.Text, date, "1");

                MessageBox.Show($"Пользователь {firstnameTB.Text} успешно добавлен", "Внимание!", MessageBoxButton.OK);

                firstnameTB.Text = "";
                lastnameTB.Text = "";
                emailTB.Text = "";
                passwordTB.Text = "";
                birhtdateDT.SelectedDate = null;
                
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Внимание!", MessageBoxButton.OK);
            }
        }
    }
}
