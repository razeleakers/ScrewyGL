using System.Text;
using System.Drawing;
using System.Collections.Generic;
using SharpGL;
using SharpGL.Enumerations;

namespace ScrewyGL.Drawing
{
    public struct SW_Point2D
    {
        public Point Position { get; set; }
        public Color ColorARGB { get; set; }

        public SW_Point2D(Point position, Color colorARGB)
        {
            this.Position = position;
            this.ColorARGB = colorARGB;
        }
    }

    public struct SW_Config2D
    {
        public float LineSize { get; set; }
        public BeginMode Type2D { get; set; }

        public SW_Config2D(float lineSize, BeginMode type2D)
        {
            this.LineSize = lineSize;
            this.Type2D = type2D;
        }
    }

    public class SW_Draw2D
    {
        private List<SW_Point2D> _ListPoints2D;
        private StringBuilder _DataDraw2D;
        private SW_Config2D _Config2D;

        public SW_Draw2D(SW_Config2D config2D)
        {
            this._Config2D = config2D;
            this._DataDraw2D = new StringBuilder();
            this._DataDraw2D.AppendLine($"\t// GL_{config2D.Type2D}\n\tglLineWidth({config2D.LineSize});\n\tglBegin({(uint)config2D.Type2D});");
            this._ListPoints2D = new List<SW_Point2D> ();
        }

        public int GetTotalPoints() => _ListPoints2D.Count;

        public void AddPoint(SW_Point2D point2D)
        {
            if(_ListPoints2D.Count == 0 || _ListPoints2D[_ListPoints2D.Count - 1].ColorARGB != point2D.ColorARGB)
            {
                _DataDraw2D.AppendLine($"\tglColor3ub({point2D.ColorARGB.R}, {point2D.ColorARGB.G}, {point2D.ColorARGB.B});");
            }

            _DataDraw2D.AppendLine($"\tglVertex2f({point2D.Position.X}.0f, {point2D.Position.Y}.0f);");

            _ListPoints2D.Add(point2D);
        }

        public void RenderDrawingObject(OpenGL sharpGL)
        {
            if (_ListPoints2D.Count > 0)
            {
                sharpGL.LineWidth(_Config2D.LineSize);

                sharpGL.Begin(_Config2D.Type2D);

                _ListPoints2D.ForEach(pt => 
                {
                    sharpGL.Color(pt.ColorARGB.R, pt.ColorARGB.G, pt.ColorARGB.B);
                    sharpGL.Vertex(pt.Position.X,pt.Position.Y);
                });

                sharpGL.End();
            }
        }

        public string GetDrawingData()
        {
            if (_ListPoints2D.Count == 0) return string.Empty;

            return $"{_DataDraw2D.ToString().TrimEnd()}\n\tglEnd();\n\n";
        }
    }
}