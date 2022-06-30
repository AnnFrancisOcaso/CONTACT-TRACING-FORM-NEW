﻿
namespace Contact_Tracing
{
    partial class Login
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
            this.formlbl = new System.Windows.Forms.Label();
            this.datebx = new System.Windows.Forms.TextBox();
            this.temperaturebx = new System.Windows.Forms.TextBox();
            this.temperaturelbl = new System.Windows.Forms.Label();
            this.timebx = new System.Windows.Forms.TextBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Palatino Linotype", 21.75F);
            this.formlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formlbl.Location = new System.Drawing.Point(39, 48);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(439, 38);
            this.formlbl.TabIndex = 78;
            this.formlbl.Text = "COVID 19 Contact Tracing Form";
            // 
            // datebx
            // 
            this.datebx.Location = new System.Drawing.Point(184, 118);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(225, 20);
            this.datebx.TabIndex = 129;
            // 
            // temperaturebx
            // 
            this.temperaturebx.Location = new System.Drawing.Point(184, 212);
            this.temperaturebx.Name = "temperaturebx";
            this.temperaturebx.Size = new System.Drawing.Size(225, 20);
            this.temperaturebx.TabIndex = 128;
            // 
            // temperaturelbl
            // 
            this.temperaturelbl.AutoSize = true;
            this.temperaturelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.temperaturelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.temperaturelbl.Location = new System.Drawing.Point(82, 208);
            this.temperaturelbl.Name = "temperaturelbl";
            this.temperaturelbl.Size = new System.Drawing.Size(96, 23);
            this.temperaturelbl.TabIndex = 127;
            this.temperaturelbl.Text = "Temperature:";
            // 
            // timebx
            // 
            this.timebx.Location = new System.Drawing.Point(184, 164);
            this.timebx.Name = "timebx";
            this.timebx.Size = new System.Drawing.Size(225, 20);
            this.timebx.TabIndex = 126;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.timelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timelbl.Location = new System.Drawing.Point(82, 160);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(47, 23);
            this.timelbl.TabIndex = 125;
            this.timelbl.Text = "Time:";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.datelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datelbl.Location = new System.Drawing.Point(83, 115);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(47, 23);
            this.datelbl.TabIndex = 124;
            this.datelbl.Text = "Date: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 130;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.qrToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // qrToolStripMenuItem
            // 
            this.qrToolStripMenuItem.Name = "qrToolStripMenuItem";
            this.qrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qrToolStripMenuItem.Text = "Qr";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 291);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.temperaturebx);
            this.Controls.Add(this.temperaturelbl);
            this.Controls.Add(this.timebx);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.formlbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Contact Tracing ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.TextBox datebx;
        private System.Windows.Forms.TextBox temperaturebx;
        private System.Windows.Forms.Label temperaturelbl;
        private System.Windows.Forms.TextBox timebx;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrToolStripMenuItem;
    }
}

