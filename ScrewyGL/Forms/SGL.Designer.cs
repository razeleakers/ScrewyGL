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
            System.Windows.Forms.Panel PN_Content;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.PN3D_Options = new System.Windows.Forms.Panel();
            this.BTN3D_ShowResult = new System.Windows.Forms.Button();
            this.BTN3D_ClearAll = new System.Windows.Forms.Button();
            this.BTN3D_DelFigure = new System.Windows.Forms.Button();
            this.LB3D_Figures = new System.Windows.Forms.ListBox();
            this.NUD3D_MoveCant = new System.Windows.Forms.NumericUpDown();
            this.RB3D_Translate = new System.Windows.Forms.RadioButton();
            this.RB3D_Rotate = new System.Windows.Forms.RadioButton();
            this.RB3D_Scale = new System.Windows.Forms.RadioButton();
            this.BTN3D_PosZ = new System.Windows.Forms.Button();
            this.BTN3D_PosY = new System.Windows.Forms.Button();
            this.BTN3D_PosX = new System.Windows.Forms.Button();
            this.BTN3D_Color = new System.Windows.Forms.Button();
            this.TB3D_Name = new System.Windows.Forms.TextBox();
            this.CB3D_Figure = new System.Windows.Forms.ComboBox();
            this.BTN3D_NewFigure = new System.Windows.Forms.Button();
            this.PN2D_Options = new System.Windows.Forms.Panel();
            this.BTN2D_Redo = new System.Windows.Forms.Button();
            this.BTN2D_Undo = new System.Windows.Forms.Button();
            this.BTN2D_ShowResult = new System.Windows.Forms.Button();
            this.BTN2D_ClearAll = new System.Windows.Forms.Button();
            this.BTN2D_ClearPoints = new System.Windows.Forms.Button();
            this.BTN2D_Stop = new System.Windows.Forms.Button();
            this.BTN2D_Color = new System.Windows.Forms.Button();
            this.LB2D_Coordinates = new System.Windows.Forms.Label();
            this.NUD2D_LineSize = new System.Windows.Forms.NumericUpDown();
            this.CB2D_Geometry = new System.Windows.Forms.ComboBox();
            this.BTN2D_NewPoint = new System.Windows.Forms.Button();
            this.TC_Drawing = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelOpenGL2D = new SharpGL.OpenGLControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelOpenGL3D = new SharpGL.OpenGLControl();
            this.LBL_ScrewyGL = new System.Windows.Forms.Label();
            PN_Content = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            PN_Content.SuspendLayout();
            this.PN3D_Options.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD3D_MoveCant)).BeginInit();
            groupBox1.SuspendLayout();
            this.PN2D_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD2D_LineSize)).BeginInit();
            this.TC_Drawing.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL2D)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL3D)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Content
            // 
            PN_Content.Controls.Add(this.PN3D_Options);
            PN_Content.Controls.Add(this.PN2D_Options);
            PN_Content.Controls.Add(this.TC_Drawing);
            PN_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            PN_Content.Location = new System.Drawing.Point(0, 92);
            PN_Content.Name = "PN_Content";
            PN_Content.Size = new System.Drawing.Size(834, 429);
            PN_Content.TabIndex = 1;
            // 
            // PN3D_Options
            // 
            this.PN3D_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PN3D_Options.Controls.Add(this.BTN3D_ShowResult);
            this.PN3D_Options.Controls.Add(this.BTN3D_ClearAll);
            this.PN3D_Options.Controls.Add(this.BTN3D_DelFigure);
            this.PN3D_Options.Controls.Add(groupBox2);
            this.PN3D_Options.Controls.Add(groupBox1);
            this.PN3D_Options.Controls.Add(label3);
            this.PN3D_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN3D_Options.Location = new System.Drawing.Point(284, 0);
            this.PN3D_Options.Name = "PN3D_Options";
            this.PN3D_Options.Size = new System.Drawing.Size(310, 429);
            this.PN3D_Options.TabIndex = 2;
            this.PN3D_Options.Visible = false;
            // 
            // BTN3D_ShowResult
            // 
            this.BTN3D_ShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BTN3D_ShowResult.Enabled = false;
            this.BTN3D_ShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_ShowResult.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_ShowResult.Location = new System.Drawing.Point(6, 379);
            this.BTN3D_ShowResult.Name = "BTN3D_ShowResult";
            this.BTN3D_ShowResult.Size = new System.Drawing.Size(297, 40);
            this.BTN3D_ShowResult.TabIndex = 25;
            this.BTN3D_ShowResult.Text = "Show Result";
            this.BTN3D_ShowResult.UseVisualStyleBackColor = false;
            this.BTN3D_ShowResult.Click += new System.EventHandler(this.BTN3D_ShowResult_Click);
            // 
            // BTN3D_ClearAll
            // 
            this.BTN3D_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN3D_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_ClearAll.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_ClearAll.Location = new System.Drawing.Point(158, 333);
            this.BTN3D_ClearAll.Name = "BTN3D_ClearAll";
            this.BTN3D_ClearAll.Size = new System.Drawing.Size(145, 40);
            this.BTN3D_ClearAll.TabIndex = 24;
            this.BTN3D_ClearAll.Text = "Clear All";
            this.BTN3D_ClearAll.UseVisualStyleBackColor = false;
            this.BTN3D_ClearAll.Click += new System.EventHandler(this.BTN3D_ClearAll_Click);
            // 
            // BTN3D_DelFigure
            // 
            this.BTN3D_DelFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN3D_DelFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_DelFigure.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_DelFigure.Location = new System.Drawing.Point(6, 333);
            this.BTN3D_DelFigure.Name = "BTN3D_DelFigure";
            this.BTN3D_DelFigure.Size = new System.Drawing.Size(145, 40);
            this.BTN3D_DelFigure.TabIndex = 23;
            this.BTN3D_DelFigure.Text = "Del Figure";
            this.BTN3D_DelFigure.UseVisualStyleBackColor = false;
            this.BTN3D_DelFigure.Click += new System.EventHandler(this.BTN3D_DelFigure_Click);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.LB3D_Figures);
            groupBox2.Controls.Add(this.NUD3D_MoveCant);
            groupBox2.Controls.Add(this.RB3D_Translate);
            groupBox2.Controls.Add(this.RB3D_Rotate);
            groupBox2.Controls.Add(this.RB3D_Scale);
            groupBox2.Controls.Add(this.BTN3D_PosZ);
            groupBox2.Controls.Add(this.BTN3D_PosY);
            groupBox2.Controls.Add(this.BTN3D_PosX);
            groupBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            groupBox2.Location = new System.Drawing.Point(158, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(145, 269);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage";
            // 
            // LB3D_Figures
            // 
            this.LB3D_Figures.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB3D_Figures.FormattingEnabled = true;
            this.LB3D_Figures.ItemHeight = 18;
            this.LB3D_Figures.Location = new System.Drawing.Point(11, 21);
            this.LB3D_Figures.Name = "LB3D_Figures";
            this.LB3D_Figures.Size = new System.Drawing.Size(119, 76);
            this.LB3D_Figures.TabIndex = 15;
            // 
            // NUD3D_MoveCant
            // 
            this.NUD3D_MoveCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.NUD3D_MoveCant.DecimalPlaces = 3;
            this.NUD3D_MoveCant.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD3D_MoveCant.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NUD3D_MoveCant.Location = new System.Drawing.Point(11, 108);
            this.NUD3D_MoveCant.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NUD3D_MoveCant.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.NUD3D_MoveCant.Name = "NUD3D_MoveCant";
            this.NUD3D_MoveCant.Size = new System.Drawing.Size(119, 25);
            this.NUD3D_MoveCant.TabIndex = 16;
            this.NUD3D_MoveCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD3D_MoveCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RB3D_Translate
            // 
            this.RB3D_Translate.AutoSize = true;
            this.RB3D_Translate.BackColor = System.Drawing.Color.Transparent;
            this.RB3D_Translate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB3D_Translate.Location = new System.Drawing.Point(11, 228);
            this.RB3D_Translate.Name = "RB3D_Translate";
            this.RB3D_Translate.Size = new System.Drawing.Size(78, 22);
            this.RB3D_Translate.TabIndex = 19;
            this.RB3D_Translate.Text = "Translate";
            this.RB3D_Translate.UseVisualStyleBackColor = false;
            // 
            // RB3D_Rotate
            // 
            this.RB3D_Rotate.AutoSize = true;
            this.RB3D_Rotate.BackColor = System.Drawing.Color.Transparent;
            this.RB3D_Rotate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB3D_Rotate.Location = new System.Drawing.Point(11, 186);
            this.RB3D_Rotate.Name = "RB3D_Rotate";
            this.RB3D_Rotate.Size = new System.Drawing.Size(62, 22);
            this.RB3D_Rotate.TabIndex = 18;
            this.RB3D_Rotate.Text = "Rotate";
            this.RB3D_Rotate.UseVisualStyleBackColor = false;
            // 
            // RB3D_Scale
            // 
            this.RB3D_Scale.AutoSize = true;
            this.RB3D_Scale.BackColor = System.Drawing.Color.Transparent;
            this.RB3D_Scale.Checked = true;
            this.RB3D_Scale.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB3D_Scale.Location = new System.Drawing.Point(11, 145);
            this.RB3D_Scale.Name = "RB3D_Scale";
            this.RB3D_Scale.Size = new System.Drawing.Size(55, 22);
            this.RB3D_Scale.TabIndex = 17;
            this.RB3D_Scale.TabStop = true;
            this.RB3D_Scale.Text = "Scale";
            this.RB3D_Scale.UseVisualStyleBackColor = false;
            // 
            // BTN3D_PosZ
            // 
            this.BTN3D_PosZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.BTN3D_PosZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_PosZ.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_PosZ.ForeColor = System.Drawing.Color.Black;
            this.BTN3D_PosZ.Location = new System.Drawing.Point(95, 222);
            this.BTN3D_PosZ.Name = "BTN3D_PosZ";
            this.BTN3D_PosZ.Size = new System.Drawing.Size(35, 35);
            this.BTN3D_PosZ.TabIndex = 22;
            this.BTN3D_PosZ.Text = "Z";
            this.BTN3D_PosZ.UseVisualStyleBackColor = false;
            this.BTN3D_PosZ.Click += new System.EventHandler(this.BTN3D_PosZ_Click);
            // 
            // BTN3D_PosY
            // 
            this.BTN3D_PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.BTN3D_PosY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_PosY.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_PosY.ForeColor = System.Drawing.Color.Black;
            this.BTN3D_PosY.Location = new System.Drawing.Point(95, 180);
            this.BTN3D_PosY.Name = "BTN3D_PosY";
            this.BTN3D_PosY.Size = new System.Drawing.Size(35, 35);
            this.BTN3D_PosY.TabIndex = 21;
            this.BTN3D_PosY.Text = "Y";
            this.BTN3D_PosY.UseVisualStyleBackColor = false;
            this.BTN3D_PosY.Click += new System.EventHandler(this.BTN3D_PosY_Click);
            // 
            // BTN3D_PosX
            // 
            this.BTN3D_PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.BTN3D_PosX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_PosX.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_PosX.ForeColor = System.Drawing.Color.Black;
            this.BTN3D_PosX.Location = new System.Drawing.Point(95, 139);
            this.BTN3D_PosX.Name = "BTN3D_PosX";
            this.BTN3D_PosX.Size = new System.Drawing.Size(35, 35);
            this.BTN3D_PosX.TabIndex = 20;
            this.BTN3D_PosX.Text = "X";
            this.BTN3D_PosX.UseVisualStyleBackColor = false;
            this.BTN3D_PosX.Click += new System.EventHandler(this.BTN3D_PosX_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.BTN3D_Color);
            groupBox1.Controls.Add(this.TB3D_Name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(this.CB3D_Figure);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(this.BTN3D_NewFigure);
            groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            groupBox1.Location = new System.Drawing.Point(6, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(145, 269);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create";
            // 
            // BTN3D_Color
            // 
            this.BTN3D_Color.BackColor = System.Drawing.Color.Gray;
            this.BTN3D_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN3D_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_Color.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_Color.Location = new System.Drawing.Point(15, 180);
            this.BTN3D_Color.Name = "BTN3D_Color";
            this.BTN3D_Color.Size = new System.Drawing.Size(117, 28);
            this.BTN3D_Color.TabIndex = 13;
            this.BTN3D_Color.UseVisualStyleBackColor = false;
            this.BTN3D_Color.Click += new System.EventHandler(this.BTN3D_Color_Click);
            // 
            // TB3D_Name
            // 
            this.TB3D_Name.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB3D_Name.Location = new System.Drawing.Point(15, 66);
            this.TB3D_Name.Name = "TB3D_Name";
            this.TB3D_Name.Size = new System.Drawing.Size(117, 25);
            this.TB3D_Name.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(11, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 22);
            label5.TabIndex = 14;
            label5.Text = "Figure:";
            // 
            // CB3D_Figure
            // 
            this.CB3D_Figure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CB3D_Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB3D_Figure.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB3D_Figure.FormattingEnabled = true;
            this.CB3D_Figure.Items.AddRange(new object[] {
            "CUBE",
            "CONE",
            "CYLINDER",
            "DISK",
            "SPHERE"});
            this.CB3D_Figure.Location = new System.Drawing.Point(15, 141);
            this.CB3D_Figure.Name = "CB3D_Figure";
            this.CB3D_Figure.Size = new System.Drawing.Size(117, 26);
            this.CB3D_Figure.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(11, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 22);
            label4.TabIndex = 13;
            label4.Text = "Name:";
            // 
            // BTN3D_NewFigure
            // 
            this.BTN3D_NewFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.BTN3D_NewFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3D_NewFigure.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3D_NewFigure.ForeColor = System.Drawing.Color.Black;
            this.BTN3D_NewFigure.Location = new System.Drawing.Point(15, 217);
            this.BTN3D_NewFigure.Name = "BTN3D_NewFigure";
            this.BTN3D_NewFigure.Size = new System.Drawing.Size(117, 40);
            this.BTN3D_NewFigure.TabIndex = 14;
            this.BTN3D_NewFigure.Text = "New Figure";
            this.BTN3D_NewFigure.UseVisualStyleBackColor = false;
            this.BTN3D_NewFigure.Click += new System.EventHandler(this.BTN3D_NewFigure_Click);
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(310, 55);
            label3.TabIndex = 1;
            label3.Text = "OPTIONS 3D";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN2D_Options
            // 
            this.PN2D_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PN2D_Options.Controls.Add(this.BTN2D_Redo);
            this.PN2D_Options.Controls.Add(this.BTN2D_Undo);
            this.PN2D_Options.Controls.Add(this.BTN2D_ShowResult);
            this.PN2D_Options.Controls.Add(this.BTN2D_ClearAll);
            this.PN2D_Options.Controls.Add(this.BTN2D_ClearPoints);
            this.PN2D_Options.Controls.Add(this.BTN2D_Stop);
            this.PN2D_Options.Controls.Add(label2);
            this.PN2D_Options.Controls.Add(this.BTN2D_Color);
            this.PN2D_Options.Controls.Add(this.LB2D_Coordinates);
            this.PN2D_Options.Controls.Add(this.NUD2D_LineSize);
            this.PN2D_Options.Controls.Add(this.CB2D_Geometry);
            this.PN2D_Options.Controls.Add(this.BTN2D_NewPoint);
            this.PN2D_Options.Controls.Add(label1);
            this.PN2D_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN2D_Options.Location = new System.Drawing.Point(594, 0);
            this.PN2D_Options.Name = "PN2D_Options";
            this.PN2D_Options.Size = new System.Drawing.Size(240, 429);
            this.PN2D_Options.TabIndex = 1;
            // 
            // BTN2D_Redo
            // 
            this.BTN2D_Redo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BTN2D_Redo.Enabled = false;
            this.BTN2D_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_Redo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_Redo.Location = new System.Drawing.Point(138, 261);
            this.BTN2D_Redo.Name = "BTN2D_Redo";
            this.BTN2D_Redo.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_Redo.TabIndex = 7;
            this.BTN2D_Redo.Text = "Redo >";
            this.BTN2D_Redo.UseVisualStyleBackColor = false;
            this.BTN2D_Redo.Click += new System.EventHandler(this.BTN2D_Redo_Click);
            // 
            // BTN2D_Undo
            // 
            this.BTN2D_Undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BTN2D_Undo.Enabled = false;
            this.BTN2D_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_Undo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_Undo.Location = new System.Drawing.Point(17, 261);
            this.BTN2D_Undo.Name = "BTN2D_Undo";
            this.BTN2D_Undo.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_Undo.TabIndex = 6;
            this.BTN2D_Undo.Text = "< Undo";
            this.BTN2D_Undo.UseVisualStyleBackColor = false;
            this.BTN2D_Undo.Click += new System.EventHandler(this.BTN2D_Undo_Click);
            // 
            // BTN2D_ShowResult
            // 
            this.BTN2D_ShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BTN2D_ShowResult.Enabled = false;
            this.BTN2D_ShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_ShowResult.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_ShowResult.Location = new System.Drawing.Point(17, 377);
            this.BTN2D_ShowResult.Name = "BTN2D_ShowResult";
            this.BTN2D_ShowResult.Size = new System.Drawing.Size(211, 40);
            this.BTN2D_ShowResult.TabIndex = 10;
            this.BTN2D_ShowResult.Text = "Show Result";
            this.BTN2D_ShowResult.UseVisualStyleBackColor = false;
            this.BTN2D_ShowResult.Click += new System.EventHandler(this.BTN2D_ShowResult_Click);
            // 
            // BTN2D_ClearAll
            // 
            this.BTN2D_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN2D_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_ClearAll.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_ClearAll.Location = new System.Drawing.Point(138, 318);
            this.BTN2D_ClearAll.Name = "BTN2D_ClearAll";
            this.BTN2D_ClearAll.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_ClearAll.TabIndex = 9;
            this.BTN2D_ClearAll.Text = "Clear All";
            this.BTN2D_ClearAll.UseVisualStyleBackColor = false;
            this.BTN2D_ClearAll.Click += new System.EventHandler(this.BTN2D_ClearAll_Click);
            // 
            // BTN2D_ClearPoints
            // 
            this.BTN2D_ClearPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN2D_ClearPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_ClearPoints.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_ClearPoints.Location = new System.Drawing.Point(17, 318);
            this.BTN2D_ClearPoints.Name = "BTN2D_ClearPoints";
            this.BTN2D_ClearPoints.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_ClearPoints.TabIndex = 8;
            this.BTN2D_ClearPoints.Text = "Clear Points";
            this.BTN2D_ClearPoints.UseVisualStyleBackColor = false;
            this.BTN2D_ClearPoints.Click += new System.EventHandler(this.BTN2D_ClearPoints_Click);
            // 
            // BTN2D_Stop
            // 
            this.BTN2D_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.BTN2D_Stop.Enabled = false;
            this.BTN2D_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_Stop.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_Stop.Location = new System.Drawing.Point(138, 202);
            this.BTN2D_Stop.Name = "BTN2D_Stop";
            this.BTN2D_Stop.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_Stop.TabIndex = 5;
            this.BTN2D_Stop.Text = "Stop";
            this.BTN2D_Stop.UseVisualStyleBackColor = false;
            this.BTN2D_Stop.Click += new System.EventHandler(this.BTN2D_Stop_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(13, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 22);
            label2.TabIndex = 6;
            label2.Text = "Color:";
            // 
            // BTN2D_Color
            // 
            this.BTN2D_Color.BackColor = System.Drawing.Color.Black;
            this.BTN2D_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN2D_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_Color.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_Color.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN2D_Color.Location = new System.Drawing.Point(80, 149);
            this.BTN2D_Color.Name = "BTN2D_Color";
            this.BTN2D_Color.Size = new System.Drawing.Size(148, 33);
            this.BTN2D_Color.TabIndex = 3;
            this.BTN2D_Color.UseVisualStyleBackColor = false;
            this.BTN2D_Color.Click += new System.EventHandler(this.BTN2D_Color_Click);
            // 
            // LB2D_Coordinates
            // 
            this.LB2D_Coordinates.AutoSize = true;
            this.LB2D_Coordinates.BackColor = System.Drawing.Color.Transparent;
            this.LB2D_Coordinates.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB2D_Coordinates.ForeColor = System.Drawing.Color.White;
            this.LB2D_Coordinates.Location = new System.Drawing.Point(13, 71);
            this.LB2D_Coordinates.Name = "LB2D_Coordinates";
            this.LB2D_Coordinates.Size = new System.Drawing.Size(81, 60);
            this.LB2D_Coordinates.TabIndex = 4;
            this.LB2D_Coordinates.Text = "Coordinates\r\nX: 0\r\nY: 0\r\n";
            // 
            // NUD2D_LineSize
            // 
            this.NUD2D_LineSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.NUD2D_LineSize.DecimalPlaces = 2;
            this.NUD2D_LineSize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD2D_LineSize.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NUD2D_LineSize.Location = new System.Drawing.Point(108, 106);
            this.NUD2D_LineSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD2D_LineSize.Name = "NUD2D_LineSize";
            this.NUD2D_LineSize.Size = new System.Drawing.Size(120, 25);
            this.NUD2D_LineSize.TabIndex = 2;
            this.NUD2D_LineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD2D_LineSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CB2D_Geometry
            // 
            this.CB2D_Geometry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CB2D_Geometry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB2D_Geometry.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB2D_Geometry.FormattingEnabled = true;
            this.CB2D_Geometry.Items.AddRange(new object[] {
            "GL_LINES",
            "GL_LINE_LOOP",
            "GL_LINE_STRIP",
            "GL_TRIANGLES",
            "GL_TRIANGLE_STRIP",
            "GL_TRIANGLE_FAN",
            "GL_QUADS",
            "GL_QUAD_STRIP",
            "GL_POLYGON"});
            this.CB2D_Geometry.Location = new System.Drawing.Point(108, 71);
            this.CB2D_Geometry.Name = "CB2D_Geometry";
            this.CB2D_Geometry.Size = new System.Drawing.Size(120, 23);
            this.CB2D_Geometry.TabIndex = 1;
            this.CB2D_Geometry.SelectedIndexChanged += new System.EventHandler(this.CB2D_Geometry_SelectedIndexChanged);
            // 
            // BTN2D_NewPoint
            // 
            this.BTN2D_NewPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.BTN2D_NewPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2D_NewPoint.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2D_NewPoint.Location = new System.Drawing.Point(17, 202);
            this.BTN2D_NewPoint.Name = "BTN2D_NewPoint";
            this.BTN2D_NewPoint.Size = new System.Drawing.Size(90, 40);
            this.BTN2D_NewPoint.TabIndex = 4;
            this.BTN2D_NewPoint.Text = "New Point";
            this.BTN2D_NewPoint.UseVisualStyleBackColor = false;
            this.BTN2D_NewPoint.Click += new System.EventHandler(this.BTN2D_NewPoint_Click);
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 68);
            label1.TabIndex = 0;
            label1.Text = "OPTIONS 2D";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TC_Drawing
            // 
            this.TC_Drawing.Controls.Add(this.tabPage1);
            this.TC_Drawing.Controls.Add(this.tabPage2);
            this.TC_Drawing.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_Drawing.Location = new System.Drawing.Point(0, 0);
            this.TC_Drawing.Name = "TC_Drawing";
            this.TC_Drawing.SelectedIndex = 0;
            this.TC_Drawing.Size = new System.Drawing.Size(594, 429);
            this.TC_Drawing.TabIndex = 0;
            this.TC_Drawing.SelectedIndexChanged += new System.EventHandler(this.TC_Drawing_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tabPage1.Controls.Add(this.PanelOpenGL2D);
            this.tabPage1.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Draw 2D";
            // 
            // PanelOpenGL2D
            // 
            this.PanelOpenGL2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOpenGL2D.DrawFPS = false;
            this.PanelOpenGL2D.Location = new System.Drawing.Point(3, 3);
            this.PanelOpenGL2D.Name = "PanelOpenGL2D";
            this.PanelOpenGL2D.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.PanelOpenGL2D.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.PanelOpenGL2D.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.PanelOpenGL2D.Size = new System.Drawing.Size(580, 390);
            this.PanelOpenGL2D.TabIndex = 0;
            this.PanelOpenGL2D.OpenGLInitialized += new System.EventHandler(this.PanelOpenGL2D_OpenGLInitialized);
            this.PanelOpenGL2D.OpenGLDraw += new SharpGL.RenderEventHandler(this.PanelOpenGL2D_OpenGLDraw);
            this.PanelOpenGL2D.Resized += new System.EventHandler(this.PanelOpenGL2D_Resized);
            this.PanelOpenGL2D.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGL2D_MouseClick);
            this.PanelOpenGL2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGL2D_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tabPage2.Controls.Add(this.PanelOpenGL3D);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Draw 3D";
            // 
            // PanelOpenGL3D
            // 
            this.PanelOpenGL3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOpenGL3D.DrawFPS = false;
            this.PanelOpenGL3D.Location = new System.Drawing.Point(3, 3);
            this.PanelOpenGL3D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelOpenGL3D.Name = "PanelOpenGL3D";
            this.PanelOpenGL3D.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.PanelOpenGL3D.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.PanelOpenGL3D.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.PanelOpenGL3D.Size = new System.Drawing.Size(580, 390);
            this.PanelOpenGL3D.TabIndex = 0;
            this.PanelOpenGL3D.OpenGLInitialized += new System.EventHandler(this.PanelOpenGL3D_OpenGLInitialized);
            this.PanelOpenGL3D.OpenGLDraw += new SharpGL.RenderEventHandler(this.PanelOpenGL3D_OpenGLDraw);
            this.PanelOpenGL3D.Resized += new System.EventHandler(this.PanelOpenGL3D_Resized);
            this.PanelOpenGL3D.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelOpenGL3D_KeyDown);
            // 
            // LBL_ScrewyGL
            // 
            this.LBL_ScrewyGL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LBL_ScrewyGL.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_ScrewyGL.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ScrewyGL.ForeColor = System.Drawing.Color.White;
            this.LBL_ScrewyGL.Location = new System.Drawing.Point(0, 0);
            this.LBL_ScrewyGL.Name = "LBL_ScrewyGL";
            this.LBL_ScrewyGL.Size = new System.Drawing.Size(834, 92);
            this.LBL_ScrewyGL.TabIndex = 0;
            this.LBL_ScrewyGL.Text = "ScrewyGL";
            this.LBL_ScrewyGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(PN_Content);
            this.Controls.Add(this.LBL_ScrewyGL);
            this.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SGL";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrewyGL | M3RFR3T & IKnowMartha";
            this.Load += new System.EventHandler(this.SGL_Load);
            PN_Content.ResumeLayout(false);
            this.PN3D_Options.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD3D_MoveCant)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.PN2D_Options.ResumeLayout(false);
            this.PN2D_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD2D_LineSize)).EndInit();
            this.TC_Drawing.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL2D)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL3D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC_Drawing;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PN2D_Options;
        private SharpGL.OpenGLControl PanelOpenGL2D;
        private System.Windows.Forms.Panel PN3D_Options;
        private System.Windows.Forms.NumericUpDown NUD2D_LineSize;
        private System.Windows.Forms.ComboBox CB2D_Geometry;
        private System.Windows.Forms.Button BTN2D_NewPoint;
        private System.Windows.Forms.Label LB2D_Coordinates;
        private System.Windows.Forms.Button BTN2D_Color;
        private System.Windows.Forms.Button BTN2D_Stop;
        private System.Windows.Forms.Button BTN2D_ClearAll;
        private System.Windows.Forms.Button BTN2D_ClearPoints;
        private System.Windows.Forms.Button BTN2D_ShowResult;
        private System.Windows.Forms.Button BTN2D_Undo;
        private System.Windows.Forms.Button BTN2D_Redo;
        private SharpGL.OpenGLControl PanelOpenGL3D;
        private System.Windows.Forms.ComboBox CB3D_Figure;
        private System.Windows.Forms.Button BTN3D_NewFigure;
        private System.Windows.Forms.TextBox TB3D_Name;
        private System.Windows.Forms.Button BTN3D_PosX;
        private System.Windows.Forms.Button BTN3D_PosZ;
        private System.Windows.Forms.Button BTN3D_PosY;
        private System.Windows.Forms.RadioButton RB3D_Scale;
        private System.Windows.Forms.RadioButton RB3D_Translate;
        private System.Windows.Forms.RadioButton RB3D_Rotate;
        private System.Windows.Forms.NumericUpDown NUD3D_MoveCant;
        private System.Windows.Forms.Button BTN3D_ClearAll;
        private System.Windows.Forms.Button BTN3D_DelFigure;
        private System.Windows.Forms.ListBox LB3D_Figures;
        private System.Windows.Forms.Button BTN3D_ShowResult;
        private System.Windows.Forms.Label LBL_ScrewyGL;
        private System.Windows.Forms.Button BTN3D_Color;
    }
}

