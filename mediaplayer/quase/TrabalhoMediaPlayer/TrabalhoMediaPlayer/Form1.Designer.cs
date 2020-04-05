namespace TrabalhoMediaPlayer
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxVolume = new System.Windows.Forms.PictureBox();
            this.trackBarminplus = new System.Windows.Forms.TrackBar();
            this.buttonbusca = new System.Windows.Forms.Button();
            this.buttonplay = new System.Windows.Forms.Button();
            this.buttonfoward = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.buttonpause = new System.Windows.Forms.Button();
            this.treeViewMusic = new System.Windows.Forms.TreeView();
            this.listaimagens = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.buttonAleatorio = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarminplus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAleatorio);
            this.panel1.Controls.Add(this.pictureBoxVolume);
            this.panel1.Controls.Add(this.trackBarminplus);
            this.panel1.Controls.Add(this.buttonbusca);
            this.panel1.Controls.Add(this.buttonplay);
            this.panel1.Controls.Add(this.buttonfoward);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.buttonstop);
            this.panel1.Controls.Add(this.buttonpause);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 97);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxVolume
            // 
            this.pictureBoxVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVolume.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolume.Image")));
            this.pictureBoxVolume.Location = new System.Drawing.Point(594, 16);
            this.pictureBoxVolume.Name = "pictureBoxVolume";
            this.pictureBoxVolume.Size = new System.Drawing.Size(43, 43);
            this.pictureBoxVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolume.TabIndex = 6;
            this.pictureBoxVolume.TabStop = false;
            // 
            // trackBarminplus
            // 
            this.trackBarminplus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBarminplus.Location = new System.Drawing.Point(664, 16);
            this.trackBarminplus.Maximum = 1;
            this.trackBarminplus.Name = "trackBarminplus";
            this.trackBarminplus.Size = new System.Drawing.Size(108, 45);
            this.trackBarminplus.TabIndex = 2;
            this.trackBarminplus.Value = 1;
            this.trackBarminplus.Scroll += new System.EventHandler(this.trackBarminplus_Scroll);
            // 
            // buttonbusca
            // 
            this.buttonbusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonbusca.BackgroundImage")));
            this.buttonbusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonbusca.FlatAppearance.BorderSize = 0;
            this.buttonbusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonbusca.Location = new System.Drawing.Point(22, 18);
            this.buttonbusca.Name = "buttonbusca";
            this.buttonbusca.Size = new System.Drawing.Size(60, 60);
            this.buttonbusca.TabIndex = 8;
            this.buttonbusca.UseVisualStyleBackColor = true;
            this.buttonbusca.Click += new System.EventHandler(this.buttonbusca_Click);
            // 
            // buttonplay
            // 
            this.buttonplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonplay.BackgroundImage")));
            this.buttonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonplay.FlatAppearance.BorderSize = 0;
            this.buttonplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonplay.Location = new System.Drawing.Point(154, 18);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(59, 60);
            this.buttonplay.TabIndex = 7;
            this.buttonplay.UseVisualStyleBackColor = false;
            this.buttonplay.Click += new System.EventHandler(this.buttonplay_Click);
            // 
            // buttonfoward
            // 
            this.buttonfoward.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonfoward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonfoward.BackgroundImage")));
            this.buttonfoward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfoward.FlatAppearance.BorderSize = 0;
            this.buttonfoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfoward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonfoward.Location = new System.Drawing.Point(415, 18);
            this.buttonfoward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonfoward.Name = "buttonfoward";
            this.buttonfoward.Size = new System.Drawing.Size(49, 60);
            this.buttonfoward.TabIndex = 5;
            this.buttonfoward.UseVisualStyleBackColor = false;
            this.buttonfoward.Click += new System.EventHandler(this.buttonfoward_Click_1);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonback.BackgroundImage")));
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonback.FlatAppearance.BorderSize = 0;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonback.Location = new System.Drawing.Point(350, 18);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(62, 60);
            this.buttonback.TabIndex = 6;
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click_1);
            // 
            // buttonstop
            // 
            this.buttonstop.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonstop.BackgroundImage")));
            this.buttonstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonstop.FlatAppearance.BorderSize = 0;
            this.buttonstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonstop.Location = new System.Drawing.Point(284, 18);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(60, 60);
            this.buttonstop.TabIndex = 3;
            this.buttonstop.UseVisualStyleBackColor = false;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // buttonpause
            // 
            this.buttonpause.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonpause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonpause.BackgroundImage")));
            this.buttonpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpause.FlatAppearance.BorderSize = 0;
            this.buttonpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonpause.Location = new System.Drawing.Point(219, 18);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(59, 60);
            this.buttonpause.TabIndex = 4;
            this.buttonpause.UseVisualStyleBackColor = false;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // treeViewMusic
            // 
            this.treeViewMusic.ImageIndex = 0;
            this.treeViewMusic.ImageList = this.listaimagens;
            this.treeViewMusic.Location = new System.Drawing.Point(17, 121);
            this.treeViewMusic.Name = "treeViewMusic";
            this.treeViewMusic.SelectedImageIndex = 0;
            this.treeViewMusic.Size = new System.Drawing.Size(459, 423);
            this.treeViewMusic.TabIndex = 2;
            // 
            // listaimagens
            // 
            this.listaimagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaimagens.ImageStream")));
            this.listaimagens.TransparentColor = System.Drawing.Color.Transparent;
            this.listaimagens.Images.SetKeyName(0, "music");
            this.listaimagens.Images.SetKeyName(1, "harddisk");
            this.listaimagens.Images.SetKeyName(2, "Time");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(494, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(809, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(494, 146);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(370, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(494, 171);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(370, 10);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(494, 196);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(370, 10);
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar4.TabIndex = 7;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(494, 221);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(370, 10);
            this.progressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar5.TabIndex = 8;
            // 
            // buttonAleatorio
            // 
            this.buttonAleatorio.Location = new System.Drawing.Point(467, 18);
            this.buttonAleatorio.Name = "buttonAleatorio";
            this.buttonAleatorio.Size = new System.Drawing.Size(53, 60);
            this.buttonAleatorio.TabIndex = 9;
            this.buttonAleatorio.Text = "button1";
            this.buttonAleatorio.UseVisualStyleBackColor = true;
            this.buttonAleatorio.Click += new System.EventHandler(this.buttonAleatorio_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(526, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(53, 60);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "button1";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 556);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeViewMusic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarminplus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxVolume;
        private System.Windows.Forms.TrackBar trackBarminplus;
        private System.Windows.Forms.Button buttonbusca;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.Button buttonfoward;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonstop;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.TreeView treeViewMusic;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList listaimagens;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Button buttonAleatorio;
        private System.Windows.Forms.Button buttonDelete;
    }
}

