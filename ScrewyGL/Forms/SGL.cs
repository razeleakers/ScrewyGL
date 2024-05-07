using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ScrewyGL
{
    public partial class SGL : Form
    {
        private Color lastColor;
        private int cantPoints = 0;
        private bool infinitePoints = false;
        private readonly StringBuilder sb_all = new StringBuilder();
        private readonly StringBuilder sb_actual = new StringBuilder();
        private readonly StringBuilder sb_last_result = new StringBuilder();

        public SGL()
        {
            InitializeComponent();
            CB_Geometry.Text = "GL_LINES";
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = false;
            lastColor = BTN_Color.BackColor;
        }

        private void NewButton(int x,int y)
        {
            Button btn = new Button
            {
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                BackColor = BTN_Color.BackColor,
                Size = new Size(7, 7),
                Location = new Point(x - 3, y)
            };

            btn.MouseClick += (sender,e) => {
                if (BTN_NewPoint.Enabled) return;

                if(MessageBox.Show("Color: RGB(" + btn.BackColor.R + "," + btn.BackColor.G + "," + btn.BackColor.B + ");\n" +
                    "Position: (X: " + btn.Location.X + ",Y: " + (PB_Image.Height - btn.Location.Y) + ");",
                    "Do you want to add this point to your draw?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (lastColor != BTN_Color.BackColor)
                    {
                        sb_actual.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
                        sb_last_result.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
                        lastColor = BTN_Color.BackColor;
                    }

                    btn.BackColor = BTN_Color.BackColor;
                    sb_actual.AppendLine("glVertex2d(" + (btn.Location.X + 3) + "," + (PB_Image.Height - btn.Location.Y) + ");");
                    sb_last_result.AppendLine("glVertex2d(" + (btn.Location.X + 3) + "," + (PB_Image.Height - btn.Location.Y) + ");");

                    if (!infinitePoints) cantPoints--;
                    if (cantPoints == 0 && !infinitePoints)
                    {
                        BTN_NewPoint.Enabled = true;
                        sb_actual.AppendLine("glEnd();\n");
                        sb_last_result.AppendLine("glEnd();\n");
                        BTN_Result.Enabled = true;
                    }
                }
            };

            PB_Image.Controls.Add(btn);
        }

        private void PB_Image_MouseClick(object sender, MouseEventArgs e)
        {
            if (cantPoints == 0 && !infinitePoints) return;

            if (lastColor != BTN_Color.BackColor)
            {
                sb_actual.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
                sb_last_result.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
                lastColor = BTN_Color.BackColor;
            }

            NewButton(e.X,e.Y);
            sb_actual.AppendLine("glVertex2d(" + e.X + "," + (PB_Image.Height - e.Y) + ");");
            sb_last_result.AppendLine("glVertex2d(" + e.X + "," + (PB_Image.Height - e.Y) + ");");

            if (!infinitePoints) cantPoints--;
            if (cantPoints == 0 && !infinitePoints)
            {
                BTN_NewPoint.Enabled = true;
                sb_actual.AppendLine("glEnd();\n");
                sb_last_result.AppendLine("glEnd();\n");
                BTN_Result.Enabled = true;
            }
        }

        private void PB_Image_MouseMove(object sender, MouseEventArgs e)
        {
            LB_Coordinates.Text = "Coordinates:\r\nX: " + e.X + "\r\nY: " + (PB_Image.Height - e.Y);
        }

        private void BTN_Upload_Picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select a image";
                dialog.Filter = "Images (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PB_Image.ImageLocation = dialog.FileName;
                }
            }
        }

        private void BTN_Remove_Picture_Click(object sender, EventArgs e)
        {
            PB_Image.ImageLocation = "";
        }

        private void BTN_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BTN_Color.BackColor = colorDialog1.Color;
            }
        }

        private void BTN_NewPoint_Click(object sender, EventArgs e)
        {
            sb_last_result.Clear();
            BTN_NewPoint.Enabled = false;
            BTN_Result.Enabled = false;

            sb_actual.AppendLine("glBegin(" + CB_Geometry.Text + ");");
            sb_last_result.AppendLine("glBegin(" + CB_Geometry.Text + ");");

            switch (CB_Geometry.Text)
            {
                case "GL_LINES":
                    cantPoints = 2;
                    break;
                case "GL_LINE_LOOP":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    break;
                case "GL_TRIANGLES":
                    cantPoints = 3;
                    break;
                case "GL_QUADS":
                    cantPoints = 4;
                    break;
                case "GL_POLYGON":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    break;
            }

            lastColor = BTN_Color.BackColor;
            sb_actual.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
            sb_last_result.AppendLine("glColor3ub(" + BTN_Color.BackColor.R + "," + BTN_Color.BackColor.G + "," + BTN_Color.BackColor.B + ");");
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            BTN_NewPoint.Enabled = true;
            sb_actual.AppendLine("glEnd();\n");
            sb_last_result.AppendLine("glEnd();\n");
            BTN_Result.Enabled = true;
            infinitePoints = false;
            BTN_Stop.Enabled = false;
        }

        private void BTN_ClearPoints_Click(object sender, EventArgs e)
        {
            sb_actual.Clear();
            sb_last_result.Clear();
            sb_all.Clear();
            cantPoints = 0;
            infinitePoints = false;
            BTN_NewPoint.Enabled = true;
            BTN_Result.Enabled = false;
            PB_Image.Controls.Clear();
        }

        private void BTN_Result_Click(object sender, EventArgs e)
        {
            sb_all.AppendLine("#include <GL/glut.h>\n");
            sb_all.AppendLine("void ScrewyGL() {");
            sb_all.AppendLine(sb_actual.ToString().TrimEnd());
            sb_all.AppendLine("}\n");


            sb_all.AppendLine("void loadConfig() {");
            sb_all.AppendLine("glLoadIdentity();\n" +
                              "gluOrtho2D(0, 500, 0, 394);\n" +
                              "glClearColor(0.784f, 0.784f, 0.784f, 1.0f);\n" +
                              "glClear(GL_COLOR_BUFFER_BIT);\n" +
                              "glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);\n" +
                              "glEnable(GL_BLEND);\n" +
                              "ScrewyGL();\n" +
                              "glFlush();");
            sb_all.AppendLine("}\n");

            sb_all.AppendLine("int main(int argc, char* argv[]) {");
            sb_all.AppendLine("glutInit(&argc, argv);\n" +
                              "glutInitDisplayMode(GLUT_SINGLE);\n" +
                              "glutInitWindowSize(500, 394);\n" +
                              "glutInitWindowPosition(50, 50);\n" +
                              "glutCreateWindow(\"ScrewyGL - BY M3RFR3T | github.com/RazeLeakers\");\n" +
                              "glutDisplayFunc(loadConfig);\n" +
                              "glutMainLoop();\n" +
                              "return 0;");
            sb_all.AppendLine("}");

            using (Result rt = new Result(sb_all.ToString(), sb_actual.ToString().TrimEnd(), sb_last_result.ToString().TrimEnd()))
            {
                rt.ShowDialog();
            }

            sb_all.Clear();
        }
    }
}
