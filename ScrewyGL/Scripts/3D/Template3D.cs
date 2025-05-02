using SharpGL;
using SharpGL.Enumerations;

namespace ScrewyGL.Drawing
{
    public static class Template3D
    {
        public static void AxisXYZ(OpenGL sharpGL, float size)
        {
            sharpGL.LineWidth(3.0f);

            sharpGL.Begin(BeginMode.Lines);

            sharpGL.Color(1.0f, 0.0f, 0.0f);
            sharpGL.Vertex(0.0f, 0.0f, 0.0f);
            sharpGL.Vertex(size, 0.0f, 0.0f);

            sharpGL.Color(0.0f, 1.0f, 0.0f);
            sharpGL.Vertex(0.0f, 0.0f, 0.0f);
            sharpGL.Vertex(0.0f, size, 0.0f);

            sharpGL.Color(0.0f, 0.0f, 1.0f);
            sharpGL.Vertex(0.0f, 0.0f, 0.0f);
            sharpGL.Vertex(0.0f, 0.0f, size);

            sharpGL.End();
        }

        public static void GridLines(OpenGL sharpGL, float size)
        {
            size *= 2.0f;

            sharpGL.LineWidth(1.0f);

            sharpGL.Begin(BeginMode.Lines);

            sharpGL.Color(40.0f / 255.0f, 40.0f / 255.0f, 40.0f / 255.0f);

            for (float i = -size; i <= size; i += 0.5f)
            {
                sharpGL.Vertex(i, 0.0f, -size);
                sharpGL.Vertex(i, 0.0f, size);

                sharpGL.Vertex(-size, 0.0f, i);
                sharpGL.Vertex(size, 0.0f, i);
            }

            sharpGL.End();
        }
    }
}