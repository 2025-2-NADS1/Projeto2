namespace AppLogin
{
    partial class frmDificuldades
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
            splitContainer1 = new SplitContainer();
            btnVoltar1 = new Button();
            btnDificil = new Button();
            btnMedio = new Button();
            btnFacil = new Button();
            lblHistoria = new Label();
            btnDificio1 = new Button();
            btnMedio1 = new Button();
            bntFacil1 = new Button();
            lblMatematica = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnVoltar1);
            splitContainer1.Panel1.Controls.Add(btnDificil);
            splitContainer1.Panel1.Controls.Add(btnMedio);
            splitContainer1.Panel1.Controls.Add(btnFacil);
            splitContainer1.Panel1.Controls.Add(lblHistoria);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlDarkDark;
            splitContainer1.Panel2.Controls.Add(btnDificio1);
            splitContainer1.Panel2.Controls.Add(btnMedio1);
            splitContainer1.Panel2.Controls.Add(bntFacil1);
            splitContainer1.Panel2.Controls.Add(lblMatematica);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(964, 561);
            splitContainer1.SplitterDistance = 466;
            splitContainer1.TabIndex = 0;
            // 
            // btnVoltar1
            // 
            btnVoltar1.Location = new Point(12, 526);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.Size = new Size(75, 23);
            btnVoltar1.TabIndex = 4;
            btnVoltar1.Text = "Voltar";
            btnVoltar1.UseVisualStyleBackColor = true;
            btnVoltar1.Click += btnVoltar1_Click;
            // 
            // btnDificil
            // 
            btnDificil.Location = new Point(128, 308);
            btnDificil.Name = "btnDificil";
            btnDificil.Size = new Size(153, 26);
            btnDificil.TabIndex = 3;
            btnDificil.Text = "Difício";
            btnDificil.UseVisualStyleBackColor = true;
            // 
            // btnMedio
            // 
            btnMedio.Location = new Point(128, 246);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(153, 26);
            btnMedio.TabIndex = 2;
            btnMedio.Text = "Médio";
            btnMedio.UseVisualStyleBackColor = true;
            // 
            // btnFacil
            // 
            btnFacil.Location = new Point(128, 180);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(153, 26);
            btnFacil.TabIndex = 1;
            btnFacil.Text = "Fácil ";
            btnFacil.UseVisualStyleBackColor = true;
            btnFacil.Click += btnFacil_Click;
            // 
            // lblHistoria
            // 
            lblHistoria.AutoSize = true;
            lblHistoria.Font = new Font("Arial", 16F);
            lblHistoria.Location = new Point(154, 59);
            lblHistoria.Name = "lblHistoria";
            lblHistoria.Size = new Size(92, 25);
            lblHistoria.TabIndex = 0;
            lblHistoria.Text = "História ";
            // 
            // btnDificio1
            // 
            btnDificio1.Location = new Point(176, 308);
            btnDificio1.Name = "btnDificio1";
            btnDificio1.Size = new Size(153, 26);
            btnDificio1.TabIndex = 4;
            btnDificio1.Text = "Difício";
            btnDificio1.UseVisualStyleBackColor = true;
            // 
            // btnMedio1
            // 
            btnMedio1.Location = new Point(176, 246);
            btnMedio1.Name = "btnMedio1";
            btnMedio1.Size = new Size(153, 26);
            btnMedio1.TabIndex = 4;
            btnMedio1.Text = "Médio";
            btnMedio1.UseVisualStyleBackColor = true;
            btnMedio1.Click += button2_Click;
            // 
            // bntFacil1
            // 
            bntFacil1.Location = new Point(176, 180);
            bntFacil1.Name = "bntFacil1";
            bntFacil1.Size = new Size(153, 26);
            bntFacil1.TabIndex = 4;
            bntFacil1.Text = "Fácil ";
            bntFacil1.UseVisualStyleBackColor = true;
            // 
            // lblMatematica
            // 
            lblMatematica.AutoSize = true;
            lblMatematica.Font = new Font("Arial", 16F);
            lblMatematica.ForeColor = SystemColors.Control;
            lblMatematica.Location = new Point(187, 59);
            lblMatematica.Name = "lblMatematica";
            lblMatematica.Size = new Size(125, 25);
            lblMatematica.TabIndex = 1;
            lblMatematica.Text = "Matemática";
            // 
            // frmDificuldades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 561);
            Controls.Add(splitContainer1);
            Name = "frmDificuldades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDificuldades";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnDificil;
        private Button btnMedio;
        private Button btnFacil;
        private Label lblHistoria;
        private Label lblMatematica;
        private Button btnDificio1;
        private Button btnMedio1;
        private Button bntFacil1;
        private Button btnVoltar;
        private Button btnVoltar1;
    }
}