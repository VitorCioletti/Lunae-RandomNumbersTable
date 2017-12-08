namespace Gerador_TabelaNA
{
    using System;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;

    public partial class TelaPrincipal : Form
    {
        private static Loading_Page janelaCarregamento = new Loading_Page();

        public TelaPrincipal()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(ResultadoExcessao);

            InitializeComponent();

            PreencherComboBoxPeriodo();
            PreencheLabelVersao();
        }
        
        private static void ResultadoExcessao(object sender, ThreadExceptionEventArgs t)
        {
            janelaCarregamento.Close();
            MessageBox.Show(t.Exception.Message, "Oops, an error ocurred, that's embarassing :s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
           
        private async void btn_criarTabela_Click(object sender, EventArgs e)
        {
            VerificaCamposVazios();

            janelaCarregamento.Show();
            this.Hide();
            
            await ArquivoTexto.NovaTabela(
                nomeCurso: txt_curso.Text,
                nomeProfessor: txt_professor.Text,
                nomeTabela: txt_tabela.Text,
                nomeUniversidade: txt_universidade.Text,
                periodo: cmb_periodo.Text,
                caminhoSalvar: lbl_caminho.Text
            );

            janelaCarregamento.Hide();
            this.Show();

            MessageBox.Show("Success! The file now exists :)", "Happy Ending", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void VerificaCamposVazios()
        {
            if (String.IsNullOrEmpty(txt_curso.Text))
                throw new ArgumentException("Type the course name before proceeding.");

            if (String.IsNullOrEmpty(txt_universidade.Text))
                throw new ArgumentException("Type the university name before proceeding.");

            if (String.IsNullOrEmpty(txt_tabela.Text))
                throw new ArgumentException("Type the table's name before proceeding.");

            if (String.IsNullOrEmpty(txt_professor.Text))
                throw new ArgumentException("Type the teacher's name before proceeding.");

            if (String.IsNullOrEmpty(lbl_caminho.Text))
                throw new ArgumentException("Select the path to save the file.");
        }

        private void PreencherComboBoxPeriodo() =>
            cmb_periodo.DataSource = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        

        private void btn_selecionaCaminho_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lbl_caminho.Text = folderBrowserDialog1.SelectedPath;
        }

        private void PreencheLabelVersao() =>
            lbl_versaoSistema.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
    }
}
