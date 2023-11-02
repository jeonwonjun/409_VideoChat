using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GUI
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(listView1.Items.Count.ToString());

            listView1.Items.Add(item);
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
