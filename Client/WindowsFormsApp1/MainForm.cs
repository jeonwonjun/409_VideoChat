using GUI;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using Size = System.Drawing.Size;
using System.Threading;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace WindowsFormsApp1
{

    public partial class MainForm : Form
    {

        TcpNetwork net;
        TcpClient client;
        ViewInterface viewinterface;
        NetInterface netinterface;

        byte[] buf;
        private readonly VideoCapture capture;
        Mat frame = new Mat();
        Size camsz;
        Bitmap cambit;
        Thread thread = null;
        Graphics camgraphics;
        MemoryStream ms;
        Image src;

        public MainForm(ViewInterface viewinterface, NetInterface netinterface)
        {
            InitializeComponent();
            this.viewinterface = viewinterface;
            this.netinterface = netinterface;
            capture = new VideoCapture(0);
            capture.FrameWidth = 995;
            capture.FrameHeight = 468;

            camsz = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            cambit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            camgraphics = Graphics.FromImage(cambit);
            thread = new Thread(new ThreadStart(Capture_Thread));
            ms = new MemoryStream();
        }

        public void Capture_Thread()
        {
            while(true)
            {
                camgraphics.CopyFromScreen(0, 0, 0, 0, cambit.Size);

                try
                {
                    cambit.Save("x2.jpg", ImageFormat.Jpeg);
                    cambit.Save(ms, ImageFormat.Jpeg);
                    buf = ms.ToArray();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                CameraBox.ImageLocation = "x2.jpg";
                Thread.Sleep(100);
            }
        }

        private void btnMic_Click(object sender, EventArgs e)
        {
            btnMic.SendToBack();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            
            btnVdieo.SendToBack();
            //frame.Dispose();
            capture.Release();
            CameraBox.Visible = false;



        }
            

            private void btnVideoSlash_Click(object sender, EventArgs e)
        {
            btnVideoSlash.SendToBack();
            CameraBox.Visible = true;

            //string RSTPadder = "127.0.0.1";
            //video = new VideoCapture(RSTPadder);


            using (Mat cameraImage = new Mat())
            {
                while (Cv2.WaitKey(33) != 'q')
                {
                    /*if(!video.Read(cameraImage))
                    {
                        Cv2.WaitKey();
                    }*/
                    
                    /*if(cameraImage.Size().Width > 0 && cameraImage.Size().Height > 0)
                    {
                        bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(cameraImage);
                        CameraBox.Image = bitmap;
                    }*/

                    /*if(Cv2.WaitKey(1) >= 0)
                    {
                        break;
                    }*/
                    


                    capture.Read(frame);
                    CameraBox.Image = frame.ToBitmap();
                }
            }


            }

        private void btnMicSlash_Click(object sender, EventArgs e)
        {
            btnMicSlash.SendToBack();
        }

        private void btnmember_Click(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            viewinterface.Viewf1();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewinterface.CloseForm();
            capture.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CameraBox_Click(object sender, EventArgs e)
        {

        }

        private void btnScrshare_Click(object sender, EventArgs e)
        {
            if (btnScrshare.Text == "화면공유")
            {
                if (!thread.IsAlive)
                {
                    CameraBox.Visible = true;
                    thread.Start();
                }
                btnScrshare.Text = "화면공유중단";
            }
            else if (btnScrshare.Text == "화면공유중단")
            {
                if(thread.IsAlive)
                {
                    thread.Abort();
                    CameraBox.Visible = false;
                    
                }               
                btnScrshare.Text = "화면공유";
            }
            
            
            /*int BUFF_SIZE = 1024;
            netinterface.Connect();



            Bitmap bmp = ScreenCapture();
            var imgconv = new ImageConverter();
            byte[] imgbytes = (byte[])imgconv.ConvertTo(bmp, typeof(byte[]));
            byte[] nbytes = BitConverter.GetBytes(imgbytes.Length);

            using (NetworkStream stream = client.GetStream())
            {
                // (1) 먼저 데이타 크기 전달
                stream.Write(nbytes, 0, nbytes.Length);

                // (2) 다음 실제 데이타 전달
                int end = imgbytes.Length;
                int start = 0;
                while (start < end)
                {
                    int n = end - start >= BUFF_SIZE ? BUFF_SIZE : end - start;
                    stream.Write(imgbytes, start, n);
                    start += n;
                }

                // (3) 결과 수신: 성공이면 1, 실패이면 0
                byte[] result = new byte[1];
                stream.Read(result, 0, result.Length);
                Console.WriteLine(result[0]);
            }

            client.Close();*/
        }

        /*static Bitmap ScreenCapture()
        {
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            Bitmap scrbmp = new Bitmap(rect.Width, rect.Height);

            using (Graphics g = Graphics.FromImage(scrbmp))
            {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, scrbmp.Size, CopyPixelOperation.SourceCopy);
            }
            return scrbmp;
        }*/
    }   
}
