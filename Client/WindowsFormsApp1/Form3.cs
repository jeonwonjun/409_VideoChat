using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        TcpClient tcpclient;
        NetworkStream networkstream;
        StreamReader streamreader;
        StreamWriter streamwriter;
        ViewInterface viewinterface;
        NetInterface netinterface;

        public Form3(ViewInterface viewinterface, NetInterface netinterface)
        {
            InitializeComponent();
            this.viewinterface = viewinterface;
            this.netinterface = netinterface;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewinterface.Viewf1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                try
                {

                    tcpclient = new TcpClient("127.0.0.1", 7000); //소켓생성,커넥트
                    NetworkStream ns = tcpclient.GetStream();
                //StreamReader sr = new StreamReader(ns);
                //StreamWriter sw = new StreamWriter(ns);

                //sw.WriteLine(string.Format("Join;{0};{1};", CodeBox.Text, NameBox2.Text));
                byte[] buffer = Encoding.Default.GetBytes(string.Format("Join;{0};{1};", CodeBox.Text, NameBox2.Text));

                ns.Write(buffer, 0, buffer.Length);
                    
                viewinterface.Viewlectur();


                }
                catch (SocketException a)
                {
                    MessageBox.Show(a.ToString());
                    MessageBox.Show("연결실패");
                }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewinterface.CloseForm();
        }
    }
}
