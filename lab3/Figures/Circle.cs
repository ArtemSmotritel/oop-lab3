namespace lab3.Figures
{
    internal class Circle : Figure
    {
        private int radius;

        public Circle(int radius, int xCenter, int yCenter)
        {
            this.radius = radius;
            this.xCenter = xCenter;
            this.yCenter = yCenter;
        }

        public override void DrawBlack()
        {
            CurrentGraphics().DrawEllipse(Utils.BlackPen(), GetCurrentRectangle());
        }

        public override void HideDrawingBackGround()
        {
            CurrentGraphics().DrawEllipse(Utils.BackGroundPen(), GetCurrentRectangle());
        }

        private Rectangle GetCurrentRectangle()
        {
            var diameter = radius * 2;
            return new Rectangle(xCenter - radius, yCenter - radius, diameter, diameter);
        }
    }
}
