namespace lab3.Figures
{
    internal class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;

        public Rhomb(int horDiagLen, int vertDiagLen, int xCenter, int yCenter)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
            this.xCenter = xCenter;
            this.yCenter = yCenter;
        }

        public override void DrawBlack()
        {
            CurrentGraphics().DrawPolygon(Utils.BlackPen(), GetCurrentRhomb());
        }

        public override void HideDrawingBackGround()
        {
            CurrentGraphics().DrawPolygon(Utils.BackGroundPen(), GetCurrentRhomb());
        }

        private Point[] GetCurrentRhomb()
        {
            var halfVert = vertDiagLen / 2;
            var halfHor = horDiagLen / 2;

            var leftPoint = new Point(xCenter - halfHor, yCenter);
            var rightPoint = new Point(xCenter + halfHor, yCenter);
            var topPoint = new Point(xCenter, yCenter + halfVert);
            var bottomPoint = new Point(xCenter, yCenter - halfVert);
            return new Point[] { leftPoint, topPoint, rightPoint, bottomPoint };
        }
    }
}
