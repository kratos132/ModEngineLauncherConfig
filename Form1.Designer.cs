namespace ModEngineLauncherConfig
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnPlay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(12, 12);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(200, 40);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar Executável";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(12, 65);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(155, 15);
            this.lblCaminho.TabIndex = 1;
            this.lblCaminho.Text = "Nenhum executável selecionado";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 40);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.btnProcurar);
            this.Name = "Form1";
            this.Text = "ModEngine Launcher Config";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
