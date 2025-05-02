using System.Text;
using System.Collections.Generic;
using SharpGL;

namespace ScrewyGL.Drawing
{
    public class SW_Register2D
    {
        private List<SW_Draw2D> _ListDrawings2D;
        private StringBuilder _DataDrawings2D;
        private OpenGL _SharpGL;

        public SW_Register2D(OpenGL sharpGL) 
        {
            this._SharpGL = sharpGL;
            this._DataDrawings2D = new StringBuilder();
            this._ListDrawings2D = new List<SW_Draw2D>();
        }

        public void AddDrawingObject(SW_Draw2D draw2D)
        {
            _ListDrawings2D.Add(draw2D);
        }

        public void RemoveLastDrawingObject()
        {
            if (_ListDrawings2D.Count > 0) _ListDrawings2D.RemoveAt(_ListDrawings2D.Count - 1);
        }
        public void RenderDrawingsObjects()
        {
            _ListDrawings2D.ForEach(dw => dw.RenderDrawingObject(_SharpGL));
        }

        public string GetDrawingsData(int width,int height)
        {
            _DataDrawings2D.Clear();

            _DataDrawings2D.AppendLine("#include <GL/glut.h>\n\nvoid ScrewyDraw2D() {");

            _ListDrawings2D.ForEach(dw => _DataDrawings2D.Append(dw.GetDrawingData()));

            _DataDrawings2D.Append($"}}\n\nvoid LoadConfig() {{\r\n\tglClearColor(155.0f / 255.0f, 155.0f / 255.0f, 155.0f / 255.0f, 1.0f);\r\n\tglViewport(0, 0, {width}, {height});\r\n\tglMatrixMode(GL_PROJECTION);\r\n\tglLoadIdentity();\r\n\tgluOrtho2D(0.0, {width}.0, {height}.0, 0.0);\r\n\tglMatrixMode(GL_MODELVIEW);\r\n\tglLoadIdentity();\r\n}}\r\n\r\nvoid ScrewyGL() {{\r\n\tglClear(GL_COLOR_BUFFER_BIT);\r\n\tScrewyDraw2D();\r\n\tglFlush();\r\n}}\r\n\r\nint main(int argc, char** argv) {{\r\n\tglutInit(&argc, argv);\r\n\tglutInitDisplayMode(GLUT_SINGLE | GLUT_RGBA);\r\n\tglutInitWindowPosition(50, 50);\r\n\tglutInitWindowSize({width}, {height});\r\n\tglutCreateWindow(\"ScrewyGL - 2D\");\r\n\tLoadConfig();\r\n\tglutDisplayFunc(ScrewyGL);\r\n\tglutMainLoop();\r\n\r\n\treturn 0;\r\n}}");

            return _DataDrawings2D.ToString();
        }

        public void ClearDrawings()
        {
            _DataDrawings2D.Clear();
            _ListDrawings2D.Clear();
        }
    }
}