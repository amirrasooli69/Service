﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        string load = "";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.timer1.Enabled = true;
                Directory.CreateDirectory(txt_save.Text + "\\" + time());
                File.Copy(load, txt_save.Text + "\\" + time() + "\\db.db", true);



            }
            catch { }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_save.Text = Application.StartupPath + "\\Backup\\";
        }

        public string time()
        {
            string sal, mah, roz, hor, min, sec, dandt;
            //namayesh tarikhe shamsie system
            PersianCalendar years = new PersianCalendar();
            sal = years.GetYear(DateTime.Now).ToString();
            PersianCalendar Month = new PersianCalendar();
            mah = Month.GetMonth(DateTime.Now).ToString();
            PersianCalendar day = new PersianCalendar();
            roz = day.GetDayOfMonth(DateTime.Now).ToString();
            PersianCalendar hour = new PersianCalendar();
            hor = hour.GetHour(DateTime.Now).ToString();
            PersianCalendar minit = new PersianCalendar();
            min = minit.GetMinute(DateTime.Now).ToString();
            PersianCalendar second = new PersianCalendar();
            sec = second.GetSecond(DateTime.Now).ToString();
            //PersianCalendar msecond = new PersianCalendar();
            //milisec = msecond.GetMilliseconds(DateTime.Now).ToString();
            dandt = sal + "-" + mah + "-" + roz + " _ " + hor + "-" + min;
            ///////////////////
            return dandt;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            // دستور شرطی : درصورت انتخاب ادرس و اوکی شدن
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            { 
                // نمایش ادرس در تکست باکس
                Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "\\");
                txt_save.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void Frm_backup_Load(object sender, EventArgs e)
        {
            txt_save.Text = Application.StartupPath + "\\Backup\\";
            load = Application.StartupPath + "\\Stimulsoft.dll";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 100)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("عملیات پشتیبان گیری با موفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value += 10;
            }
        }
    }
}
