namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnScrshare = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnmember = new System.Windows.Forms.Button();
            this.btnMicSlash = new FontAwesome.Sharp.IconButton();
            this.btnVideoSlash = new FontAwesome.Sharp.IconButton();
            this.btnMic = new FontAwesome.Sharp.IconButton();
            this.btnVdieo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.CameraBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 534);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(0, 0);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(990, 468);
            this.CameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CameraBox.TabIndex = 1;
            this.CameraBox.TabStop = false;
            this.CameraBox.Click += new System.EventHandler(this.CameraBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnScrshare);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnmember);
            this.panel2.Controls.Add(this.btnMicSlash);
            this.panel2.Controls.Add(this.btnVideoSlash);
            this.panel2.Controls.Add(this.btnMic);
            this.panel2.Controls.Add(this.btnVdieo);
            this.panel2.Location = new System.Drawing.Point(0, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 71);
            this.panel2.TabIndex = 0;
            // 
            // btnScrshare
            // 
            this.btnScrshare.Location = new System.Drawing.Point(529, 21);
            this.btnScrshare.Name = "btnScrshare";
            this.btnScrshare.Size = new System.Drawing.Size(125, 33);
            this.btnScrshare.TabIndex = 1;
            this.btnScrshare.Text = "화면공유";
            this.btnScrshare.UseVisualStyleBackColor = true;
            this.btnScrshare.Click += new System.EventHandler(this.btnScrshare_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(826, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "나가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnmember
            // 
            this.btnmember.Location = new System.Drawing.Point(679, 21);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(125, 33);
            this.btnmember.TabIndex = 1;
            this.btnmember.Text = "참가자";
            this.btnmember.UseVisualStyleBackColor = true;
            this.btnmember.Click += new System.EventHandler(this.btnmember_Click);
            // 
            // btnMicSlash
            // 
            this.btnMicSlash.IconChar = FontAwesome.Sharp.IconChar.MicrophoneSlash;
            this.btnMicSlash.IconColor = System.Drawing.Color.Black;
            this.btnMicSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMicSlash.IconSize = 70;
            this.btnMicSlash.Location = new System.Drawing.Point(90, 0);
            this.btnMicSlash.Name = "btnMicSlash";
            this.btnMicSlash.Size = new System.Drawing.Size(94, 71);
            this.btnMicSlash.TabIndex = 1;
            this.btnMicSlash.UseVisualStyleBackColor = true;
            this.btnMicSlash.Click += new System.EventHandler(this.btnMicSlash_Click);
            // 
            // btnVideoSlash
            // 
            this.btnVideoSlash.IconChar = FontAwesome.Sharp.IconChar.VideoSlash;
            this.btnVideoSlash.IconColor = System.Drawing.Color.Black;
            this.btnVideoSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVideoSlash.IconSize = 70;
            this.btnVideoSlash.Location = new System.Drawing.Point(0, 0);
            this.btnVideoSlash.Name = "btnVideoSlash";
            this.btnVideoSlash.Size = new System.Drawing.Size(94, 71);
            this.btnVideoSlash.TabIndex = 1;
            this.btnVideoSlash.UseVisualStyleBackColor = true;
            this.btnVideoSlash.Click += new System.EventHandler(this.btnVideoSlash_Click);
            // 
            // btnMic
            // 
            this.btnMic.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.btnMic.IconColor = System.Drawing.Color.Black;
            this.btnMic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMic.IconSize = 58;
            this.btnMic.Location = new System.Drawing.Point(90, 0);
            this.btnMic.Name = "btnMic";
            this.btnMic.Size = new System.Drawing.Size(94, 71);
            this.btnMic.TabIndex = 1;
            this.btnMic.UseVisualStyleBackColor = true;
            this.btnMic.Click += new System.EventHandler(this.btnMic_Click);
            // 
            // btnVdieo
            // 
            this.btnVdieo.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnVdieo.IconColor = System.Drawing.Color.Black;
            this.btnVdieo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVdieo.IconSize = 70;
            this.btnVdieo.Location = new System.Drawing.Point(0, 0);
            this.btnVdieo.Name = "btnVdieo";
            this.btnVdieo.Size = new System.Drawing.Size(94, 71);
            this.btnVdieo.TabIndex = 1;
            this.btnVdieo.UseVisualStyleBackColor = true;
            this.btnVdieo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 528);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnVdieo;
        private FontAwesome.Sharp.IconButton btnMic;
        private FontAwesome.Sharp.IconButton btnVideoSlash;
        private FontAwesome.Sharp.IconButton btnMicSlash;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.Button btnScrshare;
    }
}