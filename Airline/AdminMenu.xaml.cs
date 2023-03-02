using Airline.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class AdminMenu : Window
    {
        DataSet1 dataSet = new DataSet1();
        RolesTableAdapter rolesTableAdapter = new RolesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        UsersViewTableAdapter usersViewTableAdapter = new UsersViewTableAdapter();

        public AdminMenu()
        {
            InitializeComponent();

            rolesTableAdapter.Fill(dataSet.Roles);
            usersTableAdapter.Fill(dataSet.Users);
            officesTableAdapter.Fill(dataSet.Offices);
            usersViewTableAdapter.Fill(dataSet.UsersView);

            cbFilter.Items.Add("All offices");
            cbFilter.Items.Add("Abu dhabi");
            cbFilter.Items.Add("Cairo");
            cbFilter.Items.Add("Bahrain");
            cbFilter.Items.Add("Doha");
            cbFilter.Items.Add("Riyadh");
            cbFilter.SelectedIndex = 0;

            dataGrid.ItemsSource = dataSet.UsersView.DefaultView;
            dataGrid.SelectedValuePath = "ID";
            dataGrid.CanUserAddRows = false;
            dataGrid.CanUserDeleteRows = false;
            dataGrid.SelectionMode = DataGridSelectionMode.Single;

        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUser window = new AddUser();
            window.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Hide();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.Columns[0].Visibility = Visibility.Hidden;
        }

        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillDataGrid();
        }

        private void btnChangeRole_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                try
                {
                    DataRowView selectedRow = (DataRowView)dataGrid.SelectedItem;

                    SaveThings.id = (int)(selectedRow.Row.ItemArray[0]);
                    SaveThings.firstName = selectedRow.Row.ItemArray[1].ToString();
                    SaveThings.lastName = selectedRow.Row.ItemArray[2].ToString();
                    SaveThings.role = selectedRow.Row.ItemArray[4].ToString();
                    SaveThings.email = selectedRow.Row.ItemArray[5].ToString();
                    SaveThings.office = selectedRow.Row.ItemArray[6].ToString();

                    EditRole window = new EditRole();
                    window.Show();
                    Hide();
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }

        }

        private void btnEnableDisable_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                try
                {
                    DataRowView selectedRow = (DataRowView)dataGrid.SelectedItem;
                    int id_user = (int)(selectedRow.Row.ItemArray[0]);
                    if (Convert.ToBoolean(selectedRow.Row.ItemArray[7]) == true)
                    {
                        usersViewTableAdapter.UpdateActive(false, id_user);
                    }
                    else
                    {
                        usersViewTableAdapter.UpdateActive(true, id_user);
                    }
                    usersViewTableAdapter.Fill(dataSet.UsersView);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void FillDataGrid()
        {
            if (cbFilter.SelectedIndex == 0)
            {
                usersViewTableAdapter.Fill(dataSet.UsersView);
            }
            else
            {
                usersViewTableAdapter.FillBy(dataSet.UsersView, cbFilter.SelectedItem.ToString());
            }
        }
    }
}
