using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Threading;
using WSR_Airlines.Domain;
using WSR_Airlines.MainSetTableAdapters;
using WSR_Airlines.Models;

namespace WSR_Airlines
{
    /// <summary>
    /// Логика взаимодействия для UserMenuWindow.xaml
    /// </summary>


    public partial class UserMenuWindow : Window
    {
        MainSet mainSet;
        UserActivityTableAdapter userActivityTableAdapter = new UserActivityTableAdapter();

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        TimeSpan loginTime;
        User currentUser;

        
        
        public UserMenuWindow(User user)
        {
            InitializeComponent();
            mainSet = new MainSet();
            userActivityTableAdapter.Fill(mainSet.UserActivity);

            var select = $"select * from UserActivity where Session_OwnerId = {user.UserId}";
            var c = new SqlConnection(Helper.connectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataTable();
            dataAdapter.Fill(ds);

            ActivityDataGrid.ItemsSource = ds.DefaultView;

            ActivityDataGrid.SelectedValuePath = "ID";
            ActivityDataGrid.CanUserAddRows = false;
            ActivityDataGrid.CanUserDeleteRows = false;
            ActivityDataGrid.SelectionMode = DataGridSelectionMode.Single;

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            currentUser = user;

            loginTime = new TimeSpan(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            String[] partsString = timeSpentLB.Content.ToString().Split(':');
            int[] partsInt = new int[3];

            partsInt[0] = Convert.ToInt32(partsString[0]);
            partsInt[1] = Convert.ToInt32(partsString[1]);
            partsInt[2] = Convert.ToInt32(partsString[2]);

            for (int i=2; i > 0; i--)
            {
                if (Convert.ToInt32(partsInt[i]) >= 60)
                {
                    partsInt[i - 1] += 1;
                    partsInt[i] = 0;
                }

            }

            partsInt[2]++;
            timeSpentLB.Content = $"{partsInt[0]}:{partsInt[1]}:{partsInt[2]}";



        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            userActivityTableAdapter.Insert(DateTime.Now.Date, loginTime, 
                new TimeSpan(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds),
                timeSpentLB.Content.ToString(), "", currentUser.UserId);
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
