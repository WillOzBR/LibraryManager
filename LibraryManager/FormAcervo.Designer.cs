namespace LibraryManager
{
    partial class FormAcervo
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
            this.txtCAutor = new System.Windows.Forms.TextBox();
            this.txtCEditora = new System.Windows.Forms.TextBox();
            this.listLivro = new System.Windows.Forms.ListBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAddLivro = new System.Windows.Forms.Button();
            this.txtCTitle = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCAutor
            // 
            this.txtCAutor.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCAutor.Location = new System.Drawing.Point(159, 111);
            this.txtCAutor.Multiline = true;
            this.txtCAutor.Name = "txtCAutor";
            this.txtCAutor.PlaceholderText = "Autor";
            this.txtCAutor.Size = new System.Drawing.Size(100, 30);
            this.txtCAutor.TabIndex = 2;
            // 
            // txtCEditora
            // 
            this.txtCEditora.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCEditora.Location = new System.Drawing.Point(283, 111);
            this.txtCEditora.Multiline = true;
            this.txtCEditora.Name = "txtCEditora";
            this.txtCEditora.PlaceholderText = "Editora";
            this.txtCEditora.Size = new System.Drawing.Size(100, 30);
            this.txtCEditora.TabIndex = 3;
            // 
            // listLivro
            // 
            this.listLivro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLivro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLivro.FormattingEnabled = true;
            this.listLivro.ItemHeight = 22;
            this.listLivro.Location = new System.Drawing.Point(36, 157);
            this.listLivro.Name = "listLivro";
            this.listLivro.Size = new System.Drawing.Size(947, 400);
            this.listLivro.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoria.Location = new System.Drawing.Point(406, 111);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PlaceholderText = "Categoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 30);
            this.txtCategoria.TabIndex = 5;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltro.Location = new System.Drawing.Point(36, 69);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(68, 30);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtrar";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Noto Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(42, 37);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "↩";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAddLivro
            // 
            this.btnAddLivro.Font = new System.Drawing.Font("Noto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddLivro.Location = new System.Drawing.Point(833, 111);
            this.btnAddLivro.Name = "btnAddLivro";
            this.btnAddLivro.Size = new System.Drawing.Size(140, 30);
            this.btnAddLivro.TabIndex = 12;
            this.btnAddLivro.Text = "+ Adicionar Livro";
            this.btnAddLivro.UseVisualStyleBackColor = true;
            // 
            // txtCTitle
            // 
            this.txtCTitle.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCTitle.Location = new System.Drawing.Point(36, 111);
            this.txtCTitle.Multiline = true;
            this.txtCTitle.Name = "txtCTitle";
            this.txtCTitle.PlaceholderText = "Título";
            this.txtCTitle.Size = new System.Drawing.Size(101, 30);
            this.txtCTitle.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(528, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ano";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 13;
            // 
            // FormAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 586);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddLivro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.listLivro);
            this.Controls.Add(this.txtCEditora);
            this.Controls.Add(this.txtCAutor);
            this.Controls.Add(this.txtCTitle);
            this.Name = "FormAcervo";
            this.Text = "Acervo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCAutor;
        private TextBox txtCEditora;
        private ListBox listLivro;
        private TextBox txtCategoria;
        private Label lblFiltro;
        private Button btnVoltar;
        private Button btnAddLivro;
        private TextBox txtCTitle;
        private TextBox textBox1;
    }
}