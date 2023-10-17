namespace ziptester
{
    partial class megshow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxshowtopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxshowmeg = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主题";
            this.label1.Visible = false;
            // 
            // textBoxshowtopic
            // 
            this.textBoxshowtopic.Location = new System.Drawing.Point(84, 55);
            this.textBoxshowtopic.Name = "textBoxshowtopic";
            this.textBoxshowtopic.ReadOnly = true;
            this.textBoxshowtopic.Size = new System.Drawing.Size(100, 21);
            this.textBoxshowtopic.TabIndex = 1;
            this.textBoxshowtopic.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "消息";
            // 
            // textBoxshowmeg
            // 
            this.textBoxshowmeg.Location = new System.Drawing.Point(84, 104);
            this.textBoxshowmeg.Multiline = true;
            this.textBoxshowmeg.Name = "textBoxshowmeg";
            this.textBoxshowmeg.ReadOnly = true;
            this.textBoxshowmeg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxshowmeg.Size = new System.Drawing.Size(350, 244);
            this.textBoxshowmeg.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.rbRcvStr);
            this.groupBox8.Controls.Add(this.rbRcv16);
            this.groupBox8.Location = new System.Drawing.Point(33, 40);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(276, 36);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "接收数据格式";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "无间隔16进制";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbRcv16_CheckedChanged);
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Checked = true;
            this.rbRcvStr.Location = new System.Drawing.Point(72, 14);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 2;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            this.rbRcvStr.CheckedChanged += new System.EventHandler(this.rbRcv16_CheckedChanged);
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(9, 14);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 1;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            this.rbRcv16.CheckedChanged += new System.EventHandler(this.rbRcv16_CheckedChanged);
            // 
            // megshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 389);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.textBoxshowmeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxshowtopic);
            this.Controls.Add(this.label1);
            this.Name = "megshow";
            this.Text = "megshow";
            this.Load += new System.EventHandler(this.megshow_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxshowtopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxshowmeg;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}