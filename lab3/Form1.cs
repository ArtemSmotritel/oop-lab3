using lab3.Figures;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => { new Circle(50, 150, 150).MoveRight(100, 5); });
            thread.Start();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => { new Square(100, 150, 300).MoveRight(100); });
            thread.Start();
        }

        private void rhomb_button_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => { new Rhomb(100, 50, 150, 450).MoveRight(40, 20); });
            thread.Start();
        }
    }
}