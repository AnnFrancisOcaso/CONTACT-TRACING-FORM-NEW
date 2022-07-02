
namespace Contact_Tracing
{
    partial class Contact_Tracing_Information
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
            this.dataGridViewctf = new System.Windows.Forms.DataGridView();
            this.CTFlbl = new System.Windows.Forms.Label();
            this.savebttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewctf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewctf
            // 
            this.dataGridViewctf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewctf.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewctf.Name = "dataGridViewctf";
            this.dataGridViewctf.Size = new System.Drawing.Size(592, 276);
            this.dataGridViewctf.TabIndex = 0;
            // 
            // CTFlbl
            // 
            this.CTFlbl.AutoSize = true;
            this.CTFlbl.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.CTFlbl.Location = new System.Drawing.Point(12, 29);
            this.CTFlbl.Name = "CTFlbl";
            this.CTFlbl.Size = new System.Drawing.Size(226, 16);
            this.CTFlbl.TabIndex = 1;
            this.CTFlbl.Text = "Contact Tracing Form Information";
            // 
            // savebttn
            // 
            this.savebttn.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebttn.Location = new System.Drawing.Point(216, 389);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(148, 31);
            this.savebttn.TabIndex = 2;
            this.savebttn.Text = "Save Information";
            this.savebttn.UseVisualStyleBackColor = true;
            this.savebttn.Click += new System.EventHandler(this.savebttn_Click);
            // 
            // Contact_Tracing_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.CTFlbl);
            this.Controls.Add(this.dataGridViewctf);
            this.Name = "Contact_Tracing_Information";
            this.Text = "Contact Tracing Information";
            this.Load += new System.EventHandler(this.Contact_Tracing_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewctf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewctf;
        private System.Windows.Forms.Label CTFlbl;
        private System.Windows.Forms.Button savebttn;
    }
}