using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ziptester
{
    public partial class megshow : Form
    {
        public megshow(String topic, String meg)
        {
            InitializeComponent();
            this.textBoxshowtopic.Text = topic;
            this.textBoxshowmeg.Text = meg;
        }
        enum Outstrtype
        {
            ostring,
            ohex,
            onothex
        }
        Outstrtype mOutstrtype = Outstrtype.ostring;
        private void rbRcvStr_CheckedChanged(object sender, EventArgs e)
        {
            //  textBoxshowmeg.Text = Conver.hex2str(textBoxshowmeg.Text);
        }

        private void rbRcv16_CheckedChanged(object sender, EventArgs e)
        {
            //   if (rbRcv16.Checked)
            //        textBoxshowmeg.Text = Conver.str2hex(textBoxshowmeg.Text);
            //    else
            //        textBoxshowmeg.Text = Conver.hex2str(textBoxshowmeg.Text);

            try
            {
                if (rbRcv16.Checked)//hex
                {

                }
                else if (rbRcvStr.Checked)//str
                {

                }
                else if (radioButton1.Checked)//nothex
                {

                }
            }
            catch
            {
                MessageBox.Show("保证正确输入");
                this.Close();
            }
        }

        private void megshow_Load(object sender, EventArgs e)
        {

        }
    }
}
