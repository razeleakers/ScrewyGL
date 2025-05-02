using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using SharpGL.Enumerations;
using ScrewyGL.Drawing;
using ScrewyGL.Drawing.Models;

namespace ScrewyGL
{
    public partial class SGL : Form
    {
        // 2D
        private SW_Register2D _ListDrawings2D;
        private SW_Draw2D _Draw2D;
        private int _TotalPoints2D = 0;
        // 3D
        private SW_Register3D _ListDrawings3D;
        private SW_Camera3D _Camera3D;
        private float[] L_POSITION = new float[] { 0.0f, 5.0f, 10.0f, 1.0f };

        public SGL()
        {
            InitializeComponent();
        }

        private void SGL_Load(object sender, EventArgs e)
        {
            CB2D_Geometry.Text = "GL_LINES";
            CB3D_Figure.Text = "CUBE";
        }

        private void TC_Drawing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_Drawing.SelectedIndex == 0)
            {
                TC_Drawing.Width = LBL_ScrewyGL.Width - PN2D_Options.Width;

                PanelOpenGL3D.FrameRate = 0;

                PN3D_Options.Visible = false;
                PN2D_Options.Visible = true;
            }
            else
            {
                TC_Drawing.Width = LBL_ScrewyGL.Width - PN3D_Options.Width;

                PanelOpenGL3D.FrameRate = 20;

                PN2D_Options.Visible = false;
                PN3D_Options.Visible = true;
            }
        }

        // DRAW 2D

        private void PanelOpenGL2D_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || _TotalPoints2D == 0) return;

            Create2DButton(e.X,e.Y);

            _Draw2D.AddPoint(new SW_Point2D(new Point(e.X, e.Y), BTN2D_Color.BackColor));

            if (_TotalPoints2D != -1) _TotalPoints2D--;

            if (_TotalPoints2D == 0)
            {
                CB2D_Geometry.Enabled = true;
                EnableDisable2DLineSize();
                BTN2D_NewPoint.Enabled = true;
                BTN2D_ShowResult.Enabled = true;
            }

            PanelOpenGL2D.DoRender();
        }

        private void PanelOpenGL2D_MouseMove(object sender, MouseEventArgs e)
        {
            LB2D_Coordinates.Text = $"Coordinates:\nX: {e.X}\nY: {e.Y}";
        }

        private void PanelOpenGL2D_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL sharpGL = PanelOpenGL2D.OpenGL;

            sharpGL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            _ListDrawings2D.RenderDrawingsObjects();

            sharpGL.Flush();
        }

        private void PanelOpenGL2D_OpenGLInitialized(object sender, System.EventArgs e)
        {
            OpenGL sharpGL = PanelOpenGL2D.OpenGL;

            this._ListDrawings2D = new SW_Register2D(sharpGL);

            sharpGL.ClearColor(155.0f / 255.0f,155.0f / 255.0f,155.0f / 255.0f, 1.0f);
        }

        private void PanelOpenGL2D_Resized(object sender, EventArgs e)
        {
            OpenGL sharpGL = PanelOpenGL2D.OpenGL;

            sharpGL.Viewport(0, 0, PanelOpenGL2D.Width, PanelOpenGL2D.Height);

            sharpGL.MatrixMode(OpenGL.GL_PROJECTION);
            sharpGL.LoadIdentity();

            sharpGL.Ortho2D(0.0d, (double)PanelOpenGL2D.Width, (double)PanelOpenGL2D.Height, 0.0d);

            sharpGL.MatrixMode(OpenGL.GL_MODELVIEW);
            sharpGL.LoadIdentity();
        }

        private void CB2D_Geometry_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisable2DLineSize();
        }

        private void BTN2D_Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    BTN2D_Color.BackColor = cd.Color;
                }
            }
        }

        private void BTN2D_NewPoint_Click(object sender, EventArgs e)
        {
            CB2D_Geometry.Enabled = false;
            NUD2D_LineSize.Enabled = false;
            BTN2D_NewPoint.Enabled = false;
            BTN2D_ShowResult.Enabled = false;

            SW_Config2D config2D;

            switch (CB2D_Geometry.SelectedItem.ToString())
            {
                case "GL_LINES":
                    _TotalPoints2D = 2;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.Lines);
                    break;
                case "GL_LINE_LOOP":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.LineLoop);
                    break;
                case "GL_LINE_STRIP":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.LineStrip);
                    break;
                case "GL_TRIANGLES":
                    _TotalPoints2D = 3;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.Triangles);
                    break;
                case "GL_TRIANGLE_STRIP":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.TriangleString);
                    break;
                case "GL_TRIANGLE_FAN":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.TriangleFan);
                    break;
                case "GL_QUADS":
                    _TotalPoints2D = 4;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.Quads);
                    break;
                case "GL_QUAD_STRIP":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.QuadStrip);
                    break;
                case "GL_POLYGON":
                    BTN2D_Stop.Enabled = true;
                    _TotalPoints2D = -1;
                    config2D = new SW_Config2D((float)NUD2D_LineSize.Value, BeginMode.Polygon);
                    break;
                default:
                    CB2D_Geometry.Enabled = true;
                    NUD2D_LineSize.Enabled = true;
                    BTN2D_NewPoint.Enabled = true;
                    BTN2D_ShowResult.Enabled = true;
                    return;
            }

            _Draw2D = new SW_Draw2D(config2D);

            _ListDrawings2D.AddDrawingObject(_Draw2D);
        }

        private void BTN2D_Stop_Click(object sender, EventArgs e)
        {
            if (_Draw2D.GetTotalPoints() == 0) _ListDrawings2D.RemoveLastDrawingObject();

            _TotalPoints2D = 0;

            CB2D_Geometry.Enabled = true;
            EnableDisable2DLineSize();
            BTN2D_NewPoint.Enabled = true;
            BTN2D_Stop.Enabled = false;
            BTN2D_ShowResult.Enabled = true;
        }

        private void BTN2D_Undo_Click(object sender, EventArgs e)
        {
            // Coming Soon...
        }

        private void BTN2D_Redo_Click(object sender, EventArgs e)
        {
            // Coming Soon...
        }

        private void BTN2D_ClearPoints_Click(object sender, EventArgs e)
        {
            PanelOpenGL2D.Controls.Clear();
        }

        private void BTN2D_ClearAll_Click(object sender, EventArgs e)
        {
            PN2D_Options.Enabled = false;

            _TotalPoints2D = 0;
            _ListDrawings2D.ClearDrawings();
            PanelOpenGL2D.Controls.Clear();
            PanelOpenGL2D.DoRender();

            _Draw2D = null;

            CB2D_Geometry.Enabled = true;
            EnableDisable2DLineSize();
            BTN2D_NewPoint.Enabled = true;
            BTN2D_Stop.Enabled = false;
            BTN2D_ShowResult.Enabled = false;

            PN2D_Options.Enabled = true;
        }

        private void BTN2D_ShowResult_Click(object sender, EventArgs e)
        {
            PN2D_Options.Enabled = false;

            using (DResult rt = new DResult(_ListDrawings2D.GetDrawingsData(PanelOpenGL2D.Width,PanelOpenGL2D.Height)))
            {
                rt.ShowDialog();
            }

            PN2D_Options.Enabled = true;
        }

        // CUSTOM 2D

        private void Create2DButton(int x,int y)
        {
            Button btn = new Button()
            {
                Cursor = Cursors.Default,
                FlatStyle = FlatStyle.Flat,
                BackColor = BTN2D_Color.BackColor,
                Size = new Size(5, 5),
                Location = new Point(x - 3,y)
            };

            btn.MouseClick += (sender, e) =>
            {
                if (BTN2D_NewPoint.Enabled)
                {
                    MessageBox.Show($"Color RGB ({btn.BackColor.R}, {btn.BackColor.G}, {btn.BackColor.B}) \nPosition (X: {btn.Location.X + 3} Y: {btn.Location.Y})","Button Info", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show($"Color RGB ({btn.BackColor.R}, {btn.BackColor.G}, {btn.BackColor.B}) \nPosition (X: {btn.Location.X + 3} Y: {btn.Location.Y})","Do you want to add this point to your draw?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btn.BackColor = BTN2D_Color.BackColor;

                    _Draw2D.AddPoint(new SW_Point2D(new Point(x, y), BTN2D_Color.BackColor));

                    if (_TotalPoints2D != -1) _TotalPoints2D--;

                    if (_TotalPoints2D == 0)
                    {
                        CB2D_Geometry.Enabled = true;
                        EnableDisable2DLineSize();
                        BTN2D_NewPoint.Enabled = true;
                        BTN2D_ShowResult.Enabled = true;
                    }

                    PanelOpenGL2D.DoRender();
                }
            };

            PanelOpenGL2D.Controls.Add(btn);
        }

        private void EnableDisable2DLineSize()
        {
            switch (CB2D_Geometry.SelectedItem.ToString())
            {
                case "GL_LINES":
                case "GL_LINE_LOOP":
                case "GL_LINE_STRIP":
                    NUD2D_LineSize.Enabled = true;
                    break;
                default:
                    NUD2D_LineSize.Value = 1;
                    NUD2D_LineSize.Enabled = false;
                    break;
            }
        }

        // DRAW 3D

        private void PanelOpenGL3D_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _Camera3D.MoveUp();
                    break;
                case Keys.A:
                    _Camera3D.MoveLeft();
                    break;
                case Keys.S:
                    _Camera3D.MoveDown();
                    break;
                case Keys.D:
                    _Camera3D.MoveRight();
                    break;
                case Keys.X:
                    _Camera3D.ZoomIn();
                    break;
                case Keys.Z:
                    _Camera3D.ZoomOut();
                    break;
            }
        }

        private void PanelOpenGL3D_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL sharpGL = PanelOpenGL3D.OpenGL;

            sharpGL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            sharpGL.MatrixMode(OpenGL.GL_MODELVIEW);
            sharpGL.LoadIdentity();
            sharpGL.LookAt(_Camera3D.EyeX, _Camera3D.EyeY, _Camera3D.EyeZ, _Camera3D.CenterX, _Camera3D.CenterY, _Camera3D.CenterZ, 0.0d ,1.0d ,0.0d);
            
            Template3D.AxisXYZ(sharpGL, 3.0f);
            Template3D.GridLines(sharpGL, 5.0f);

            sharpGL.Enable(OpenGL.GL_LIGHTING);
            sharpGL.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, L_POSITION);

            _ListDrawings3D.RenderFigures();

            sharpGL.Disable(OpenGL.GL_LIGHTING);

            sharpGL.Flush();
        }

        private void PanelOpenGL3D_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL sharpGL = PanelOpenGL3D.OpenGL;

            this._Camera3D = new SW_Camera3D();

            this._ListDrawings3D = new SW_Register3D(sharpGL);

            sharpGL.ClearColor(0.0f,0.0f,0.0f,0.0f);

            sharpGL.Enable(OpenGL.GL_DEPTH_TEST);

            sharpGL.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, new float[] { 0.2f, 0.2f, 0.2f, 1.0f });
            sharpGL.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, new float[] { 0.7f, 0.7f, 0.7f, 1.0f });

            sharpGL.Enable(OpenGL.GL_LIGHT0);

            sharpGL.Enable(OpenGL.GL_COLOR_MATERIAL);
            sharpGL.ColorMaterial(OpenGL.GL_FRONT, OpenGL.GL_AMBIENT_AND_DIFFUSE);

            // Better alternative: GL_SMOOTH
            sharpGL.ShadeModel(OpenGL.GL_FLAT);

            sharpGL.Enable(OpenGL.GL_NORMALIZE);
        }

        private void PanelOpenGL3D_Resized(object sender, EventArgs e)
        {
            OpenGL sharpGL = PanelOpenGL3D.OpenGL;

            sharpGL.Viewport(0, 0, PanelOpenGL3D.Width, PanelOpenGL3D.Height);

            sharpGL.MatrixMode(OpenGL.GL_PROJECTION);
            sharpGL.LoadIdentity();

            sharpGL.Perspective(60.0d,(double)PanelOpenGL3D.Width / (double)PanelOpenGL3D.Height, 1.0d, 80.0d);
        }

        private void BTN3D_Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    BTN3D_Color.BackColor = cd.Color;
                }
            }
        }

        private void BTN3D_NewFigure_Click(object sender, EventArgs e)
        {
            string figureName = TB3D_Name.Text.Trim().ToLower();

            if (figureName == string.Empty)
            {
                MessageBox.Show("Enter a valid name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ListDrawings3D.FigureExists(figureName))
            {
                MessageBox.Show("Enter a non-duplicated name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScrewyFigure3D figure3D;

            switch (CB3D_Figure.SelectedItem.ToString())
            {
                case "CUBE":
                    figure3D = new SW_Cube3D(figureName,BTN3D_Color.BackColor);
                    break;
                case "CONE":
                    figure3D = new SW_Cone3D(figureName, BTN3D_Color.BackColor, PanelOpenGL3D.OpenGL.NewQuadric());
                    break;
                case "CYLINDER":
                    figure3D = new SW_Cylinder3D(figureName, BTN3D_Color.BackColor, PanelOpenGL3D.OpenGL.NewQuadric());
                    break;
                case "DISK":
                    figure3D = new SW_Disk3D(figureName, BTN3D_Color.BackColor, PanelOpenGL3D.OpenGL.NewQuadric());
                    break;
                case "SPHERE":
                    figure3D = new SW_Sphere3D(figureName,BTN3D_Color.BackColor, PanelOpenGL3D.OpenGL.NewQuadric());
                    break;
                default:
                    return;
            }

            _ListDrawings3D.AddNewFigure(figure3D);

            LB3D_Figures.Items.Add(figureName);

            LB3D_Figures.SelectedIndex = LB3D_Figures.Items.Count - 1;

            BTN3D_ShowResult.Enabled = true;
        }

        private void BTN3D_PosX_Click(object sender, EventArgs e)
        {
            Figure3DAction(EW_Pos3D.X);
        }

        private void BTN3D_PosY_Click(object sender, EventArgs e)
        {
            Figure3DAction(EW_Pos3D.Y);
        }

        private void BTN3D_PosZ_Click(object sender, EventArgs e)
        {
            Figure3DAction(EW_Pos3D.Z);
        }

        private void BTN3D_DelFigure_Click(object sender, EventArgs e)
        {
            if (LB3D_Figures.SelectedIndex == -1) return;

            _ListDrawings3D.RemoveFigureAt(LB3D_Figures.SelectedIndex);
            LB3D_Figures.Items.RemoveAt(LB3D_Figures.SelectedIndex);

            if (LB3D_Figures.Items.Count == 0) BTN3D_ShowResult.Enabled = false;
        }

        private void BTN3D_ClearAll_Click(object sender, EventArgs e)
        {
            PN3D_Options.Enabled = false;

            LB3D_Figures.Items.Clear();
            _ListDrawings3D.ClearFigures();

            BTN3D_ShowResult.Enabled = false;

            PN3D_Options.Enabled = true;
        }

        private void BTN3D_ShowResult_Click(object sender, EventArgs e)
        {
            PN3D_Options.Enabled = false;
            PanelOpenGL3D.FrameRate = 0;

            using (DResult rt = new DResult(_ListDrawings3D.GetFiguresData(PanelOpenGL3D.Width,PanelOpenGL3D.Height)))
            {
                rt.ShowDialog();
            }

            PanelOpenGL3D.FrameRate = 20;
            PN3D_Options.Enabled = true;
        }

        // Custom 3D

        private void Figure3DAction(EW_Pos3D pos)
        {
            if (LB3D_Figures.SelectedIndex == -1) return;

            if (RB3D_Translate.Checked)
            {
                _ListDrawings3D.TranslateFigureAt(LB3D_Figures.SelectedIndex, pos, (float)NUD3D_MoveCant.Value);
            }
            else if (RB3D_Rotate.Checked)
            {
                _ListDrawings3D.RotateFigureAt(LB3D_Figures.SelectedIndex, pos, (float)NUD3D_MoveCant.Value);
            }
            else
            {
                _ListDrawings3D.ScaleFigureAt(LB3D_Figures.SelectedIndex, pos, (float)NUD3D_MoveCant.Value);
            }
        }
    }
}