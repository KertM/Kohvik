using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohvik
{
    public partial class KK : Form
    {
        public KK()
        {
            InitializeComponent();
        }

        private void KK_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
        }


        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Order_Click(object sender, EventArgs e)
        {
            double summa = 0;
            ListBox.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                ListBox.Items.Add(s + "     2.5€");
                summa += 2.5;
            foreach (string s in checkedListBox2.CheckedItems)
                ListBox.Items.Add(s + "     4€");
            foreach (string s in checkedListBox3.CheckedItems)
                ListBox.Items.Add(s + "     42€");

            Total.Text = "Your total: " + summa;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Total_Click(object sender, EventArgs e)
        {

        }


        private void tere_Click(object sender, EventArgs e)
        {
            Tab.SelectedTab = Kohvik;
        }
    }
}
