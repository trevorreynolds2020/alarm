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
    public partial class Form1 : Form
    {
        public List<Alarm> Alarms = new List<Alarm>();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Alarm> Alarms)
        {
            InitializeComponent();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AlarmInfo alarmEditor = new AlarmInfo();
            alarmEditor.Show();
        }

        private void AlarmsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
