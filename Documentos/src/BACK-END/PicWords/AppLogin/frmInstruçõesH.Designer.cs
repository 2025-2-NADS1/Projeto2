namespace AppLogin
{
    partial class frmInstruçõesH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruçõesH));
            lblInstrucoes = new Label();
            lblInstrucoestxt = new Label();
            lblHistoriaF = new Label();
            lblIniciar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblInstrucoes
            // 
            lblInstrucoes.AutoSize = true;
            lblInstrucoes.Font = new Font("Arial", 30F);
            lblInstrucoes.Location = new Point(321, 61);
            lblInstrucoes.Name = "lblInstrucoes";
            lblInstrucoes.Size = new Size(282, 45);
            lblInstrucoes.TabIndex = 0;
            lblInstrucoes.Text = "INSTRUÇÕES";
            // 
            // lblInstrucoestxt
            // 
            lblInstrucoestxt.AutoSize = true;
            lblInstrucoestxt.Location = new Point(114, 183);
            lblInstrucoestxt.Name = "lblInstrucoestxt";
            lblInstrucoestxt.Size = new Size(696, 135);
            lblInstrucoestxt.TabIndex = 1;
            lblInstrucoestxt.Text = resources.GetString("lblInstrucoestxt.Text");
            // 
            // lblHistoriaF
            // 
            lblHistoriaF.AutoSize = true;
            lblHistoriaF.Font = new Font("Arial", 14F);
            lblHistoriaF.Location = new Point(391, 121);
            lblHistoriaF.Name = "lblHistoriaF";
            lblHistoriaF.Size = new Size(129, 22);
            lblHistoriaF.TabIndex = 2;
            lblHistoriaF.Text = "História - Fácil";
            // 
            // lblIniciar
            // 
            lblIniciar.Location = new Point(385, 343);
            lblIniciar.Name = "lblIniciar";
            lblIniciar.Size = new Size(135, 31);
            lblIniciar.TabIndex = 3;
            lblIniciar.Text = "INICIAR";
            lblIniciar.UseVisualStyleBackColor = true;
            lblIniciar.Click += lblIniciar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 526);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmInstruçõesH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 561);
            Controls.Add(btnVoltar);
            Controls.Add(lblIniciar);
            Controls.Add(lblHistoriaF);
            Controls.Add(lblInstrucoestxt);
            Controls.Add(lblInstrucoes);
            Name = "frmInstruçõesH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInstruçõesH";
            Load += frmInstruçõesH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstrucoes;
        private Label lblInstrucoestxt;
        private Label lblHistoriaF;
        private Button lblIniciar;
        private Button btnVoltar;
    }
}