namespace Inverted_Pendulum_Mega {
  partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tbLog = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblStats = new System.Windows.Forms.Label();
      this.cbRealtimeUpdate = new System.Windows.Forms.CheckBox();
      this.tbKp = new System.Windows.Forms.TrackBar();
      this.tbKi = new System.Windows.Forms.TrackBar();
      this.tbKd = new System.Windows.Forms.TrackBar();
      this.tbAngleOffset = new System.Windows.Forms.TrackBar();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnCalibrate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbKp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbKi)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbKd)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbAngleOffset)).BeginInit();
      this.SuspendLayout();
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbLog.ForeColor = System.Drawing.Color.White;
      this.tbLog.Location = new System.Drawing.Point(491, 202);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(310, 196);
      this.tbLog.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.White;
      this.groupBox1.Controls.Add(this.lblStats);
      this.groupBox1.Controls.Add(this.cbRealtimeUpdate);
      this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBox1.ForeColor = System.Drawing.Color.Black;
      this.groupBox1.Location = new System.Drawing.Point(218, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 249);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Values";
      // 
      // lblStats
      // 
      this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblStats.Location = new System.Drawing.Point(3, 16);
      this.lblStats.Name = "lblStats";
      this.lblStats.Size = new System.Drawing.Size(194, 184);
      this.lblStats.TabIndex = 0;
      // 
      // cbRealtimeUpdate
      // 
      this.cbRealtimeUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.cbRealtimeUpdate.Location = new System.Drawing.Point(3, 200);
      this.cbRealtimeUpdate.Name = "cbRealtimeUpdate";
      this.cbRealtimeUpdate.Size = new System.Drawing.Size(194, 46);
      this.cbRealtimeUpdate.TabIndex = 1;
      this.cbRealtimeUpdate.Text = "Update Realtime\r\n(Slows transmission)\r\n";
      this.cbRealtimeUpdate.UseVisualStyleBackColor = true;
      this.cbRealtimeUpdate.CheckedChanged += new System.EventHandler(this.cbRealtimeUpdate_CheckedChanged);
      // 
      // tbKp
      // 
      this.tbKp.BackColor = System.Drawing.Color.White;
      this.tbKp.Location = new System.Drawing.Point(12, 12);
      this.tbKp.Maximum = 4095;
      this.tbKp.Minimum = 1;
      this.tbKp.Name = "tbKp";
      this.tbKp.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbKp.Size = new System.Drawing.Size(45, 223);
      this.tbKp.TabIndex = 3;
      this.tbKp.TickFrequency = 100;
      this.tbKp.Value = 4095;
      this.tbKp.Scroll += new System.EventHandler(this.trackBar_Scroll);
      // 
      // tbKi
      // 
      this.tbKi.BackColor = System.Drawing.Color.White;
      this.tbKi.Location = new System.Drawing.Point(63, 12);
      this.tbKi.Maximum = 4095;
      this.tbKi.Minimum = 1;
      this.tbKi.Name = "tbKi";
      this.tbKi.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbKi.Size = new System.Drawing.Size(45, 223);
      this.tbKi.TabIndex = 4;
      this.tbKi.TickFrequency = 100;
      this.tbKi.Value = 4095;
      this.tbKi.Scroll += new System.EventHandler(this.trackBar_Scroll);
      // 
      // tbKd
      // 
      this.tbKd.BackColor = System.Drawing.Color.White;
      this.tbKd.Location = new System.Drawing.Point(114, 12);
      this.tbKd.Maximum = 4095;
      this.tbKd.Minimum = 1;
      this.tbKd.Name = "tbKd";
      this.tbKd.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tbKd.Size = new System.Drawing.Size(45, 223);
      this.tbKd.TabIndex = 5;
      this.tbKd.TickFrequency = 100;
      this.tbKd.Value = 4095;
      this.tbKd.Scroll += new System.EventHandler(this.trackBar_Scroll);
      // 
      // tbAngleOffset
      // 
      this.tbAngleOffset.BackColor = System.Drawing.Color.White;
      this.tbAngleOffset.LargeChange = 1;
      this.tbAngleOffset.Location = new System.Drawing.Point(491, 41);
      this.tbAngleOffset.Maximum = 50;
      this.tbAngleOffset.Minimum = -50;
      this.tbAngleOffset.Name = "tbAngleOffset";
      this.tbAngleOffset.Size = new System.Drawing.Size(223, 45);
      this.tbAngleOffset.TabIndex = 6;
      this.tbAngleOffset.TickFrequency = 5;
      this.tbAngleOffset.Scroll += new System.EventHandler(this.trackBar_Scroll);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(197, 267);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(48, 27);
      this.button1.TabIndex = 7;
      this.button1.Text = "^";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.White;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.Color.Black;
      this.button2.Location = new System.Drawing.Point(197, 300);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(48, 27);
      this.button2.TabIndex = 8;
      this.button2.Text = "[]";
      this.button2.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.White;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.ForeColor = System.Drawing.Color.Black;
      this.button3.Location = new System.Drawing.Point(251, 300);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(48, 27);
      this.button3.TabIndex = 9;
      this.button3.Text = ">";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.White;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.Color.Black;
      this.button4.Location = new System.Drawing.Point(143, 300);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(48, 27);
      this.button4.TabIndex = 10;
      this.button4.Text = "<";
      this.button4.UseVisualStyleBackColor = false;
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.White;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.ForeColor = System.Drawing.Color.Black;
      this.button5.Location = new System.Drawing.Point(197, 333);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(48, 27);
      this.button5.TabIndex = 11;
      this.button5.Text = "v";
      this.button5.UseVisualStyleBackColor = false;
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.ForeColor = System.Drawing.Color.White;
      this.textBox1.Location = new System.Drawing.Point(145, 375);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(154, 13);
      this.textBox1.TabIndex = 12;
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // btnCalibrate
      // 
      this.btnCalibrate.BackColor = System.Drawing.Color.White;
      this.btnCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCalibrate.ForeColor = System.Drawing.Color.Black;
      this.btnCalibrate.Location = new System.Drawing.Point(343, 267);
      this.btnCalibrate.Name = "btnCalibrate";
      this.btnCalibrate.Size = new System.Drawing.Size(75, 23);
      this.btnCalibrate.TabIndex = 13;
      this.btnCalibrate.Text = "Calibrate";
      this.btnCalibrate.UseVisualStyleBackColor = false;
      this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.White;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(12, 238);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 20);
      this.label1.TabIndex = 14;
      this.label1.Text = "Kp";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.White;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(60, 238);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(22, 20);
      this.label2.TabIndex = 15;
      this.label2.Text = "Ki";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.White;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Black;
      this.label3.Location = new System.Drawing.Point(114, 238);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 20);
      this.label3.TabIndex = 16;
      this.label3.Text = "Kd";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.White;
      this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Black;
      this.label4.Location = new System.Drawing.Point(539, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(140, 16);
      this.label4.TabIndex = 17;
      this.label4.Text = "Angle correction offset";
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.White;
      this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label5.ForeColor = System.Drawing.Color.Black;
      this.label5.Location = new System.Drawing.Point(343, 293);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(115, 67);
      this.label5.TabIndex = 18;
      this.label5.Text = "Send calibration command to Mega";
      // 
      // FormMain
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalibrate);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tbAngleOffset);
      this.Controls.Add(this.tbKd);
      this.Controls.Add(this.tbKi);
      this.Controls.Add(this.tbKp);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.tbLog);
      this.Name = "FormMain";
      this.Text = "FormMain";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tbKp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbKi)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbKd)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbAngleOffset)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.CheckBox cbRealtimeUpdate;
    private System.Windows.Forms.TrackBar tbKp;
    private System.Windows.Forms.TrackBar tbKi;
    private System.Windows.Forms.TrackBar tbKd;
    private System.Windows.Forms.TrackBar tbAngleOffset;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnCalibrate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}