namespace PyboardFileManager
{
    partial class SelectComForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectComForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkDTREnabled = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picESP8266 = new System.Windows.Forms.PictureBox();
            this.picSTMicro = new System.Windows.Forms.PictureBox();
            this.picRP2040 = new System.Windows.Forms.PictureBox();
            this.tmrRotatePicture = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picESP8266)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSTMicro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRP2040)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 92);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comm Ports";
            // 
            // cboPorts
            // 
            this.cboPorts.BackColor = System.Drawing.SystemColors.Window;
            this.cboPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(394, 91);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 24);
            this.cboPorts.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(282, 157);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkDTREnabled
            // 
            this.chkDTREnabled.BackColor = System.Drawing.Color.Transparent;
            this.chkDTREnabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDTREnabled.Location = new System.Drawing.Point(387, 123);
            this.chkDTREnabled.Name = "chkDTREnabled";
            this.chkDTREnabled.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.chkDTREnabled.Size = new System.Drawing.Size(111, 19);
            this.chkDTREnabled.TabIndex = 1;
            this.chkDTREnabled.Text = "DTR Enabled";
            this.chkDTREnabled.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(444, 157);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(303, 59);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pyboard File Manager";
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(375, 7);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(49, 47);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 8;
            this.picIcon.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(363, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picESP8266
            // 
            this.picESP8266.Image = ((System.Drawing.Image)(resources.GetObject("picESP8266.Image")));
            this.picESP8266.Location = new System.Drawing.Point(12, 13);
            this.picESP8266.Name = "picESP8266";
            this.picESP8266.Size = new System.Drawing.Size(265, 167);
            this.picESP8266.TabIndex = 9;
            this.picESP8266.TabStop = false;
            // 
            // picSTMicro
            // 
            this.picSTMicro.Image = ((System.Drawing.Image)(resources.GetObject("picSTMicro.Image")));
            this.picSTMicro.Location = new System.Drawing.Point(12, 13);
            this.picSTMicro.Name = "picSTMicro";
            this.picSTMicro.Size = new System.Drawing.Size(265, 167);
            this.picSTMicro.TabIndex = 10;
            this.picSTMicro.TabStop = false;
            this.picSTMicro.Visible = false;
            // 
            // picRP2040
            // 
            this.picRP2040.Image = ((System.Drawing.Image)(resources.GetObject("picRP2040.Image")));
            this.picRP2040.Location = new System.Drawing.Point(12, 13);
            this.picRP2040.Name = "picRP2040";
            this.picRP2040.Size = new System.Drawing.Size(265, 167);
            this.picRP2040.TabIndex = 11;
            this.picRP2040.TabStop = false;
            this.picRP2040.Visible = false;
            // 
            // tmrRotatePicture
            // 
            this.tmrRotatePicture.Enabled = true;
            this.tmrRotatePicture.Interval = 2000;
            this.tmrRotatePicture.Tick += new System.EventHandler(this.tmrRotatePicture_Tick);
            // 
            // SelectComForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(534, 192);
            this.ControlBox = false;
            this.Controls.Add(this.picRP2040);
            this.Controls.Add(this.picSTMicro);
            this.Controls.Add(this.picESP8266);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDTREnabled);
            this.Controls.Add(this.cboPorts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectComForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectComForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picESP8266)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSTMicro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRP2040)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkDTREnabled;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picESP8266;
        private System.Windows.Forms.PictureBox picSTMicro;
        private System.Windows.Forms.PictureBox picRP2040;
        private System.Windows.Forms.Timer tmrRotatePicture;
    }
}