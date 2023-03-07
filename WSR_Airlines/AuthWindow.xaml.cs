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
using System.Windows.Navigation;
using System.Windows.Shapes;
//using WSR_Airlines.MainSetTableAdapters;
using System.Data.SqlClient;
using System.Data;
using WSR_Airlines.MainSetTableAdapters;
using WSR_Airlines.Models;
using System.Windows.Threading;

namespace WSR_Airlines
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        MainSet dataSet;
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        private bool isLoggedIn = false;
        private Int16 _attempt = 0;


        int currentTimerSec = 0; 

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        

        public AuthWindow()
        {
            InitializeComponent();
            dataSet = new MainSet();
            usersTableAdapter.Fill(dataSet.Users);
        }

        private void backBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if(currentTimerSec == 10)
            {
                dispatcherTimer.Stop();
                currentTimerSec = 0;
                loginBTN.Visibility = Visibility.Visible;
            }

            else 
                currentTimerSec++;

            timerTB.Text = currentTimerSec.ToString();
            
        }

        private void enterBTN_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < dataSet.Users.Rows.Count; i++)
            {
                if(usernameTB.Text == dataSet.Users.Rows[i]["Email"].ToString() &&
                    passwordTB.Text == dataSet.Users.Rows[i]["Password"].ToString())
                {
                    User user = new User(_userId: Convert.ToInt32(dataSet.Users.Rows[i]["Id"]), _email: usernameTB.Text, _password: passwordTB.Text,
                        _firstname: dataSet.Users.Rows[i]["Firstname"].ToString(), _secondname: dataSet.Users.Rows[i]["Secondname"].ToString(),
                        _birthdate: dataSet.Users.Rows[i]["Birthdate"].ToString(), _active: dataSet.Users.Rows[i]["Active"].ToString(),
                        _roleId: Convert.ToInt32(dataSet.Users.Rows[i]["Role"]), _officeId: Convert.ToInt32(dataSet.Users.Rows[i]["Office"]));

                    isLoggedIn = true;
              
                }
            }

            if (isLoggedIn)
            {
                MessageBox.Show("Данные введены верно");
                new AdminMenuWindow().Show();

                Close();
            }
            else
            {
                _attempt++;
                if (_attempt == 3)
                {
                    _attempt = 0;
                    loginBTN.Visibility = Visibility.Hidden;

                    dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                    dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                    dispatcherTimer.Start();
                }
                MessageBox.Show("Данные введены неправильно");
                
            }
            
        }
    }
}
