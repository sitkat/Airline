using System;
using System.Globalization;
using System.Windows;
using Airline.DataSet1TableAdapters;
using static Airline.Helper;

namespace Airline
{
    public partial class MainWindow : Window
    {
        DataSet1 dataSet = new DataSet1();
        RolesTableAdapter rolesTableAdapter = new RolesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        AcitivityTrackerTableAdapter acitivityTrackerTableAdapter = new AcitivityTrackerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            rolesTableAdapter.Fill(dataSet.Roles);
            usersTableAdapter.Fill(dataSet.Users);
            acitivityTrackerTableAdapter.Fill(dataSet.AcitivityTracker);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool checker = false;
            for (int j = 0; j < dataSet.Tables["Users"].Rows.Count; j++)
            {
                if (txtUsername.Text.Contains(dataSet.Tables["Users"].Rows[j]["Email"].ToString()) && txtPassword.Password.Contains(dataSet.Tables["Users"].Rows[j]["Password"].ToString()) && Convert.ToBoolean(dataSet.Tables["Users"].Rows[j]["Active"].ToString()) == true)
                {
                    int ID_Role = int.Parse(dataSet.Tables["Users"].Rows[j]["RoleID"].ToString());
                    switch (ID_Role)
                    {
                        case 1:
                            {
                                AdminMenu window = new AdminMenu();
                                window.Show();
                                Hide();
                                break;
                            }
                        case 2:
                            {
                                SaveThings.id = int.Parse(dataSet.Tables["Users"].Rows[j]["ID"].ToString());
                                SaveThings.firstName = dataSet.Tables["Users"].Rows[j]["FirstName"].ToString();
                                int trackerID = 0;

                                for (int k = 0; k < dataSet.Tables["AcitivityTracker"].Rows.Count; k++)
                                {
                                    if (SaveThings.id == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[k]["UserID"].ToString()))
                                    {
                                        trackerID = int.Parse(dataSet.Tables["AcitivityTracker"].Rows[k]["ID"].ToString());
                                    }
                                }

                                for (int i = 0; i < dataSet.Tables["AcitivityTracker"].Rows.Count; i++)
                                {
                                    if (trackerID == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[i]["ID"].ToString()) 
                                        && string.IsNullOrEmpty(dataSet.Tables["AcitivityTracker"].Rows[i]["LogoutTime"].ToString())
                                        && string.IsNullOrEmpty(dataSet.Tables["AcitivityTracker"].Rows[i]["Reason"].ToString()))
                                    {
                                        SaveThings.idTracker = trackerID;
                                        checker = true;
                                        LogoutDetected logoutDetected = new LogoutDetected();
                                        logoutDetected.Show();
                                        Hide();
                                    }
                                    else
                                    {
                                        checker = false;
                                    }
                                }

                                if (checker == false)
                                {
                                    acitivityTrackerTableAdapter.Insert(DateTime.Now, TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")), null, "", int.Parse(dataSet.Tables["Users"].Rows[j]["ID"].ToString()));
                                    UserMenu window = new UserMenu();
                                    window.Show();
                                    Hide();
                                }
                                break;

                            }

                    }

                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}