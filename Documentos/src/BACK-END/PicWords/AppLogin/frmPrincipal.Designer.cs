namespace AppLogin
{
    partial class frmPrincipal
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
            lblTitulo = new Label();
            btnNovojogo = new Button();
            btnPontuacao = new Button();
            btnFecharjogo = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Italic);
            lblTitulo.Location = new Point(412, 138);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(112, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TITULO DO JOGO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += label1_Click;
            // 
            // btnNovojogo
            // 
            btnNovojogo.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Italic);
            btnNovojogo.Location = new Point(309, 164);
            btnNovojogo.Name = "btnNovojogo";
            btnNovojogo.Size = new Size(319, 23);
            btnNovojogo.TabIndex = 1;
            btnNovojogo.Text = "Novo Jogo";
            btnNovojogo.UseVisualStyleBackColor = true;
            btnNovojogo.Click += btnNovojogo_Click;
            // 
            // btnPontuacao
            // 
            btnPontuacao.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Italic);
            btnPontuacao.Location = new Point(323, 225);
            btnPontuacao.Name = "btnPontuacao";
            btnPontuacao.Size = new Size(292, 23);
            btnPontuacao.TabIndex = 2;
            btnPontuacao.Text = "Pontuação";
            btnPontuacao.UseVisualStyleBackColor = true;
            btnPontuacao.Click += btnPontuacao_Click;
            // 
            // btnFecharjogo
            // 
            btnFecharjogo.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Italic);
            btnFecharjogo.Location = new Point(337, 280);
            btnFecharjogo.Name = "btnFecharjogo";
            btnFecharjogo.Size = new Size(263, 23);
            btnFecharjogo.TabIndex = 3;
            btnFecharjogo.Text = "Finalizar";
            btnFecharjogo.UseVisualStyleBackColor = true;
            btnFecharjogo.Click += btnFecharjogo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 561);
            Controls.Add(btnFecharjogo);
            Controls.Add(btnPontuacao);
            Controls.Add(btnNovojogo);
            Controls.Add(lblTitulo);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnNovojogo;
        private Button btnPontuacao;
        private Button btnFecharjogo;
    }
}