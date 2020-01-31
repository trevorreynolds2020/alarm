using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace alarm
{
    public partial class AlarmInfo : Form
    {
        private DateTime time;
        private bool on;
        public Alarm alarm;
        public List<Alarm> AlarmList = new List<Alarm>();
        public AlarmInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Editing alarms
        /// </summary>
        /// <param name="alarm"></param>
        public AlarmInfo(string alarm)
        {
            InitializeComponent();
            selectedTime.Value = DateTime.Now; //value of string
        }
        /// <summary>
        /// Set Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetButton(object sender, EventArgs e)
        {
            // [1] , [2] , [3] , [4]
            String time = selectedTime.ToString();
            String[] parts = time.Split(':', ',', '/');
            String status;
            if (on)
            {
                status = "ON";
            }
            else
            {
                status = "OFF";
            }
            String officialTime =  parts[4].Split(' ')[1] +":"+parts[5] + ":" + parts[6] +" "+ status;
            Form1 form = new Form1(officialTime);
            this.Close();
        }

        private void SelectedTime_ValueChanged(object sender, EventArgs e)
        {
            //alarm = new Alarm(selectedTime.Value, on);
            //AlarmList.Add(alarm);
            //this.Close();
        }

        /// <summary>
        /// RadioButton1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChecked(object sender, EventArgs e)
        {
            if(onButton.Checked == true)
            {
                on = true;
            }
            else
            {
                on = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
