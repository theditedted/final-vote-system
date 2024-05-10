using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprint_form
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        public Form1()
        {
            InitializeComponent();
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Action(delegate ()
            {
                StatusText.Text = message;
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (Capturer != null)
                {
                    Capturer.EventHandler = this;
                    MakeReport("Press Start Capture to Start Scanning.");
                }
           
                else
                {
                    MakeReport("Can't initiate Operation.");
                }


            }
            catch
            {
                MessageBox.Show("Cant Capture Initiate Operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OnReaderConnect(object Capture,string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint Reader Was Connected.");
        }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint Reader Was Disconnected.");
        }
        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint Was Remove From the Fingerprint Readeer.");
        }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Luway sanang duon");
        }
        public void OnComplete(object Capture, string ReaderSerialNumber,DPFP.Sample Sample)
        {
            MakeReport("The Fingerprint sample was completed");
            Process (Sample);
        }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good");
            else
                MakeReport("The quality of the fingerprint sample is poor");
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitMap(Sample));
        }
        protected Bitmap ConvertSampleToBitMap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);

            return bitmap;
        }
        private void DrawPicture(Bitmap bitmap)
        {
            fImage.Image = new Bitmap(bitmap, fImage.Size);
        }
        private void Button1_Click(object sender,EventArgs e)
        {
            if(Capturer !=null)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Using the fingerprint reader,scan your fingerprint.");
                }
                catch
                {
                    MakeReport("Can't initiate Capture");
                }
            }
        }


    }
}
