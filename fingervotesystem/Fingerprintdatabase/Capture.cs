using DPFP;
using DPFP.Capture;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprintdatabase
{
    public partial class Capture : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        public string FirstName = "";
        public Capture()
        {
            InitializeComponent();
        }
        private void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate ()
            {
                Prompt.Text = prompt;
            }));
        }
        public void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                statuslabel.Text = status;
            }));
        }
        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                fImage.Image = new Bitmap(bitmap, fImage.Size);
            }));
        }
        protected void Setfirstname(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                firstname.Text = value;
            }));
        }
        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                }
                else
                    SetPrompt("Can't initiate capture application");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't initiate capture application:"+ex.Message);
            }
        }

        //process
        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }
       
        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }
        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the finger,scan your fingerprint");
                }
                catch
                {
                    SetPrompt("Can't initiate capture");
                }
            }
        }
        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                    Timer1.Dispose();
                }
                catch
                {
                    SetPrompt("Can't initiate capture");
                }
            }
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                statustext.AppendText(message + "\r\n");
            }));
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample,Purpose,ref feedback,ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;

        }
        

        public void OnComplete(object Capture, string ReaderSerialNumber,DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint was remove on fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint reader was touched");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint reader was Connected");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The Fingerprint reader was Disconnected");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber,DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint capture is good.");
            else
                MakeReport("The quality of the fingerprint capture is good.");
        }


        private void Startscan_Click(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }

        private void Capture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
        private void Capture_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {
            FirstName = firstname.Text;
        }
    }
}
