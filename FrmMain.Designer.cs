namespace AldlEmulator
{
    partial class FrmMain
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
            this.serialAldl = new System.IO.Ports.SerialPort(this.components);
            this.serialAem = new System.IO.Ports.SerialPort(this.components);
            this.timerAem = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtECMCom = new System.Windows.Forms.TextBox();
            this.txtAemCom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numRPM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numThrottle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numCoolant = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numKnock = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numMsgSize = new System.Windows.Forms.NumericUpDown();
            this.chkEcho = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoolant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKnock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsgSize)).BeginInit();
            this.SuspendLayout();
            // 
            // serialAldl
            // 
            this.serialAldl.ReceivedBytesThreshold = 4;
            // 
            // timerAem
            // 
            this.timerAem.Tick += new System.EventHandler(this.timerAem_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(380, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ECM Comport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aem WB Comport:";
            // 
            // txtECMCom
            // 
            this.txtECMCom.Location = new System.Drawing.Point(435, 9);
            this.txtECMCom.Name = "txtECMCom";
            this.txtECMCom.Size = new System.Drawing.Size(100, 20);
            this.txtECMCom.TabIndex = 3;
            this.txtECMCom.Text = "COM2";
            // 
            // txtAemCom
            // 
            this.txtAemCom.Location = new System.Drawing.Point(435, 30);
            this.txtAemCom.Name = "txtAemCom";
            this.txtAemCom.Size = new System.Drawing.Size(100, 20);
            this.txtAemCom.TabIndex = 4;
            this.txtAemCom.Text = "COM4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle Speed, MPH:";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(177, 8);
            this.numSpeed.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(120, 20);
            this.numSpeed.TabIndex = 6;
            this.numSpeed.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numSpeed.ValueChanged += new System.EventHandler(this.numSpeed_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Engine RPM:";
            // 
            // numRPM
            // 
            this.numRPM.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRPM.Location = new System.Drawing.Point(177, 35);
            this.numRPM.Maximum = new decimal(new int[] {
            6300,
            0,
            0,
            0});
            this.numRPM.Name = "numRPM";
            this.numRPM.Size = new System.Drawing.Size(120, 20);
            this.numRPM.TabIndex = 8;
            this.numRPM.Value = new decimal(new int[] {
            2800,
            0,
            0,
            0});
            this.numRPM.ValueChanged += new System.EventHandler(this.numRPM_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Throttle position:";
            // 
            // numThrottle
            // 
            this.numThrottle.DecimalPlaces = 2;
            this.numThrottle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numThrottle.Location = new System.Drawing.Point(177, 61);
            this.numThrottle.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numThrottle.Name = "numThrottle";
            this.numThrottle.Size = new System.Drawing.Size(120, 20);
            this.numThrottle.TabIndex = 10;
            this.numThrottle.Value = new decimal(new int[] {
            22,
            0,
            0,
            65536});
            this.numThrottle.ValueChanged += new System.EventHandler(this.numThrottle_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Engine Coolant (Deg C): ";
            // 
            // numCoolant
            // 
            this.numCoolant.Location = new System.Drawing.Point(177, 87);
            this.numCoolant.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numCoolant.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.numCoolant.Name = "numCoolant";
            this.numCoolant.Size = new System.Drawing.Size(120, 20);
            this.numCoolant.TabIndex = 12;
            this.numCoolant.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.numCoolant.ValueChanged += new System.EventHandler(this.numCoolant_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Knock count:";
            // 
            // numKnock
            // 
            this.numKnock.Location = new System.Drawing.Point(177, 113);
            this.numKnock.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numKnock.Name = "numKnock";
            this.numKnock.Size = new System.Drawing.Size(120, 20);
            this.numKnock.TabIndex = 14;
            this.numKnock.ValueChanged += new System.EventHandler(this.numKnock_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Message size:";
            // 
            // numMsgSize
            // 
            this.numMsgSize.Location = new System.Drawing.Point(435, 53);
            this.numMsgSize.Name = "numMsgSize";
            this.numMsgSize.Size = new System.Drawing.Size(100, 20);
            this.numMsgSize.TabIndex = 16;
            this.numMsgSize.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            // 
            // chkEcho
            // 
            this.chkEcho.AutoSize = true;
            this.chkEcho.Checked = true;
            this.chkEcho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEcho.Location = new System.Drawing.Point(448, 79);
            this.chkEcho.Name = "chkEcho";
            this.chkEcho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEcho.Size = new System.Drawing.Size(87, 17);
            this.chkEcho.TabIndex = 17;
            this.chkEcho.Text = "RS232 Echo";
            this.chkEcho.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 150);
            this.Controls.Add(this.chkEcho);
            this.Controls.Add(this.numMsgSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numKnock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCoolant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numThrottle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numRPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAemCom);
            this.Controls.Add(this.txtECMCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmMain";
            this.Text = "Aldl Emulator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoolant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKnock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsgSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialAldl;
        private System.IO.Ports.SerialPort serialAem;
        private System.Windows.Forms.Timer timerAem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtECMCom;
        private System.Windows.Forms.TextBox txtAemCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numThrottle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCoolant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numKnock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMsgSize;
        private System.Windows.Forms.CheckBox chkEcho;
    }
}

