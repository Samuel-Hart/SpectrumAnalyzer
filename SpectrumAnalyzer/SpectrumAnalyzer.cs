using System;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SpectrumAnalyzerService;

namespace SpectrumAnalyzer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class SpectrumAnalyzer : Form
	{
		IntPtr hDongle;
		Thread Read_Data;
		//Thread Write_Data;
		bool SingleFile;
		bool InitialWrite;
        
		private string OutputDirectory = string.Empty;
		private string OutputFilePath = string.Empty;
        
		public SpectrumAnalyzer()
		{
			InitializeComponent();
		}

		void Label_Initialize()
		{
			lblFREQ.Text = "Center Frequency(MHz)";
			lblSTEP.Text = "Step(kHz)";
			lblRBW.Text = "RBW";
			lblPOINTS.Text = "Number of Points";
			lblAMP.Text = "Amplitude";
			lblSWEEPTIME.Text = "Sweep Time";
			lblOutputDir.Text = "No Directory Selected:  Select a valid output directory to enable start button";
			lblOutputDir.TextAlign = ContentAlignment.MiddleCenter;
		}

		void ComboBox_Initialize()
		{
			cboRBW.Items.Add("50M");
			cboRBW.Items.Add("100M");
			cboRBW.Items.Add("200M");
			cboRBW.Items.Add("500M");

			cboRBW.DropDownStyle = ComboBoxStyle.DropDownList;
			cboRBW.SelectedIndex = 0;

			for (int i = -60; i <= 0; i = i + 10) {
				cboAMP.Items.Add(i);
			}

			cboAMP.DropDownStyle = ComboBoxStyle.DropDownList;
			cboAMP.SelectedIndex = 6;

			cboSWEEPTIME.Items.Add("x1  (CW Mode)");
			cboSWEEPTIME.Items.Add("x1.5  (Burst Mode)");
			cboSWEEPTIME.Items.Add("x2  (Burst Mode)");
			cboSWEEPTIME.Items.Add("x4  (Burst Mode)");
			cboSWEEPTIME.Items.Add("x8  (Burst Mode)");
			cboSWEEPTIME.Items.Add("x16  (Burst Mode)");
			cboSWEEPTIME.Items.Add("x32  (Burst Mode)");

			cboSWEEPTIME.DropDownStyle = ComboBoxStyle.DropDownList;
			cboSWEEPTIME.SelectedIndex = 0;

		}

		void CheckBox_Initialize()
		{
			chkEXTATT.Text = "30dB External Attenuator";
			chkEXTATT.AutoSize = true;
			chkEXTATT.ThreeState = false;
			chkEXTATT.Checked = false;
		}

		void Button_Initialize()
		{
			btnFINDHID.Text = "Find HID";
			btnFINDHID.BackColor = themeSettings.Background;
            
			btnSTART.Text = "Start";
			btnSTART.Enabled = false;
			btnSTART.BackColor = themeSettings.ButtonErr;
            
			btnSTOP.Text = "Stop";
			btnSTOP.Enabled = false;
			btnSTOP.BackColor = themeSettings.ButtonErr;
            
			btnEXIT.Text = "Exit";
			btnEXIT.BackColor = themeSettings.Background;
            
			btnGETSN.Text = "Get SN";
			btnGETSN.BackColor = themeSettings.Background;
            
			btnChangeDir.Text = "Set Output Directory";
			btnChangeDir.BackColor = themeSettings.Highlight;
            
			foreach (Button btn in Controls.OfType<Button>()) {
				btn.FlatStyle = FlatStyle.Popup;
			}
		}

		void TextBox_Initialize()
		{
			txtFREQ.Text = "1000";
			txtSTEP.Text = "10000";
			txtPOINTS.Text = "201";
		}

		void Controls_Font_Initialize()
		{
			foreach (Control control in Controls) {
				control.Font = themeSettings.ControlFont;
			}
		}

		void Controls_Location_Initialize()
		{
			var size = new Size(100, 30);
            
			foreach (Button btn in Controls.OfType<Button>()) {
				if (btn != btnChangeDir)
					btn.Size = size;		
			}

			int span = size.Width + (txtRESULT.Size.Width - size.Width * 5) / 4;
            
			var x = txtRESULT.Location.X;
			var y = txtRESULT.Location.Y + txtRESULT.Size.Height + 10;
            
			btnFINDHID.Location = new Point(x, y);
			btnGETSN.Location = new Point(x + span, y);
			btnSTART.Location = new Point(x + 2 * span, y);
			btnSTOP.Location = new Point(x + 3 * span, y);
			btnEXIT.Location = new Point(x + 4 * span, y);
            
		}

		String Return_Error_Description(Byte err)
		{
			String Err__Description = "Unknown Error";

			if (0 == err) {
				Err__Description = "Everything is OK!";
			} else if (1 == err) {
				Err__Description = "To send command fail!";
			} else if (2 == err) {
				Err__Description = "File is missing!";
			} else if (3 == err) {
				Err__Description = "File's format is wrong!";
			} else if (4 == err) {
				Err__Description = "Frequency is wrong!";
			} else if (5 == err) {
				Err__Description = "Step is wrong!";
			} else if (6 == err) {
				Err__Description = "RBW is wrong!";
			} else if (7 == err) {
				Err__Description = "Points number is wrong!";
			} else if (8 == err) {
				Err__Description = "Amplitude is wrong!";
			} else if (9 == err) {
				Err__Description = "Sweep Time is wrong!";
			} else if (10 == err) {
				Err__Description = "External Attenuator is wrong!";
			} else if (11 == err) {
				Err__Description = "Frequency limit is wrong!";
			} else if (12 == err) {
				Err__Description = "850MHz frequency is wrong!";
			}

			return Err__Description;
		}

		private void SpectrumAnalyzer_Load(object sender, EventArgs e)
		{
			this.Text = "Spectrum Analyzer Control Panel";
            
			this.BackColor = themeSettings.Background;
			this.ForeColor = themeSettings.Foreground;
            
			Label_Initialize();
			ComboBox_Initialize();
			CheckBox_Initialize();
			Button_Initialize();
			TextBox_Initialize();
			Controls_Font_Initialize();
			Controls_Location_Initialize();

			this.Height = btnEXIT.Location.Y + 2 * btnEXIT.Height + SystemInformation.CaptionHeight;
            
			this.MinimumSize = this.Size;
			SingleFile = rdoSingleFile.Checked;
			
            
			CheckForIllegalCrossThreadCalls = false;

		}

		private void btnFINDHID_Click(object sender, EventArgs e)
		{
			hDongle = TSA.Get_Hid_Handle();

			if ((IntPtr)0 == hDongle) {
				txtRESULT.Text = "Can't find USB Dongle!";
			} else {
				txtRESULT.Text = "Found USB Dongle! The handle is " + hDongle.ToString();
			}
		}

		private void btnGETSN_Click(object sender, EventArgs e)
		{
			string DIR_PATH = Application.StartupPath;

			byte[] bytDIR_PATH = System.Text.Encoding.ASCII.GetBytes(DIR_PATH);

			byte[] bytSN = new byte[10];

			Byte x = TSA.Output_Serial_Number(ref bytDIR_PATH[0], ref bytSN[0]);

			if (0 == x) {
				txtRESULT.Text = "Can't find Serial Number!";
			} else {
				string SN = (System.Text.Encoding.ASCII.GetString(bytSN, 0, bytSN.Length)).TrimEnd();
				txtRESULT.Text = "Serial Number is " + SN;
			}
		}

		private void btnSTART_Click(object sender, EventArgs e)
		{
			InitialWrite = true;
			
			if ((IntPtr)0 == hDongle) {
				txtRESULT.Text = "Handle is Null";
			} else {
				Double C_FREQ = double.Parse(txtFREQ.Text);
				UInt32 STEP = UInt32.Parse(txtSTEP.Text);
				Byte iRBW = (Byte)(cboRBW.SelectedIndex + 1);
				UInt16 POINTS = UInt16.Parse(txtPOINTS.Text);
				Byte AMP = (Byte)cboAMP.SelectedIndex;
				Byte SWEEP_TIME = (Byte)cboSWEEPTIME.SelectedIndex;
				Byte EXT_ATT = 0;
				if (true == chkEXTATT.Checked) {
					EXT_ATT = 1;
				}

				string DIR_PATH = Application.StartupPath;

				byte[] bytDIR_PATH = System.Text.Encoding.ASCII.GetBytes(DIR_PATH);

				Byte result = TSA.Start_Dongle(hDongle, C_FREQ, STEP, iRBW, POINTS, AMP, SWEEP_TIME, EXT_ATT, ref bytDIR_PATH[0]);

				if (result == 0) {
					txtRESULT.Text = "Start Dongle";

					bool Flag;
					Flag = false;

					if ((Read_Data == null) || (Read_Data.IsAlive == false)) {
						Read_Data = new Thread(new ThreadStart(Read_Data_Thread_Start));
						Read_Data.IsBackground = true;
						Flag = true;
					} else {
						if (Read_Data.ThreadState == ThreadState.Aborted)
							Flag = true;
					}

					if (Flag) 
					{  
						DisableInputControls();  //Keep the user from fiddling with inputs
						
						SingleFile = rdoSingleFile.Checked;
						InitialWrite = true;
						Read_Data.Start();
                    
					}
				} else
					txtRESULT.Text = Return_Error_Description(result);
			}
		}

		void Read_Data_Thread_Start()
		{
			int waitInterval = (int)nudInterval.Value;
			bool threadShouldSleep = waitInterval > 0;
            
			if (OutputDirectory == string.Empty)
				OutputDirectory = Application.StartupPath;
            
			if (threadShouldSleep) 
			{
				do {
					Read_Data_From_Dongle();
					Thread.Sleep(waitInterval);
				} while (true);
			}
			
			else
			{
				do {
					Read_Data_From_Dongle();
				} while (true);
			}
		}

		void Read_Data_From_Dongle()
		{
			Int32 ID = 0;
			Int32 Data_Length = 0;
			Double[] data = new Double[61];

			Byte result = TSA.Receive_Data_From_Dongle(hDongle, ref ID, ref data[0], ref Data_Length);
			string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            
			if (SingleFile)
			{    
				if(InitialWrite)
				{
					OutputFilePath = OutputDirectory+"\\"+timestamp+".csv";
					InitialWrite = false;
				}
				
				Write_To_File(ID, Data_Length, data, OutputFilePath, timestamp);
			}
			else
				Write_To_File(ID, Data_Length, data, OutputDirectory+"\\"+timestamp+".csv", timestamp);
			
			txtRESULT.Text = txtRESULT.Text + Environment.NewLine + "ID:" + ID.ToString();
			txtRESULT.Text = txtRESULT.Text + Environment.NewLine + "Data_Length:" + Data_Length.ToString();
			txtRESULT.Text = txtRESULT.Text + Environment.NewLine + "Data:" + Environment.NewLine;

			for (Byte i = 0; i < Data_Length; i++) {
				txtRESULT.Text = txtRESULT.Text + data[i] + "   ";
			}
		}

		private void Write_To_File(Int32 ID, Int32 Data_Length, Double[] data, string FILE_PATH, string timestamp)
		{
			FileInfo outputFile;
			StreamWriter SW;
	
			if (!File.Exists(FILE_PATH)) {
				FileStream FS = new FileStream(FILE_PATH, FileMode.Create);

				FS.Close();
				FS.Dispose();

				outputFile = new FileInfo(FILE_PATH);
				SW = outputFile.AppendText();

				SW.WriteLine("Row Format: Timestamp, ID, Data Length, Data Values");

			}
			else
			{
				outputFile = new FileInfo(FILE_PATH);
				SW = outputFile.AppendText();	
			}

			SW.Write(timestamp + ", ");
			SW.Write(ID);
			SW.Write(", ");
			SW.Write(Data_Length);
			SW.Write(", ");
                
			for (Byte i = 0; i < Data_Length; i++) 
			{ 
				SW.Write(data[i]);
				SW.Write(", ");
			}
			SW.WriteLine();
                
			SW.Close();
            
		}

		private void btnSTOP_Click(object sender, EventArgs e)
		{
			if ((IntPtr)0 == hDongle) {
				txtRESULT.Text = "Handle is Null";
			} else {
				Byte result = TSA.Stop_Dongle(hDongle);
				Read_Data_Thread_Abort();

				if (0 == result) {
					txtRESULT.Text = txtRESULT.Text + Environment.NewLine + "Stop dongle!";
				} else {
					txtRESULT.Text = Return_Error_Description(result);
				}
			}
			
			EnableInputControls();
		}

		private void btnEXIT_Click(object sender, EventArgs e)
		{
			Read_Data_Thread_Abort();
			Dispose();
		}

		private void SpectrumAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
		{
			Read_Data_Thread_Abort();
			Dispose();
		}

		private void Read_Data_Thread_Abort()
		{
			if (Read_Data != null) {
				if (Read_Data.ThreadState != ThreadState.Aborted) {
					Read_Data.Abort();
				}

			}
 
		}
		void BtnChangeDirClick(object sender, EventArgs e)
		{
			string folderpath = String.Empty;
            
			FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            
			DialogResult dr = fbd.ShowDialog();
 
			if (dr != DialogResult.OK)
				return;
            
			folderpath = fbd.SelectedPath;
            
			if (folderpath == String.Empty)
				return;
            
			lblOutputDir.Text = folderpath;
            
			OutputDirectory = folderpath;
            
			btnSTART.Enabled = true;
			btnSTART.BackColor = themeSettings.Background;
			btnSTOP.Enabled = true;
			btnSTOP.BackColor = themeSettings.Background;
            
			foreach (Button btn in Controls.OfType<Button>()) {	
				btn.BackColor = !btn.Enabled ? themeSettings.ButtonErr : themeSettings.Background;
			}
            
		}
        
		void RdoManyFilesCheckedChanged(object sender, EventArgs e)
		{
			rdoSingleFile.Checked = !rdoManyFiles.Checked;
			SingleFile = rdoSingleFile.Checked;
		}
        
		private void EnableInputControls()
		{
			foreach (Control ctrl in Controls) {	
				if (!(ctrl is Label))
					ctrl.Enabled = true;
			}
            
			
			foreach (Button btn in Controls.OfType<Button>()) {
				if (!btn.Enabled)
					btn.BackColor = themeSettings.ButtonErr;
				else
					btn.BackColor = themeSettings.Background;
			}
            
			btnSTART.Focus();
		}
		
		private void DisableInputControls()
		{
			foreach (Control ctrl in Controls) {	
				if (!(ctrl is Label))
					ctrl.Enabled = false;
			}
            
			btnSTOP.Enabled = true;
			btnEXIT.Enabled = true;
			txtRESULT.Enabled = true;

			foreach (Button btn in Controls.OfType<Button>()) {
				if (!btn.Enabled)
					btn.BackColor = themeSettings.ButtonErr;
				else
					btn.BackColor = themeSettings.Highlight;
			}
            
			btnSTOP.Focus();
		}

	}

	public static class themeSettings
	{
		public static Color Background = Color.WhiteSmoke;
		public static Color Foreground = Color.DarkSlateGray;
		public static Color ButtonErr = Color.LightSlateGray;
		public static Color Highlight = Color.LightSkyBlue;
		public static Font ControlFont = new Font(Control.DefaultFont.FontFamily, 9);
        
	}

}
