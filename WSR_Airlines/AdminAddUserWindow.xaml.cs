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
            officeCB.SelectedValuePath = "Id";

            officeCB.SelectedIndex = 0; 

        }
    }
}
