﻿using System;
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
    public partial class Form1 : Form
    {
        public BindingList<String> Alarms = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            alarmsList.DataSource = Alarms;
            Alarms.AllowNew = true;
            ReadAlarmFile("C:/Users/tjr2020/Source/Repos/alarm/alarm/alarm.txt");
        }
        public Form1(string alarm)
        {
            InitializeComponent();
            WriteAlarmFile(alarm, "C:/Users/tjr2020/Source/Repos/alarm/alarm/alarm.txt");
            ReadAlarmFile("C:/Users/tjr2020/Source/Repos/alarm/alarm/alarm.txt");
        }

        private void AddButton(object sender, EventArgs e)
        {
            AlarmInfo alarmEditor = new AlarmInfo();
            alarmEditor.ShowDialog();
        }

        private void AlarmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxEdit.Enabled = true;
        }
        /// <summary>
        /// Read the alarm file
        /// </summary>
        /// <param name="path"></param>
        private void ReadAlarmFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                Alarms.Add(line);
            }
            sr.Close();
        }
        /// <summary>
        /// Write to the alarm file
        /// </summary>
        /// <param name="newAlarm"></param>
        /// <param name="path"></param>
        private void WriteAlarmFile(string newAlarm, string path)
        {
            // copy the alarms over from the file
            List<string> replicaAlarm = new List<string>();
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                replicaAlarm.Add(line);
            }
            sr.Close();

            // rewrite the alarms with the new alarm
            StreamWriter sw = new StreamWriter(path);
            sw.Flush();
            foreach (string a in replicaAlarm)
            {
               sw.WriteLine(a);
            }
            sw.WriteLine(newAlarm);
            sw.Close();
        }

        private void UxEdit_Click(object sender, EventArgs e)
        {
            AlarmInfo alarmEditor = new AlarmInfo();
            alarmEditor.ShowDialog();
        }
    }
}
