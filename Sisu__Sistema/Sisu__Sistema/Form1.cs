using Sisu__Sistema.View.Aluno;

namespace Sisu__Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gota Serena");
            AlunoIndex alunoExibir = new AlunoIndex();
            alunoExibir.Show();
        }
    }
}