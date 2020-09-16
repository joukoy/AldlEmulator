using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AldlEmulator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private double afr = 14.7;
        byte[] emuBuff = { 0x80, 0x95, 0x1, 0x2, 0x27, 0x0, 0x0, 0x0, 0x0, 0x0, 0x60, 0x60, 0x1C, 0x0, 0x19, 0x94, 0x0, 0x20, 0xFF, 0x66, 0xE2, 0x80, 0x80, 0x1, 0x80, 0xA0, 0x80, 0xFF, 0xA0, 0x80, 0xA0, 0x4D, 0x33, 0x0, 0x0, 0x0, 0x79, 0x0, 0x5, 0x0, 0x3E, 0x0, 0x4F, 0x0, 0x33, 0x8, 0x0, 0x0, 0x0, 0x1, 0xEC, 0xEE, 0x8C, 0x0, 0x0, 0x0, 0x1, 0xD5, 0x6A, 0x60, 0x0, 0x5, 0x4, 0x6, 0x95, 0x80, 0x80, 0x1, 0x29, 0x80, 0x95, 0x1, 0x2, 0x27, 0x0, 0x0, 0x0, 0x0, 0x0, 0x60, 0x60, 0x1C, 0x0, 0x19, 0x94, 0x0, 0x20, 0xFF, 0x66, 0xE2, 0x80, 0x80, 0x1, 0x80, 0xA0, 0x80, 0xFF, 0xA0, 0x80, 0xA0, 0x4D, 0x33, 0x0, 0x0, 0x0, 0x79, 0x0, 0x5, 0x0, 0x3E, 0x0, 0x4F, 0x0, 0x33, 0x8, 0x0, 0x0, 0x0, 0x1, 0xEC, 0xEE, 0x8C, 0x0, 0x0, 0x0, 0x1, 0xD5, 0x6A, 0x60, 0x0, 0x5, 0x4, 0x6, 0x95 };

        private void btnStart_Click(object sender, EventArgs e)
        {
            setAldlValues();

            serialAldl.PortName = txtECMCom.Text;
            serialAldl.BaudRate = 8192;
            serialAldl.RtsEnable = false;
            serialAldl.Open();
            serialAldl.DataReceived += SerialAldl_DataReceived;
            serialAldl.DiscardInBuffer();

            serialAem.PortName = txtAemCom.Text;
            serialAem.BaudRate = 9600;
            serialAem.Open();

            timerAem.Enabled = true;
            btnStart.Enabled = false;
        }

        private void SerialAldl_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] inbuf = new byte[100];
            //string inBuff = serialAldl.ReadExisting();
            int p = 0;
            Debug.Write("Receiving: ");
            while (serialAldl.BytesToRead > 0 && p < 100)
            {
                inbuf[p] = (byte)serialAldl.ReadByte();
                Debug.Write(inbuf[p].ToString("X") +", ");
                p++;
            }
            Debug.WriteLine("");

            if (chkEcho.Checked)
                serialAldl.Write(inbuf, 0, p);  //RS232 echo
            if (inbuf[2] == 1)  //Mode byte
            {
                emuBuff[0] = inbuf[0];  //Message ID
                Application.DoEvents();
                serialAldl.Write(emuBuff, 0, (int)numMsgSize.Value);
            }
        }

        private void timerAem_Tick(object sender, EventArgs e)
        {
            afr += 0.1;
            if (afr > 17)
                afr = 12.0;

            string outStr = afr.ToString("00.0") + Environment.NewLine;
            outStr = outStr.Replace(',', '.');
            char[] outBuff = outStr.ToCharArray();
            serialAem.Write(outBuff, 0, outBuff.Length);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void numSpeed_ValueChanged(object sender, EventArgs e)
        {
            setAldlValues();
        }
        private void setAldlValues()
        {
            emuBuff[10] = (byte)((double)(numCoolant.Value + 40) / 0.75);
            emuBuff[12] = (byte)((double)numThrottle.Value / 0.019608);
            emuBuff[13] = (byte)(numRPM.Value / 25);
            emuBuff[16] = (byte)numSpeed.Value;
            emuBuff[45] = (byte)numKnock.Value;
            int cksum = 0;

            int cksumPos = (int)numMsgSize.Value - 1; 
            for (int i = 0; i < cksumPos; i++)
                cksum += emuBuff[i];
            emuBuff[cksumPos] = (byte)((-cksum) & 0xff);

        }

        private void numRPM_ValueChanged(object sender, EventArgs e)
        {
            setAldlValues();

        }

        private void numThrottle_ValueChanged(object sender, EventArgs e)
        {
            setAldlValues();

        }

        private void numCoolant_ValueChanged(object sender, EventArgs e)
        {
            setAldlValues();

        }

        private void numKnock_ValueChanged(object sender, EventArgs e)
        {
            setAldlValues();

        }
    }
}
