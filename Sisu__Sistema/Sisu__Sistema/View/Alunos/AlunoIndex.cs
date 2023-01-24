using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisu__Sistema.DAL;

namespace Sisu__Sistema.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "")
            {
                MessageBox.Show("Nome é obrigatorio");
                txtTexto.BackColor = Color.Red;
            }
            if (txtidade.Text == "")
            {
                MessageBox.Show("Idade é obrigatorio");
                txtidade.BackColor = Color.Red;    
            }
            if ((txtTexto.Text!= "") & (txtidade.Text!= ""))
            {
                listaAluno.Items.Add(txtTexto.Text + "|" + txtidade.Text);
                txtTexto.BackColor = Color.White;
                txtidade.BackColor = Color.White;
            }

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");
            foreach (ListViewItem item in listaAluno.Items)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine("Reginaldo Bonito");
            sw.Close();
        }

        private void txtCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Alunos.txt");
                string linha = sr.ReadLine();
                while (linha != null)
                {
                    listaAluno.Items.Add(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch(System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Erro de leitura de arquivo");

            }
        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {
            try
            {
                AlunoDAO dados = new AlunoDAO();    
                List<Model.Aluno> alunos = dados.getTodosAlunos();
                foreach (var item in alunos)
                {
                    listaAluno.Items.Add(item.Nome + "|" + item.Idade);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Erro de leitura de arquivo");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");
            sw.Flush();
            sw.Close();
            listaAluno.Clear();
        }
    }
}
