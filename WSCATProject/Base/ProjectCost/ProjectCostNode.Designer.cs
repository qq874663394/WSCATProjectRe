﻿namespace WSCATProject.Base
{
    partial class ProjectCostNode
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.TabIndex = 3;
            // 
            // form_save
            // 
            this.form_save.Location = new System.Drawing.Point(81, 70);
            this.form_save.TabIndex = 1;
            // 
            // form_exit
            // 
            this.form_exit.Location = new System.Drawing.Point(162, 70);
            // 
            // ProjectCostNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 112);
            this.Name = "ProjectCostNode";
            this.Text = "InsSuNode";
            this.Load += new System.EventHandler(this.ProjectCostNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}