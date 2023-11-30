namespace _2plus2Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Plus(2,2).ToString(), "ответ");
        }

        int Plus(int a, int b) { 
            return a + b;
        }
    }
}