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
            System.Windows.Forms.Label LB_Options;
            System.Windows.Forms.Label LB_Color;
            System.Windows.Forms.Panel Panel_Main;
            System.Windows.Forms.Panel Panel_Left;
            System.Windows.Forms.GroupBox GP_Create;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label LB_Name3D;
            System.Windows.Forms.GroupBox GP_Manage;
            System.Windows.Forms.Label LB_Options3D;
            System.Windows.Forms.TabPage TabPage_2D;
            System.Windows.Forms.TabPage TabPage_3D;
            System.Windows.Forms.Panel Panel_Header;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGL));
            this.Panel_Right3D = new System.Windows.Forms.Panel();
            this.TB_Name3D = new System.Windows.Forms.TextBox();
            this.CB_Figure3D = new System.Windows.Forms.ComboBox();
            this.BTN_CreateFigure3D = new System.Windows.Forms.Button();
            this.LB_Figures3D = new System.Windows.Forms.ListBox();
            this.NUD_MovePos3D = new System.Windows.Forms.NumericUpDown();
            this.RB_Translate3D = new System.Windows.Forms.RadioButton();
            this.BTN_PosZ = new System.Windows.Forms.Button();
            this.RB_Rotate3D = new System.Windows.Forms.RadioButton();
            this.BTN_PosY = new System.Windows.Forms.Button();
            this.RB_Scale3D = new System.Windows.Forms.RadioButton();
            this.BTN_PosX = new System.Windows.Forms.Button();
            this.BTN_DelFigure3D = new System.Windows.Forms.Button();
            this.BTN_Result3D = new System.Windows.Forms.Button();
            this.BTN_ClearFigures3D = new System.Windows.Forms.Button();
            this.TabControlDraw = new System.Windows.Forms.TabControl();
            this.PanelOpenGL2D = new SharpGL.OpenGLControl();
            this.SceneControl3D = new SharpGL.SceneControl();
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.BTN_ClearPoints = new System.Windows.Forms.Button();
            this.NUD_LineSize = new System.Windows.Forms.NumericUpDown();
            this.BTN_Result = new System.Windows.Forms.Button();
            this.BTN_Remove_Picture = new System.Windows.Forms.Button();
            this.BTN_Upload_Picture = new System.Windows.Forms.Button();
            this.BTN_ClearDraw = new System.Windows.Forms.Button();
            this.LB_Coordinates = new System.Windows.Forms.Label();
            this.BTN_Color = new System.Windows.Forms.Button();
            this.CB_Geometry = new System.Windows.Forms.ComboBox();
            this.BTN_NewPoint = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.LB_ScrewyGL = new System.Windows.Forms.Label();
            LB_Options = new System.Windows.Forms.Label();
            LB_Color = new System.Windows.Forms.Label();
            Panel_Main = new System.Windows.Forms.Panel();
            Panel_Left = new System.Windows.Forms.Panel();
            GP_Create = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            LB_Name3D = new System.Windows.Forms.Label();
            GP_Manage = new System.Windows.Forms.GroupBox();
            LB_Options3D = new System.Windows.Forms.Label();
            TabPage_2D = new System.Windows.Forms.TabPage();
            TabPage_3D = new System.Windows.Forms.TabPage();
            Panel_Header = new System.Windows.Forms.Panel();
            Panel_Main.SuspendLayout();
            Panel_Left.SuspendLayout();
            this.Panel_Right3D.SuspendLayout();
            GP_Create.SuspendLayout();
            GP_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MovePos3D)).BeginInit();
            this.TabControlDraw.SuspendLayout();
            TabPage_2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL2D)).BeginInit();
            TabPage_3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SceneControl3D)).BeginInit();
            this.Panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LineSize)).BeginInit();
            Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Options
            // 
            LB_Options.AutoSize = true;
            LB_Options.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Options.ForeColor = System.Drawing.Color.White;
            LB_Options.Location = new System.Drawing.Point(47, 15);
            LB_Options.Name = "LB_Options";
            LB_Options.Size = new System.Drawing.Size(140, 32);
            LB_Options.TabIndex = 2;
            LB_Options.Text = "OPTIONS 2D";
            // 
            // LB_Color
            // 
            LB_Color.AutoSize = true;
            LB_Color.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Color.ForeColor = System.Drawing.Color.White;
            LB_Color.Location = new System.Drawing.Point(10, 213);
            LB_Color.Name = "LB_Color";
            LB_Color.Size = new System.Drawing.Size(55, 24);
            LB_Color.TabIndex = 10;
            LB_Color.Text = "Color:";
            // 
            // Panel_Main
            // 
            Panel_Main.Controls.Add(Panel_Left);
            Panel_Main.Controls.Add(this.Panel_Right);
            Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel_Main.Location = new System.Drawing.Point(0, 94);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new System.Drawing.Size(830, 430);
            Panel_Main.TabIndex = 16;
            // 
            // Panel_Left
            // 
            Panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            Panel_Left.Controls.Add(this.Panel_Right3D);
            Panel_Left.Controls.Add(this.TabControlDraw);
            Panel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel_Left.Location = new System.Drawing.Point(0, 0);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new System.Drawing.Size(591, 430);
            Panel_Left.TabIndex = 16;
            // 
            // Panel_Right3D
            // 
            this.Panel_Right3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel_Right3D.Controls.Add(GP_Create);
            this.Panel_Right3D.Controls.Add(GP_Manage);
            this.Panel_Right3D.Controls.Add(this.BTN_DelFigure3D);
            this.Panel_Right3D.Controls.Add(this.BTN_Result3D);
            this.Panel_Right3D.Controls.Add(LB_Options3D);
            this.Panel_Right3D.Controls.Add(this.BTN_ClearFigures3D);
            this.Panel_Right3D.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Right3D.Location = new System.Drawing.Point(291, 0);
            this.Panel_Right3D.Name = "Panel_Right3D";
            this.Panel_Right3D.Size = new System.Drawing.Size(300, 430);
            this.Panel_Right3D.TabIndex = 16;
            // 
            // GP_Create
            // 
            GP_Create.Controls.Add(label1);
            GP_Create.Controls.Add(LB_Name3D);
            GP_Create.Controls.Add(this.TB_Name3D);
            GP_Create.Controls.Add(this.CB_Figure3D);
            GP_Create.Controls.Add(this.BTN_CreateFigure3D);
            GP_Create.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GP_Create.ForeColor = System.Drawing.SystemColors.ButtonFace;
            GP_Create.Location = new System.Drawing.Point(6, 50);
            GP_Create.Name = "GP_Create";
            GP_Create.Size = new System.Drawing.Size(141, 270);
            GP_Create.TabIndex = 24;
            GP_Create.TabStop = false;
            GP_Create.Text = "Create";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 24);
            label1.TabIndex = 14;
            label1.Text = "Figure:";
            // 
            // LB_Name3D
            // 
            LB_Name3D.AutoSize = true;
            LB_Name3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Name3D.ForeColor = System.Drawing.Color.White;
            LB_Name3D.Location = new System.Drawing.Point(10, 28);
            LB_Name3D.Name = "LB_Name3D";
            LB_Name3D.Size = new System.Drawing.Size(63, 24);
            LB_Name3D.TabIndex = 13;
            LB_Name3D.Text = "Name:";
            // 
            // TB_Name3D
            // 
            this.TB_Name3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name3D.Location = new System.Drawing.Point(12, 67);
            this.TB_Name3D.Name = "TB_Name3D";
            this.TB_Name3D.Size = new System.Drawing.Size(116, 25);
            this.TB_Name3D.TabIndex = 11;
            // 
            // CB_Figure3D
            // 
            this.CB_Figure3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CB_Figure3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Figure3D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Figure3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Figure3D.FormattingEnabled = true;
            this.CB_Figure3D.Items.AddRange(new object[] {
            "CUBE",
            "CONE",
            "SPHERE",
            "CYLINDER"});
            this.CB_Figure3D.Location = new System.Drawing.Point(12, 158);
            this.CB_Figure3D.Name = "CB_Figure3D";
            this.CB_Figure3D.Size = new System.Drawing.Size(116, 26);
            this.CB_Figure3D.TabIndex = 12;
            // 
            // BTN_CreateFigure3D
            // 
            this.BTN_CreateFigure3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.BTN_CreateFigure3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CreateFigure3D.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_CreateFigure3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CreateFigure3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CreateFigure3D.ForeColor = System.Drawing.Color.Black;
            this.BTN_CreateFigure3D.Location = new System.Drawing.Point(12, 214);
            this.BTN_CreateFigure3D.Name = "BTN_CreateFigure3D";
            this.BTN_CreateFigure3D.Size = new System.Drawing.Size(116, 43);
            this.BTN_CreateFigure3D.TabIndex = 13;
            this.BTN_CreateFigure3D.Text = "New";
            this.BTN_CreateFigure3D.UseVisualStyleBackColor = false;
            this.BTN_CreateFigure3D.Click += new System.EventHandler(this.BTN_CreateFigure3D_Click);
            // 
            // GP_Manage
            // 
            GP_Manage.Controls.Add(this.LB_Figures3D);
            GP_Manage.Controls.Add(this.NUD_MovePos3D);
            GP_Manage.Controls.Add(this.RB_Translate3D);
            GP_Manage.Controls.Add(this.BTN_PosZ);
            GP_Manage.Controls.Add(this.RB_Rotate3D);
            GP_Manage.Controls.Add(this.BTN_PosY);
            GP_Manage.Controls.Add(this.RB_Scale3D);
            GP_Manage.Controls.Add(this.BTN_PosX);
            GP_Manage.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GP_Manage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            GP_Manage.Location = new System.Drawing.Point(152, 50);
            GP_Manage.Name = "GP_Manage";
            GP_Manage.Size = new System.Drawing.Size(141, 270);
            GP_Manage.TabIndex = 23;
            GP_Manage.TabStop = false;
            GP_Manage.Text = "Manage";
            // 
            // LB_Figures3D
            // 
            this.LB_Figures3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Figures3D.FormattingEnabled = true;
            this.LB_Figures3D.ItemHeight = 18;
            this.LB_Figures3D.Location = new System.Drawing.Point(15, 22);
            this.LB_Figures3D.Name = "LB_Figures3D";
            this.LB_Figures3D.Size = new System.Drawing.Size(115, 58);
            this.LB_Figures3D.TabIndex = 14;
            // 
            // NUD_MovePos3D
            // 
            this.NUD_MovePos3D.BackColor = System.Drawing.Color.LightGray;
            this.NUD_MovePos3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_MovePos3D.Location = new System.Drawing.Point(15, 95);
            this.NUD_MovePos3D.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NUD_MovePos3D.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.NUD_MovePos3D.Name = "NUD_MovePos3D";
            this.NUD_MovePos3D.Size = new System.Drawing.Size(115, 25);
            this.NUD_MovePos3D.TabIndex = 15;
            this.NUD_MovePos3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_MovePos3D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RB_Translate3D
            // 
            this.RB_Translate3D.AutoSize = true;
            this.RB_Translate3D.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Translate3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RB_Translate3D.Location = new System.Drawing.Point(15, 228);
            this.RB_Translate3D.Name = "RB_Translate3D";
            this.RB_Translate3D.Size = new System.Drawing.Size(82, 23);
            this.RB_Translate3D.TabIndex = 18;
            this.RB_Translate3D.Text = "Translate";
            this.RB_Translate3D.UseVisualStyleBackColor = true;
            // 
            // BTN_PosZ
            // 
            this.BTN_PosZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_PosZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PosZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_PosZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PosZ.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PosZ.ForeColor = System.Drawing.Color.Black;
            this.BTN_PosZ.Location = new System.Drawing.Point(95, 222);
            this.BTN_PosZ.Name = "BTN_PosZ";
            this.BTN_PosZ.Size = new System.Drawing.Size(35, 35);
            this.BTN_PosZ.TabIndex = 21;
            this.BTN_PosZ.Text = "Z";
            this.BTN_PosZ.UseVisualStyleBackColor = false;
            this.BTN_PosZ.Click += new System.EventHandler(this.BTN_PosZ_Click);
            // 
            // RB_Rotate3D
            // 
            this.RB_Rotate3D.AutoSize = true;
            this.RB_Rotate3D.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Rotate3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RB_Rotate3D.Location = new System.Drawing.Point(15, 186);
            this.RB_Rotate3D.Name = "RB_Rotate3D";
            this.RB_Rotate3D.Size = new System.Drawing.Size(66, 23);
            this.RB_Rotate3D.TabIndex = 17;
            this.RB_Rotate3D.Text = "Rotate";
            this.RB_Rotate3D.UseVisualStyleBackColor = true;
            // 
            // BTN_PosY
            // 
            this.BTN_PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_PosY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PosY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_PosY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PosY.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PosY.ForeColor = System.Drawing.Color.Black;
            this.BTN_PosY.Location = new System.Drawing.Point(95, 181);
            this.BTN_PosY.Name = "BTN_PosY";
            this.BTN_PosY.Size = new System.Drawing.Size(35, 35);
            this.BTN_PosY.TabIndex = 20;
            this.BTN_PosY.Text = "Y";
            this.BTN_PosY.UseVisualStyleBackColor = false;
            this.BTN_PosY.Click += new System.EventHandler(this.BTN_PosY_Click);
            // 
            // RB_Scale3D
            // 
            this.RB_Scale3D.AutoSize = true;
            this.RB_Scale3D.Checked = true;
            this.RB_Scale3D.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Scale3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RB_Scale3D.Location = new System.Drawing.Point(15, 145);
            this.RB_Scale3D.Name = "RB_Scale3D";
            this.RB_Scale3D.Size = new System.Drawing.Size(56, 23);
            this.RB_Scale3D.TabIndex = 16;
            this.RB_Scale3D.TabStop = true;
            this.RB_Scale3D.Text = "Scale";
            this.RB_Scale3D.UseVisualStyleBackColor = true;
            // 
            // BTN_PosX
            // 
            this.BTN_PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_PosX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PosX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_PosX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PosX.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PosX.ForeColor = System.Drawing.Color.Black;
            this.BTN_PosX.Location = new System.Drawing.Point(95, 140);
            this.BTN_PosX.Name = "BTN_PosX";
            this.BTN_PosX.Size = new System.Drawing.Size(35, 35);
            this.BTN_PosX.TabIndex = 19;
            this.BTN_PosX.Text = "X";
            this.BTN_PosX.UseVisualStyleBackColor = false;
            this.BTN_PosX.Click += new System.EventHandler(this.BTN_PosX_Click);
            // 
            // BTN_DelFigure3D
            // 
            this.BTN_DelFigure3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.BTN_DelFigure3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DelFigure3D.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_DelFigure3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DelFigure3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DelFigure3D.ForeColor = System.Drawing.Color.Black;
            this.BTN_DelFigure3D.Location = new System.Drawing.Point(6, 326);
            this.BTN_DelFigure3D.Name = "BTN_DelFigure3D";
            this.BTN_DelFigure3D.Size = new System.Drawing.Size(141, 43);
            this.BTN_DelFigure3D.TabIndex = 22;
            this.BTN_DelFigure3D.Text = "Del Figure";
            this.BTN_DelFigure3D.UseVisualStyleBackColor = false;
            this.BTN_DelFigure3D.Click += new System.EventHandler(this.BTN_DelFigure3D_Click);
            // 
            // BTN_Result3D
            // 
            this.BTN_Result3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(99)))));
            this.BTN_Result3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Result3D.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Result3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Result3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Result3D.ForeColor = System.Drawing.Color.Black;
            this.BTN_Result3D.Location = new System.Drawing.Point(6, 375);
            this.BTN_Result3D.Name = "BTN_Result3D";
            this.BTN_Result3D.Size = new System.Drawing.Size(287, 43);
            this.BTN_Result3D.TabIndex = 24;
            this.BTN_Result3D.Text = "Show Result";
            this.BTN_Result3D.UseVisualStyleBackColor = false;
            this.BTN_Result3D.Click += new System.EventHandler(this.BTN_Result3D_Click);
            // 
            // LB_Options3D
            // 
            LB_Options3D.AutoSize = true;
            LB_Options3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_Options3D.ForeColor = System.Drawing.Color.White;
            LB_Options3D.Location = new System.Drawing.Point(76, 15);
            LB_Options3D.Name = "LB_Options3D";
            LB_Options3D.Size = new System.Drawing.Size(140, 32);
            LB_Options3D.TabIndex = 2;
            LB_Options3D.Text = "OPTIONS 3D";
            // 
            // BTN_ClearFigures3D
            // 
            this.BTN_ClearFigures3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.BTN_ClearFigures3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearFigures3D.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ClearFigures3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearFigures3D.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearFigures3D.ForeColor = System.Drawing.Color.Black;
            this.BTN_ClearFigures3D.Location = new System.Drawing.Point(152, 326);
            this.BTN_ClearFigures3D.Name = "BTN_ClearFigures3D";
            this.BTN_ClearFigures3D.Size = new System.Drawing.Size(140, 43);
            this.BTN_ClearFigures3D.TabIndex = 23;
            this.BTN_ClearFigures3D.Text = "Clear All";
            this.BTN_ClearFigures3D.UseVisualStyleBackColor = false;
            this.BTN_ClearFigures3D.Click += new System.EventHandler(this.BTN_ClearFigures3D_Click);
            // 
            // TabControlDraw
            // 
            this.TabControlDraw.Controls.Add(TabPage_2D);
            this.TabControlDraw.Controls.Add(TabPage_3D);
            this.TabControlDraw.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlDraw.Location = new System.Drawing.Point(0, 0);
            this.TabControlDraw.Name = "TabControlDraw";
            this.TabControlDraw.SelectedIndex = 0;
            this.TabControlDraw.Size = new System.Drawing.Size(588, 430);
            this.TabControlDraw.TabIndex = 15;
            this.TabControlDraw.SelectedIndexChanged += new System.EventHandler(this.TabControlDraw_SelectedIndexChanged);
            // 
            // TabPage_2D
            // 
            TabPage_2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            TabPage_2D.Controls.Add(this.PanelOpenGL2D);
            TabPage_2D.Location = new System.Drawing.Point(4, 29);
            TabPage_2D.Name = "TabPage_2D";
            TabPage_2D.Padding = new System.Windows.Forms.Padding(3);
            TabPage_2D.Size = new System.Drawing.Size(580, 397);
            TabPage_2D.TabIndex = 0;
            TabPage_2D.Text = "Draw 2D";
            // 
            // PanelOpenGL2D
            // 
            this.PanelOpenGL2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOpenGL2D.DrawFPS = false;
            this.PanelOpenGL2D.Location = new System.Drawing.Point(3, 3);
            this.PanelOpenGL2D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelOpenGL2D.Name = "PanelOpenGL2D";
            this.PanelOpenGL2D.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.PanelOpenGL2D.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.PanelOpenGL2D.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.PanelOpenGL2D.Size = new System.Drawing.Size(574, 391);
            this.PanelOpenGL2D.TabIndex = 14;
            this.PanelOpenGL2D.OpenGLInitialized += new System.EventHandler(this.PanelOpenGL2D_OpenGLInitialized);
            this.PanelOpenGL2D.OpenGLDraw += new SharpGL.RenderEventHandler(this.PanelOpenGL2D_OpenGLDraw);
            this.PanelOpenGL2D.Resized += new System.EventHandler(this.PanelOpenGL2D_Resized);
            this.PanelOpenGL2D.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGL_MouseClick);
            this.PanelOpenGL2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGL_MouseMove);
            // 
            // TabPage_3D
            // 
            TabPage_3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            TabPage_3D.Controls.Add(this.SceneControl3D);
            TabPage_3D.Location = new System.Drawing.Point(4, 29);
            TabPage_3D.Name = "TabPage_3D";
            TabPage_3D.Padding = new System.Windows.Forms.Padding(3);
            TabPage_3D.Size = new System.Drawing.Size(580, 397);
            TabPage_3D.TabIndex = 1;
            TabPage_3D.Text = "Draw 3D";
            // 
            // SceneControl3D
            // 
            this.SceneControl3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneControl3D.DrawFPS = false;
            this.SceneControl3D.Location = new System.Drawing.Point(3, 3);
            this.SceneControl3D.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.SceneControl3D.Name = "SceneControl3D";
            this.SceneControl3D.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.SceneControl3D.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.SceneControl3D.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.SceneControl3D.Size = new System.Drawing.Size(574, 391);
            this.SceneControl3D.TabIndex = 16;
            this.SceneControl3D.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SceneControl3D_KeyDown);
            // 
            // Panel_Right
            // 
            this.Panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel_Right.Controls.Add(this.BTN_ClearPoints);
            this.Panel_Right.Controls.Add(this.NUD_LineSize);
            this.Panel_Right.Controls.Add(this.BTN_Result);
            this.Panel_Right.Controls.Add(LB_Options);
            this.Panel_Right.Controls.Add(this.BTN_Remove_Picture);
            this.Panel_Right.Controls.Add(this.BTN_Upload_Picture);
            this.Panel_Right.Controls.Add(this.BTN_ClearDraw);
            this.Panel_Right.Controls.Add(this.LB_Coordinates);
            this.Panel_Right.Controls.Add(this.BTN_Color);
            this.Panel_Right.Controls.Add(this.CB_Geometry);
            this.Panel_Right.Controls.Add(LB_Color);
            this.Panel_Right.Controls.Add(this.BTN_NewPoint);
            this.Panel_Right.Controls.Add(this.BTN_Stop);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Right.Location = new System.Drawing.Point(591, 0);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(239, 430);
            this.Panel_Right.TabIndex = 15;
            // 
            // BTN_ClearPoints
            // 
            this.BTN_ClearPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.BTN_ClearPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearPoints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ClearPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearPoints.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearPoints.ForeColor = System.Drawing.Color.Black;
            this.BTN_ClearPoints.Location = new System.Drawing.Point(14, 316);
            this.BTN_ClearPoints.Name = "BTN_ClearPoints";
            this.BTN_ClearPoints.Size = new System.Drawing.Size(95, 43);
            this.BTN_ClearPoints.TabIndex = 8;
            this.BTN_ClearPoints.Text = "Clear Points";
            this.BTN_ClearPoints.UseVisualStyleBackColor = false;
            this.BTN_ClearPoints.Click += new System.EventHandler(this.BTN_ClearPoints_Click);
            // 
            // NUD_LineSize
            // 
            this.NUD_LineSize.BackColor = System.Drawing.Color.LightGray;
            this.NUD_LineSize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_LineSize.Location = new System.Drawing.Point(101, 168);
            this.NUD_LineSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_LineSize.Name = "NUD_LineSize";
            this.NUD_LineSize.Size = new System.Drawing.Size(117, 25);
            this.NUD_LineSize.TabIndex = 4;
            this.NUD_LineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_LineSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_Result
            // 
            this.BTN_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(99)))));
            this.BTN_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Result.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Result.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Result.ForeColor = System.Drawing.Color.Black;
            this.BTN_Result.Location = new System.Drawing.Point(14, 375);
            this.BTN_Result.Name = "BTN_Result";
            this.BTN_Result.Size = new System.Drawing.Size(204, 43);
            this.BTN_Result.TabIndex = 10;
            this.BTN_Result.Text = "Show Result";
            this.BTN_Result.UseVisualStyleBackColor = false;
            this.BTN_Result.Click += new System.EventHandler(this.BTN_Result_Click);
            // 
            // BTN_Remove_Picture
            // 
            this.BTN_Remove_Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.BTN_Remove_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Remove_Picture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Remove_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Remove_Picture.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Remove_Picture.ForeColor = System.Drawing.Color.Black;
            this.BTN_Remove_Picture.Location = new System.Drawing.Point(123, 70);
            this.BTN_Remove_Picture.Name = "BTN_Remove_Picture";
            this.BTN_Remove_Picture.Size = new System.Drawing.Size(95, 45);
            this.BTN_Remove_Picture.TabIndex = 2;
            this.BTN_Remove_Picture.Text = "Remove Pic";
            this.BTN_Remove_Picture.UseVisualStyleBackColor = false;
            this.BTN_Remove_Picture.Click += new System.EventHandler(this.BTN_Remove_Picture_Click);
            // 
            // BTN_Upload_Picture
            // 
            this.BTN_Upload_Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.BTN_Upload_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Upload_Picture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Upload_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Upload_Picture.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Upload_Picture.ForeColor = System.Drawing.Color.Black;
            this.BTN_Upload_Picture.Location = new System.Drawing.Point(14, 70);
            this.BTN_Upload_Picture.Name = "BTN_Upload_Picture";
            this.BTN_Upload_Picture.Size = new System.Drawing.Size(95, 45);
            this.BTN_Upload_Picture.TabIndex = 1;
            this.BTN_Upload_Picture.Text = "Upload Pic";
            this.BTN_Upload_Picture.UseVisualStyleBackColor = false;
            this.BTN_Upload_Picture.Click += new System.EventHandler(this.BTN_Upload_Picture_Click);
            // 
            // BTN_ClearDraw
            // 
            this.BTN_ClearDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.BTN_ClearDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ClearDraw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_ClearDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearDraw.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearDraw.ForeColor = System.Drawing.Color.Black;
            this.BTN_ClearDraw.Location = new System.Drawing.Point(123, 316);
            this.BTN_ClearDraw.Name = "BTN_ClearDraw";
            this.BTN_ClearDraw.Size = new System.Drawing.Size(95, 43);
            this.BTN_ClearDraw.TabIndex = 9;
            this.BTN_ClearDraw.Text = "Clear All";
            this.BTN_ClearDraw.UseVisualStyleBackColor = false;
            this.BTN_ClearDraw.Click += new System.EventHandler(this.BTN_ClearAll_Click);
            // 
            // LB_Coordinates
            // 
            this.LB_Coordinates.AutoSize = true;
            this.LB_Coordinates.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Coordinates.ForeColor = System.Drawing.Color.White;
            this.LB_Coordinates.Location = new System.Drawing.Point(10, 130);
            this.LB_Coordinates.Name = "LB_Coordinates";
            this.LB_Coordinates.Size = new System.Drawing.Size(81, 60);
            this.LB_Coordinates.TabIndex = 5;
            this.LB_Coordinates.Text = "Coordinates\r\nX: 0\r\nY: 0";
            // 
            // BTN_Color
            // 
            this.BTN_Color.BackColor = System.Drawing.Color.Black;
            this.BTN_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Color.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Color.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Color.ForeColor = System.Drawing.Color.Black;
            this.BTN_Color.Location = new System.Drawing.Point(71, 208);
            this.BTN_Color.Name = "BTN_Color";
            this.BTN_Color.Size = new System.Drawing.Size(147, 39);
            this.BTN_Color.TabIndex = 5;
            this.BTN_Color.UseVisualStyleBackColor = false;
            this.BTN_Color.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // CB_Geometry
            // 
            this.CB_Geometry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CB_Geometry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Geometry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Geometry.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Geometry.FormattingEnabled = true;
            this.CB_Geometry.Items.AddRange(new object[] {
            "GL_LINES",
            "GL_LINE_LOOP",
            "GL_LINE_STRIP",
            "GL_TRIANGLES",
            "GL_TRIANGLE_STRIP",
            "GL_TRIANGLE_FAN",
            "GL_QUADS",
            "GL_QUAD_STRIP",
            "GL_POLYGON"});
            this.CB_Geometry.Location = new System.Drawing.Point(101, 130);
            this.CB_Geometry.Name = "CB_Geometry";
            this.CB_Geometry.Size = new System.Drawing.Size(117, 23);
            this.CB_Geometry.TabIndex = 3;
            this.CB_Geometry.SelectedIndexChanged += new System.EventHandler(this.CB_Geometry_SelectedIndexChanged);
            // 
            // BTN_NewPoint
            // 
            this.BTN_NewPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(106)))));
            this.BTN_NewPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_NewPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_NewPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NewPoint.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NewPoint.ForeColor = System.Drawing.Color.Black;
            this.BTN_NewPoint.Location = new System.Drawing.Point(14, 258);
            this.BTN_NewPoint.Name = "BTN_NewPoint";
            this.BTN_NewPoint.Size = new System.Drawing.Size(93, 42);
            this.BTN_NewPoint.TabIndex = 6;
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
            this.BTN_Stop.Location = new System.Drawing.Point(125, 258);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(93, 42);
            this.BTN_Stop.TabIndex = 7;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = false;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // Panel_Header
            // 
            Panel_Header.Controls.Add(this.LB_ScrewyGL);
            Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            Panel_Header.Location = new System.Drawing.Point(0, 0);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new System.Drawing.Size(830, 94);
            Panel_Header.TabIndex = 1;
            // 
            // LB_ScrewyGL
            // 
            this.LB_ScrewyGL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LB_ScrewyGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_ScrewyGL.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ScrewyGL.ForeColor = System.Drawing.Color.White;
            this.LB_ScrewyGL.Location = new System.Drawing.Point(0, 0);
            this.LB_ScrewyGL.Name = "LB_ScrewyGL";
            this.LB_ScrewyGL.Size = new System.Drawing.Size(830, 94);
            this.LB_ScrewyGL.TabIndex = 0;
            this.LB_ScrewyGL.Text = "ScrewyGL";
            this.LB_ScrewyGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(830, 524);
            this.Controls.Add(Panel_Main);
            this.Controls.Add(Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrewyGL | BY M3RFR3T | github.com/RazeLeakers";
            Panel_Main.ResumeLayout(false);
            Panel_Left.ResumeLayout(false);
            this.Panel_Right3D.ResumeLayout(false);
            this.Panel_Right3D.PerformLayout();
            GP_Create.ResumeLayout(false);
            GP_Create.PerformLayout();
            GP_Manage.ResumeLayout(false);
            GP_Manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MovePos3D)).EndInit();
            this.TabControlDraw.ResumeLayout(false);
            TabPage_2D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOpenGL2D)).EndInit();
            TabPage_3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SceneControl3D)).EndInit();
            this.Panel_Right.ResumeLayout(false);
            this.Panel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LineSize)).EndInit();
            Panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Upload_Picture;
        private System.Windows.Forms.Label LB_Coordinates;
        private System.Windows.Forms.ComboBox CB_Geometry;
        private System.Windows.Forms.Button BTN_Result;
        private System.Windows.Forms.Button BTN_NewPoint;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Button BTN_Color;
        private System.Windows.Forms.Button BTN_ClearDraw;
        private System.Windows.Forms.Button BTN_Remove_Picture;
        private SharpGL.OpenGLControl PanelOpenGL2D;
        private System.Windows.Forms.NumericUpDown NUD_LineSize;
        private System.Windows.Forms.Button BTN_ClearPoints;
        private System.Windows.Forms.Panel Panel_Right;
        private System.Windows.Forms.TabControl TabControlDraw;
        private System.Windows.Forms.Panel Panel_Right3D;
        private System.Windows.Forms.Button BTN_DelFigure3D;
        private System.Windows.Forms.Button BTN_Result3D;
        private System.Windows.Forms.Button BTN_ClearFigures3D;
        private System.Windows.Forms.Button BTN_CreateFigure3D;
        private System.Windows.Forms.ComboBox CB_Figure3D;
        private SharpGL.SceneControl SceneControl3D;
        private System.Windows.Forms.ListBox LB_Figures3D;
        private System.Windows.Forms.Label LB_ScrewyGL;
        private System.Windows.Forms.RadioButton RB_Translate3D;
        private System.Windows.Forms.RadioButton RB_Scale3D;
        private System.Windows.Forms.RadioButton RB_Rotate3D;
        private System.Windows.Forms.Button BTN_PosZ;
        private System.Windows.Forms.Button BTN_PosY;
        private System.Windows.Forms.Button BTN_PosX;
        private System.Windows.Forms.NumericUpDown NUD_MovePos3D;
        private System.Windows.Forms.TextBox TB_Name3D;
    }
}
