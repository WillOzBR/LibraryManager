namespace LibraryManager
{
    partial class FormReserva
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
            this.lblReservarLivro = new System.Windows.Forms.Label();
            this.listLivro = new System.Windows.Forms.ListBox();
            this.txtCTitle = new System.Windows.Forms.TextBox();
            this.toolCalendario = new System.Windows.Forms.MonthCalendar();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLivros = new System.Windows.Forms.Label();
            this.listReservados = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReservarLivro
            // 
            this.lblReservarLivro.AutoSize = true;
            this.lblReservarLivro.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservarLivro.Location = new System.Drawing.Point(28, 31);
            this.lblReservarLivro.Name = "lblReservarLivro";
            this.lblReservarLivro.Size = new System.Drawing.Size(288, 59);
            this.lblReservarLivro.TabIndex = 7;
            this.lblReservarLivro.Text = "Reservar Livro";
            this.lblReservarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listLivro
            // 
            this.listLivro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLivro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLivro.FormattingEnabled = true;
            this.listLivro.ItemHeight = 22;
            this.listLivro.Location = new System.Drawing.Point(28, 181);
            this.listLivro.Name = "listLivro";
            this.listLivro.Size = new System.Drawing.Size(315, 400);
            this.listLivro.TabIndex = 8;
            // 
            // txtCTitle
            // 
            this.txtCTitle.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCTitle.Location = new System.Drawing.Point(28, 149);
            this.txtCTitle.Multiline = true;
            this.txtCTitle.Name = "txtCTitle";
            this.txtCTitle.PlaceholderText = "Título";
            this.txtCTitle.Size = new System.Drawing.Size(101, 26);
            this.txtCTitle.TabIndex = 9;
            // 
            // toolCalendario
            // 
            this.toolCalendario.Location = new System.Drawing.Point(746, 181);
            this.toolCalendario.Name = "toolCalendario";
            this.toolCalendario.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(746, 153);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 19);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data da Reserva";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLivros.Location = new System.Drawing.Point(28, 127);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(118, 19);
            this.lblLivros.TabIndex = 26;
            this.lblLivros.Text = "Livros Disponíveis";
            this.lblLivros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listReservados
            // 
            this.listReservados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listReservados.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listReservados.FormattingEnabled = true;
            this.listReservados.ItemHeight = 22;
            this.listReservados.Location = new System.Drawing.Point(381, 181);
            this.listReservados.Name = "listReservados";
            this.listReservados.Size = new System.Drawing.Size(315, 400);
            this.listReservados.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(381, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Título";
            this.textBox1.Size = new System.Drawing.Size(101, 26);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Livros Reservados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserva
            // 
            this.btnReserva.Font = new System.Drawing.Font("Noto Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserva.Location = new System.Drawing.Point(781, 415);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(160, 54);
            this.btnReserva.TabIndex = 30;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Noto Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(781, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 54);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 604);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listReservados);
            this.Controls.Add(this.lblLivros);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.toolCalendario);
            this.Controls.Add(this.txtCTitle);
            this.Controls.Add(this.listLivro);
            this.Controls.Add(this.lblReservarLivro);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReservarLivro;
        private ListBox listLivro;
        private TextBox txtCTitle;
        private MonthCalendar toolCalendario;
        private Label lblData;
        private Label lblLivros;
        private ListBox listReservados;
        private TextBox textBox1;
        private Label label1;
        private Button btnReserva;
        private Button btnCancelar;
    }
}