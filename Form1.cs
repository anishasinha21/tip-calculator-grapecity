using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double bill;
        double tip;
        double totalperperson;
        int noofperson;
        double tipamount;
        double tipperperson;
        double totalbill;
        double tipperson;
        private void button3_Click(object sender, EventArgs e)
        {
            T1.Clear();
            T2.Clear();
            T3.Clear();
            N1.Value = 0;
            N2.Value = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            T2.Text = "";
            T3.Text = "";
            try
            {
                bill = double.Parse(T1.Text);
                tip= double.Parse(N1.Text);
                noofperson = int.Parse(N2.Text);
                tipamount = bill * (tip / 100);
                tipperson = tipamount / noofperson;
                totalbill = bill + tipamount;
                totalperperson = totalbill / noofperson;
                T2.Text = tipperson.ToString("c2");
                T3.Text = totalperperson.ToString("c2");
            }
            catch
            {
                MessageBox.Show("please enter the bill amount");
                T1.Focus();
                T1.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void T1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
                
                    }
    }
}
