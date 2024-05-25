using System.Text;
using System.Collections.Generic;
using ScrewyGL.Draw;
using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Cameras;
using SharpGL.SceneGraph.Quadrics;
using SharpGL.SceneGraph.Primitives;

namespace ScrewyGL.Draw3D
{
    public class ScrewyCamera3D
    {
        private readonly SceneControl SharpControlOpenGL;
        private readonly Camera SCamera;
        private float PosX, PosY, PosZ;
        private readonly float Speed;

        public ScrewyCamera3D(SceneControl SharpControlOpenGL)
        {
            this.SharpControlOpenGL = SharpControlOpenGL;
            SCamera = SharpControlOpenGL.Scene.CurrentCamera;
            PosX = SCamera.Position.X;
            PosY = SCamera.Position.Y;
            PosZ = SCamera.Position.Z;
            Speed = 0.5f;
        }

        public void MoveLeft()
        {
            PosY += Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }

        public void MoveRight()
        {
            PosY -= Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }

        public void MoveUp()
        {
            PosZ += Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }

        public void MoveDown()
        {
            PosZ -= Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }

        public void ZoomIn()
        {
            PosX -= Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }

        public void ZoomOut()
        {
            PosX += Speed;
            SCamera.Position = new Vertex(PosX, PosY, PosZ);
        }
    }

    public class ScrewyFigure3D
    {
        private readonly SceneControl SharpControlOpenGL;
        public ScrewyType3D SType3D { get; }
        public Cube SCube { get; }
        public Cylinder SCylinder { get; }
        public Sphere SSphere { get; }

        public ScrewyFigure3D(SceneControl SharpControlOpenGL, ScrewyType3D SType3D,string FigureName) 
        {
            this.SharpControlOpenGL = SharpControlOpenGL;
            this.SType3D = SType3D;
            SCube = null;
            SCylinder = null;
            SSphere = null;

            switch (SType3D)
            {
                case ScrewyType3D.CUBE:
                    SCube = new Cube
                    {
                        Name = FigureName,
                    };
                    break;
                case ScrewyType3D.CONE:
                    SCylinder = new Cylinder
                    {
                        Name = FigureName,
                        BaseRadius = 1.5,
                        TopRadius = 0,
                        Height = 2
                    };
                    break;
                case ScrewyType3D.SPHERE:
                    SSphere = new Sphere
                    {
                        Name = FigureName,
                    };
                    break;
                case ScrewyType3D.CYLINDER:
                    SCylinder = new Cylinder
                    {
                        Name = FigureName,
                        BaseRadius = 1.5,
                        TopRadius = 1.5,
                        Height = 2,
                    };
                    break;
            }
        }

        public string GetFigureName()
        {
            if (SCube != null)
            {
                return SCube.Name;
            }
            else if (SCylinder != null)
            {
                return SCylinder.Name;
            }
            else if (SSphere != null)
            {
                return SSphere.Name;
            }

            return string.Empty;
        }

        public void RenderFigure()
        {
            if (SCube != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.AddChild(SCube);
            }else if (SCylinder != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.AddChild(SCylinder);
            }
            else if (SSphere != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.AddChild(SSphere);
            }
        }

        public void RemoveFigure()
        {
            if (SCube != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.RemoveChild(SCube);
            }
            else if (SCylinder != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.RemoveChild(SCylinder);
            }
            else if (SSphere != null)
            {
                SharpControlOpenGL.Scene.SceneContainer.RemoveChild(SSphere);
            }
        }

        public void TranslateFigure(char position,float cant)
        {
            if (SCube != null)
            {
                switch (position)
                {
                    case 'X':
                        SCube.Transformation.TranslateX += cant;
                        break;
                    case 'Y':
                        SCube.Transformation.TranslateY += cant;
                        break;
                    case 'Z':
                        SCube.Transformation.TranslateZ += cant;
                        break;
                }
            }
            else if (SCylinder != null)
            {
                switch (position)
                {
                    case 'X':
                        SCylinder.Transformation.TranslateX += cant;
                        break;
                    case 'Y':
                        SCylinder.Transformation.TranslateY += cant;
                        break;
                    case 'Z':
                        SCylinder.Transformation.TranslateZ += cant;
                        break;
                }
            }
            else if (SSphere != null)
            {
                switch (position)
                {
                    case 'X':
                        SSphere.Transformation.TranslateX += cant;
                        break;
                    case 'Y':
                        SSphere.Transformation.TranslateY += cant;
                        break;
                    case 'Z':
                        SSphere.Transformation.TranslateZ += cant;
                        break;
                }
            }
        }

