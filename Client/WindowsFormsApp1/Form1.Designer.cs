using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        internal void Show()
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.InMeeting = new FontAwesome.Sharp.IconButton();
            this.NewMeeting = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.InMeeting);
            this.panel1.Controls.Add(this.NewMeeting);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.InfoText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 125;
            this.iconPictureBox1.Location = new System.Drawing.Point(377, 95);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(378, 125);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // InMeeting
            // 
            this.InMeeting.BackColor = System.Drawing.SystemColors.Window;
            this.InMeeting.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.InMeeting.IconColor = System.Drawing.Color.Gray;
            this.InMeeting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InMeeting.IconSize = 32;
            this.InMeeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InMeeting.Location = new System.Drawing.Point(500, 384);
            this.InMeeting.Name = "InMeeting";
            this.InMeeting.Size = new System.Drawing.Size(132, 46);
            this.InMeeting.TabIndex = 2;
            this.InMeeting.Text = "회의 참가";
            this.InMeeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InMeeting.UseVisualStyleBackColor = false;
            this.InMeeting.Click += new System.EventHandler(this.InMeeting_Click);
            // 
            // NewMeeting
            // 
            this.NewMeeting.BackColor = System.Drawing.SystemColors.Window;
            this.NewMeeting.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.NewMeeting.IconColor = System.Drawing.Color.Gray;
            this.NewMeeting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewMeeting.IconSize = 32;
            this.NewMeeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewMeeting.Location = new System.Drawing.Point(500, 313);
            this.NewMeeting.Name = "NewMeeting";
            this.NewMeeting.Size = new System.Drawing.Size(132, 46);
            this.NewMeeting.TabIndex = 2;
            this.NewMeeting.Text = "회의 생성";
            this.NewMeeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewMeeting.UseVisualStyleBackColor = false;
            this.NewMeeting.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton InMeeting;
        private FontAwesome.Sharp.IconButton NewMeeting;
    }
}

