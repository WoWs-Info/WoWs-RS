﻿namespace WoWs_Info_R
{
    partial class MainWindow
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
            this.Settings = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Links = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Settings.Location = new System.Drawing.Point(890, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(62, 62);
            this.Settings.TabIndex = 0;
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.SystemColors.ControlDark;
            this.About.Location = new System.Drawing.Point(958, 12);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(62, 62);
            this.About.TabIndex = 0;
            this.About.UseVisualStyleBackColor = false;
            // 
            // Links
            // 
            this.Links.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Links.Location = new System.Drawing.Point(822, 12);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(62, 62);
            this.Links.TabIndex = 0;
            this.Links.UseVisualStyleBackColor = false;
            this.Links.Click += new System.EventHandler(this.Links_Load);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(295, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(465, 55);
            this.title.TabIndex = 1;
            this.title.Text = "Real Time Statistics";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 530);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Settings);
            this.Name = "MainWindow";
            this.Text = "WoWs Info R";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Links;
        private System.Windows.Forms.Label title;
    }
}
