namespace lab3.Figures
{
    internal abstract class Figure
    {
        protected int xCenter;
        protected int yCenter;

        protected Graphics CurrentGraphics() => Form1.ActiveForm.CreateGraphics();

        public abstract void DrawBlack();

        public abstract void HideDrawingBackGround();

        public void MoveRight(int stepCount = 10, int step = 10)
        {
            for (int i = 0; i < stepCount; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(30);
                HideDrawingBackGround();
                xCenter += step;
            }
        }
    }
}
