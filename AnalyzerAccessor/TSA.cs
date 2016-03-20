﻿using System;
using System.Linq;
using System.Runtime.InteropServices;
namespace SpectrumAnalyzerService
{
    public class TSA
    {
        [DllImport("TSA.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public extern static IntPtr Get_Hid_Handle();
        [DllImport("TSA.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public extern static Byte Output_Serial_Number(ref Byte dir_path, ref Byte sn);
        [DllImport("TSA.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public extern static Byte Stop_Dongle(IntPtr hDongle);
        [DllImport("TSA.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public extern static Byte Start_Dongle(IntPtr hDongle, Double C_FREQ, UInt32 STEP, Byte iRBW, UInt16 POINTS, Byte AMP, Byte SWEEP_TIME, Byte EXT_ATT, ref Byte dir_path);
        [DllImport("TSA.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public extern static Byte Receive_Data_From_Dongle(IntPtr hDongle, ref Int32 ID, ref Double rev_data, ref Int32 Data_Length);
    }
}