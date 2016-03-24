
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSingleFile = new System.Windows.Forms.RadioButton();
            this.rdoManyFiles = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFINDHID
            // 
            this.btnFINDHID.Location = new System.Drawing.Point(67, 651);
            this.btnFINDHID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFINDHID.Name = "btnFINDHID";
            this.btnFINDHID.Size = new System.Drawing.Size(100, 31);
            this.btnFINDHID.TabIndex = 0;
            this.btnFINDHID.Text = "button1";
            this.btnFINDHID.UseVisualStyleBackColor = true;
            this.btnFINDHID.Click += new System.EventHandler(this.btnFINDHID_Click);
            // 
            // btnGETSN
            // 
            this.btnGETSN.Location = new System.Drawing.Point(204, 650);
            this.btnGETSN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGETSN.Name = "btnGETSN";
            this.btnGETSN.Size = new System.Drawing.Size(100, 31);
            this.btnGETSN.TabIndex = 1;
            this.btnGETSN.Text = "button2";
            this.btnGETSN.UseVisualStyleBackColor = true;
            this.btnGETSN.Click += new System.EventHandler(this.btnGETSN_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(335, 651);
            this.btnSTART.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(100, 31);
            this.btnSTART.TabIndex = 2;
            this.btnSTART.Text = "button3";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.Location = new System.Drawing.Point(456, 651);
            this.btnSTOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(100, 31);
            this.btnSTOP.TabIndex = 3;
            this.btnSTOP.Text = "button4";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(581, 650);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(100, 31);
            this.btnEXIT.TabIndex = 4;
            this.btnEXIT.Text = "button5";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // txtRESULT
            // 
            this.txtRESULT.Location = new System.Drawing.Point(16, 313);
            this.txtRESULT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRESULT.Multiline = true;
            this.txtRESULT.Name = "txtRESULT";
            this.txtRESULT.Size = new System.Drawing.Size(916, 293);
            this.txtRESULT.TabIndex = 5;
            // 
            // lblFREQ
            // 
            this.lblFREQ.AutoSize = true;
            this.lblFREQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFREQ.Location = new System.Drawing.Point(16, 14);
            this.lblFREQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFREQ.Name = "lblFREQ";
            this.lblFREQ.Size = new System.Drawing.Size(137, 15);
            this.lblFREQ.TabIndex = 6;
            this.lblFREQ.Text = "Center Frequency(MHz)";
            // 
            // lblSTEP
            // 
            this.lblSTEP.AutoSize = true;
            this.lblSTEP.Location = new System.Drawing.Point(235, 14);
            this.lblSTEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTEP.Name = "lblSTEP";
            this.lblSTEP.Size = new System.Drawing.Size(67, 16);
            this.lblSTEP.TabIndex = 7;
            this.lblSTEP.Text = "Step(kHz)";
            // 
            // lblRBW
            // 
            this.lblRBW.AutoSize = true;
            this.lblRBW.Location = new System.Drawing.Point(456, 76);
            this.lblRBW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRBW.Name = "lblRBW";
            this.lblRBW.Size = new System.Drawing.Size(40, 16);
            this.lblRBW.TabIndex = 8;
            this.lblRBW.Text = "RBW";
            // 
            // lblPOINTS
            // 
            this.lblPOINTS.AutoSize = true;
            this.lblPOINTS.Location = new System.Drawing.Point(456, 14);
            this.lblPOINTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPOINTS.Name = "lblPOINTS";
            this.lblPOINTS.Size = new System.Drawing.Size(110, 16);
            this.lblPOINTS.TabIndex = 9;
            this.lblPOINTS.Text = "Number of Points";
            // 
            // lblAMP
            // 
            this.lblAMP.AutoSize = true;
            this.lblAMP.Location = new System.Drawing.Point(19, 76);
            this.lblAMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAMP.Name = "lblAMP";
            this.lblAMP.Size = new System.Drawing.Size(68, 16);
            this.lblAMP.TabIndex = 10;
            this.lblAMP.Text = "Amplitude";
            // 
            // lblSWEEPTIME
            // 
            this.lblSWEEPTIME.AutoSize = true;
            this.lblSWEEPTIME.Location = new System.Drawing.Point(237, 76);
            this.lblSWEEPTIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSWEEPTIME.Name = "lblSWEEPTIME";
            this.lblSWEEPTIME.Size = new System.Drawing.Size(84, 16);
            this.lblSWEEPTIME.TabIndex = 11;
            this.lblSWEEPTIME.Text = "Sweep Time";
            // 
            // txtFREQ
            // 
            this.txtFREQ.Location = new System.Drawing.Point(16, 33);
            this.txtFREQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFREQ.Name = "txtFREQ";
            this.txtFREQ.Size = new System.Drawing.Size(180, 22);
            this.txtFREQ.TabIndex = 12;
            // 
            // txtSTEP
            // 
            this.txtSTEP.Location = new System.Drawing.Point(235, 33);
            this.txtSTEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSTEP.Name = "txtSTEP";
            this.txtSTEP.Size = new System.Drawing.Size(187, 22);
            this.txtSTEP.TabIndex = 13;
            // 
            // txtPOINTS
            // 
            this.txtPOINTS.Location = new System.Drawing.Point(459, 33);
            this.txtPOINTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPOINTS.Name = "txtPOINTS";
            this.txtPOINTS.Size = new System.Drawing.Size(213, 22);
            this.txtPOINTS.TabIndex = 14;
            // 
            // cboRBW
            // 
            this.cboRBW.FormattingEnabled = true;
            this.cboRBW.Location = new System.Drawing.Point(459, 96);
            this.cboRBW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRBW.Name = "cboRBW";
            this.cboRBW.Size = new System.Drawing.Size(213, 24);
            this.cboRBW.TabIndex = 15;
            // 
            // cboAMP
            // 
            this.cboAMP.FormattingEnabled = true;
            this.cboAMP.Location = new System.Drawing.Point(16, 96);
            this.cboAMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAMP.Name = "cboAMP";
            this.cboAMP.Size = new System.Drawing.Size(180, 24);
            this.cboAMP.TabIndex = 16;
            // 
            // cboSWEEPTIME
            // 
            this.cboSWEEPTIME.FormattingEnabled = true;
            this.cboSWEEPTIME.Location = new System.Drawing.Point(235, 96);
            this.cboSWEEPTIME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSWEEPTIME.Name = "cboSWEEPTIME";
            this.cboSWEEPTIME.Size = new System.Drawing.Size(187, 24);
            this.cboSWEEPTIME.TabIndex = 17;
            // 
            // chkEXTATT
            // 
            this.chkEXTATT.AutoSize = true;
            this.chkEXTATT.Location = new System.Drawing.Point(43, 150);
            this.chkEXTATT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEXTATT.Name = "chkEXTATT";
            this.chkEXTATT.Size = new System.Drawing.Size(93, 20);
            this.chkEXTATT.TabIndex = 18;
            this.chkEXTATT.Text = "checkBox1";
            this.chkEXTATT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOutputDir);
            this.groupBox1.Location = new System.Drawing.Point(16, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(917, 74);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Output Directory";
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoEllipsis = true;
            this.lblOutputDir.Location = new System.Drawing.Point(8, 21);
            this.lblOutputDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(901, 39);
            this.lblOutputDir.TabIndex = 2;
            this.lblOutputDir.Text = "No Directory Selected:  Select a valid output directory to enable start button";
            this.lblOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeDir
            // 
            this.btnChangeDir.Location = new System.Drawing.Point(16, 265);
            this.btnChangeDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeDir.Name = "btnChangeDir";
            this.btnChangeDir.Size = new System.Drawing.Size(917, 41);
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
            this.nudInterval.Location = new System.Drawing.Point(711, 96);
            this.nudInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(223, 22);
            this.nudInterval.TabIndex = 20;
            this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblScanInterval
            // 
            this.lblScanInterval.AutoSize = true;
            this.lblScanInterval.Location = new System.Drawing.Point(711, 76);
            this.lblScanInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanInterval.Name = "lblScanInterval";
            this.lblScanInterval.Size = new System.Drawing.Size(164, 16);
            this.lblScanInterval.TabIndex = 21;
            this.lblScanInterval.Text = "Time Between Scans (ms)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSingleFile);
            this.groupBox2.Controls.Add(this.rdoManyFiles);
            this.groupBox2.Location = new System.Drawing.Point(380, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(553, 58);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ouput Option";
            // 
            // rdoSingleFile
            // 
            this.rdoSingleFile.Checked = true;
            this.rdoSingleFile.Location = new System.Drawing.Point(300, 21);
            this.rdoSingleFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSingleFile.Name = "rdoSingleFile";
            this.rdoSingleFile.Size = new System.Drawing.Size(199, 30);
            this.rdoSingleFile.TabIndex = 1;
            this.rdoSingleFile.TabStop = true;
            this.rdoSingleFile.Text = "One File Per Session";
            this.rdoSingleFile.UseVisualStyleBackColor = true;
            // 
            // rdoManyFiles
            // 
            this.rdoManyFiles.Location = new System.Drawing.Point(36, 21);
            this.rdoManyFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoManyFiles.Name = "rdoManyFiles";
            this.rdoManyFiles.Size = new System.Drawing.Size(207, 30);
            this.rdoManyFiles.TabIndex = 0;
            this.rdoManyFiles.Text = "One File Per Scan";
            this.rdoManyFiles.UseVisualStyleBackColor = true;
            this.rdoManyFiles.CheckedChanged += new System.EventHandler(this.RdoManyFilesCheckedChanged);
            // 
            // SpectrumAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(949, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnChangeDir);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox2.ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdoSingleFile;
		private System.Windows.Forms.RadioButton rdoManyFiles;
    }

	
}