        public void RotateFigure(char position, float cant)
        {
            if (SCube != null)
            {
                switch (position)
                {
                    case 'X':
                        SCube.Transformation.RotateX += cant;
                        break;
                    case 'Y':
                        SCube.Transformation.RotateY += cant;
                        break;
                    case 'Z':
                        SCube.Transformation.RotateZ += cant;
                        break;
                }
            }
            else if (SCylinder != null)
            {
                switch (position)
                {
                    case 'X':
                        SCylinder.Transformation.RotateX += cant;
                        break;
                    case 'Y':
                        SCylinder.Transformation.RotateY += cant;
                        break;
                    case 'Z':
                        SCylinder.Transformation.RotateZ += cant;
                        break;
                }
            }
            else if (SSphere != null)
            {
                switch (position)
                {
                    case 'X':
                        SSphere.Transformation.RotateX += cant;
                        break;
                    case 'Y':
                        SSphere.Transformation.RotateY += cant;
                        break;
                    case 'Z':
                        SSphere.Transformation.RotateZ += cant;
                        break;
                }
            }
        }

        public void ScaleFigure(char position, float cant)
        {
            if (SCube != null)
            {
                switch (position)
                {
                    case 'X':
                        SCube.Transformation.ScaleX += cant;
                        break;
                    case 'Y':
                        SCube.Transformation.ScaleY += cant;
                        break;
                    case 'Z':
                        SCube.Transformation.ScaleZ += cant;
                        break;
                }
            }
            else if (SCylinder != null)
            {
                switch (position)
                {
                    case 'X':
                        SCylinder.Transformation.ScaleX += cant;
                        break;
                    case 'Y':
                        SCylinder.Transformation.ScaleY += cant;
                        break;
                    case 'Z':
                        SCylinder.Transformation.ScaleZ += cant;
                        break;
                }
            }
            else if (SSphere != null)
            {
                switch (position)
                {
                    case 'X':
                        SSphere.Transformation.ScaleX += cant;
                        break;
                    case 'Y':
                        SSphere.Transformation.ScaleY += cant;
                        break;
                    case 'Z':
                        SSphere.Transformation.ScaleZ += cant;
                        break;
                }
            }
        }
    }

    public class ScrewyRegister3D
    {
        private readonly StringBuilder sb_metods3D;
        private readonly StringBuilder sb_actualContent3D;
        private readonly StringBuilder sb_lastContent3D;
        private readonly List<ScrewyFigure3D> ListSFigure3D;

        public ScrewyRegister3D(List<ScrewyFigure3D> ListSFigure3D)
        {
            this.ListSFigure3D = ListSFigure3D;
            sb_metods3D = new StringBuilder();
            sb_actualContent3D = new StringBuilder();
            sb_lastContent3D = new StringBuilder();
        }

