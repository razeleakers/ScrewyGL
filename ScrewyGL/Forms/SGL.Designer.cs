namespace ScrewyGL
{
    partial class SGL
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
            this.label1 = new System.Windows.Forms.Label();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Upload_Picture = new System.Windows.Forms.Button();
            this.LB_Coordinates = new System.Windows.Forms.Label();
            this.CB_Geometry = new System.Windows.Forms.ComboBox();
            this.BTN_Result = new System.Windows.Forms.Button();
            this.BTN_NewPoint = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Color = new System.Windows.Forms.Button();
            this.BTN_ClearPoints = new System.Windows.Forms.Button();
            this.BTN_Remove_Picture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScrewyGL";
            // 
            // PB_Image
            // 
            this.PB_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Image.Location = new System.Drawing.Point(12, 86);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(500, 394);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Image.TabIndex = 1;
            this.PB_Image.TabStop = false;
            this.PB_Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_Image_MouseClick);
            this.PB_Image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Image_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(599, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "OPTIONS";
            // 
            // BTN_Upload_Picture
            // 
            this.BTN_Upload_Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.BTN_Upload_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Upload_Picture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Upload_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Upload_Picture.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Upload_Picture.ForeColor = System.Drawing.Color.Black;
            this.BTN_Upload_Picture.Location = new System.Drawing.Point(548, 132);
            this.BTN_Upload_Picture.Name = "BTN_Upload_Picture";
            this.BTN_Upload_Picture.Size = new System.Drawing.Size(95, 45);
            this.BTN_Upload_Picture.TabIndex = 4;
            this.BTN_Upload_Picture.Text = "Upload Pic";
            this.BTN_Upload_Picture.UseVisualStyleBackColor = false;
            this.BTN_Upload_Picture.Click += new System.EventHandler(this.BTN_Upload_Picture_Click);
            // 
            // LB_Coordinates
            // 
            this.LB_Coordinates.AutoSize = true;
            this.LB_Coordinates.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Coordinates.ForeColor = System.Drawing.Color.White;
            this.LB_Coordinates.Location = new System.Drawing.Point(544, 192);
            this.LB_Coordinates.Name = "LB_Coordinates";
            this.LB_Coordinates.Size = new System.Drawing.Size(81, 60);
            this.LB_Coordinates.TabIndex = 5;
            this.LB_Coordinates.Text = "Coordinates\r\nX:\r\nY:";
            // 
            // CB_Geometry
            // 
            this.CB_Geometry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.CB_Geometry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Geometry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Geometry.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Geometry.FormattingEnabled = true;
            this.CB_Geometry.Items.AddRange(new object[] {
            "GL_LINES",
            "GL_LINE_LOOP",
            "GL_TRIANGLES",
            "GL_QUADS",
            "GL_POLYGON"});
            this.CB_Geometry.Location = new System.Drawing.Point(635, 192);
            this.CB_Geometry.Name = "CB_Geometry";
            this.CB_Geometry.Size = new System.Drawing.Size(117, 28);
            this.CB_Geometry.TabIndex = 6;
            // 
            // BTN_Result
            // 
            this.BTN_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(99)))));
            this.BTN_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Result.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Result.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Result.ForeColor = System.Drawing.Color.Black;
            this.BTN_Result.Location = new System.Drawing.Point(548, 437);
            this.BTN_Result.Name = "BTN_Result";
            this.BTN_Result.Size = new System.Drawing.Size(204, 43);
            this.BTN_Result.TabIndex = 7;
            this.BTN_Result.Text = "Show Result";
            this.BTN_Result.UseVisualStyleBackColor = false;
            this.BTN_Result.Click += new System.EventHandler(this.BTN_Result_Click);
            // 
            // BTN_NewPoint
            // 
            this.BTN_NewPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(106)))));
            this.BTN_NewPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_NewPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_NewPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NewPoint.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NewPoint.ForeColor = System.Drawing.Color.Black;
            this.BTN_NewPoint.Location = new System.Drawing.Point(548, 320);
            this.BTN_NewPoint.Name = "BTN_NewPoint";
            this.BTN_NewPoint.Size = new System.Drawing.Size(93, 42);
            this.BTN_NewPoint.TabIndex = 8;
            this.BTN_NewPoint.Text = "New Point";
            this.BTN_NewPoint.UseVisualStyleBackColor = false;
            this.BTN_NewPoint.Click += new System.EventHandler(this.BTN_NewPoint_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(84)))), ((int)(((byte)(97)))));
            this.BTN_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Stop.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Stop.ForeColor = System.Drawing.Color.Black;
            this.BTN_Stop.Location = new System.Drawing.Point(659, 320);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(93, 42);
            this.BTN_Stop.TabIndex = 9;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = false;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color:";
            // 
            // BTN_Color
            // 
            this.BTN_Color.BackColor = System.Drawing.Color.Black;
            this.BTN_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Color.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Color.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Color.ForeColor = System.Drawing.Color.Black;
            this.BTN_Color.Location = new System.Drawing.Point(605, 261);
            this.BTN_Color.Name = "BTN_Color";
            this.BTN_Color.Size = new System.Drawing.Size(147, 39);
            this.BTN_Color.TabIndex = 11;
            this.BTN_Color.UseVisualStyleBackColor = false;
            this.BTN_Color.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_ClearPoints
            // 
            this.BTN_ClearPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.BTN_ClearPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearPoints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ClearPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearPoints.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearPoints.ForeColor = System.Drawing.Color.Black;
            this.BTN_ClearPoints.Location = new System.Drawing.Point(548, 378);
            this.BTN_ClearPoints.Name = "BTN_ClearPoints";
            this.BTN_ClearPoints.Size = new System.Drawing.Size(204, 43);
            this.BTN_ClearPoints.TabIndex = 12;
            this.BTN_ClearPoints.Text = "Clear Points";
            this.BTN_ClearPoints.UseVisualStyleBackColor = false;
            this.BTN_ClearPoints.Click += new System.EventHandler(this.BTN_ClearPoints_Click);
            // 
            // BTN_Remove_Picture
            // 
            this.BTN_Remove_Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.BTN_Remove_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Remove_Picture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Remove_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Remove_Picture.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Remove_Picture.ForeColor = System.Drawing.Color.Black;
            this.BTN_Remove_Picture.Location = new System.Drawing.Point(657, 132);
            this.BTN_Remove_Picture.Name = "BTN_Remove_Picture";
            this.BTN_Remove_Picture.Size = new System.Drawing.Size(95, 45);
            this.BTN_Remove_Picture.TabIndex = 13;
            this.BTN_Remove_Picture.Text = "Remove Pic";
            this.BTN_Remove_Picture.UseVisualStyleBackColor = false;
            this.BTN_Remove_Picture.Click += new System.EventHandler(this.BTN_Remove_Picture_Click);
            // 
            // SGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.BTN_Remove_Picture);
            this.Controls.Add(this.BTN_ClearPoints);
            this.Controls.Add(this.BTN_Color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_NewPoint);
            this.Controls.Add(this.BTN_Result);
            this.Controls.Add(this.CB_Geometry);
            this.Controls.Add(this.LB_Coordinates);
            this.Controls.Add(this.BTN_Upload_Picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PB_Image);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrewyGL | BY M3RFR3T | github.com/RazeLeakers";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Upload_Picture;
        private System.Windows.Forms.Label LB_Coordinates;
        private System.Windows.Forms.ComboBox CB_Geometry;
        private System.Windows.Forms.Button BTN_Result;
        private System.Windows.Forms.Button BTN_NewPoint;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Color;
        private System.Windows.Forms.Button BTN_ClearPoints;
        private System.Windows.Forms.Button BTN_Remove_Picture;
    }
}