using System;
using ScrewyGL.Draw;
using System.Drawing;
using System.Windows.Forms;

namespace ScrewyGL
{
    public partial class SGL : Form
    {
        private int cantPoints = 0;
        private bool infinitePoints = false;
        private readonly ScrewyRegister2D screwyRegister2D;

        public SGL()
        {
            InitializeComponent();
            CB_Geometry.Text = "GL_LINES";
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = false;
            screwyRegister2D = new ScrewyRegister2D();
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
                    "Position: (X: " + (btn.Location.X + 3) + ",Y: " + (PB_Image.Height - btn.Location.Y) + ");",
                    "Do you want to add this point to your draw?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    btn.BackColor = BTN_Color.BackColor;

                    screwyRegister2D.AddNewPoint(new ScrewyPoint2D(CB_Geometry.SelectedItem.ToString(), (btn.Location.X + 3), (PB_Image.Height - btn.Location.Y), BTN_Color.BackColor));

                    if (!infinitePoints) cantPoints--;
                    if (cantPoints == 0 && !infinitePoints)
                    {
                        CB_Geometry.Enabled = true;
                        BTN_NewPoint.Enabled = true;
                        BTN_Result.Enabled = true;
                        screwyRegister2D.CreateNewRegister();
                    }
                }
            };

            PB_Image.Controls.Add(btn);
        }

        private void PB_Image_MouseClick(object sender, MouseEventArgs e)
        {
            if (cantPoints == 0 && !infinitePoints) return;

            NewButton(e.X,e.Y);
            screwyRegister2D.AddNewPoint(new ScrewyPoint2D(CB_Geometry.SelectedItem.ToString(),e.X, (PB_Image.Height - e.Y),BTN_Color.BackColor));

            if (!infinitePoints) cantPoints--;
            if (cantPoints == 0 && !infinitePoints)
            {
                CB_Geometry.Enabled = true;
                BTN_NewPoint.Enabled = true;
                BTN_Result.Enabled = true;
                screwyRegister2D.CreateNewRegister();
            }
        }

        private void PB_Image_MouseMove(object sender, MouseEventArgs e)
        {
            LB_Coordinates.Text = "Coordinates:\r\nX: " + e.X + "\r\nY: " + (PB_Image.Height - e.Y);
        }

        private void BTN_Upload_Picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDG = new OpenFileDialog())
            {
                fileDG.Title = "Select a image";
                fileDG.Filter = "Images (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                fileDG.Multiselect = false;

                if (fileDG.ShowDialog() == DialogResult.OK)
                {
                    PB_Image.ImageLocation = fileDG.FileName;
                }
            }
        }

        private void BTN_Remove_Picture_Click(object sender, EventArgs e)
        {
            PB_Image.ImageLocation = "";
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
            BTN_NewPoint.Enabled = false;
            BTN_Result.Enabled = false;

            switch (CB_Geometry.SelectedItem.ToString())
            {
                case "GL_LINES":
                    cantPoints = 2;
                    break;
                case "GL_TRIANGLES":
                    cantPoints = 3;
                    break;
                case "GL_QUADS":
                    cantPoints = 4;
                    break;
                case "GL_LINE_LOOP":
                case "GL_POLYGON":
                    BTN_Stop.Enabled = true;
                    infinitePoints = true;
                    break;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            infinitePoints = false;
            CB_Geometry.Enabled = true;
            BTN_NewPoint.Enabled = true;
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = true;
            screwyRegister2D.CreateNewRegister();
        }

        private void BTN_ClearPoints_Click(object sender, EventArgs e)
        {
            cantPoints = 0;
            infinitePoints = false;
            CB_Geometry.Enabled = true;
            BTN_NewPoint.Enabled = true;
            BTN_Stop.Enabled = false;
            BTN_Result.Enabled = false;
            PB_Image.Controls.Clear();
            screwyRegister2D.ClearRegister();
        }

        private void BTN_Result_Click(object sender, EventArgs e)
        {
            using (Result rt = new Result(screwyRegister2D.GetAllDraw(PB_Image.Width,PB_Image.Height), screwyRegister2D.GetActualDraw(), screwyRegister2D.GetLastDraw()))
            {
                rt.ShowDialog();
            }
        }
    }
}
