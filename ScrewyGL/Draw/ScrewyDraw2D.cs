using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ScrewyGL.Draw;
using SharpGL;

namespace ScrewyGL.Draw2D
{
    public class ScrewyDraw2D
    {
        private readonly OpenGL SharpOpenGL;
        private readonly ScrewyConfig2D SConfig2D;
        private readonly List<ScrewyPoint2D> ListSPoints;

        public ScrewyDraw2D(OpenGL SharpOpenGL, ScrewyConfig2D SConfig2D)
        {
            this.SharpOpenGL = SharpOpenGL;
            this.SConfig2D = SConfig2D;
            ListSPoints = new List<ScrewyPoint2D>();
        }

        public void AddPoint(ScrewyPoint2D SPoint2D)
        {
            ListSPoints.Add(SPoint2D);
        }

        public void Draw()
        {
            if (ListSPoints.Count > 1)
            {
                SharpOpenGL.LineWidth(SConfig2D.SLineSize);
                SharpOpenGL.PointSize(SConfig2D.SLineSize);

                SharpOpenGL.Begin((uint)SConfig2D.SType2D);

                ListSPoints.ForEach(SPoint =>
                {
                    SharpOpenGL.Color(SPoint.SColorARGB.R / 255.0, SPoint.SColorARGB.G / 255.0, SPoint.SColorARGB.B / 255.0, 1.0f);
                    SharpOpenGL.Vertex(SPoint.SPosition.X, SPoint.SPosition.Y);
                });

                SharpOpenGL.End();
                SharpOpenGL.Flush();
            }
        }
    }

    public class ScrewyConfig2D
    {
        public float SLineSize { get; set; }
        public ScrewyType2D SType2D { get; set; }

        public ScrewyConfig2D(float SLineSize, ScrewyType2D SType2D)
        {
            this.SLineSize = SLineSize;
            this.SType2D = SType2D;
        }
    }

    public class ScrewyPoint2D
    {
        public Point SPosition { get; set; }
        public Color SColorARGB { get; set; }

        public ScrewyPoint2D(Point SPosition, Color SColorARGB)
        {
            this.SPosition = SPosition;
            this.SColorARGB = SColorARGB;
        }
    }

    public class ScrewyRegister2D
    {
        private ScrewyConfig2D SConfig2D;
        private readonly StringBuilder sb_actualContent;
        private readonly StringBuilder sb_lastContent;
        private readonly List<ScrewyPoint2D> ListSPoints;

        public ScrewyRegister2D()
        {
            SConfig2D = null;
            sb_actualContent = new StringBuilder();
            sb_lastContent = new StringBuilder();
            ListSPoints = new List<ScrewyPoint2D>();
        }

        public void LoadConfig(ScrewyConfig2D SConfig2D)
        {
            this.SConfig2D = SConfig2D;
        }

        public void AddNewPoint(ScrewyPoint2D point)
        {
            ListSPoints.Add(point);
        }

        public void CreateNewRegister()
        {
            if (ListSPoints.Count > 1 && SConfig2D != null)
            { 
                sb_lastContent.Clear();

                Color lastColor = ListSPoints[0].SColorARGB;

                if (SConfig2D.SType2D == ScrewyType2D.GL_LINES || SConfig2D.SType2D == ScrewyType2D.GL_LINE_STRIP || SConfig2D.SType2D == ScrewyType2D.GL_LINE_LOOP)
                {
                    sb_actualContent.AppendLine("glLineWidth( + " + SConfig2D.SLineSize + ");");
                    sb_lastContent.AppendLine("glLineWidth( + " + SConfig2D.SLineSize + ");");
                }

                sb_actualContent.AppendLine("glBegin(" + Enum.GetName(typeof(ScrewyType2D),SConfig2D.SType2D) + ");");
                sb_actualContent.AppendLine("glColor3ub(" + ListSPoints[0].SColorARGB.R + "," + ListSPoints[0].SColorARGB.G + "," + ListSPoints[0].SColorARGB.B + ");");

                sb_lastContent.AppendLine("glBegin(" + Enum.GetName(typeof(ScrewyType2D), SConfig2D.SType2D) + ");");
                sb_lastContent.AppendLine("glColor3ub(" + ListSPoints[0].SColorARGB.R + "," + ListSPoints[0].SColorARGB.G + "," + ListSPoints[0].SColorARGB.B + ");");

                ListSPoints.ForEach((p) =>
                {
                    if (lastColor != p.SColorARGB)
                    {
                        sb_actualContent.AppendLine("glColor3ub(" + p.SColorARGB.R + "," + p.SColorARGB.G + "," + p.SColorARGB.B + ");");
                        sb_lastContent.AppendLine("glColor3ub(" + p.SColorARGB.R + "," + p.SColorARGB.G + "," + p.SColorARGB.B + ");");
                    }

                    sb_actualContent.AppendLine("glVertex2d(" + p.SPosition.X + "," + p.SPosition.Y + ");");
                    sb_lastContent.AppendLine("glVertex2d(" + p.SPosition.X + "," + p.SPosition.Y + ");");
                });

                sb_actualContent.AppendLine("glEnd();\n");
                sb_lastContent.AppendLine("glEnd();\n");

                ListSPoints.Clear();
            }
        }

        public void ClearRegister()
        {
            sb_actualContent.Clear();
            sb_lastContent.Clear();
            ListSPoints.Clear();
        }
        
        public string GetAllDraw(int panelWidth,int panelHeight)
        {
            if (sb_actualContent.Length == 0) return "Data empty...";

            return "#include <GL/glut.h>\n\n" +

                    "void ScrewyDraw2D() {\n" +
                    sb_actualContent.ToString().TrimEnd() +
                    "\n}\n\n" +

                    "void LoadConfig() {\n" +
                    "glLoadIdentity();\n" +
                    "gluOrtho2D(0, "+ panelWidth + ", 0, " + panelHeight + ");\n" +
                    "glClearColor(155 / 255.0f, 155 / 255.0f, 155 / 255.0f, 1.0f);\n" +
                    "glClear(GL_COLOR_BUFFER_BIT);\n" +
                    "glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);\n" +
                    "glEnable(GL_BLEND);\n" +
                    "ScrewyDraw2D();\n" +
                    "glFlush();\n" +
                     "}\n\n" +

                    "int main(int argc, char* argv[]) {\n" +
                    "glutInit(&argc, argv);\n" +
                    "glutInitDisplayMode(GLUT_SINGLE);\n" +
                    "glutInitWindowSize(" + panelWidth + ", " + panelHeight + ");\n" +
                    "glutInitWindowPosition(50, 50);\n" +
                    "glutCreateWindow(\"ScrewyGL - BY M3RFR3T | github.com/RazeLeakers\");\n" +
                    "glutDisplayFunc(LoadConfig);\n" +
                    "glutMainLoop();\n" +
                    "return 0;\n" +
                    "}";
        }

        public string GetActualDraw()
        {
            if (sb_actualContent.Length == 0) return "Data empty...";

            return sb_actualContent.ToString().TrimEnd();
        }

        public string GetLastDraw()
        {
            if (sb_lastContent.Length == 0) return "Data empty...";

            return sb_lastContent.ToString().TrimEnd();
        }
    }
}
