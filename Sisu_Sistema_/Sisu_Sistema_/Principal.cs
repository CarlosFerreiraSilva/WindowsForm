using Sisu_Sistema_.View.Aluno;

namespace Sisu_Sistema_
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gota Serena");
            AlunoIndex alunoExibir = new AlunoIndex();
            alunoExibir.Show(); 
        }
    }
}