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

        public BindingList<String> Alarms = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            alarmsList.DataSource = Alarms;
            Alarms.AllowNew = true;
        }

        private void AddButton(object sender, EventArgs e)
        {
            AlarmInfo alarmEditor = new AlarmInfo();
            alarmEditor.Show();
        }

        private void AlarmsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
