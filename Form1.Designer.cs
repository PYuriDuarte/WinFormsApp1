namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBotao = new Button();
            txtTexto01 = new TextBox();
            txtTexto02 = new TextBox();
            cbAdicao = new CheckBox();
            cbSubtracao = new CheckBox();
            cbMultiplicacao = new CheckBox();
            cbDivisao = new CheckBox();
            SuspendLayout();
            // 
            // btnBotao
            // 
            btnBotao.Cursor = Cursors.Hand;
            btnBotao.Location = new Point(555, 44);
            btnBotao.Name = "btnBotao";
            btnBotao.Size = new Size(75, 23);
            btnBotao.TabIndex = 0;
            btnBotao.Text = "Botão 01";
            btnBotao.UseVisualStyleBackColor = true;
            btnBotao.Click += btnBotao_Click;
            // 
            // txtTexto01
            // 
            txtTexto01.Location = new Point(139, 128);
            txtTexto01.Name = "txtTexto01";
            txtTexto01.PlaceholderText = "Campo de texto 01";
            txtTexto01.Size = new Size(109, 23);
            txtTexto01.TabIndex = 1;
            txtTexto01.TextChanged += txtTexto01_TextChanged;
            // 
            // txtTexto02
            // 
            txtTexto02.Location = new Point(256, 128);
            txtTexto02.Name = "txtTexto02";
            txtTexto02.PlaceholderText = "Campo de texto 02";
            txtTexto02.Size = new Size(109, 23);
            txtTexto02.TabIndex = 1;
            txtTexto02.TextChanged += txtTexto02_TextChanged;
            // 
            // cbAdicao
            // 
            cbAdicao.AutoSize = true;
            cbAdicao.Location = new Point(71, 73);
            cbAdicao.Name = "cbAdicao";
            cbAdicao.Size = new Size(79, 19);
            cbAdicao.TabIndex = 2;
            cbAdicao.Text = "Adição(+)";
            cbAdicao.UseVisualStyleBackColor = true;
            cbAdicao.CheckedChanged += cbAdicao_CheckedChanged;
            // 
            // cbSubtracao
            // 
            cbSubtracao.AutoSize = true;
            cbSubtracao.Location = new Point(156, 73);
            cbSubtracao.Name = "cbSubtracao";
            cbSubtracao.Size = new Size(92, 19);
            cbSubtracao.TabIndex = 2;
            cbSubtracao.Text = "Subtração(-)";
            cbSubtracao.UseVisualStyleBackColor = true;
            cbSubtracao.CheckedChanged += cbSubtracao_CheckedChanged;
            // 
            // cbMultiplicacao
            // 
            cbMultiplicacao.AutoSize = true;
            cbMultiplicacao.Location = new Point(254, 73);
            cbMultiplicacao.Name = "cbMultiplicacao";
            cbMultiplicacao.Size = new Size(111, 19);
            cbMultiplicacao.TabIndex = 2;
            cbMultiplicacao.Text = "Multiplicação(*)";
            cbMultiplicacao.UseVisualStyleBackColor = true;
            cbMultiplicacao.CheckedChanged += cbMultiplicacao_CheckedChanged;
            // 
            // cbDivisao
            // 
            cbDivisao.AutoSize = true;
            cbDivisao.Location = new Point(371, 73);
            cbDivisao.Name = "cbDivisao";
            cbDivisao.Size = new Size(77, 19);
            cbDivisao.TabIndex = 2;
            cbDivisao.Text = "Divisão(/)";
            cbDivisao.UseVisualStyleBackColor = true;
            cbDivisao.CheckedChanged += cbDivisao_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 371);
            Controls.Add(cbDivisao);
            Controls.Add(cbMultiplicacao);
            Controls.Add(cbSubtracao);
            Controls.Add(cbAdicao);
            Controls.Add(txtTexto02);
            Controls.Add(txtTexto01);
            Controls.Add(btnBotao);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Livraria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBotao;
        private TextBox txtTexto01;
        private TextBox txtTexto02;
        private CheckBox cbAdicao;
        private CheckBox cbSubtracao;
        private CheckBox cbMultiplicacao;
        private CheckBox cbDivisao;
    }
}