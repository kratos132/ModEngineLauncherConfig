using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ModEngineLauncherConfig
{
    public partial class Form1 : Form
    {
        string caminhoExe = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione o executável do jogo";
            openFileDialog.Filter = "Executáveis (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoExe = openFileDialog.FileName;
                lblCaminho.Text = $"Selecionado: {caminhoExe}";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoExe))
            {
                MessageBox.Show("Por favor, selecione o executável do jogo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string arquivoBat = "modengine_launcher.bat";
            if (!File.Exists(arquivoBat))
            {
                MessageBox.Show($"Arquivo '{arquivoBat}' não encontrado na pasta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conteudo = File.ReadAllText(arquivoBat);

            if (!conteudo.Contains("caminho do jogo"))
            {
                MessageBox.Show("O texto 'caminho do jogo' não foi encontrado no .bat.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string novoConteudo = conteudo.Replace("caminho do jogo", caminhoExe);
            string novoBat = "modengine_launcher_configurado.bat";
            File.WriteAllText(novoBat, novoConteudo);

            try
            {
                Process.Start(novoBat);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar o .bat: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
