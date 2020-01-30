using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// Set Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            alarm = new Alarm(selectedTime.Value, on);

            //close
        }

        private void SelectedTime_ValueChanged(object sender, EventArgs e)
        {
            alarm = new Alarm(selectedTime.Value, on);
            AlarmList.Add(alarm);
            //this.Hide();
        }

        /// <summary>
        /// RadioButton1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
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
            this.Hide();
        }
    }
}
