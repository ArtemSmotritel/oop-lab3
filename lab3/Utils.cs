namespace lab3
{
    internal static class Utils
    {
        public static Pen BlackPen()
        {
            return new Pen(Color.Black, 4);
        }

        public static Pen BackGroundPen()
        {
            return new Pen(Form1.ActiveForm.BackColor, 4);
        }
    }
}
