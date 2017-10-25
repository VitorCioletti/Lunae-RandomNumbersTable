namespace Gerador_TabelaNA
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(ResultadoExcessao);

            InitializeComponent();

            PreencherComboBoxPeriodo();           
        }
        
        private static void ResultadoExcessao(object sender, ThreadExceptionEventArgs t) => MessageBox.Show(t.Exception.Message, "Opa :s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        private void btn_criarTabela_Click(object sender, EventArgs e)
        {
            VerificaCamposVazios();

            ArquivoTexto.NovaTabela(
                nomeCurso: txt_curso.Text,
                nomeProfessor: txt_professor.Text,
                nomeTabela: txt_tabela.Text,
                nomeUniversidade: txt_universidade.Text,
                periodo: Convert.ToInt16(cmb_periodo.Text),
                caminhoSalvar: lbl_caminho.Text
            );

            MessageBox.Show("Arquivo gerado com sucesso", "Resultado Feliz", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void VerificaCamposVazios()
        {
            if (String.IsNullOrEmpty(txt_curso.Text))
                throw new ArgumentException("Digite o nome do curso antes de prosseguir.");

            if (String.IsNullOrEmpty(txt_universidade.Text))
                throw new ArgumentException("Digite o nome da universidade antes de prosseguir.");

            if (String.IsNullOrEmpty(txt_tabela.Text))
                throw new ArgumentException("Digite o nome da tabela antes de prosseguir.");

            if (String.IsNullOrEmpty(txt_professor.Text))
                throw new ArgumentException("Digite o nome do professor antes de prosseguir.");

            if (String.IsNullOrEmpty(lbl_caminho.Text))
                throw new ArgumentException("Selecione o caminho para salvar o arquivo.");

            if (String.IsNullOrEmpty(cmb_periodo.Text))
                throw new ArgumentException("Selecione um período antes de prosseguir.");
        }

        private void PreencherComboBoxPeriodo()
        {
            var periodos = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            cmb_periodo.DataSource = periodos;
        }

        private void btn_selecionaCaminho_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lbl_caminho.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
