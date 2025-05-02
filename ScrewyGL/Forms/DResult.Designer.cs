namespace ScrewyGL
{
    partial class DResult
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
            System.Windows.Forms.Label label1;
            this.RTB_Content = new System.Windows.Forms.RichTextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Download = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(411, 58);
            label1.TabIndex = 1;
            label1.Text = "Result";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTB_Content
            // 
            this.RTB_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RTB_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Content.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Content.Location = new System.Drawing.Point(22, 61);
            this.RTB_Content.Name = "RTB_Content";
            this.RTB_Content.ReadOnly = true;
            this.RTB_Content.Size = new System.Drawing.Size(370, 220);
            this.RTB_Content.TabIndex = 2;
            this.RTB_Content.Text = " ";
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Copy.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Copy.Location = new System.Drawing.Point(22, 300);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(165, 40);
            this.BTN_Copy.TabIndex = 3;
            this.BTN_Copy.Text = "Copy";
            this.BTN_Copy.UseVisualStyleBackColor = false;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Download
            // 
            this.BTN_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Download.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Download.Location = new System.Drawing.Point(227, 300);
            this.BTN_Download.Name = "BTN_Download";
            this.BTN_Download.Size = new System.Drawing.Size(165, 40);
            this.BTN_Download.TabIndex = 4;
            this.BTN_Download.Text = "Download";
            this.BTN_Download.UseVisualStyleBackColor = false;
            this.BTN_Download.Click += new System.EventHandler(this.BTN_Download_Click);
            // 
            // DResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(411, 361);
            this.Controls.Add(this.BTN_Download);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.RTB_Content);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Content;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Download;
    }
}