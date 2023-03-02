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

namespace Airline
{
    public partial class AddUser : Window
    {

        DataSet1 dataSet = new DataSet1();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        public AddUser()
        {
            InitializeComponent();
            usersTableAdapter.Fill(dataSet.Users);
            officesTableAdapter.Fill(dataSet.Offices);

            cbOffice.ItemsSource = dataSet.Offices.DefaultView;
            cbOffice.DisplayMemberPath = "Title";
            cbOffice.SelectedValuePath = "ID";
            cbOffice.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Password.ToString()) ||
                string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtBirthDate.Text) ||
                string.IsNullOrEmpty(txtLastName.Text))
                MessageBox.Show("Заполните все поля!");
            else
            {
                DateTime dateTime = Convert.ToDateTime(txtBirthDate.Text);
                usersTableAdapter.Insert(2, txtEmail.Text, txtPassword.Password.ToString(), txtFirstName.Text, txtLastName.Text, int.Parse(cbOffice.SelectedValue.ToString()), dateTime, true);
                Hide();
            }
        }
        private void btnCance_Click(object sender, RoutedEventArgs e)
        {
            //AdminMenu window = new AdminMenu();
            //window.Show();
            Hide();
        }
    }
}
