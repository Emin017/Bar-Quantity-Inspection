﻿namespace Demo2
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
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.open_button = new System.Windows.Forms.Button();
            this.ROI_Button = new System.Windows.Forms.Button();
            this.count_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reduce_num = new System.Windows.Forms.Button();
            this.add_num = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(0, 1);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(770, 775);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(770, 775);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(863, 48);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(162, 44);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "选择图片";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // ROI_Button
            // 
            this.ROI_Button.Location = new System.Drawing.Point(863, 123);
            this.ROI_Button.Name = "ROI_Button";
            this.ROI_Button.Size = new System.Drawing.Size(162, 44);
            this.ROI_Button.TabIndex = 2;
            this.ROI_Button.Text = "ROI选择";
            this.ROI_Button.UseVisualStyleBackColor = true;
            this.ROI_Button.Click += new System.EventHandler(this.ROI_Button_Click);
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(863, 204);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(162, 44);
            this.count_button.TabIndex = 3;
            this.count_button.Text = "统计计数";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 697);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 28);
            this.textBox1.TabIndex = 4;
            // 
            // reduce_num
            // 
            this.reduce_num.Location = new System.Drawing.Point(863, 501);
            this.reduce_num.Name = "reduce_num";
            this.reduce_num.Size = new System.Drawing.Size(162, 35);
            this.reduce_num.TabIndex = 6;
            this.reduce_num.Text = "减少1";
            this.reduce_num.UseVisualStyleBackColor = true;
            this.reduce_num.Click += new System.EventHandler(this.reduce_num_Click);
            // 
            // add_num
            // 
            this.add_num.Location = new System.Drawing.Point(863, 383);
            this.add_num.Name = "add_num";
            this.add_num.Size = new System.Drawing.Size(162, 40);
            this.add_num.TabIndex = 5;
            this.add_num.Text = "增加1";
            this.add_num.UseVisualStyleBackColor = true;
            this.add_num.Click += new System.EventHandler(this.add_num_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 778);
            this.Controls.Add(this.reduce_num);
            this.Controls.Add(this.add_num);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.count_button);
            this.Controls.Add(this.ROI_Button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button ROI_Button;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reduce_num;
        private System.Windows.Forms.Button add_num;
    }
}

