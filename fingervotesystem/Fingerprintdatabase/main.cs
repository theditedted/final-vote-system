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
    delegate void Function();
    public partial class main : Form
    {
        private DPFP.Template Template;
        public main()
        {
            InitializeComponent();
        }


        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                if (Template !=null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification","Fingerprint Enrollment");
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid:Repeat fingerprint scanning","Fingerprint Enrollment");
                }

            }));
            


        }

        private void Enroll_btn_Click(object sender, EventArgs e)
        {
            Enroll EnFrm = new Enroll();
            EnFrm.OnTemplate += this.OnTemplate;
            EnFrm.Show();
        }

        private void Ver_btn_Click(object sender, EventArgs e)
        {
            verify VFrm = new verify();
            VFrm.Verify(Template);
        }
    }
}