using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace ScrewyGL.Draw
{
    public class ScrewyPoint2D
    {
        public Guid ID { get; }
        public string Type { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Color ColorARGB { get; set; }

        public ScrewyPoint2D(string Type,int PosX, int PosY, Color ColorARGB)
        {
            ID = Guid.NewGuid();
            this.Type = Type;
            this.PosX = PosX;
            this.PosY = PosY;
            this.ColorARGB = ColorARGB;
        }
    }

    public class ScrewyRegister2D
    {
        private readonly StringBuilder sb_actualContent;
        private readonly StringBuilder sb_lastContent;
        private readonly List<ScrewyPoint2D> pointsData;

        public ScrewyRegister2D() 
        {
            sb_actualContent = new StringBuilder();
            sb_lastContent = new StringBuilder();
            pointsData = new List<ScrewyPoint2D>();
        }

        public void AddNewPoint(ScrewyPoint2D point)
        {
            pointsData.Add(point);
        }

        public void CreateNewRegister()
        {
            if (pointsData.Count > 0)
            {
                sb_lastContent.Clear();

                Color lastColor = pointsData[0].ColorARGB;

                sb_actualContent.AppendLine("glBegin(" + pointsData[0].Type + ");");
                sb_actualContent.AppendLine("glColor3ub(" + pointsData[0].ColorARGB.R + "," + pointsData[0].ColorARGB.G + "," + pointsData[0].ColorARGB.B + ");");

                sb_lastContent.AppendLine("glBegin(" + pointsData[0].Type + ");");
                sb_lastContent.AppendLine("glColor3ub(" + pointsData[0].ColorARGB.R + "," + pointsData[0].ColorARGB.G + "," + pointsData[0].ColorARGB.B + ");");

                pointsData.ForEach((p) =>
                {
                    if (lastColor != p.ColorARGB)
                    {
                        sb_actualContent.AppendLine("glColor3ub(" + pointsData[0].ColorARGB.R + "," + pointsData[0].ColorARGB.G + "," + pointsData[0].ColorARGB.B + ");");
                        sb_lastContent.AppendLine("glColor3ub(" + pointsData[0].ColorARGB.R + "," + pointsData[0].ColorARGB.G + "," + pointsData[0].ColorARGB.B + ");");
                    }

                    sb_actualContent.AppendLine("glVertex2d(" + p.PosX + "," + p.PosY + ");");
                    sb_lastContent.AppendLine("glVertex2d(" + p.PosX + "," + p.PosY + ");");
                });

                sb_actualContent.AppendLine("glEnd();\n");
                sb_lastContent.AppendLine("glEnd();\n");

                pointsData.Clear();
            }
        }

        public void ClearRegister()
        {
            sb_actualContent.Clear();
            sb_lastContent.Clear();
            pointsData.Clear();
        }
        
        public string GetAllDraw(int panelWidth,int panelHeight)
        {
            if (sb_actualContent.Length == 0) return "Data empty...";

            return "#include <GL/glut.h>\n\n" +
                    "void ScrewyGL() {\n" +
                    sb_actualContent.ToString().TrimEnd() +
                    "\n}\n\n" +

                    "void loadConfig() {\n" +
                    "glLoadIdentity();\n" +
                    "gluOrtho2D(0, "+ panelWidth + ", 0, " + panelHeight + ");\n" +
                    "glClearColor(0.784f, 0.784f, 0.784f, 1.0f);\n" +
                    "glClear(GL_COLOR_BUFFER_BIT);\n" +
                    "glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);\n" +
                    "glEnable(GL_BLEND);\n" +
                    "ScrewyGL();\n" +
                    "glFlush();\n" +
                     "}\n\n" +

                    "int main(int argc, char* argv[]) {\n" +
                    "glutInit(&argc, argv);\n" +
                    "glutInitDisplayMode(GLUT_SINGLE);\n" +
                    "glutInitWindowSize(" + panelWidth + ", " + panelHeight + ");\n" +
                    "glutInitWindowPosition(50, 50);\n" +
                    "glutCreateWindow(\"ScrewyGL - BY M3RFR3T | github.com/RazeLeakers\");\n" +
                    "glutDisplayFunc(loadConfig);\n" +
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
