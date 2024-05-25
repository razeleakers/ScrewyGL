using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ScrewyGL.Draw;
using ScrewyGL.Draw2D;
using ScrewyGL.Draw3D;
using SharpGL;

namespace ScrewyGL
{
    public partial class SGL : Form
    {
        // Sharp GL 2D
        private int cantPoints;
        private bool infinitePoints = false;
        private ScrewyDraw2D SDraw2D = null;
        private readonly List<ScrewyDraw2D> ListSDraw2D;
        private readonly ScrewyRegister2D SRegister2D;
        // Sharp GL 3D
        private readonly ScrewyCamera3D SCamera3D;
        private readonly List<ScrewyFigure3D> ListSFigure3D;

        public SGL()
        {
            InitializeComponent();
            // Sharp GL 2D
            cantPoints = 0;
            BTN_Upload_Picture.Enabled = false;
            BTN_Remove_Picture.Enabled = false;
            CB_Geometry.Text = "GL_LINES";
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = false;
            ListSDraw2D = new List<ScrewyDraw2D>();
            SRegister2D = new ScrewyRegister2D();
            // Sharp GL 3D
            Panel_Right3D.Visible = false;
            CB_Figure3D.Text = "CUBE";
            BTN_Result3D.Enabled = false;
            ListSFigure3D = new List<ScrewyFigure3D>();
            SCamera3D = new ScrewyCamera3D(SceneControl3D);
            SceneControl3D.Scene.RenderBoundingVolumes = false;
        }

        // SHARP GL 2D
        private void PanelOpenGL2D_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL SharpOpenGL = PanelOpenGL2D.OpenGL;
            SharpOpenGL.ClearColor(155 / 255.0f, 155 / 255.0f, 155 / 255.0f, 1.0f);
            SharpOpenGL.MatrixMode(OpenGL.GL_PROJECTION);
            SharpOpenGL.LoadIdentity();
        }

