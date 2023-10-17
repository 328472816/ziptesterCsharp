using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ziptester.tar;
using ziptester.tool;

namespace ziptester
{
    public partial class Form1 : Office2007Form
    {

        private Work work;

        public Form1()
        {
            
            SaveCfg.LoadProfile();
            InitializeComponent();
            this.EnableGlass = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (SaveCfg.G_DEBUG == "Debug")
            {
                //调试ToolStripMenuItem.Checked = true;
                ConsoleEx.AllocConsole();
                Debug.WriteLine("启动");
                Console.WriteLine("启动");
            }

            work = new Work();
            work.WorkResultEvent += new EventHandler(WorkFinishEvent);
            work.NowWorkProgressEvent += new EventHandler(NowWorkProgressEvent);
            work.WorkGetKeyEvent += new EventHandler(WorkGetKeyFinishEvent); 
        }
        #region 拿到密钥事件响应
        private delegate void WorkGetKeyEvent(string finish);
        private void WorkGetKeyFinishEvent(object sender, EventArgs e)
        {
            string finish = (String)sender;
            WorkGetKeyEvent status = new WorkGetKeyEvent(GetKeyResult);
            this.Invoke(status, finish);
        }
        private void GetKeyResult(string result)
        {
            ListViewItem item = new ListViewItem(new string[]
            {
                                result
            });

            lv_key.Items.Insert(0, item);
            lv_key.Items.Insert(0, item); lv_key.Items.Insert(0, item);
        }
        #endregion
        #region 完成委托及事件响应
        private delegate void WorkFinish(string finish);
        private void WorkFinishEvent(object sender, EventArgs e)
        {
            string finish = (String)sender;
            WorkFinish status = new WorkFinish(TarFileResult);
            this.Invoke(status, finish);
        }
        private void TarFileResult(string result)
        {
            if (result == "OK")
            {
                MessageBox.Show("测试结束");
                this.DownloadProgressBar.Value = 0;
            }
            else if (result == "notopen")
            {
                MessageBox.Show("打开文件失败");
                this.DownloadProgressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("测试失败:"+ result);
                this.DownloadProgressBar.Value = 0;
            }
        }
        #endregion
        #region 进度委托及事件响应
        private delegate void NowWorkProgress(int nowValue);
        private void NowWorkProgressEvent(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(sender);
            NowWorkProgress count = new NowWorkProgress(WorkProgress);
            this.Invoke(count, value);
        }
        private void WorkProgress(int count)
        {
            DownloadProgressBar.Value = count;
        }
        #endregion
        

        private void rb_ram1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择压缩包";
            openFileDialog.Filter = "(*.rar)(*.7z)(*.zip)|*.rar;*.7z;*.zip";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.label4.Text = openFileDialog.FileName.ToString();
            }

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            openFileDialog1.Title = "选择密码本";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label5.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void barlink_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCfg.SaveProfile();
            Environment.Exit(0);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            work.TarPath = this.label4.Text;
            work.KeyPath = this.label5.Text;
            work.FileType = cb_type.SelectedIndex;
            System.Threading.Thread downloadThread = new System.Threading.Thread(work.worktask);
            downloadThread.Start();
        }

        private void lv_key_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lv_key_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            megshow mmegshow = new megshow(lv_key.Items[lv_key.SelectedItems[0].Index].SubItems[0].Text, lv_key.Items[lv_key.SelectedItems[0].Index].SubItems[0].Text);
            //mmegshow.MdiParent = this;
            mmegshow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv_key.Items.Clear();
        }
    }
}
