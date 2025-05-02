using System.Drawing;
using SharpGL;
using SharpGL.Enumerations;
using ScrewyGL.Drawing.Models;

namespace ScrewyGL.Drawing
{
    public class SW_Cube3D : ScrewyFigure3D
    {
        public SW_Cube3D(string figureName, Color figureColor) : base(figureName, figureColor) { }

        public override void RenderFigure(OpenGL sharpGL)
        {
            sharpGL.PushMatrix();

            sharpGL.Translate(_PosX, _PosY, _PosZ);
            sharpGL.Rotate(_AngleX, 1.0f, 0.0f, 0.0f);
            sharpGL.Rotate(_AngleY, 0.0f, 1.0f, 0.0f);
            sharpGL.Rotate(_AngleZ, 0.0f, 0.0f, 1.0f);
            sharpGL.Scale(_ScaleX, _ScaleY, _ScaleZ);

            sharpGL.Begin(BeginMode.Quads);

            sharpGL.Color(_FigureColor.R, _FigureColor.G, _FigureColor.B);

            // TOP
            sharpGL.Normal(0.0f, 1.0f, 0.0f);
            sharpGL.Vertex(1.0f, 1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, 1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, 1.0f, 1.0f);
            sharpGL.Vertex(1.0f, 1.0f, 1.0f);

            // BOTTOM
            sharpGL.Normal(0.0f, -1.0f, 0.0f);
            sharpGL.Vertex(1.0f, -1.0f, 1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, 1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, -1.0f);
            sharpGL.Vertex(1.0f, -1.0f, -1.0f);

            // FRONT
            sharpGL.Normal(0.0f, 0.0f, 1.0f);
            sharpGL.Vertex(1.0f, 1.0f, 1.0f);
            sharpGL.Vertex(-1.0f, 1.0f, 1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, 1.0f);
            sharpGL.Vertex(1.0f, -1.0f, 1.0f);

            // BACK
            sharpGL.Normal(0.0f, 0.0f, -1.0f);
            sharpGL.Vertex(1.0f, -1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, 1.0f, -1.0f);
            sharpGL.Vertex(1.0f, 1.0f, -1.0f);

            // LEFT
            sharpGL.Normal(-1.0f, 0.0f, 0.0f);
            sharpGL.Vertex(-1.0f, 1.0f, 1.0f);
            sharpGL.Vertex(-1.0f, 1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, -1.0f);
            sharpGL.Vertex(-1.0f, -1.0f, 1.0f);

            // RIGHT
            sharpGL.Normal(1.0f, 0.0f, 0.0f);
            sharpGL.Vertex(1.0f, 1.0f, -1.0f);
            sharpGL.Vertex(1.0f, 1.0f, 1.0f);
            sharpGL.Vertex(1.0f, -1.0f, 1.0f);
            sharpGL.Vertex(1.0f, -1.0f, -1.0f);

            sharpGL.End();

            sharpGL.PopMatrix();
        }

        public override void RotateFigure(EW_Pos3D pos, float angle)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _AngleZ -= angle;
                    break;
                case EW_Pos3D.Y:
                    _AngleY += angle;
                    break;
                case EW_Pos3D.Z:
                    _AngleX += angle;
                    break;
            }
        }

        public override string GetFigureData()
        {
            return $"{GetStartConfigData()} glutSolidCube(2.0f); {GetFinalConfigData()}";
        }
    }
}