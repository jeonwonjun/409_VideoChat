using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{

    

    class Sharing
    {
        byte[] buf;
        Size camsz;
        Bitmap cambit;
        Thread thread = null;
        Graphics camgraphics;
        MemoryStream ms;

        public void Capture_Thread()
        {
            while (true)
            {
                camgraphics.CopyFromScreen(0, 0, 0, 0, cambit.Size);

                try
                {
                    cambit.Save("x2.jpg", ImageFormat.Jpeg);
                    cambit.Save(ms, ImageFormat.Jpeg);
                    buf = ms.ToArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                CameraBox.ImageLocation = "x2.jpg";
                Thread.Sleep(100);
            }
        }
    }    
}
