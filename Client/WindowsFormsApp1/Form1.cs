using GUI;
using NewMeet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public interface ViewInterface
    {
        void Viewf1();
        void Viewf2();
        void Viewf3();
        void Viewlectur();
        void Viewmember();
        void CloseForm();
    }

    public partial class Form1 : Form, ViewInterface
    {
        TcpNetwork net;
        Form2 f2;
        Form3 f3;
        MainForm lectur;
        MemberForm member;
        NetInterface netinterface;
        public Form1()
        {
            InitializeComponent();
            net = new TcpNetwork();
            netinterface = net.Interface;
            f2 = new Form2(this as ViewInterface, netinterface);
            f3 = new Form3(this as ViewInterface, netinterface);
            lectur = new MainForm(this as ViewInterface, netinterface);
            member = new MemberForm();
        }

        public void Viewf1()
        {
            this.Show();
            f2.Hide();
            f3.Hide();
            lectur.Hide();
            member.Hide();
        }
        public void CloseForm()
        {
            this.Close();
            f2.Close();
            f3.Close();
            lectur.Close();
            member.Close();

        }
        public void Viewf2()
        {
            this.Hide();
            f2.Show();
            f3.Hide();
            lectur.Hide();
            member.Hide();

            
        }

        public void Viewf3()
        {
            this.Hide();
            f2.Hide();
            f3.Show();
            lectur.Hide();
            member.Hide();
        }

        public void Viewlectur()
        {
            this.Hide();
            f2.Hide();
            f3.Hide();
            lectur.Show();
            member.Hide();
        }

        public void Viewmember()
        {
            this.Hide();
            f2.Hide();
            f3.Hide();
            lectur.Hide();
            member.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewf2();

        }

        private void InMeeting_Click(object sender, EventArgs e)
        {
            Viewf3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm();
        }
    }
}
