
using System;
using System.Threading;
using SpectrumAnalyzerClient;
	
namespace SpectrumAnalyzerService
{
	/// <summary>
	/// Description of SpectrumAnalyzerServiceManager.
	/// </summary>
	public class SpectrumAnalyzerServiceManager
	{
		IntPtr hDongle;  		 	//TSA Dongle ID
        Thread Read_Data;  		 	//Handle for thread used to read data from dongle.
        
        SpectrumAnalyzerViewModel spectrumAnalyzerVM;
		
		public SpectrumAnalyzerServiceManager(SpectrumAnalyzerViewModel vm)
		{
			spectrumAnalyzerVM = vm;
		}
		
		public IntPtr GetHardwareID()
		{
			hDongle = TSA.Get_Hid_Handle();

            if ((IntPtr)0 == hDongle)
            { txtRESULT.Text = "Can't find USB Dongle!"; }
            else
            { txtRESULT.Text = "Find USB Dongle! The handle is " + hDongle.ToString(); }
            
            return hDongle;
			
		}
	}
}
