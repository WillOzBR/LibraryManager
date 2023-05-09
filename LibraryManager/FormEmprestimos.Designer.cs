namespace LibraryManager
{
    partial class FormEmprestimos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listDevolver = new System.Windows.Forms.ListBox();
            this.lblLivros = new System.Windows.Forms.Label();
            this.txtCTitle = new System.Windows.Forms.TextBox();
            this.listLivro = new System.Windows.Forms.ListBox();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.lblDevolver = new System.Windows.Forms.Label();
            this.lblQtdDevolver = new System.Windows.Forms.Label();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.toolCalendario = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Noto Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(784, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 54);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Marcar Devolvido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Font = new System.Drawing.Font("Noto Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmprestimo.Location = new System.Drawing.Point(784, 393);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(160, 54);
            this.btnEmprestimo.TabIndex = 41;
            this.btnEmprestimo.Text = "Realizar Empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(408, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Livros a Devolver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(408, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Título";
            this.textBox1.Size = new System.Drawing.Size(101, 26);
            this.textBox1.TabIndex = 39;
            // 
            // listDevolver
            // 
            this.listDevolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listDevolver.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listDevolver.FormattingEnabled = true;
            this.listDevolver.ItemHeight = 22;
            this.listDevolver.Location = new System.Drawing.Point(408, 171);
            this.listDevolver.Name = "listDevolver";
            this.listDevolver.Size = new System.Drawing.Size(315, 400);
            this.listDevolver.TabIndex = 38;
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLivros.Location = new System.Drawing.Point(55, 117);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(118, 19);
            this.lblLivros.TabIndex = 37;
            this.lblLivros.Text = "Livros Disponíveis";
            this.lblLivros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCTitle
            // 
            this.txtCTitle.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCTitle.Location = new System.Drawing.Point(55, 139);
            this.txtCTitle.Multiline = true;
            this.txtCTitle.Name = "txtCTitle";
            this.txtCTitle.PlaceholderText = "Título";
            this.txtCTitle.Size = new System.Drawing.Size(101, 26);
            this.txtCTitle.TabIndex = 34;
            // 
            // listLivro
            // 
            this.listLivro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLivro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLivro.FormattingEnabled = true;
            this.listLivro.ItemHeight = 22;
            this.listLivro.Location = new System.Drawing.Point(55, 171);
            this.listLivro.Name = "listLivro";
            this.listLivro.Size = new System.Drawing.Size(315, 400);
            this.listLivro.TabIndex = 33;
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmprestimo.Location = new System.Drawing.Point(55, 21);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(532, 59);
            this.lblEmprestimo.TabIndex = 32;
            this.lblEmprestimo.Text = "Empréstimos e Devoluções";
            this.lblEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDevolver
            // 
            this.lblDevolver.AutoSize = true;
            this.lblDevolver.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevolver.Location = new System.Drawing.Point(765, 48);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(196, 32);
            this.lblDevolver.TabIndex = 43;
            this.lblDevolver.Text = "Livros a Devolver";
            this.lblDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdDevolver
            // 
            this.lblQtdDevolver.AutoSize = true;
            this.lblQtdDevolver.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtdDevolver.Location = new System.Drawing.Point(844, 102);
            this.lblQtdDevolver.Name = "lblQtdDevolver";
            this.lblQtdDevolver.Size = new System.Drawing.Size(27, 32);
            this.lblQtdDevolver.TabIndex = 44;
            this.lblQtdDevolver.Text = "0";
            this.lblQtdDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEmp.Location = new System.Drawing.Point(750, 174);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(135, 19);
            this.lblDataEmp.TabIndex = 46;
            this.lblDataEmp.Text = "Data do Empréstimo";
            this.lblDataEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolCalendario
            // 
            this.toolCalendario.Location = new System.Drawing.Point(750, 202);
            this.toolCalendario.Name = "toolCalendario";
            this.toolCalendario.TabIndex = 45;
            // 
            // FormEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 593);
            this.Controls.Add(this.lblDataEmp);
            this.Controls.Add(this.toolCalendario);
            this.Controls.Add(this.lblQtdDevolver);
            this.Controls.Add(this.lblDevolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listDevolver);
            this.Controls.Add(this.lblLivros);
            this.Controls.Add(this.txtCTitle);
            this.Controls.Add(this.listLivro);
            this.Controls.Add(this.lblEmprestimo);
            this.Name = "FormEmprestimos";
            this.Text = "FormEmprestimos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnEmprestimo;
        private Label label1;
        private TextBox textBox1;
        private ListBox listDevolver;
        private Label lblLivros;
        private TextBox txtCTitle;
        private ListBox listLivro;
        private Label lblEmprestimo;
        private Label lblDevolver;
        private Label lblQtdDevolver;
        private Label lblDataEmp;
        private MonthCalendar toolCalendario;
    }
}