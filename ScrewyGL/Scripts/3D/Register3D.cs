using System.Text;
using System.Collections.Generic;
using SharpGL;
using ScrewyGL.Drawing.Models;

namespace ScrewyGL.Drawing
{
    public class SW_Register3D
    {
        private List<ScrewyFigure3D> _ListFigures3D;
        private StringBuilder _DataFigures3D;
        private OpenGL _SharpGL;

        public SW_Register3D(OpenGL sharpGL)
        {
            this._SharpGL = sharpGL;
            this._DataFigures3D = new StringBuilder();
            this._ListFigures3D = new List<ScrewyFigure3D>();
        }

        public bool FigureExists(string figureName)
        {
            foreach (var fg in _ListFigures3D) if (fg.GetFigureName() == figureName) return true;

            return false;
        }

        public void AddNewFigure(ScrewyFigure3D figure3D)
        {
            _ListFigures3D.Add(figure3D);
        }

        public void TranslateFigureAt(int index, EW_Pos3D pos, float cant)
        {
            if (index < 0 || index >= _ListFigures3D.Count) return;

            _ListFigures3D[index].TranslateFigure(pos, cant);
        }

        public void RotateFigureAt(int index, EW_Pos3D pos, float cant)
        {
            if (index < 0 || index >= _ListFigures3D.Count) return;

            _ListFigures3D[index].RotateFigure(pos, cant);
        }

        public void ScaleFigureAt(int index,EW_Pos3D pos,float cant)
        {
            if (index < 0 || index >= _ListFigures3D.Count) return;

            _ListFigures3D[index].ScaleFigure(pos, cant);
        }

        public void RemoveFigureAt(int index)
        {
            if (index < 0 || index >= _ListFigures3D.Count) return;

            ScrewyFigure3D fg = _ListFigures3D[index];
            _ListFigures3D.RemoveAt(index);
            fg.Dispose(_SharpGL);
        }

        public void RenderFigures()
        {
            _ListFigures3D.ForEach(fg => fg.RenderFigure(_SharpGL));
        }

