namespace AppLogin
{
    partial class frmRanking
    {


        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lstRanking = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(316, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RANKING";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstRanking
            // 
            lstRanking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRanking.FormattingEnabled = true;
            lstRanking.ItemHeight = 20;
            lstRanking.Location = new Point(14, 58);
            lstRanking.Margin = new Padding(4, 3, 4, 3);
            lstRanking.Name = "lstRanking";
            lstRanking.Size = new Size(937, 484);
            lstRanking.TabIndex = 1;
            lstRanking.SelectedIndexChanged += lstRanking_SelectedIndexChanged;
            // 
            // frmRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 561);
            Controls.Add(lstRanking);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRanking";
            Text = "Ranking";
            Load += frmRanking_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstRanking;
    }
}