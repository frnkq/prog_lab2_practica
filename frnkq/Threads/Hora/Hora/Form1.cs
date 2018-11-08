﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Hora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerCallback timerDelegate = new TimerCallback(AsignarHora);
            System.Threading.Timer timer = new System.Threading.Timer(timerDelegate, DateTime.Now, 0, 1000);

        }

        private void AsignarHora(Object time)
        {
            DateTime now = (DateTime)time;
            string rightnow = now.Day.ToString() + "/" + now.Month.ToString() +
                                "/" + now.Year.ToString() +
                                " " + now.Hour.ToString() +
                                ":" + now.Minute.ToString() +
                                ":" + now.Second.ToString();
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                {
                        this.lblHora.Text = rightnow;
                }
                );
            }
            else
            {
                this.lblHora.Text = rightnow;
            }

        }
    }
}
