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
       
        public NowServingForm()
        { 
           
            InitializeComponent();

           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
          
        }
        private void NowServingForm_Load(object sender, EventArgs e)
        {
            lblNowServing.Text = "Now Serving: ";
            
        }

        private void lblNowServing_Click(object sender, EventArgs e)
        {
        }
        public void  UpdateNowServing(string number)
        {
            lblNowServing.Text = "Now Serving: " +  "   " + number;

        }
    
        }
}

