using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sisu__Sistema.Model;

namespace Sisu__Sistema.DAL
{
    public class AlunoDAO
    {
        string endereçoArquivo;
        public AlunoDAO()
        {
            endereçoArquivo = "Aluno.txt";
        }
            
            
      
        public void inserir(Aluno aluno)
        {

        }
        public List<Aluno> getTodosAlunos()
        {
            List<Aluno> novaLista = new List<Aluno>();
            {
                StreamReader sr = new StreamReader("Alunos.txt");
                string linha = sr.ReadLine();
                while (linha != null)
                {
                    Aluno novoAluno = new Aluno();
                    string[] dados = linha.Split("|");
                    novoAluno.Nome= dados[0];
                  
                    novaLista.Add(novoAluno);
                    linha = sr.ReadLine();
                }
                sr.Close();
                return novaLista;
            }
           
        }
    }
}
