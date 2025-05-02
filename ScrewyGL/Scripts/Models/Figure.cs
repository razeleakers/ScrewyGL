using System.Drawing;
using SharpGL;

namespace ScrewyGL.Drawing.Models
{
    public abstract class ScrewyFigure3D
    {
        protected Color _FigureColor;

        protected string _FigureName;

        protected float _PosX = 0.0f;
        protected float _PosY = 0.0f;
        protected float _PosZ = 0.0f;

        protected float _AngleX = 0.0f;
        protected float _AngleY = 0.0f;
        protected float _AngleZ = 0.0f;

        protected float _ScaleX = 1.0f;
        protected float _ScaleY = 1.0f;
        protected float _ScaleZ = 1.0f;

        public ScrewyFigure3D(string figureName,Color figureColor)
        {
            this._FigureName = figureName;
            this._FigureColor = figureColor;
        }

        public string GetFigureName() => _FigureName;

        protected string GetStartConfigData()
        {
            return $"void {GetFigureName()}() {{\r\n    glPushMatrix();\r\n\r\n    glTranslatef({_PosX},{_PosY},{_PosZ});\r\n    glRotatef({_AngleX}, 1.0f, 0.0f, 0.0f);\r\n    glRotatef({_AngleY}, 0.0f, 1.0f, 0.0f);\r\n    glRotatef({_AngleZ}, 0.0f, 0.0f, 1.0f);\r\n    glScalef({_ScaleX},{_ScaleY},{_ScaleZ});\r\n\r\n    glColor3ub({_FigureColor.R},{_FigureColor.G},{_FigureColor.B});\r\n    ";
        }

        protected string GetFinalConfigData()
        {
            return $"\r\n    glPopMatrix();\r\n}}\n\n";
        }

        public abstract void RenderFigure(OpenGL sharpGL);

        public abstract string GetFigureData();

        public virtual void TranslateFigure(EW_Pos3D pos, float cant)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _PosX += cant;
                    break;
                case EW_Pos3D.Y:
                    _PosY += cant;
                    break;
                case EW_Pos3D.Z:
                    _PosZ += cant;
                    break;
            }
        }

        public virtual void RotateFigure(EW_Pos3D pos, float cant)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _AngleX += cant;
                    break;
                case EW_Pos3D.Y:
                    _AngleY += cant;
                    break;
                case EW_Pos3D.Z:
                    _AngleZ += cant;
                    break;
            }
        }

        public virtual void ScaleFigure(EW_Pos3D pos, float cant)
        {
            switch (pos)
            {
                case EW_Pos3D.X:
                    _ScaleX += cant;
                    break;
                case EW_Pos3D.Y:
                    _ScaleY += cant;
                    break;
                case EW_Pos3D.Z:
                    _ScaleZ += cant;
                    break;
            }
        }

        public virtual void Dispose(OpenGL sharpGL) { }
    }
}