        private void PanelOpenGL2D_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL SharpOpenGL = PanelOpenGL2D.OpenGL;
            SharpOpenGL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            ListSDraw2D.ForEach((content) =>
            {
                content.Draw();
            });
        }

        private void PanelOpenGL2D_Resized(object sender, EventArgs e)
        {
            OpenGL SharpOpenGL = PanelOpenGL2D.OpenGL;
            SharpOpenGL.MatrixMode(OpenGL.GL_PROJECTION);
            SharpOpenGL.LoadIdentity();
            SharpOpenGL.Viewport(0, 0, PanelOpenGL2D.Width, PanelOpenGL2D.Height);
            SharpOpenGL.Ortho2D(0, PanelOpenGL2D.Width, 0, PanelOpenGL2D.Height);
        }

        private void NewButton(int x, int y)
        {
            Button btn = new Button
            {
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                BackColor = BTN_Color.BackColor,
                Size = new Size(6, 6),
                Location = new Point(x - 3, y)
            };

            btn.MouseClick += (sender, e) => {
                if (BTN_NewPoint.Enabled)
                {
                    MessageBox.Show("Color: RGB(" + btn.BackColor.R + "," + btn.BackColor.G + "," + btn.BackColor.B + ");\n" +
                    "Position: (X: " + (btn.Location.X + 3) + ",Y: " + (PanelOpenGL2D.Height - btn.Location.Y) + ");",
                    "Button Info", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Color: RGB(" + btn.BackColor.R + "," + btn.BackColor.G + "," + btn.BackColor.B + ");\n" +
                    "Position: (X: " + (btn.Location.X + 3) + ",Y: " + (PanelOpenGL2D.Height - btn.Location.Y) + ");",
                    "Do you want to add this point to your draw?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btn.BackColor = BTN_Color.BackColor;

                    ScrewyPoint2D SPoint2D = new ScrewyPoint2D(new Point(btn.Location.X + 3, PanelOpenGL2D.Height - btn.Location.Y), BTN_Color.BackColor);
                    SDraw2D.AddPoint(SPoint2D);
                    SRegister2D.AddNewPoint(SPoint2D);

                    if (!infinitePoints) cantPoints--;
                    if (cantPoints == 0 && !infinitePoints)
                    {
                        CB_Geometry.Enabled = true;
                        BTN_NewPoint.Enabled = true;
                        BTN_Result.Enabled = true;
                        SRegister2D.CreateNewRegister();
                    }
                }
            };

            PanelOpenGL2D.Controls.Add(btn);
        }

        private void EnableDisableLine()
        {
            switch (CB_Geometry.SelectedItem.ToString())
            {
                case "GL_LINES":
                case "GL_LINE_LOOP":
                case "GL_LINE_STRIP":
                    NUD_LineSize.Enabled = true;
                    break;
                default:
                    NUD_LineSize.Enabled = false;
                    break;
            }
        }

        private void PanelOpenGL_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (cantPoints == 0 && !infinitePoints) return;

                NewButton(e.X, e.Y);
                ScrewyPoint2D SPoint2D = new ScrewyPoint2D(new Point(e.X, PanelOpenGL2D.Height - e.Y), BTN_Color.BackColor);
                SDraw2D.AddPoint(SPoint2D);
                SRegister2D.AddNewPoint(SPoint2D);

                if (!infinitePoints) cantPoints--;
                if (cantPoints == 0 && !infinitePoints)
                {
                    CB_Geometry.Enabled = true;
                    EnableDisableLine();
                    BTN_NewPoint.Enabled = true;
                    BTN_Result.Enabled = true;
                    SRegister2D.CreateNewRegister();
                }
            }
        }

        private void PanelOpenGL_MouseMove(object sender, MouseEventArgs e)
        {
            LB_Coordinates.Text = "Coordinates:\r\nX: " + e.X + "\r\nY: " + (PanelOpenGL2D.Height - e.Y);
        }

        private void CB_Geometry_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisableLine();
        }

        private void BTN_Upload_Picture_Click(object sender, EventArgs e)
        {
            // Will soon be available again :D

            /*
            using (OpenFileDialog fileDG = new OpenFileDialog())
            {
                fileDG.Title = "Select a image";
                fileDG.Filter = "Images (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                fileDG.Multiselect = false;

                if (fileDG.ShowDialog() == DialogResult.OK)
                {

                }
            }
            */
        }

        private void BTN_Remove_Picture_Click(object sender, EventArgs e)
        {
            //PB_Image.ImageLocation = "";
        }

        private void BTN_Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDG = new ColorDialog())
            {
                if (colorDG.ShowDialog() == DialogResult.OK)
                {
                    BTN_Color.BackColor = colorDG.Color;
                }
            }
        }

        private void BTN_NewPoint_Click(object sender, EventArgs e)
        {
            CB_Geometry.Enabled = false;
            NUD_LineSize.Enabled = false;
            BTN_NewPoint.Enabled = false;
            BTN_Result.Enabled = false;

            ScrewyConfig2D SConfig2D = null;

            switch (CB_Geometry.SelectedItem.ToString())
            {
                case "GL_LINES":
                    cantPoints = 2;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_LINES);
                    break;
                case "GL_LINE_LOOP":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_LINE_LOOP);
                    break;
                case "GL_LINE_STRIP":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_LINE_STRIP);
                    break;
                case "GL_TRIANGLES":
                    cantPoints = 3;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_TRIANGLES);
                    break;
                case "GL_TRIANGLE_STRIP":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_TRIANGLE_STRIP);
                    break;
                case "GL_TRIANGLE_FAN":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_TRIANGLE_FAN);
                    break;
                case "GL_QUADS":
                    cantPoints = 4;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_QUADS);
                    break;
                case "GL_QUAD_STRIP":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_QUAD_STRIP);
                    break;
                case "GL_POLYGON":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    SConfig2D = new ScrewyConfig2D((float)NUD_LineSize.Value, ScrewyType2D.GL_POLYGON);
                    break;
            }

            if (SConfig2D != null)
            {
                SRegister2D.LoadConfig(SConfig2D);
                SDraw2D = new ScrewyDraw2D(PanelOpenGL2D.OpenGL, SConfig2D);
                ListSDraw2D.Add(SDraw2D);
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            SRegister2D.CreateNewRegister();
            infinitePoints = false;
            CB_Geometry.Enabled = true;
            EnableDisableLine();
            BTN_NewPoint.Enabled = true;
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = true;
        }

        private void BTN_ClearPoints_Click(object sender, EventArgs e)
        {
            PanelOpenGL2D.Controls.Clear();
        }

        private void BTN_ClearAll_Click(object sender, EventArgs e)
        {
            cantPoints = 0;
            infinitePoints = false;
            CB_Geometry.Enabled = true;
            EnableDisableLine();
            BTN_NewPoint.Enabled = true;
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = false;
            ListSDraw2D.Clear();
            SRegister2D.ClearRegister();
            PanelOpenGL2D.Controls.Clear();
        }

        private void BTN_Result_Click(object sender, EventArgs e)
        {
            using (Result rt = new Result(SRegister2D.GetAllDraw(PanelOpenGL2D.Width, PanelOpenGL2D.Height), SRegister2D.GetActualDraw(), SRegister2D.GetLastDraw()))
            {
                rt.ShowDialog();
            }
        }

        // SHARP GL 3D

        private void SceneControl3D_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    SCamera3D.MoveUp();
                    break;
                case Keys.A:
                    SCamera3D.MoveLeft();
                    break;
                case Keys.S:
                    SCamera3D.MoveDown();
                    break;
                case Keys.D:
                    SCamera3D.MoveRight();
                    break;
                case Keys.X:
                    SCamera3D.ZoomIn();
                    break;
                case Keys.Z:
                    SCamera3D.ZoomOut();
                    break;
            }
        }

        private bool CheckDuplicateName(string figureName)
        {
            foreach (var Figure3D in ListSFigure3D)
            {
                if (Figure3D.GetFigureName() == figureName)
                {
                    return true;
                }
            }

            return false;
        }

        private void BTN_CreateFigure3D_Click(object sender, EventArgs e)
        {
            string FigureName3D = TB_Name3D.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(FigureName3D) || string.IsNullOrEmpty(FigureName3D) || TB_Name3D.Text.Contains(" "))
            {
                MessageBox.Show("Enter a valid name!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }else if (CheckDuplicateName(FigureName3D))
            {
                MessageBox.Show("Enter a non-duplicated name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScrewyFigure3D SFigure3D = null;

            switch (CB_Figure3D.SelectedItem.ToString())
            {
                case "CUBE":
                    SFigure3D = new ScrewyFigure3D(SceneControl3D,ScrewyType3D.CUBE, FigureName3D);
                    break;
                case "CONE":
                    SFigure3D = new ScrewyFigure3D(SceneControl3D, ScrewyType3D.CONE, FigureName3D);
                    break;
                case "SPHERE":
                    SFigure3D = new ScrewyFigure3D(SceneControl3D, ScrewyType3D.SPHERE, FigureName3D);
                    break;
                case "CYLINDER":
                    SFigure3D =new ScrewyFigure3D(SceneControl3D, ScrewyType3D.CYLINDER, FigureName3D);
                    break;
            }

            if (SFigure3D != null)
            {
                SFigure3D.RenderFigure();
                ListSFigure3D.Add(SFigure3D);
                LB_Figures3D.Items.Add(FigureName3D);
                LB_Figures3D.SelectedIndex = LB_Figures3D.Items.Count - 1;
                TB_Name3D.Clear();
                TB_Name3D.Focus();
                BTN_Result3D.Enabled = true;
            }
        }

        private void ActionFigure(char position,float cant)
        {
            if (ListSFigure3D.Count > 0 && LB_Figures3D.SelectedIndex >= 0)
            {
                if (RB_Scale3D.Checked)
                {
                    ListSFigure3D[LB_Figures3D.SelectedIndex].ScaleFigure(position, cant);
                }
                else if (RB_Rotate3D.Checked)
                {
                    ListSFigure3D[LB_Figures3D.SelectedIndex].RotateFigure(position, cant);
                }
                else
                {
                    ListSFigure3D[LB_Figures3D.SelectedIndex].TranslateFigure(position,cant);
                }
            }
        }

        private void BTN_PosX_Click(object sender, EventArgs e)
        {
            ActionFigure('Y', (float)NUD_MovePos3D.Value);
        }

        private void BTN_PosY_Click(object sender, EventArgs e)
        {
            ActionFigure('Z', (float)NUD_MovePos3D.Value);

        }

        private void BTN_PosZ_Click(object sender, EventArgs e)
        {
            ActionFigure('X', (float)NUD_MovePos3D.Value);
        }

        private void BTN_DelFigure3D_Click(object sender, EventArgs e)
        {
            if (ListSFigure3D.Count > 0 && LB_Figures3D.SelectedIndex >= 0)
            {
                ListSFigure3D[LB_Figures3D.SelectedIndex].RemoveFigure();
                ListSFigure3D.RemoveAt(LB_Figures3D.SelectedIndex);
                LB_Figures3D.Items.RemoveAt(LB_Figures3D.SelectedIndex);
                if (LB_Figures3D.Items.Count == 0)
                {
                    BTN_Result3D.Enabled = false;
                }
            }
        }

        private void BTN_ClearFigures3D_Click(object sender, EventArgs e)
        {
            BTN_Result3D.Enabled = false;
            ListSFigure3D.ForEach((content) =>
            {
                content.RemoveFigure();
            });

            ListSFigure3D.Clear();
            LB_Figures3D.Items.Clear();
        }

        private void BTN_Result3D_Click(object sender, EventArgs e)
        {
            ScrewyRegister3D SRegister3D = new ScrewyRegister3D(ListSFigure3D);
            SRegister3D.CreateNewRegister3D();

            using (Result rt = new Result(SRegister3D.GetAllDraw3D(SceneControl3D.Width,SceneControl3D.Height), SRegister3D.GetActualDraw3D(), SRegister3D.GetLastDraw3D()))
            {
                rt.ShowDialog();
            }
        }

        // GLOBAL

        private void TabControlDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlDraw.SelectedIndex == 0)
            {
                TabControlDraw.Width = LB_ScrewyGL.Width - Panel_Right.Width;
                Panel_Right3D.Visible = false;
                Panel_Right.Visible = true;
            }
            else
            {
                TabControlDraw.Width = LB_ScrewyGL.Width - Panel_Right3D.Width;
                Panel_Right.Visible = false;
                Panel_Right3D.Visible = true;
            }
        }
    }
}
