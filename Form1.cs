namespace _2plus2Solver
{
    public partial class Form1 : Form
    {
        Solver solver;
        public Form1()
        {
            InitializeComponent();
            solver = new Solver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(solver.Plus(2,2).ToString(), "ответ");
        }
    }
}