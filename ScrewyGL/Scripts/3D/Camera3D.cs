using System;

namespace ScrewyGL.Drawing
{
    public class SW_Camera3D
    {
        public double EyeX { get; private set; }
        public double EyeY { get; private set; }
        public double EyeZ { get; private set; }

        public double CenterX { get; }
        public double CenterY { get; }
        public double CenterZ { get; }

        private double _Radius, _Theta, _Phi;

        private const double VELOCITY = 0.05d;
        private const double PHI_LIMIT = Math.PI / 2.0d;

        public SW_Camera3D()
        {
            this.CenterX = 0.0d;
            this.CenterY = 0.0d;
            this.CenterZ = 0.0d;

            this.EyeX = 10.0d;
            this.EyeY = 5.0d;
            this.EyeZ = 10.0d;

            ComputeRTP();
        }

        public void ZoomIn()
        {
            UpdateZoom(1);
        }

        public void ZoomOut()
        {
            UpdateZoom(-1);
        }

        public void MoveLeft()
        {
            _Theta -= VELOCITY;

            UpdateLook();
        }

        public void MoveRight()
        {
            _Theta += VELOCITY;

            UpdateLook();
        }

        public void MoveUp()
        {
            _Phi = Math.Min(_Phi + VELOCITY, PHI_LIMIT);

            UpdateLook();
        }

        public void MoveDown()
        {
            _Phi = Math.Max(_Phi - VELOCITY, -PHI_LIMIT);

            UpdateLook();
        }

        private void UpdateZoom(int direction)
        {
            if (direction == -1)
            {
                double length = Math.Sqrt(Math.Pow(CenterX - EyeX, 2.0d) + Math.Pow(CenterY - EyeY, 2.0d) + Math.Pow(CenterZ - EyeZ, 2.0d));

                if (length <= 1.5d) return;
            }

            EyeX += direction * VELOCITY * EyeX;
            EyeY += direction * VELOCITY * EyeY;
            EyeZ += direction * VELOCITY * EyeZ;

            ComputeRTP();
        }

        private void UpdateLook()
        {
            EyeX = CenterX + _Radius * Math.Cos(_Phi) * Math.Sin(_Theta);
            EyeY = CenterY + _Radius * Math.Sin(_Phi);
            EyeZ = CenterZ + _Radius * Math.Cos(_Phi) * Math.Cos(_Theta);
        }

        private void ComputeRTP()
        {
            GenRadius();
            GenTheta();
            GenPhi();
        }

        private void GenRadius()
        {
            _Radius = Math.Sqrt(Math.Pow(EyeX - CenterX, 2.0d) + Math.Pow(EyeY - CenterY, 2.0d) + Math.Pow(EyeZ - CenterZ, 2.0d));
        }

        private void GenTheta()
        {
            _Theta = Math.Atan2(EyeX - CenterX,EyeZ - CenterZ);
        }

        private void GenPhi()
        {
            _Phi = Math.Asin((EyeY - CenterY) / _Radius);
        }
    }
}