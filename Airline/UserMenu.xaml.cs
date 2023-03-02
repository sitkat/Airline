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
    public partial class UserMenu : Window
    {
        DataSet1 dataSet = new DataSet1();
        AcitivityTrackerTableAdapter acitivityTrackerTableAdapter = new AcitivityTrackerTableAdapter();
        ActivityTracerViewTableAdapter activityTracerViewTable = new ActivityTracerViewTableAdapter();
        public UserMenu()
        {
            InitializeComponent();
            acitivityTrackerTableAdapter.Fill(dataSet.AcitivityTracker);
            activityTracerViewTable.Fill(dataSet.ActivityTracerView, SaveThings.id);

            dataGrid.ItemsSource = dataSet.ActivityTracerView.DefaultView;
            dataGrid.CanUserAddRows = false;
            dataGrid.CanUserDeleteRows = false;
            dataGrid.SelectionMode = DataGridSelectionMode.Single;

            txtName.Text = "Hi " + SaveThings.firstName + "" + ", Welcome to AMONIC Airlines.";

            int counter = 0;

            TimeSpan timeOnline = TimeSpan.Zero;
            for (int j = 0; j < dataSet.Tables["AcitivityTracker"].Rows.Count; j++)
            {

                if (SaveThings.id == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[j]["UserID"].ToString()))
                {
                    try
                    {
                        TimeSpan endTime = (TimeSpan)dataSet.Tables["AcitivityTracker"].Rows[j]["LogoutTime"];
                        TimeSpan startTime = (TimeSpan)dataSet.Tables["AcitivityTracker"].Rows[j]["LoginTime"];

                        if (startTime != TimeSpan.Zero && endTime != TimeSpan.Zero)
                        {
                            TimeSpan TimeDifference = endTime - startTime;
                            timeOnline = timeOnline + TimeDifference;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex); }

                }
                if (SaveThings.id == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[j]["UserID"].ToString())
                                       && !string.IsNullOrEmpty(dataSet.Tables["AcitivityTracker"].Rows[j]["Reason"].ToString()))
                    counter = counter + 1;
            }
            if (timeOnline != TimeSpan.Zero)
                txtTime.Text = "Time spent on system:" + " " + timeOnline.ToString();
            txtCrashes.Text = "Number of craches: " + counter.ToString();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            int trackerID = 0;
            for (int j = 0; j < dataSet.Tables["AcitivityTracker"].Rows.Count; j++)
            {
                if (SaveThings.id == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[j]["UserID"].ToString()))
                {
                    trackerID = int.Parse(dataSet.Tables["AcitivityTracker"].Rows[j]["ID"].ToString());
                }
            }

            for (int j = 0; j < dataSet.Tables["AcitivityTracker"].Rows.Count; j++)
            {
                try
                {
                    if (trackerID == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[j]["ID"].ToString()))
                        acitivityTrackerTableAdapter.UpdateLogoutTime(DateTime.Now.ToString("HH:mm:ss"), trackerID);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }


            MainWindow window = new MainWindow();
            window.Show();
            Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.Columns[5].Visibility = Visibility.Hidden;
        }
    }
}
