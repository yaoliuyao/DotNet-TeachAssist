﻿
namespace TeachAssistUI
{
    partial class RollcallForm
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
            this.lbPresents = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFileinfo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAbsents = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPresents
            // 
            this.lbPresents.BackColor = System.Drawing.SystemColors.Info;
            this.lbPresents.FormattingEnabled = true;
            this.lbPresents.ItemHeight = 18;
            this.lbPresents.Location = new System.Drawing.Point(3, 3);
            this.lbPresents.Name = "lbPresents";
            this.lbPresents.Size = new System.Drawing.Size(261, 94);
            this.lbPresents.TabIndex = 0;
            this.lbPresents.SelectedIndexChanged += new System.EventHandler(this.lbPresents_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(321, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 194);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(558, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 52);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(74, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(88, 31);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "加载...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(65, 31);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 38);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(321, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "未到";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonRefresh);
            this.flowLayoutPanel2.Controls.Add(this.buttonLoad);
            this.flowLayoutPanel2.Controls.Add(this.buttonFileinfo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(489, 44);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // buttonFileinfo
            // 
            this.buttonFileinfo.AutoSize = true;
            this.buttonFileinfo.FlatAppearance.BorderSize = 0;
            this.buttonFileinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileinfo.Location = new System.Drawing.Point(168, 3);
            this.buttonFileinfo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.buttonFileinfo.MaximumSize = new System.Drawing.Size(300, 100);
            this.buttonFileinfo.Name = "buttonFileinfo";
            this.buttonFileinfo.Size = new System.Drawing.Size(81, 31);
            this.buttonFileinfo.TabIndex = 13;
            this.buttonFileinfo.Text = "unknown";
            this.buttonFileinfo.UseVisualStyleBackColor = true;
            this.buttonFileinfo.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 589);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 41);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(756, 589);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 41);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 90);
            this.label3.TabIndex = 16;
            this.label3.Text = "使用说明:\r\n1. Enter\r\n2. Space\r\n3. BackSpace\r\n4. ESC";
            // 
            // lbAbsents
            // 
            this.lbAbsents.BackColor = System.Drawing.SystemColors.Info;
            this.lbAbsents.FormattingEnabled = true;
            this.lbAbsents.ItemHeight = 18;
            this.lbAbsents.Location = new System.Drawing.Point(3, 101);
            this.lbAbsents.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lbAbsents.Name = "lbAbsents";
            this.lbAbsents.Size = new System.Drawing.Size(261, 112);
            this.lbAbsents.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lbPresents);
            this.flowLayoutPanel3.Controls.Add(this.lbAbsents);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(15, 71);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(268, 597);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // RollcallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 666);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RollcallForm";
            this.Text = "RollcallForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPresents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonFileinfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAbsents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}