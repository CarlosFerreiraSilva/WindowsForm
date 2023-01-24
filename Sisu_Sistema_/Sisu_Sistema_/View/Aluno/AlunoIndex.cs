using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisu_Sistema_.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaAlunos.Items.Add(txtNomes.Text);
        }

        private void txtNomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");
            foreach (ListViewItem item in listaAlunos.Items)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine("Reginaldo Bonito");
            sw.Close();
        }
    }
}
