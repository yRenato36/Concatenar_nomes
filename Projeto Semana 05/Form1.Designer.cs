namespace Projeto_Semana_05
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btConcatenar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(191, 57);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(222, 20);
            this.textNome.TabIndex = 0;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textSobrenome
            // 
            this.textSobrenome.Location = new System.Drawing.Point(191, 83);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(222, 20);
            this.textSobrenome.TabIndex = 1;
            this.textSobrenome.TextChanged += new System.EventHandler(this.textSobrenome_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(71, 57);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(86, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Digite seu nome:";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Location = new System.Drawing.Point(71, 83);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(114, 13);
            this.sobrenome.TabIndex = 3;
            this.sobrenome.Text = "Digite seu Sobrenome:";
            this.sobrenome.Click += new System.EventHandler(this.sobrenome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concatenar nomes";
            // 
            // btConcatenar
            // 
            this.btConcatenar.Location = new System.Drawing.Point(74, 144);
            this.btConcatenar.Name = "btConcatenar";
            this.btConcatenar.Size = new System.Drawing.Size(168, 44);
            this.btConcatenar.TabIndex = 5;
            this.btConcatenar.Text = "Concatenar";
            this.btConcatenar.UseVisualStyleBackColor = true;
            this.btConcatenar.Click += new System.EventHandler(this.btConcatenar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(293, 144);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(120, 44);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(71, 116);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(132, 13);
            this.result.TabIndex = 7;
            this.result.Text = "Seu nome aparecerá aqui:";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 221);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btConcatenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.textNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label sobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConcatenar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label result;
    }
}

