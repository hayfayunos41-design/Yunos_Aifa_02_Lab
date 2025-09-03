using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Yunos_Aifa_02_Lab
{
        public partial class CashierWindowQueueForm : Form

        {
            private NowServingForm nowServingForm;
        
            public CashierWindowQueueForm()
            {
                InitializeComponent();

                nowServingForm = new NowServingForm();
                nowServingForm.Show();

            
        }

            private void CashierWindowQueueForm_Load(object sender, EventArgs e)
            {

            }

            private void btnRefresh_Click(object sender, EventArgs e)
            {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

            private void btnNext_Click(object sender, EventArgs e)
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                string served = CashierClass.CashierQueue.Dequeue();
                CashierClass.NowServing = served;

                DisplayCashierQueue(CashierClass.CashierQueue);

                if (nowServingForm == null || nowServingForm.IsDisposed)
                {
                    nowServingForm = new NowServingForm();
                    nowServingForm.Show();
                }
                    nowServingForm.UpdateNowServing(served);

                    DisplayCashierQueue(CashierClass.CashierQueue);
                }
                else
                {
                    MessageBox.Show("No students in queue.");
                }
            }
            private void timer1_Tick(object sender, EventArgs e)
            {
            }
            public void DisplayCashierQueue(IEnumerable<string> CashierList)
            {
                listCashierQueue.Items.Clear();
                foreach (Object obj in CashierList)
                {
                listCashierQueue.Items.Add(obj.ToString());
            }
            }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
     }

