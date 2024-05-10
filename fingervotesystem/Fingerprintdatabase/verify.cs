using DPFP;
using K4os.Compression.LZ4.Streams.Frames;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprintdatabase
{
    public partial class verify : Capture
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        protected override void Process(Sample Sample)
        {
            try
            {
                string MyConnection = "host=localhost;username=thedskie;password=password15;database=fingerset";
                string Query = "Select = FROM testdb.members  ";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                MySqlDataReader myReader;
                MyConn.Open();
                myReader = MyCommand.ExecuteReader();

                foreach (DataRow row in dTable.Rows)
                {
                    byte[] _img_ = (byte[])row["finger_print"];
                    MemoryStream ms = new MemoryStream(_img_);

                    DPFP.Template Template = new DPFP.Template();
                    Template.DeSerialize(ms);

                    base.Process(Sample);

                    DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                    if (features != null)
                    {
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        Verificator.Verify(features, Template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            MakeReport("The fingerprint was Verified as" + row["firstname"].ToString());
                            Setfirstname(row["firstname"].ToString());
                            MyConn.Close();
                            break;


                        }
                        else
                        {
                            MakeReport("The fingerprint was Not Verified:");
                            Setfirstname("No Data");
                            MyConn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }
        protected void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept Rate(FAR)={0}", FAR));
        }
    }
}
