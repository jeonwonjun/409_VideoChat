using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace NewMeet
{
    
    public partial class Form2 : Form
    {
        TcpClient client = null;
        ViewInterface viewinterface;
        NetInterface netinterface;

        public Form2(ViewInterface viewinterface, NetInterface netinterface)
        {
            InitializeComponent();
            this.viewinterface = viewinterface;
            this.netinterface = netinterface;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            viewinterface.Viewf1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NameBox1.Text != "")
            {
                try
                {
                    string strRecvMsg;
                    string strSendMsg;

                    TcpClient sockClient = new TcpClient("127.0.0.1", 7000); //소켓생성,커넥트
                    NetworkStream ns = sockClient.GetStream();
                    //StreamReader sr = new StreamReader(ns);
                    //StreamWriter sw = new StreamWriter(ns);

                    byte[] buffer = Encoding.Default.GetBytes(string.Format("Create;{0};", NameBox1.Text));
                    ns.Write(buffer, 0, buffer.Length);
                    

                    viewinterface.Viewlectur();


                }
                catch (SocketException a)
                {
                    MessageBox.Show(a.ToString());
                    MessageBox.Show("연결실패");
                }


            }
            
            else
            {
                MessageBox.Show("이름을 입력해주세요.");
            }
        }

        public string ReceiveMessage()
        {
            byte[] byteData = new byte[1024];

            client.GetStream().Read(byteData, 0, byteData.Length);

            string ReceiveMsg = Encoding.Default.GetString(byteData);

            return ReceiveMsg;
        }
        private void DisConnect()
        {
            client.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewinterface.CloseForm();
        }
    }
}
