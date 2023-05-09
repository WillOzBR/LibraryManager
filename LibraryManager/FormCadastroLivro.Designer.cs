namespace LibraryManager
{
    partial class FormCadastroLivro
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
            this.lblCdtLivro = new System.Windows.Forms.Label();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.lblQtdLivro = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtAnoPub = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCdtLivro
            // 
            this.lblCdtLivro.AutoSize = true;
            this.lblCdtLivro.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCdtLivro.Location = new System.Drawing.Point(21, 20);
            this.lblCdtLivro.Name = "lblCdtLivro";
            this.lblCdtLivro.Size = new System.Drawing.Size(309, 59);
            this.lblCdtLivro.TabIndex = 6;
            this.lblCdtLivro.Text = "Cadastrar Livro";
            this.lblCdtLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.Font = new System.Drawing.Font("Noto Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroLivro.Location = new System.Drawing.Point(398, 440);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(185, 33);
            this.btnCadastroLivro.TabIndex = 29;
            this.btnCadastroLivro.Text = "Cadastrar Livro";
            this.btnCadastroLivro.UseVisualStyleBackColor = true;
            // 
            // lblQtdLivro
            // 
            this.lblQtdLivro.AutoSize = true;
            this.lblQtdLivro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtdLivro.Location = new System.Drawing.Point(411, 330);
            this.lblQtdLivro.Name = "lblQtdLivro";
            this.lblQtdLivro.Size = new System.Drawing.Size(157, 19);
            this.lblQtdLivro.TabIndex = 28;
            this.lblQtdLivro.Text = "Quantidade em Estoque";
            this.lblQtdLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAno.Location = new System.Drawing.Point(527, 238);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(121, 19);
            this.lblAno.TabIndex = 27;
            this.lblAno.Text = "Ano de Publicação";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Location = new System.Drawing.Point(227, 238);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 19);
            this.lblMatricula.TabIndex = 26;
            this.lblMatricula.Text = "Editora";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(527, 157);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 19);
            this.lblSenha.TabIndex = 25;
            this.lblSenha.Text = "Autor";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(227, 157);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 19);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Nome";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidade.Location = new System.Drawing.Point(456, 352);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(67, 29);
            this.txtQuantidade.TabIndex = 23;
            // 
            // txtAnoPub
            // 
            this.txtAnoPub.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnoPub.Location = new System.Drawing.Point(527, 260);
            this.txtAnoPub.Multiline = true;
            this.txtAnoPub.Name = "txtAnoPub";
            this.txtAnoPub.Size = new System.Drawing.Size(212, 29);
            this.txtAnoPub.TabIndex = 22;
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditora.Location = new System.Drawing.Point(227, 260);
            this.txtEditora.Multiline = true;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(212, 29);
            this.txtEditora.TabIndex = 21;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(527, 179);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(212, 29);
            this.txtAutor.TabIndex = 20;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(227, 179);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(212, 29);
            this.txtTitulo.TabIndex = 19;
            // 
            // FormCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 620);
            this.Controls.Add(this.btnCadastroLivro);
            this.Controls.Add(this.lblQtdLivro);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtAnoPub);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCdtLivro);
            this.Name = "FormCadastroLivro";
            this.Text = "Cadastro Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCdtLivro;
        private Button btnCadastroLivro;
        private Label lblQtdLivro;
        private Label lblAno;
        private Label lblMatricula;
        private Label lblSenha;
        private Label lblTitulo;
        private TextBox txtQuantidade;
        private TextBox txtAnoPub;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private TextBox txtTitulo;
    }
}