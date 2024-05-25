namespace ScrewyGL
{
    partial class Result
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
            this.RTB_Content = new System.Windows.Forms.RichTextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Download = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ShowAll = new System.Windows.Forms.Button();
            this.BTN_ShowActual = new System.Windows.Forms.Button();
            this.BTN_ShowLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_Content
            // 
            this.RTB_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RTB_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Content.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Content.Location = new System.Drawing.Point(23, 69);
            this.RTB_Content.Name = "RTB_Content";
            this.RTB_Content.Size = new System.Drawing.Size(234, 208);
            this.RTB_Content.TabIndex = 0;
            this.RTB_Content.Text = "";
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(141)))), ((int)(((byte)(142)))));
            this.BTN_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Copy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Copy.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Copy.ForeColor = System.Drawing.Color.Black;
            this.BTN_Copy.Location = new System.Drawing.Point(280, 122);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(125, 43);
            this.BTN_Copy.TabIndex = 5;
            this.BTN_Copy.Text = "Copy";
            this.BTN_Copy.UseVisualStyleBackColor = false;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Download
            // 
            this.BTN_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.BTN_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Download.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Download.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Download.ForeColor = System.Drawing.Color.Black;
            this.BTN_Download.Location = new System.Drawing.Point(280, 202);
            this.BTN_Download.Name = "BTN_Download";
            this.BTN_Download.Size = new System.Drawing.Size(125, 43);
            this.BTN_Download.TabIndex = 6;
            this.BTN_Download.Text = "Download";
            this.BTN_Download.UseVisualStyleBackColor = false;
            this.BTN_Download.Click += new System.EventHandler(this.BTN_Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result";
            // 
            // BTN_ShowAll
            // 
            this.BTN_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ShowAll.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ShowAll.ForeColor = System.Drawing.Color.Black;
            this.BTN_ShowAll.Location = new System.Drawing.Point(23, 26);
            this.BTN_ShowAll.Name = "BTN_ShowAll";
            this.BTN_ShowAll.Size = new System.Drawing.Size(60, 33);
            this.BTN_ShowAll.TabIndex = 8;
            this.BTN_ShowAll.Text = "ALL";
            this.BTN_ShowAll.UseVisualStyleBackColor = false;
            this.BTN_ShowAll.Click += new System.EventHandler(this.BTN_ShowAll_Click);
            // 
            // BTN_ShowActual
            // 
            this.BTN_ShowActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN_ShowActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ShowActual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ShowActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ShowActual.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ShowActual.ForeColor = System.Drawing.Color.Black;
            this.BTN_ShowActual.Location = new System.Drawing.Point(110, 26);
            this.BTN_ShowActual.Name = "BTN_ShowActual";
            this.BTN_ShowActual.Size = new System.Drawing.Size(60, 33);
            this.BTN_ShowActual.TabIndex = 9;
            this.BTN_ShowActual.Text = "ACTUAL";
            this.BTN_ShowActual.UseVisualStyleBackColor = false;
            this.BTN_ShowActual.Click += new System.EventHandler(this.BTN_ShowActual_Click);
            // 
            // BTN_ShowLast
            // 
            this.BTN_ShowLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN_ShowLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ShowLast.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ShowLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ShowLast.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ShowLast.ForeColor = System.Drawing.Color.Black;
            this.BTN_ShowLast.Location = new System.Drawing.Point(197, 26);
            this.BTN_ShowLast.Name = "BTN_ShowLast";
            this.BTN_ShowLast.Size = new System.Drawing.Size(60, 33);
            this.BTN_ShowLast.TabIndex = 10;
            this.BTN_ShowLast.Text = "LAST";
            this.BTN_ShowLast.UseVisualStyleBackColor = false;
            this.BTN_ShowLast.Click += new System.EventHandler(this.BTN_ShowLast_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(434, 298);
            this.Controls.Add(this.BTN_ShowLast);
            this.Controls.Add(this.BTN_ShowActual);
            this.Controls.Add(this.BTN_ShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Download);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.RTB_Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Result";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Content;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ShowAll;
        private System.Windows.Forms.Button BTN_ShowActual;
        private System.Windows.Forms.Button BTN_ShowLast;
    }
}