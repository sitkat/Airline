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
    public partial class LogoutDetected : Window
    {
        DataSet1 dataSet = new DataSet1();
        AcitivityTrackerTableAdapter acitivityTrackerTableAdapter = new AcitivityTrackerTableAdapter();
        public LogoutDetected()
        {
            InitializeComponent();

            acitivityTrackerTableAdapter.Fill(dataSet.AcitivityTracker);

            txtNoLogout.Text = "No logout detected for your last login on 06/07/2017 at 08:22";

            for (int i = 0; i < dataSet.Tables["AcitivityTracker"].Rows.Count; i++)
            {

                if (SaveThings.idTracker == int.Parse(dataSet.Tables["AcitivityTracker"].Rows[i]["ID"].ToString()))
                    txtNoLogout.Text = "No logout detected for your last login on " + "" + dataSet.Tables["AcitivityTracker"].Rows[i]["Date"].ToString() + "" + " at " + dataSet.Tables["AcitivityTracker"].Rows[i]["LoginTime"].ToString();
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtReason.Text))
                MessageBox.Show("Заполните или выберите причину!");
            else
            {
                string txt = "";
                if (rbFirst.IsChecked == true)
                    txt = "Software Crash";
                if (rbSecond.IsChecked == true)
                    txt = "System Crash";
                if (txtReason.Text != "")
                    txt = txt + " " + txtReason.Text;
                acitivityTrackerTableAdapter.UpdateLogout(txt, int.Parse(SaveThings.idTracker.ToString()));

                acitivityTrackerTableAdapter.Insert(DateTime.Now, TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")), null, "", int.Parse(SaveThings.id.ToString()));
                UserMenu window = new UserMenu();
                window.Show();
                Hide();
            }           
        }
    }
}
