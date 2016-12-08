namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.JackPotTextBox = new System.Windows.Forms.TextBox();
            this.CreditsTextBox = new System.Windows.Forms.TextBox();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.WinnerTextBox = new System.Windows.Forms.TextBox();
            this.Bet1picture = new System.Windows.Forms.PictureBox();
            this.Bet10Picture = new System.Windows.Forms.PictureBox();
            this.Bet100Picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bet50PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet500PictureBox = new System.Windows.Forms.PictureBox();
            this.Bet5PictureBox = new System.Windows.Forms.PictureBox();
            this.LeftWinPictureBox = new System.Windows.Forms.PictureBox();
            this.MiddleWinPictureBox = new System.Windows.Forms.PictureBox();
            this.RightWinPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.QuitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet1picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet10Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet100Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet50PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet500PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleWinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(336, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            this.SpinPictureBox.MouseHover += new System.EventHandler(this.SpinPictureBox_MouseHover);
            // 
            // JackPotTextBox
            // 
            this.JackPotTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JackPotTextBox.Enabled = false;
            this.JackPotTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackPotTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.JackPotTextBox.Location = new System.Drawing.Point(183, 165);
            this.JackPotTextBox.Name = "JackPotTextBox";
            this.JackPotTextBox.ReadOnly = true;
            this.JackPotTextBox.Size = new System.Drawing.Size(100, 21);
            this.JackPotTextBox.TabIndex = 7;
            this.JackPotTextBox.Text = "Twitchy Slots!";
            // 
            // CreditsTextBox
            // 
            this.CreditsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreditsTextBox.Enabled = false;
            this.CreditsTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CreditsTextBox.Location = new System.Drawing.Point(73, 375);
            this.CreditsTextBox.Name = "CreditsTextBox";
            this.CreditsTextBox.ReadOnly = true;
            this.CreditsTextBox.Size = new System.Drawing.Size(100, 21);
            this.CreditsTextBox.TabIndex = 8;
            this.CreditsTextBox.Text = "Current Credits";
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BetTextBox.Enabled = false;
            this.BetTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BetTextBox.Location = new System.Drawing.Point(199, 375);
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.ReadOnly = true;
            this.BetTextBox.Size = new System.Drawing.Size(61, 21);
            this.BetTextBox.TabIndex = 9;
            this.BetTextBox.Text = "Bet";
            this.BetTextBox.TextChanged += new System.EventHandler(this.BetTextBox_TextChanged);
            // 
            // WinnerTextBox
            // 
            this.WinnerTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WinnerTextBox.Enabled = false;
            this.WinnerTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WinnerTextBox.Location = new System.Drawing.Point(287, 375);
            this.WinnerTextBox.Name = "WinnerTextBox";
            this.WinnerTextBox.ReadOnly = true;
            this.WinnerTextBox.Size = new System.Drawing.Size(100, 21);
            this.WinnerTextBox.TabIndex = 10;
            this.WinnerTextBox.Text = "Paid Amount";
            // 
            // Bet1picture
            // 
            this.Bet1picture.Image = global::SlotMachine.Properties.Resources.bet1;
            this.Bet1picture.Location = new System.Drawing.Point(73, 436);
            this.Bet1picture.Name = "Bet1picture";
            this.Bet1picture.Size = new System.Drawing.Size(35, 30);
            this.Bet1picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet1picture.TabIndex = 11;
            this.Bet1picture.TabStop = false;
            this.Bet1picture.Click += new System.EventHandler(this.Bet1picture_Click);
            this.Bet1picture.MouseHover += new System.EventHandler(this.Bet1picture_MouseHover);
            // 
            // Bet10Picture
            // 
            this.Bet10Picture.Image = global::SlotMachine.Properties.Resources.bet10;
            this.Bet10Picture.Location = new System.Drawing.Point(199, 436);
            this.Bet10Picture.Name = "Bet10Picture";
            this.Bet10Picture.Size = new System.Drawing.Size(35, 30);
            this.Bet10Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet10Picture.TabIndex = 12;
            this.Bet10Picture.TabStop = false;
            this.Bet10Picture.Click += new System.EventHandler(this.Bet10Picture_Click);
            this.Bet10Picture.MouseHover += new System.EventHandler(this.Bet10Picture_MouseHover);
            // 
            // Bet100Picture
            // 
            this.Bet100Picture.Image = global::SlotMachine.Properties.Resources.bet100;
            this.Bet100Picture.Location = new System.Drawing.Point(158, 472);
            this.Bet100Picture.Name = "Bet100Picture";
            this.Bet100Picture.Size = new System.Drawing.Size(35, 30);
            this.Bet100Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet100Picture.TabIndex = 13;
            this.Bet100Picture.TabStop = false;
            this.Bet100Picture.Click += new System.EventHandler(this.Bet100Picture_Click);
            this.Bet100Picture.MouseHover += new System.EventHandler(this.Bet100Picture_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine.Properties.Resources.bet2;
            this.pictureBox1.Location = new System.Drawing.Point(114, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Bet2Picture_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.Bet2Picture_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachine.Properties.Resources.bet25;
            this.pictureBox2.Location = new System.Drawing.Point(73, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Bet25Picture_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.Bet25Picture_MouseHover);
            // 
            // Bet50PictureBox
            // 
            this.Bet50PictureBox.Image = global::SlotMachine.Properties.Resources.bet50;
            this.Bet50PictureBox.Location = new System.Drawing.Point(114, 472);
            this.Bet50PictureBox.Name = "Bet50PictureBox";
            this.Bet50PictureBox.Size = new System.Drawing.Size(35, 30);
            this.Bet50PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet50PictureBox.TabIndex = 16;
            this.Bet50PictureBox.TabStop = false;
            this.Bet50PictureBox.Click += new System.EventHandler(this.Bet50PictureBox_Click);
            this.Bet50PictureBox.MouseHover += new System.EventHandler(this.Bet50PictureBox_MouseHover);
            // 
            // Bet500PictureBox
            // 
            this.Bet500PictureBox.Image = global::SlotMachine.Properties.Resources.bet500;
            this.Bet500PictureBox.Location = new System.Drawing.Point(199, 472);
            this.Bet500PictureBox.Name = "Bet500PictureBox";
            this.Bet500PictureBox.Size = new System.Drawing.Size(35, 30);
            this.Bet500PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet500PictureBox.TabIndex = 17;
            this.Bet500PictureBox.TabStop = false;
            this.Bet500PictureBox.Click += new System.EventHandler(this.Bet500PictureBox_Click);
            this.Bet500PictureBox.MouseHover += new System.EventHandler(this.Bet500PictureBox_MouseHover);
            // 
            // Bet5PictureBox
            // 
            this.Bet5PictureBox.Image = global::SlotMachine.Properties.Resources.bet5;
            this.Bet5PictureBox.Location = new System.Drawing.Point(158, 436);
            this.Bet5PictureBox.Name = "Bet5PictureBox";
            this.Bet5PictureBox.Size = new System.Drawing.Size(35, 30);
            this.Bet5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bet5PictureBox.TabIndex = 18;
            this.Bet5PictureBox.TabStop = false;
            this.Bet5PictureBox.Click += new System.EventHandler(this.Bet5PictureBox_Click);
            this.Bet5PictureBox.MouseHover += new System.EventHandler(this.Bet5PictureBox_MouseHover);
            // 
            // LeftWinPictureBox
            // 
            this.LeftWinPictureBox.Location = new System.Drawing.Point(73, 224);
            this.LeftWinPictureBox.Name = "LeftWinPictureBox";
            this.LeftWinPictureBox.Size = new System.Drawing.Size(88, 130);
            this.LeftWinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftWinPictureBox.TabIndex = 19;
            this.LeftWinPictureBox.TabStop = false;
            this.LeftWinPictureBox.Click += new System.EventHandler(this.LeftWinPictureBox_Click);
            // 
            // MiddleWinPictureBox
            // 
            this.MiddleWinPictureBox.Location = new System.Drawing.Point(183, 224);
            this.MiddleWinPictureBox.Name = "MiddleWinPictureBox";
            this.MiddleWinPictureBox.Size = new System.Drawing.Size(89, 130);
            this.MiddleWinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MiddleWinPictureBox.TabIndex = 20;
            this.MiddleWinPictureBox.TabStop = false;
            // 
            // RightWinPictureBox
            // 
            this.RightWinPictureBox.Location = new System.Drawing.Point(298, 224);
            this.RightWinPictureBox.Name = "RightWinPictureBox";
            this.RightWinPictureBox.Size = new System.Drawing.Size(89, 130);
            this.RightWinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightWinPictureBox.TabIndex = 21;
            this.RightWinPictureBox.TabStop = false;
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetPictureBox.Location = new System.Drawing.Point(249, 436);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(34, 30);
            this.ResetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPictureBox.TabIndex = 22;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            this.ResetPictureBox.MouseHover += new System.EventHandler(this.ResetPictureBox_MouseHover);
            // 
            // QuitPictureBox
            // 
            this.QuitPictureBox.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.QuitPictureBox.Location = new System.Drawing.Point(249, 472);
            this.QuitPictureBox.Name = "QuitPictureBox";
            this.QuitPictureBox.Size = new System.Drawing.Size(34, 30);
            this.QuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuitPictureBox.TabIndex = 23;
            this.QuitPictureBox.TabStop = false;
            this.QuitPictureBox.Click += new System.EventHandler(this.QuitPictureBox_Click);
            this.QuitPictureBox.MouseHover += new System.EventHandler(this.QuitPictureBox_MouseHover);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.QuitPictureBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.RightWinPictureBox);
            this.Controls.Add(this.MiddleWinPictureBox);
            this.Controls.Add(this.LeftWinPictureBox);
            this.Controls.Add(this.Bet5PictureBox);
            this.Controls.Add(this.Bet500PictureBox);
            this.Controls.Add(this.Bet50PictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bet100Picture);
            this.Controls.Add(this.Bet10Picture);
            this.Controls.Add(this.Bet1picture);
            this.Controls.Add(this.WinnerTextBox);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.CreditsTextBox);
            this.Controls.Add(this.JackPotTextBox);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet1picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet10Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet100Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet50PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet500PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bet5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleWinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.TextBox JackPotTextBox;
        private System.Windows.Forms.TextBox CreditsTextBox;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.TextBox WinnerTextBox;
        private System.Windows.Forms.PictureBox Bet1picture;
        private System.Windows.Forms.PictureBox Bet10Picture;
        private System.Windows.Forms.PictureBox Bet100Picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Bet50PictureBox;
        private System.Windows.Forms.PictureBox Bet500PictureBox;
        private System.Windows.Forms.PictureBox Bet5PictureBox;
        private System.Windows.Forms.PictureBox LeftWinPictureBox;
        private System.Windows.Forms.PictureBox MiddleWinPictureBox;
        private System.Windows.Forms.PictureBox RightWinPictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox QuitPictureBox;
    }
}