        public string GetFiguresData(int width,int height)
        {
            _DataFigures3D.Clear();

            StringBuilder fg_names = new StringBuilder();

            _DataFigures3D.AppendLine($"#define _USE_MATH_DEFINES\r\n\r\n#include <GL/glut.h>\r\n#include <algorithm>\r\n\r\nusing namespace std;\r\n\r\nclass Camera3D {{\r\nprivate:\r\n    double _EyeX, _EyeY, _EyeZ;\r\n    double _CenterX, _CenterY, _CenterZ;\r\n    double _Radius, _Theta, _Phi;\r\n\r\n    static constexpr double VELOCITY = 0.05;\r\n    static constexpr double PHI_LIMIT = M_PI_2;\r\n\r\n    void UpdateZoom(int direction) {{\r\n        if (direction == -1) {{\r\n            double dx = _CenterX - _EyeX;\r\n            double dy = _CenterY - _EyeY;\r\n            double dz = _CenterZ - _EyeZ;\r\n\r\n            double length = sqrt(dx * dx + dy * dy + dz * dz);\r\n\r\n            if (length <= 1.5) return;\r\n        }}\r\n\r\n        _EyeX += direction * VELOCITY * _EyeX;\r\n        _EyeY += direction * VELOCITY * _EyeY;\r\n        _EyeZ += direction * VELOCITY * _EyeZ;\r\n\r\n        ComputeRTP();\r\n    }}\r\n\r\n    void UpdateLook() {{\r\n        _EyeX = _CenterX + _Radius * cos(_Phi) * sin(_Theta);\r\n        _EyeY = _CenterY + _Radius * sin(_Phi);\r\n        _EyeZ = _CenterZ + _Radius * cos(_Phi) * cos(_Theta);\r\n    }}\r\n\r\n    void ComputeRTP() {{\r\n        GenRadius();\r\n        GenTheta();\r\n        GenPhi();\r\n    }}\r\n\r\n    void GenRadius() {{\r\n        _Radius = sqrt(pow(_EyeX - _CenterX, 2.0) + pow(_EyeY - _CenterY, 2.0) + pow(_EyeZ - _CenterZ, 2.0));\r\n    }}\r\n\r\n    void GenTheta() {{\r\n        _Theta = atan2(_EyeX - _CenterX, _EyeZ - _CenterZ);\r\n    }}\r\n\r\n    void GenPhi() {{\r\n        _Phi = asin((_EyeY - _CenterY) / _Radius);\r\n    }}\r\n\r\npublic:\r\n    Camera3D() {{\r\n        _EyeX = 10.0;\r\n        _EyeY = 5.0;\r\n        _EyeZ = 10.0;\r\n\r\n        _CenterX = 0;\r\n        _CenterY = 0;\r\n        _CenterZ = 0;\r\n\r\n        ComputeRTP();\r\n    }}\r\n\r\n    double Get_EyeX() const {{ return _EyeX; }}\r\n    double Get_EyeY() const {{ return _EyeY; }}\r\n    double Get_EyeZ() const {{ return _EyeZ; }}\r\n\r\n    double Get_CenterX() const {{ return _CenterX; }}\r\n    double Get_CenterY() const {{ return _CenterY; }}\r\n    double Get_CenterZ() const {{ return _CenterZ; }}\r\n\r\n    void ZoomIn()\r\n    {{\r\n        UpdateZoom(1);\r\n    }}\r\n\r\n    void ZoomOut()\r\n    {{\r\n        UpdateZoom(-1);\r\n    }}\r\n\r\n    void MoveLeft() {{\r\n        _Theta -= VELOCITY;\r\n\r\n        UpdateLook();\r\n    }}\r\n\r\n    void MoveRight() {{\r\n        _Theta += VELOCITY;\r\n\r\n        UpdateLook();\r\n    }}\r\n\r\n    void MoveUp() {{\r\n        _Phi = min(_Phi + VELOCITY, PHI_LIMIT);\r\n\r\n        UpdateLook();\r\n    }}\r\n\r\n    void MoveDown() {{\r\n        _Phi = max(_Phi - VELOCITY, -PHI_LIMIT);\r\n\r\n        UpdateLook();\r\n    }}\r\n}};\r\n\r\nvoid AxisXYZ(float size) {{\r\n    glLineWidth(3.0f);\r\n    glBegin(GL_LINES);\r\n\r\n    glColor3f(1.0f, 0.0f, 0.0f);\r\n    glVertex3f(0.0f, 0.0f, 0.0f);\r\n    glVertex3f(size, 0.0f, 0.0f);\r\n\r\n    glColor3f(0.0f, 1.0f, 0.0f);\r\n    glVertex3f(0.0f, 0.0f, 0.0f);\r\n    glVertex3f(0.0f, size, 0);\r\n\r\n    glColor3f(0.0f, 0.0f, 1.0f);\r\n    glVertex3f(0.0f, 0.0f, 0.0f);\r\n    glVertex3f(0.0f, 0.0f, size);\r\n\r\n    glEnd();\r\n}}\r\n\r\nvoid GridLines(float size) {{\r\n    size *= 2.0f;\r\n\r\n    glLineWidth(1.0f);\r\n    glBegin(GL_LINES);\r\n\r\n    glColor3f(40.0f / 255.0f, 40.0f / 255.0f, 40.0f / 255.0f);\r\n\r\n    for (float i = -size;i <= size; i += 0.5f)\r\n    {{\r\n        glVertex3f(i, 0.0f, -size);\r\n        glVertex3f(i, 0.0f, size);\r\n\r\n        glVertex3f(-size, 0.0f, i);\r\n        glVertex3f(size, 0.0f, i);\r\n    }}\r\n\r\n    glEnd();\r\n}}\r\n\r\nGLUquadric* quadric = gluNewQuadric();\n");

            _ListFigures3D.ForEach(e =>
            {
                fg_names.AppendLine($"{e.GetFigureName()}();");

                _DataFigures3D.Append(e.GetFigureData());
            });

            _DataFigures3D.Append($"void ScrewyDraw3D() {{\n{fg_names}}}\r\n\r\nvoid LoadConfig() {{\r\n    glClearColor(0.0f, 0.0f, 0.0f, 1.0f);\r\n    glViewport(0, 0, {width}, {height});\r\n    glMatrixMode(GL_PROJECTION);\r\n    glLoadIdentity();\r\n    gluPerspective(60.0, {width}.0 / {height}.0, 1.0, 80.0);\r\n\r\n    glEnable(GL_DEPTH_TEST);\r\n\r\n    float L_AMBIENT[] = {{ 0.2f, 0.2f, 0.2f, 1.0f }};\r\n    float L_DIFFUSE[] = {{ 0.7f, 0.7f, 0.7f, 1.0f }};\r\n\r\n    glLightfv(GL_LIGHT0, GL_AMBIENT, L_AMBIENT);\r\n    glLightfv(GL_LIGHT0, GL_DIFFUSE, L_DIFFUSE);\r\n\r\n    glEnable(GL_LIGHT0);\r\n\r\n    glEnable(GL_COLOR_MATERIAL);\r\n    glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);\r\n\r\n    glShadeModel(GL_FLAT);\r\n\r\n    glEnable(GL_NORMALIZE);\r\n}}\r\n\r\nfloat L_POSITION[] = {{ 0.0f, 5.0f, 10.0f, 1.0f }};\r\nCamera3D cam;\r\n\r\nvoid ScrewyGL() {{\r\n    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);\r\n    glMatrixMode(GL_MODELVIEW);\r\n    glLoadIdentity();\r\n    gluLookAt(cam.Get_EyeX(), cam.Get_EyeY(), cam.Get_EyeZ(), cam.Get_CenterX(), cam.Get_CenterY(), cam.Get_CenterZ(), 0.0, 1.0, 0.0);\r\n    \r\n    AxisXYZ(3.0f);\r\n    GridLines(5.0f);\r\n\r\n    glEnable(GL_LIGHTING);\r\n    glLightfv(GL_LIGHT0,GL_POSITION,L_POSITION);\r\n    ScrewyDraw3D();\r\n    glDisable(GL_LIGHTING);\r\n\r\n    glutSwapBuffers();\r\n}}\r\n\r\nvoid KeyBoardEvent(unsigned char key, int x, int y) {{\r\n    switch (key) {{\r\n        case 'w':\r\n        case 'W':\r\n            cam.MoveUp();\r\n            break;\r\n        case 'a':\r\n        case 'A':\r\n            cam.MoveLeft();\r\n            break;\r\n        case 's':\r\n        case 'S':\r\n            cam.MoveDown();\r\n            break;\r\n        case 'd':\r\n        case 'D':\r\n            cam.MoveRight();\r\n            break;\r\n        case 'x':\r\n        case 'X':\r\n            cam.ZoomIn();\r\n            break;\r\n        case 'z':\r\n        case 'Z':\r\n            cam.ZoomOut();\r\n            break;\r\n    }}\r\n\r\n    glutPostRedisplay();\r\n}}\r\n\r\nint main(int argc, char** argv) {{\r\n    glutInit(&argc, argv);\r\n    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);\r\n    glutInitWindowPosition(50, 50);\r\n    glutInitWindowSize({width}, {height});\r\n    glutCreateWindow(\"ScrewyGL - 3D\");\r\n    LoadConfig();\r\n    glutDisplayFunc(ScrewyGL);\r\n    glutKeyboardFunc(KeyBoardEvent);\r\n    glutMainLoop();\r\n\r\n    return 0;\r\n}}");

            return _DataFigures3D.ToString();
        }

        public void ClearFigures()
        {
            _DataFigures3D.Clear();
            _ListFigures3D.ForEach(fg => fg.Dispose(_SharpGL));
            _ListFigures3D.Clear();
        }
    }
}