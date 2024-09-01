namespace MpExe.APP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.trackBarEnd = new System.Windows.Forms.TrackBar();
            this.trackBarStart = new System.Windows.Forms.TrackBar();
            this.numericUpStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpEnd = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpEnd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(16, 37);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 30);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(65, 95);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 30);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Oynat";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(146, 95);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 30);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Durdur";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(227, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Başa Al";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Location = new System.Drawing.Point(29, 20);
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(318, 45);
            this.trackBarPosition.TabIndex = 4;
            this.trackBarPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPosition.Scroll += new System.EventHandler(this.trackBarPosition_Scroll);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(35, 68);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.wma";
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(19, 13);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(62, 13);
            this.lblSelectedFile.TabIndex = 7;
            this.lblSelectedFile.Text = "Ses Seçiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpEnd);
            this.groupBox1.Controls.Add(this.numericUpStart);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.trackBarEnd);
            this.groupBox1.Controls.Add(this.trackBarStart);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(22, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kesme İşlemleri";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(26, 130);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(26, 69);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Start";
            // 
            // trackBarEnd
            // 
            this.trackBarEnd.Location = new System.Drawing.Point(26, 98);
            this.trackBarEnd.Name = "trackBarEnd";
            this.trackBarEnd.Size = new System.Drawing.Size(318, 45);
            this.trackBarEnd.TabIndex = 6;
            this.trackBarEnd.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEnd.Scroll += new System.EventHandler(this.trackBarEnd_Scroll);
            // 
            // trackBarStart
            // 
            this.trackBarStart.Location = new System.Drawing.Point(26, 38);
            this.trackBarStart.Name = "trackBarStart";
            this.trackBarStart.Size = new System.Drawing.Size(318, 45);
            this.trackBarStart.TabIndex = 5;
            this.trackBarStart.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarStart.Scroll += new System.EventHandler(this.trackBarStart_Scroll);
            // 
            // numericUpStart
            // 
            this.numericUpStart.Location = new System.Drawing.Point(350, 38);
            this.numericUpStart.Name = "numericUpStart";
            this.numericUpStart.Size = new System.Drawing.Size(59, 20);
            this.numericUpStart.TabIndex = 10;
            this.numericUpStart.ValueChanged += new System.EventHandler(this.numericUpStart_ValueChanged);
            this.numericUpStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpStart_KeyUp);
            // 
            // numericUpEnd
            // 
            this.numericUpEnd.Location = new System.Drawing.Point(350, 98);
            this.numericUpEnd.Name = "numericUpEnd";
            this.numericUpEnd.Size = new System.Drawing.Size(59, 20);
            this.numericUpEnd.TabIndex = 11;
            this.numericUpEnd.ValueChanged += new System.EventHandler(this.numericUpEnd_ValueChanged);
            this.numericUpEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpEnd_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarPosition);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.lblCurrentTime);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(22, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yürütme İşlemleri";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(730, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Simple Audio Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpEnd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarEnd;
        private System.Windows.Forms.TrackBar trackBarStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericUpEnd;
        private System.Windows.Forms.NumericUpDown numericUpStart;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


