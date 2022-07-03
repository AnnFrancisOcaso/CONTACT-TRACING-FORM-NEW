
namespace Contact_Tracing
{
    partial class QR_code
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qrbx = new System.Windows.Forms.TextBox();
            this.generatebttn = new System.Windows.Forms.Button();
            this.qrlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 305);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // qrbx
            // 
            this.qrbx.Location = new System.Drawing.Point(130, 372);
            this.qrbx.Name = "qrbx";
            this.qrbx.Size = new System.Drawing.Size(163, 20);
            this.qrbx.TabIndex = 1;
            // 
            // generatebttn
            // 
            this.generatebttn.Location = new System.Drawing.Point(308, 372);
            this.generatebttn.Name = "generatebttn";
            this.generatebttn.Size = new System.Drawing.Size(75, 23);
            this.generatebttn.TabIndex = 2;
            this.generatebttn.Text = "Generate";
            this.generatebttn.UseVisualStyleBackColor = true;
            this.generatebttn.Click += new System.EventHandler(this.generatebttn_Click);
            // 
            // qrlbl
            // 
            this.qrlbl.AutoSize = true;
            this.qrlbl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrlbl.Location = new System.Drawing.Point(59, 373);
            this.qrlbl.Name = "qrlbl";
            this.qrlbl.Size = new System.Drawing.Size(65, 16);
            this.qrlbl.TabIndex = 3;
            this.qrlbl.Text = "QR code";
            // 
            // QR_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.qrlbl);
            this.Controls.Add(this.generatebttn);
            this.Controls.Add(this.qrbx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QR_code";
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox qrbx;
        private System.Windows.Forms.Button generatebttn;
        private System.Windows.Forms.Label qrlbl;
    }
}