﻿namespace WSCATProject.Base
{
    partial class InsNodes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form_save = new System.Windows.Forms.Button();
            this.form_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入下级名称：";
            // 
            // form_save
            // 
            this.form_save.Location = new System.Drawing.Point(83, 68);
            this.form_save.Name = "form_save";
            this.form_save.Size = new System.Drawing.Size(75, 25);
            this.form_save.TabIndex = 2;
            this.form_save.Text = "保存(&A)";
            this.form_save.UseVisualStyleBackColor = true;
            this.form_save.Click += new System.EventHandler(this.form_save_Click);
            // 
            // form_exit
            // 
            this.form_exit.Location = new System.Drawing.Point(164, 68);
            this.form_exit.Name = "form_exit";
            this.form_exit.Size = new System.Drawing.Size(75, 25);
            this.form_exit.TabIndex = 2;
            this.form_exit.Text = "取消(&Q)";
            this.form_exit.UseVisualStyleBackColor = true;
            this.form_exit.Click += new System.EventHandler(this.form_exit_Click);
            // 
            // InsNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(255, 107);
            this.ControlBox = false;
            this.Controls.Add(this.form_exit);
            this.Controls.Add(this.form_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsNodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入子节点";
            this.Load += new System.EventHandler(this.InsNodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button form_save;
        private System.Windows.Forms.Button form_exit;
    }
}