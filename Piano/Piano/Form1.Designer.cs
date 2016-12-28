namespace Piano
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cButton = new System.Windows.Forms.Button();
            this.c2Button = new System.Windows.Forms.Button();
            this.hButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playSong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.autoPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.customSongText = new System.Windows.Forms.TextBox();
            this.customPlaySong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.wplayerC = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerD = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerE = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerF = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerG = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerA = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerH = new AxWMPLib.AxWindowsMediaPlayer();
            this.wplayerC2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerC2)).BeginInit();
            this.SuspendLayout();
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(12, 60);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(34, 127);
            this.cButton.TabIndex = 0;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // c2Button
            // 
            this.c2Button.Location = new System.Drawing.Point(292, 60);
            this.c2Button.Name = "c2Button";
            this.c2Button.Size = new System.Drawing.Size(34, 127);
            this.c2Button.TabIndex = 1;
            this.c2Button.Text = "C\'";
            this.c2Button.UseVisualStyleBackColor = true;
            this.c2Button.Click += new System.EventHandler(this.c2Button_Click);
            // 
            // hButton
            // 
            this.hButton.Location = new System.Drawing.Point(252, 60);
            this.hButton.Name = "hButton";
            this.hButton.Size = new System.Drawing.Size(34, 127);
            this.hButton.TabIndex = 2;
            this.hButton.Text = "H";
            this.hButton.UseVisualStyleBackColor = true;
            this.hButton.Click += new System.EventHandler(this.hButton_Click);
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(212, 60);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(34, 127);
            this.aButton.TabIndex = 3;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // gButton
            // 
            this.gButton.Location = new System.Drawing.Point(172, 60);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(34, 127);
            this.gButton.TabIndex = 4;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.gButton_Click);
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(132, 60);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(34, 127);
            this.fButton.TabIndex = 5;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.fButton_Click);
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(92, 60);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(34, 127);
            this.eButton.TabIndex = 6;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(52, 60);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(34, 127);
            this.dButton.TabIndex = 7;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "PIANO";
            // 
            // playSong
            // 
            this.playSong.Location = new System.Drawing.Point(355, 94);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(75, 23);
            this.playSong.TabIndex = 9;
            this.playSong.Text = "Play";
            this.playSong.UseVisualStyleBackColor = true;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "AutoSong";
            // 
            // autoPlayTimer
            // 
            this.autoPlayTimer.Interval = 800;
            this.autoPlayTimer.Tick += new System.EventHandler(this.autoPlayTimer_Tick);
            // 
            // customSongText
            // 
            this.customSongText.Location = new System.Drawing.Point(12, 33);
            this.customSongText.Name = "customSongText";
            this.customSongText.Size = new System.Drawing.Size(314, 20);
            this.customSongText.TabIndex = 11;
            this.customSongText.Text = "G E E F D D";
            // 
            // customPlaySong
            // 
            this.customPlaySong.Location = new System.Drawing.Point(355, 33);
            this.customPlaySong.Name = "customPlaySong";
            this.customPlaySong.Size = new System.Drawing.Size(75, 23);
            this.customPlaySong.TabIndex = 12;
            this.customPlaySong.Text = "Play";
            this.customPlaySong.UseVisualStyleBackColor = true;
            this.customPlaySong.Click += new System.EventHandler(this.customPlaySong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sample";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(355, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Volume";
            // 
            // wplayerC
            // 
            this.wplayerC.Enabled = true;
            this.wplayerC.Location = new System.Drawing.Point(11, 9);
            this.wplayerC.Name = "wplayerC";
            this.wplayerC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerC.OcxState")));
            this.wplayerC.Size = new System.Drawing.Size(75, 23);
            this.wplayerC.TabIndex = 16;
            this.wplayerC.Visible = false;
            // 
            // wplayerD
            // 
            this.wplayerD.Enabled = true;
            this.wplayerD.Location = new System.Drawing.Point(26, 9);
            this.wplayerD.Name = "wplayerD";
            this.wplayerD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerD.OcxState")));
            this.wplayerD.Size = new System.Drawing.Size(75, 23);
            this.wplayerD.TabIndex = 17;
            this.wplayerD.Visible = false;
            // 
            // wplayerE
            // 
            this.wplayerE.Enabled = true;
            this.wplayerE.Location = new System.Drawing.Point(46, 7);
            this.wplayerE.Name = "wplayerE";
            this.wplayerE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerE.OcxState")));
            this.wplayerE.Size = new System.Drawing.Size(75, 23);
            this.wplayerE.TabIndex = 18;
            this.wplayerE.Visible = false;
            // 
            // wplayerF
            // 
            this.wplayerF.Enabled = true;
            this.wplayerF.Location = new System.Drawing.Point(63, 9);
            this.wplayerF.Name = "wplayerF";
            this.wplayerF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerF.OcxState")));
            this.wplayerF.Size = new System.Drawing.Size(75, 23);
            this.wplayerF.TabIndex = 19;
            this.wplayerF.Visible = false;
            // 
            // wplayerG
            // 
            this.wplayerG.Enabled = true;
            this.wplayerG.Location = new System.Drawing.Point(193, 9);
            this.wplayerG.Name = "wplayerG";
            this.wplayerG.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerG.OcxState")));
            this.wplayerG.Size = new System.Drawing.Size(75, 23);
            this.wplayerG.TabIndex = 20;
            this.wplayerG.Visible = false;
            // 
            // wplayerA
            // 
            this.wplayerA.Enabled = true;
            this.wplayerA.Location = new System.Drawing.Point(227, 9);
            this.wplayerA.Name = "wplayerA";
            this.wplayerA.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerA.OcxState")));
            this.wplayerA.Size = new System.Drawing.Size(75, 23);
            this.wplayerA.TabIndex = 21;
            this.wplayerA.Visible = false;
            // 
            // wplayerH
            // 
            this.wplayerH.Enabled = true;
            this.wplayerH.Location = new System.Drawing.Point(252, 9);
            this.wplayerH.Name = "wplayerH";
            this.wplayerH.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerH.OcxState")));
            this.wplayerH.Size = new System.Drawing.Size(75, 23);
            this.wplayerH.TabIndex = 22;
            this.wplayerH.Visible = false;
            // 
            // wplayerC2
            // 
            this.wplayerC2.Enabled = true;
            this.wplayerC2.Location = new System.Drawing.Point(274, 9);
            this.wplayerC2.Name = "wplayerC2";
            this.wplayerC2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayerC2.OcxState")));
            this.wplayerC2.Size = new System.Drawing.Size(75, 23);
            this.wplayerC2.TabIndex = 23;
            this.wplayerC2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 198);
            this.Controls.Add(this.wplayerC2);
            this.Controls.Add(this.wplayerH);
            this.Controls.Add(this.wplayerA);
            this.Controls.Add(this.wplayerG);
            this.Controls.Add(this.wplayerF);
            this.Controls.Add(this.wplayerE);
            this.Controls.Add(this.wplayerD);
            this.Controls.Add(this.wplayerC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customPlaySong);
            this.Controls.Add(this.customSongText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.hButton);
            this.Controls.Add(this.c2Button);
            this.Controls.Add(this.cButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piano";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayerC2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button c2Button;
        private System.Windows.Forms.Button hButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer autoPlayTimer;
        private System.Windows.Forms.TextBox customSongText;
        private System.Windows.Forms.Button customPlaySong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer wplayerC;
        private AxWMPLib.AxWindowsMediaPlayer wplayerD;
        private AxWMPLib.AxWindowsMediaPlayer wplayerE;
        private AxWMPLib.AxWindowsMediaPlayer wplayerF;
        private AxWMPLib.AxWindowsMediaPlayer wplayerG;
        private AxWMPLib.AxWindowsMediaPlayer wplayerA;
        private AxWMPLib.AxWindowsMediaPlayer wplayerH;
        private AxWMPLib.AxWindowsMediaPlayer wplayerC2;
    }
}

