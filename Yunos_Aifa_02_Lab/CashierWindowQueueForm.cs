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
    public partial class CashierWindowQueueForm : Form
    {
        private Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            listCashierQueue.View = View.List;

            timer = new Timer();
            timer.Interval = (1 * 1000); // 1 second
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listCashierQueue.Items.Clear();

            foreach (string num in CashierClass.CashierQueue)
            {
                listCashierQueue.Items.Add(num);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                string next = CashierClass.CashierQueue.Dequeue();
                MessageBox.Show("Now Serving: " + next, "Cashier Window");
            }
            else
            {
                MessageBox.Show("No customers in queue.");
            }

            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable<string> CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
    }
    }

