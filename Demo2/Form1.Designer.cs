namespace Demo2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.open_button = new System.Windows.Forms.Button();
            this.ROI_Button = new System.Windows.Forms.Button();
            this.count_button = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.reduce_num = new System.Windows.Forms.Button();
            this.add_num = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.data = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(59, 133);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(730, 494);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(730, 494);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(20, 35);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(162, 44);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "选择图片";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // ROI_Button
            // 
            this.ROI_Button.Location = new System.Drawing.Point(20, 102);
            this.ROI_Button.Name = "ROI_Button";
            this.ROI_Button.Size = new System.Drawing.Size(162, 44);
            this.ROI_Button.TabIndex = 2;
            this.ROI_Button.Text = "ROI选择";
            this.ROI_Button.UseVisualStyleBackColor = true;
            this.ROI_Button.Click += new System.EventHandler(this.ROI_Button_Click);
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(20, 184);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(162, 44);
            this.count_button.TabIndex = 3;
            this.count_button.Text = "统计计数";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(36, 46);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(131, 43);
            this.result.TabIndex = 4;
            // 
            // reduce_num
            // 
            this.reduce_num.Location = new System.Drawing.Point(11, 114);
            this.reduce_num.Name = "reduce_num";
            this.reduce_num.Size = new System.Drawing.Size(162, 35);
            this.reduce_num.TabIndex = 6;
            this.reduce_num.Text = "减少1";
            this.reduce_num.UseVisualStyleBackColor = true;
            this.reduce_num.Click += new System.EventHandler(this.reduce_num_Click);
            // 
            // add_num
            // 
            this.add_num.Location = new System.Drawing.Point(11, 46);
            this.add_num.Name = "add_num";
            this.add_num.Size = new System.Drawing.Size(162, 40);
            this.add_num.TabIndex = 5;
            this.add_num.Text = "增加1";
            this.add_num.UseVisualStyleBackColor = true;
            this.add_num.Click += new System.EventHandler(this.add_num_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(20, 306);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(162, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(314, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 30);
            this.title.TabIndex = 8;
            this.title.Text = "图像显示区域";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.BackColor = System.Drawing.Color.Transparent;
            this.path.ForeColor = System.Drawing.SystemColors.Desktop;
            this.path.Location = new System.Drawing.Point(69, 98);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 18);
            this.path.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.open_button);
            this.groupBox1.Controls.Add(this.ROI_Button);
            this.groupBox1.Controls.Add(this.count_button);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(1036, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 372);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像处理操作";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.add_num);
            this.groupBox2.Controls.Add(this.reduce_num);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(834, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据补偿";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(887, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 44);
            this.label2.TabIndex = 13;
            this.label2.Text = "棒材识别系统";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(1036, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 115);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "结果显示";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.Location = new System.Drawing.Point(829, 108);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(96, 28);
            this.data.TabIndex = 15;
            this.data.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ID_text);
            this.groupBox4.Controls.Add(this.ID);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Controls.Add(this.name_text);
            this.groupBox4.Location = new System.Drawing.Point(834, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 146);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(11, 105);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(44, 18);
            this.ID.TabIndex = 2;
            this.ID.Text = "工号";
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(61, 102);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(93, 28);
            this.ID_text.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(11, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 18);
            this.name.TabIndex = 1;
            this.name.Text = "姓名";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(61, 35);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(93, 28);
            this.name_text.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(59, 633);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(730, 161);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "时间";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "工号";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "棒材数量";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 831);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.title);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button ROI_Button;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button reduce_num;
        private System.Windows.Forms.Button add_num;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

