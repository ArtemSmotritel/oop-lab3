namespace lab3.Figures
{
    internal class Square : Figure
    {
        private int sideLength;

        public Square(int sideLength, int xCenter, int yCenter)
        {
            this.sideLength = sideLength;
            this.xCenter = xCenter;
            this.yCenter = yCenter;
        }

        public override void DrawBlack()
        {
            CurrentGraphics().DrawRectangle(Utils.BlackPen(), GetCurrentRectangle());
        }

        public override void HideDrawingBackGround()
        {
            CurrentGraphics().DrawRectangle(Utils.BackGroundPen(), GetCurrentRectangle());
        }

        private Rectangle GetCurrentRectangle()
        {
            var xTopLeft = xCenter - sideLength / 2;
            var yTopLeft = yCenter - sideLength / 2;
            return new Rectangle(xTopLeft, yTopLeft, sideLength, sideLength);
        }
    }
}