        public void CreateNewRegister3D()
        {
            for (int i = 0; i < ListSFigure3D.Count; i++)
            {
                if (ListSFigure3D[i].GetFigureName() != string.Empty)
                {
                    Vertex FScale;
                    Vertex FRotate;
                    Vertex FTranslate;

                    switch (ListSFigure3D[i].SType3D)
                    {
                        case ScrewyType3D.CUBE:
                            sb_metods3D.AppendLine(ListSFigure3D[i].SCube.Name + "();");
                            FScale = new Vertex(ListSFigure3D[i].SCube.Transformation.ScaleY * 5, ListSFigure3D[i].SCube.Transformation.ScaleZ * 5, ListSFigure3D[i].SCube.Transformation.ScaleX * 5);
                            FRotate = new Vertex(ListSFigure3D[i].SCube.Transformation.RotateY, ListSFigure3D[i].SCube.Transformation.RotateZ, ListSFigure3D[i].SCube.Transformation.RotateX);
                            FTranslate = new Vertex(ListSFigure3D[i].SCube.Transformation.TranslateY * 5, ListSFigure3D[i].SCube.Transformation.TranslateZ * 5, ListSFigure3D[i].SCube.Transformation.TranslateX * 5);
                            sb_actualContent3D.AppendLine(GetCubeDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            if (i == ListSFigure3D.Count - 1)
                            {
                                sb_lastContent3D.AppendLine(GetCubeDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            }
                            break;
                        case ScrewyType3D.CONE:
                            sb_metods3D.AppendLine(ListSFigure3D[i].SCylinder.Name + "();");
                            FScale = new Vertex(ListSFigure3D[i].SCylinder.Transformation.ScaleY, ListSFigure3D[i].SCylinder.Transformation.ScaleX, ListSFigure3D[i].SCylinder.Transformation.ScaleZ);
                            FRotate = new Vertex(ListSFigure3D[i].SCylinder.Transformation.RotateY, ListSFigure3D[i].SCylinder.Transformation.RotateX, ListSFigure3D[i].SCylinder.Transformation.RotateZ);
                            FTranslate = new Vertex(ListSFigure3D[i].SCylinder.Transformation.TranslateY * 5, ListSFigure3D[i].SCylinder.Transformation.TranslateZ * 5, ListSFigure3D[i].SCylinder.Transformation.TranslateX * 5);
                            sb_actualContent3D.AppendLine(GetConeDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            if (i == ListSFigure3D.Count - 1)
                            {
                                sb_lastContent3D.AppendLine(GetConeDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            }
                            break;
                        case ScrewyType3D.SPHERE:
                            sb_metods3D.AppendLine(ListSFigure3D[i].SSphere.Name + "();");
                            FScale = new Vertex(ListSFigure3D[i].SSphere.Transformation.ScaleY, ListSFigure3D[i].SSphere.Transformation.ScaleZ, ListSFigure3D[i].SSphere.Transformation.ScaleX);
                            FRotate = new Vertex(ListSFigure3D[i].SSphere.Transformation.RotateY, ListSFigure3D[i].SSphere.Transformation.RotateZ, ListSFigure3D[i].SSphere.Transformation.RotateX);
                            FTranslate = new Vertex(ListSFigure3D[i].SSphere.Transformation.TranslateY * 5, ListSFigure3D[i].SSphere.Transformation.TranslateZ * 5, ListSFigure3D[i].SSphere.Transformation.TranslateX * 5);
                            sb_actualContent3D.AppendLine(GetSphereDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            if (i == ListSFigure3D.Count - 1)
                            {
                                sb_lastContent3D.AppendLine(GetSphereDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            }
                            break;
                        case ScrewyType3D.CYLINDER:
                            sb_metods3D.AppendLine(ListSFigure3D[i].SCylinder.Name + "();");
                            FScale = new Vertex(ListSFigure3D[i].SCylinder.Transformation.ScaleY, ListSFigure3D[i].SCylinder.Transformation.ScaleX, ListSFigure3D[i].SCylinder.Transformation.ScaleZ);
                            FRotate = new Vertex(ListSFigure3D[i].SCylinder.Transformation.RotateY, ListSFigure3D[i].SCylinder.Transformation.RotateX * -1, ListSFigure3D[i].SCylinder.Transformation.RotateZ);
                            FTranslate = new Vertex(ListSFigure3D[i].SCylinder.Transformation.TranslateY * 5, ListSFigure3D[i].SCylinder.Transformation.TranslateZ * 5, ListSFigure3D[i].SCylinder.Transformation.TranslateX * 5);
                            sb_actualContent3D.AppendLine(GetCylinderDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            if (i == ListSFigure3D.Count - 1)
                            {
                                sb_lastContent3D.AppendLine(GetCylinderDraw3D(ListSFigure3D[i].GetFigureName(), FScale, FRotate, FTranslate));
                            }
                            break;
                    }
                }
            }
        }

        public string GetAllDraw3D(int panelWidth, int panelHeight)
        {
            if (sb_actualContent3D.Length == 0) return "Data empty...";

            return  "#include <GL/glut.h>\n\n" +

                    "float cameraPosX = -20;\n" +
                    "float cameraPosY = 40;\n" +
                    "float cameraPosZ = 60;\n" +
                    "float cameraAngle = 114;\n\n" +

                    "void GridLines() {\n" +
                    "glPushMatrix();\n\n" +
                    "glColor3ub(50, 50, 50);\n" +
                    "for (int i = -50; i <= 50; i += 5) {\n" +
                    "glBegin(GL_LINES);\n" +
                    "glVertex3d(i, 0, -50);\n" +
                    "glVertex3d(i, 0, 50);\n" +
                    "glEnd();\n" +
                    "}\n\n" +
                    "for (int i = -50; i <= 50; i += 5) {\n" +
                    "glBegin(GL_LINES);\n" +
                    "glVertex3d(-50, 0, i);\n" +
                    "glVertex3d(50, 0, i);\n" +
                    "glEnd();\n" +
                    "}\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n" +

                    "void Axis() {\n" +
                    "glPushMatrix();\n\n" +
                    "glBegin(GL_LINES);\n" +
                    "glColor3ub(150, 150, 150);\n" +
                    "glVertex3d(-50, 0, 0);\n" +
                    "glVertex3d(50, 0, 0);\n\n" +
                    "glColor3ub(150, 150, 150);\n" +
                    "glVertex3d(0, 0, -50);\n" +
                    "glVertex3d(0, 0, 50);\n\n" +
                    "glColor3ub(0, 255, 0);\n" +
                    "glVertex3d(0, 0, 0);\n" +
                    "glVertex3d(15, 0, 0);\n\n" +
                    "glColor3ub(0, 0, 255);\n" +
                    "glVertex3d(0, 0, 0);\n" +
                    "glVertex3d(0, 15, 0);\n\n" +
                    "glColor3ub(255, 0, 0);\n" +
                    "glVertex3d(0, 0, 0);\n" +
                    "glVertex3d(0, 0, 15);\n" +
                    "glEnd();\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n" +

                    sb_actualContent3D.ToString() +

                    "void LoadConfig() {\n" +
                    "glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);\n" +
                    "glMatrixMode(GL_MODELVIEW);\n" +
                    "glLoadIdentity();\n" +
                    "gluLookAt(cameraPosX, cameraPosY, cameraPosZ, 0, 0, 0, 0, 1, 0);\n" +
                    "glRotated(cameraAngle, 0, 1, 0);\n\n" +
                    "GridLines();\n" +
                    "Axis();\n\n" +
                    "glColor3ub(255, 255, 255);\n" +
                    sb_metods3D.ToString() +
                    "\nglutSwapBuffers();\n" +
                     "}\n\n" +

                    "void InitialWindow(int w, int h) {\n" +
                    "glViewport(0, 0, w, h);\n" +
                    "glMatrixMode(GL_PROJECTION);\n" +
                    "glLoadIdentity();\n" +
                    "gluPerspective(70, (float)w / (float)h, 1, 200);\n" +
                     "}\n\n" +

                    "void KeyBoardEvent(unsigned char key, int x, int y) {\n" +
                    "switch (key) {\n" +
                    "case 'w':\n" +
                    "cameraPosY += 2;\n" +
                    "break;\n" +
                    "case 's':\n" +
                    "cameraPosY -= 2;\n" +
                    "break;\n" +
                    "case 'a':\n" +
                    "cameraAngle += 2;\n" +
                    "break;\n" +
                    "case 'd':\n" +
                    "cameraAngle -= 2;\n" +
                    "break;\n" +
                    "}\n" +
                    "}\n\n" +

                    "void Timer(int value) {" +
                    "glutPostRedisplay();\n" +
                    "glutTimerFunc(20, Timer, 0);\n" +
                     "}\n\n" +

                    "int main(int argc, char* argv[]) {\n" +
                    "glutInit(&argc, argv);\n" +
                    "glutInitDisplayMode(GLUT_RGBA | GLUT_DEPTH | GLUT_DOUBLE);\n" +
                    "glutInitWindowSize(" + panelWidth + ", " + panelHeight + ");\n" +
                    "glutInitWindowPosition(50, 50);\n" +
                    "glutCreateWindow(\"ScrewyGL - BY M3RFR3T | github.com/RazeLeakers\");\n" +
                    "glutReshapeFunc(InitialWindow);\n" +
                    "glutDisplayFunc(LoadConfig);\n" +
                    "glutKeyboardFunc(KeyBoardEvent);\n" +
                    "glutTimerFunc(0, Timer, 0);\n" +
                    "glutMainLoop();\n" +
                    "return 0;\n" +
                    "}";
        }

        public string GetActualDraw3D()
        {
            if (sb_actualContent3D.Length == 0) return "Data empty...";

            return sb_actualContent3D.ToString().TrimEnd();
        }

        public string GetLastDraw3D()
        {
            if (sb_lastContent3D.Length == 0) return "Data empty...";

            return sb_lastContent3D.ToString().TrimEnd();
        }

        private string GetCubeDraw3D(string FigureName,Vertex FigureScale,Vertex FigureRotate,Vertex FigureTranslate)
        {
            return "void " + FigureName + "() {\n" +
                    "float sizeX = " + FigureScale.X +";\n" +
                    "float sizeY = " + FigureScale.Y + ";\n" +
                    "float sizeZ = " + FigureScale.Z + ";\n\n" +
                    "glPushMatrix();\n\n" +
                    "glTranslated(" + FigureTranslate.X + ", " + FigureTranslate.Y + ", " + FigureTranslate.Z + ");\n" +
                    "glRotated(" + FigureRotate.X + ", 1, 0, 0);\n" +
                    "glRotated(" + FigureRotate.Y + ", 0, 1, 0);\n" +
                    "glRotated(" + FigureRotate.Z + ", 0, 0, 1);\n" +
                    "glBegin(GL_QUADS);\n" +
                    "glVertex3f(sizeX, sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, sizeY, sizeZ);\n" +
                    "glVertex3f(sizeX, sizeY, sizeZ);\n\n" +
                    "glVertex3f(sizeX, -sizeY, sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, -sizeZ);\n" +
                    "glVertex3f(sizeX, -sizeY, -sizeZ);\n\n" +
                    "glVertex3f(sizeX, sizeY, sizeZ);\n" +
                    "glVertex3f(-sizeX, sizeY, sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, sizeZ);\n" +
                    "glVertex3f(sizeX, -sizeY, sizeZ);\n\n" +
                    "glVertex3f(sizeX, -sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, sizeY, -sizeZ);\n" +
                    "glVertex3f(sizeX, sizeY, -sizeZ);\n\n" +
                    "glVertex3f(-sizeX, sizeY, sizeZ);\n" +
                    "glVertex3f(-sizeX, sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, -sizeZ);\n" +
                    "glVertex3f(-sizeX, -sizeY, sizeZ);\n\n" +
                    "glVertex3f(sizeX, sizeY, -sizeZ);\n" +
                    "glVertex3f(sizeX, sizeY, sizeZ);\n" +
                    "glVertex3f(sizeX, -sizeY, sizeZ);\n" +
                    "glVertex3f(sizeX, -sizeY, -sizeZ);\n" +
                    "glEnd();\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n";
        }

        private string GetConeDraw3D(string FigureName, Vertex FigureScale, Vertex FigureRotate, Vertex FigureTranslate)
        {
            return "void " + FigureName + "() {\n" +
                    "glPushMatrix();\n\n" +
                    "glTranslated(" + FigureTranslate.X + ", " + FigureTranslate.Y + ", " + FigureTranslate.Z + ");\n" +
                    "glRotated(" + (FigureRotate.X - 90) + ", 1, 0, 0);\n" +
                    "glRotated(" + FigureRotate.Y + ", 0, 1, 0);\n" +
                    "glRotated(" + FigureRotate.Z + ", 0, 0, 1);\n" +
                    "glScalef(" + FigureScale.X + ", " + FigureScale.Y + ", " + FigureScale.Z + ");\n" +
                    "gluCylinder(gluNewQuadric(), 7.5, 0, 10, 50, 50);\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n";
        }

        private string GetSphereDraw3D(string FigureName, Vertex FigureScale, Vertex FigureRotate, Vertex FigureTranslate)
        {
            return "void " + FigureName + "() {\n" +
                    "glPushMatrix();\n\n" +
                    "glTranslated(" + FigureTranslate.X + ", " + FigureTranslate.Y + ", " + FigureTranslate.Z + ");\n" +
                    "glRotated(" + FigureRotate.X + ", 1, 0, 0);\n" +
                    "glRotated(" + FigureRotate.Y + ", 0, 1, 0);\n" +
                    "glRotated(" + FigureRotate.Z + ", 0, 0, 1);\n" +
                    "glScalef(" + FigureScale.X + ", " + FigureScale.Y + ", " + FigureScale.Z + ");\n" +
                    "glutSolidSphere(5, 50, 50);\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n";
        }

        private string GetCylinderDraw3D(string FigureName, Vertex FigureScale, Vertex FigureRotate, Vertex FigureTranslate)
        {
            return "void " + FigureName + "() {\n" +
                    "glPushMatrix();\n\n" +
                    "glTranslated(" + FigureTranslate.X + ", " + FigureTranslate.Y + ", " + FigureTranslate.Z + ");\n" +
                    "glRotated(" + (FigureRotate.X - 90) + ", 1, 0, 0);\n" +
                    "glRotated(" + FigureRotate.Y + ", 0, 1, 0);\n" +
                    "glRotated(" + FigureRotate.Z + ", 0, 0, 1);\n" +
                    "glScalef(" + FigureScale.X + ", " + FigureScale.Y + ", " + FigureScale.Z + ");\n" +
                    "gluCylinder(gluNewQuadric(), 7.5, 7.5, 10, 50, 50);\n\n" +
                    "glPopMatrix();\n" +
                    "}\n\n";
        }
    }
}
