namespace Sisu__Sistema.View.Aluno
{
    partial class AlunoIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.listaAluno = new System.Windows.Forms.ListView();
            this.txtsalvar = new System.Windows.Forms.Button();
            this.txtCarregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão do Aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(156, 79);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(203, 23);
            this.txtTexto.TabIndex = 2;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(389, 79);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 3;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // listaAluno
            // 
            this.listaAluno.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listaAluno.Location = new System.Drawing.Point(156, 189);
            this.listaAluno.Name = "listaAluno";
            this.listaAluno.Size = new System.Drawing.Size(203, 122);
            this.listaAluno.TabIndex = 4;
            this.listaAluno.UseCompatibleStateImageBehavior = false;
            // 
            // txtsalvar
            // 
            this.txtsalvar.Location = new System.Drawing.Point(389, 126);
            this.txtsalvar.Name = "txtsalvar";
            this.txtsalvar.Size = new System.Drawing.Size(75, 23);
            this.txtsalvar.TabIndex = 5;
            this.txtsalvar.Text = "Salvar";
            this.txtsalvar.UseVisualStyleBackColor = true;
            this.txtsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCarregar
            // 
            this.txtCarregar.Location = new System.Drawing.Point(510, 79);
            this.txtCarregar.Name = "txtCarregar";
            this.txtCarregar.Size = new System.Drawing.Size(75, 23);
            this.txtCarregar.TabIndex = 6;
            this.txtCarregar.Text = "Carregar";
            this.txtCarregar.UseVisualStyleBackColor = true;
            this.txtCarregar.Click += new System.EventHandler(this.txtCarregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Idade";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(156, 126);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(203, 23);
            this.txtidade.TabIndex = 9;
            // 
            // AlunoIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCarregar);
            this.Controls.Add(this.txtsalvar);
            this.Controls.Add(this.listaAluno);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlunoIndex";
            this.Text = "AlunoIndex";
            this.Load += new System.EventHandler(this.AlunoIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTexto;
        private Button Adicionar;
        private ListView listaAluno;
        private Button txtsalvar;
        private Button txtCarregar;
        private Button button1;
        private Label label3;
        private TextBox txtidade;
    }
}