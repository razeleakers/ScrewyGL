using System;
using System.Drawing;
using SharpGL;
using ScrewyGL.Drawing.Models;

namespace ScrewyGL.Drawing
{
    public class SW_Disk3D : ScrewyFigure3D
    {
        private IntPtr _Quadric;

        public SW_Disk3D(string figureName, Color figureColor, IntPtr quadric) : base(figureName, figureColor)
        {
            this._AngleX -= 90.0f;

            this._Quadric = quadric;
        }

        public override void RenderFigure(OpenGL sharpGL)
        {
            sharpGL.PushMatrix();

            sharpGL.Translate(_PosX, _PosY, _PosZ);
            sharpGL.Rotate(_AngleX, 1.0f, 0.0f, 0.0f);
            sharpGL.Rotate(_AngleY, 0.0f, 1.0f, 0.0f);
            sharpGL.Rotate(_AngleZ, 0.0f, 0.0f, 1.0f);
            sharpGL.Scale(_ScaleX, _ScaleY, _ScaleZ);

            sharpGL.Color(_FigureColor.R, _FigureColor.G, _FigureColor.B);

            sharpGL.Disk(_Quadric, 0.0d, 1.0d, 32, 1);

            sharpGL.PopMatrix();
        }

        public override void RotateFigure(EW_Pos3D pos, float angle)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _AngleY += angle;
                    break;
                case EW_Pos3D.Y:
                    _AngleZ += angle;
                    break;
                case EW_Pos3D.Z:
                    _AngleX += angle;
                    break;
            }
        }

        public override void ScaleFigure(EW_Pos3D pos, float cant)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _ScaleX += cant;
                    break;
                case EW_Pos3D.Y:
                    _ScaleZ += cant;
                    break;
                case EW_Pos3D.Z:
                    _ScaleY += cant;
                    break;
            }
        }

        public override string GetFigureData()
        {
            return $"{GetStartConfigData()} gluDisk(quadric, 0.0, 1.0, 32, 1); {GetFinalConfigData()}";
        }

        public override void Dispose(OpenGL sharpGL)
        {
            sharpGL.DeleteQuadric(_Quadric);
        }
    }
}