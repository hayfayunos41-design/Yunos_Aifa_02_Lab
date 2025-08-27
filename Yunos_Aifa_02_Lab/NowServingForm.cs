using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunos_Aifa_02_Lab
{
    public partial class NowServingForm : Form
    {
        Timer timer = new Timer();
        public NowServingForm()
        {
            InitializeComponent();


            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CashierClass.NowServing))
            {
                lblNowServing.Text = "Now Serving: " + CashierClass.NowServing;
            }
            else
            {
                lblNowServing.Text = "Now Serving: ---";

            }
        }
        private void NowServingForm_Load(object sender, EventArgs e)
        {

        }

        private void lblNowServing_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is NowServingForm)
                {

                }

            }

        }
       NowServingForm form3= new NowServingForm();
        form3.Show();
    }
}
