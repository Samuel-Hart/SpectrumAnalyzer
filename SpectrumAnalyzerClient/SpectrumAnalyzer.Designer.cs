
namespace SpectrumAnalyzer
{
	partial class SpectrumAnalyzer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnFINDHID = new System.Windows.Forms.Button();
			this.btnGETSN = new System.Windows.Forms.Button();
			this.btnSTART = new System.Windows.Forms.Button();
			this.btnSTOP = new System.Windows.Forms.Button();
			this.btnEXIT = new System.Windows.Forms.Button();
			this.txtRESULT = new System.Windows.Forms.TextBox();
			this.lblFREQ = new System.Windows.Forms.Label();
			this.lblSTEP = new System.Windows.Forms.Label();
			this.lblRBW = new System.Windows.Forms.Label();
			this.lblPOINTS = new System.Windows.Forms.Label();
			this.lblAMP = new System.Windows.Forms.Label();
			this.lblSWEEPTIME = new System.Windows.Forms.Label();
			this.txtFREQ = new System.Windows.Forms.TextBox();
			this.txtSTEP = new System.Windows.Forms.TextBox();
			this.txtPOINTS = new System.Windows.Forms.TextBox();
			this.cboRBW = new System.Windows.Forms.ComboBox();
			this.cboAMP = new System.Windows.Forms.ComboBox();
			this.cboSWEEPTIME = new System.Windows.Forms.ComboBox();
			this.chkEXTATT = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblOutputDir = new System.Windows.Forms.Label();
			this.btnChangeDir = new System.Windows.Forms.Button();
			this.nudInterval = new System.Windows.Forms.NumericUpDown();
			this.lblScanInterval = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFINDHID
			// 
			this.btnFINDHID.Location = new System.Drawing.Point(50, 529);
			this.btnFINDHID.Name = "btnFINDHID";
			this.btnFINDHID.Size = new System.Drawing.Size(75, 25);
			this.btnFINDHID.TabIndex = 0;
			this.btnFINDHID.Text = "button1";
			this.btnFINDHID.UseVisualStyleBackColor = true;
			this.btnFINDHID.Click += new System.EventHandler(this.btnFINDHID_Click);
			// 
			// btnGETSN
			// 
			this.btnGETSN.Location = new System.Drawing.Point(153, 528);
			this.btnGETSN.Name = "btnGETSN";
			this.btnGETSN.Size = new System.Drawing.Size(75, 25);
			this.btnGETSN.TabIndex = 1;
			this.btnGETSN.Text = "button2";
			this.btnGETSN.UseVisualStyleBackColor = true;
			this.btnGETSN.Click += new System.EventHandler(this.btnGETSN_Click);
			// 
			// btnSTART
			// 
			this.btnSTART.Location = new System.Drawing.Point(251, 529);
			this.btnSTART.Name = "btnSTART";
			this.btnSTART.Size = new System.Drawing.Size(75, 25);
			this.btnSTART.TabIndex = 2;
			this.btnSTART.Text = "button3";
			this.btnSTART.UseVisualStyleBackColor = true;
			this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
			// 
			// btnSTOP
			// 
			this.btnSTOP.Location = new System.Drawing.Point(342, 529);
			this.btnSTOP.Name = "btnSTOP";
			this.btnSTOP.Size = new System.Drawing.Size(75, 25);
			this.btnSTOP.TabIndex = 3;
			this.btnSTOP.Text = "button4";
			this.btnSTOP.UseVisualStyleBackColor = true;
			this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
			// 
			// btnEXIT
			// 
			this.btnEXIT.Location = new System.Drawing.Point(436, 528);
			this.btnEXIT.Name = "btnEXIT";
			this.btnEXIT.Size = new System.Drawing.Size(75, 25);
			this.btnEXIT.TabIndex = 4;
			this.btnEXIT.Text = "button5";
			this.btnEXIT.UseVisualStyleBackColor = true;
			this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
			// 
			// txtRESULT
			// 
			this.txtRESULT.Location = new System.Drawing.Point(12, 254);
			this.txtRESULT.Multiline = true;
			this.txtRESULT.Name = "txtRESULT";
			this.txtRESULT.Size = new System.Drawing.Size(688, 239);
			this.txtRESULT.TabIndex = 5;
			// 
			// lblFREQ
			// 
			this.lblFREQ.AutoSize = true;
			this.lblFREQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFREQ.Location = new System.Drawing.Point(12, 11);
			this.lblFREQ.Name = "lblFREQ";
			this.lblFREQ.Size = new System.Drawing.Size(137, 15);
			this.lblFREQ.TabIndex = 6;
			this.lblFREQ.Text = "Center Frequency(MHz)";
			// 
			// lblSTEP
			// 
			this.lblSTEP.AutoSize = true;
			this.lblSTEP.Location = new System.Drawing.Point(176, 11);
			this.lblSTEP.Name = "lblSTEP";
			this.lblSTEP.Size = new System.Drawing.Size(54, 13);
			this.lblSTEP.TabIndex = 7;
			this.lblSTEP.Text = "Step(kHz)";
			// 
			// lblRBW
			// 
			this.lblRBW.AutoSize = true;
			this.lblRBW.Location = new System.Drawing.Point(342, 62);
			this.lblRBW.Name = "lblRBW";
			this.lblRBW.Size = new System.Drawing.Size(33, 13);
			this.lblRBW.TabIndex = 8;
			this.lblRBW.Text = "RBW";
			// 
			// lblPOINTS
			// 
			this.lblPOINTS.AutoSize = true;
			this.lblPOINTS.Location = new System.Drawing.Point(342, 11);
			this.lblPOINTS.Name = "lblPOINTS";
			this.lblPOINTS.Size = new System.Drawing.Size(88, 13);
			this.lblPOINTS.TabIndex = 9;
			this.lblPOINTS.Text = "Number of Points";
			// 
			// lblAMP
			// 
			this.lblAMP.AutoSize = true;
			this.lblAMP.Location = new System.Drawing.Point(14, 62);
			this.lblAMP.Name = "lblAMP";
			this.lblAMP.Size = new System.Drawing.Size(53, 13);
			this.lblAMP.TabIndex = 10;
			this.lblAMP.Text = "Amplitude";
			// 
			// lblSWEEPTIME
			// 
			this.lblSWEEPTIME.AutoSize = true;
			this.lblSWEEPTIME.Location = new System.Drawing.Point(178, 62);
			this.lblSWEEPTIME.Name = "lblSWEEPTIME";
			this.lblSWEEPTIME.Size = new System.Drawing.Size(66, 13);
			this.lblSWEEPTIME.TabIndex = 11;
			this.lblSWEEPTIME.Text = "Sweep Time";
			// 
			// txtFREQ
			// 
			this.txtFREQ.Location = new System.Drawing.Point(12, 27);
			this.txtFREQ.Name = "txtFREQ";
			this.txtFREQ.Size = new System.Drawing.Size(136, 20);
			this.txtFREQ.TabIndex = 12;
			// 
			// txtSTEP
			// 
			this.txtSTEP.Location = new System.Drawing.Point(176, 27);
			this.txtSTEP.Name = "txtSTEP";
			this.txtSTEP.Size = new System.Drawing.Size(141, 20);
			this.txtSTEP.TabIndex = 13;
			// 
			// txtPOINTS
			// 
			this.txtPOINTS.Location = new System.Drawing.Point(344, 27);
			this.txtPOINTS.Name = "txtPOINTS";
			this.txtPOINTS.Size = new System.Drawing.Size(161, 20);
			this.txtPOINTS.TabIndex = 14;
			// 
			// cboRBW
			// 
			this.cboRBW.FormattingEnabled = true;
			this.cboRBW.Location = new System.Drawing.Point(344, 78);
			this.cboRBW.Name = "cboRBW";
			this.cboRBW.Size = new System.Drawing.Size(161, 21);
			this.cboRBW.TabIndex = 15;
			// 
			// cboAMP
			// 
			this.cboAMP.FormattingEnabled = true;
			this.cboAMP.Location = new System.Drawing.Point(12, 78);
			this.cboAMP.Name = "cboAMP";
			this.cboAMP.Size = new System.Drawing.Size(136, 21);
			this.cboAMP.TabIndex = 16;
			// 
			// cboSWEEPTIME
			// 
			this.cboSWEEPTIME.FormattingEnabled = true;
			this.cboSWEEPTIME.Location = new System.Drawing.Point(176, 78);
			this.cboSWEEPTIME.Name = "cboSWEEPTIME";
			this.cboSWEEPTIME.Size = new System.Drawing.Size(141, 21);
			this.cboSWEEPTIME.TabIndex = 17;
			// 
			// chkEXTATT
			// 
			this.chkEXTATT.AutoSize = true;
			this.chkEXTATT.Location = new System.Drawing.Point(32, 122);
			this.chkEXTATT.Name = "chkEXTATT";
			this.chkEXTATT.Size = new System.Drawing.Size(80, 17);
			this.chkEXTATT.TabIndex = 18;
			this.chkEXTATT.Text = "checkBox1";
			this.chkEXTATT.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblOutputDir);
			this.groupBox1.Controls.Add(this.btnChangeDir);
			this.groupBox1.Location = new System.Drawing.Point(12, 146);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(688, 102);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Current Output Directory";
			// 
			// lblOutputDir
			// 
			this.lblOutputDir.AutoEllipsis = true;
			this.lblOutputDir.Location = new System.Drawing.Point(6, 17);
			this.lblOutputDir.Name = "lblOutputDir";
			this.lblOutputDir.Size = new System.Drawing.Size(676, 32);
			this.lblOutputDir.TabIndex = 2;
			this.lblOutputDir.Text = "No Directory Selected:  Select a valid output directory to enable start button";
			this.lblOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnChangeDir
			// 
			this.btnChangeDir.Location = new System.Drawing.Point(6, 63);
			this.btnChangeDir.Name = "btnChangeDir";
			this.btnChangeDir.Size = new System.Drawing.Size(676, 33);
			this.btnChangeDir.TabIndex = 1;
			this.btnChangeDir.Text = "Change Output Directory";
			this.btnChangeDir.UseVisualStyleBackColor = true;
			this.btnChangeDir.Click += new System.EventHandler(this.BtnChangeDirClick);
			// 
			// nudInterval
			// 
			this.nudInterval.Increment = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.nudInterval.Location = new System.Drawing.Point(533, 78);
			this.nudInterval.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.nudInterval.Name = "nudInterval";
			this.nudInterval.Size = new System.Drawing.Size(167, 20);
			this.nudInterval.TabIndex = 20;
			this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblScanInterval
			// 
			this.lblScanInterval.AutoSize = true;
			this.lblScanInterval.Location = new System.Drawing.Point(533, 62);
			this.lblScanInterval.Name = "lblScanInterval";
			this.lblScanInterval.Size = new System.Drawing.Size(130, 13);
			this.lblScanInterval.TabIndex = 21;
			this.lblScanInterval.Text = "Time Between Scans (ms)";
			// 
			// SpectrumAnalyzer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(712, 599);
			this.Controls.Add(this.nudInterval);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.chkEXTATT);
			this.Controls.Add(this.cboSWEEPTIME);
			this.Controls.Add(this.cboAMP);
			this.Controls.Add(this.cboRBW);
			this.Controls.Add(this.txtPOINTS);
			this.Controls.Add(this.txtSTEP);
			this.Controls.Add(this.txtFREQ);
			this.Controls.Add(this.lblSWEEPTIME);
			this.Controls.Add(this.lblAMP);
			this.Controls.Add(this.lblPOINTS);
			this.Controls.Add(this.lblRBW);
			this.Controls.Add(this.lblSTEP);
			this.Controls.Add(this.lblScanInterval);
			this.Controls.Add(this.lblFREQ);
			this.Controls.Add(this.txtRESULT);
			this.Controls.Add(this.btnEXIT);
			this.Controls.Add(this.btnSTOP);
			this.Controls.Add(this.btnSTART);
			this.Controls.Add(this.btnGETSN);
			this.Controls.Add(this.btnFINDHID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SpectrumAnalyzer";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spectrum Analyzer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpectrumAnalyzer_FormClosing);
			this.Load += new System.EventHandler(this.SpectrumAnalyzer_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	

        private System.Windows.Forms.Button btnFINDHID;
        private System.Windows.Forms.Button btnGETSN;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox txtRESULT;
        private System.Windows.Forms.Label lblFREQ;
        private System.Windows.Forms.Label lblSTEP;
        private System.Windows.Forms.Label lblRBW;
        private System.Windows.Forms.Label lblPOINTS;
        private System.Windows.Forms.Label lblAMP;
        private System.Windows.Forms.Label lblSWEEPTIME;
        private System.Windows.Forms.TextBox txtFREQ;
        private System.Windows.Forms.TextBox txtSTEP;
        private System.Windows.Forms.TextBox txtPOINTS;
        private System.Windows.Forms.ComboBox cboRBW;
        private System.Windows.Forms.ComboBox cboAMP;
        private System.Windows.Forms.ComboBox cboSWEEPTIME;
        private System.Windows.Forms.CheckBox chkEXTATT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeDir;
        private System.Windows.Forms.Label lblOutputDir;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lblScanInterval;
    }

	
}
