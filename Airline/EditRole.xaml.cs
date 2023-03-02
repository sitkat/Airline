using Airline.DataSet1TableAdapters;
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
using static Airline.Helper;

namespace Airline
{
    public partial class EditRole : Window
    {
        DataSet1 dataSet = new DataSet1();
        RolesTableAdapter rolesTableAdapter = new RolesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();

        int role_id = 0;
        public EditRole()
        {
            InitializeComponent();

            usersTableAdapter.Fill(dataSet.Users);
            officesTableAdapter.Fill(dataSet.Offices);

            txtEmail.Text = SaveThings.email;
            txtFirstName.Text = SaveThings.firstName;
            txtLastName.Text = SaveThings.lastName;
            cbOffice.Items.Add(SaveThings.office);
            cbOffice.SelectedIndex = 0;

            if (SaveThings.role == "User")
            {
                rbUser.IsChecked = true;
                role_id = 2;
            }
            else
            {
                rbAdmin.IsChecked = true;
                role_id = 1;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu window = new AdminMenu();
            window.Show();
            Hide();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (rbUser.IsChecked == true)
            {
                role_id = 2;
            }
            if (rbAdmin.IsChecked == true)
            {
                role_id = 1;
            }
            usersTableAdapter.UpdateRole(role_id, int.Parse(SaveThings.id.ToString()));
            
            AdminMenu window = new AdminMenu();
            window.Show();
            Hide();
        }
    }
}
