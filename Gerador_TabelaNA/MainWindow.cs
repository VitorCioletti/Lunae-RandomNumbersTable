namespace TableGenerator
{
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using System.Windows.Threading;

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(ExceptionResult);

            InitializeComponent();

            FulfillPeriodComboBox();
            SetSystemVersion();
        }
        
        private static void ExceptionResult(object sender, ThreadExceptionEventArgs t) =>
            MessageBox.Show(t.Exception.Message, "Oops, an error ocurred, that's embarassing :s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        private async void btn_criarTabela_Click(object sender, EventArgs e)
        {
            VerifyEmptyFields();

            gif_loadAndSucess.Visible = true;

            await TextFile.NewTable(
                    courseName: txt_course.Text,
                    teacherName: txt_teacher.Text,
                    tableName: txt_table.Text,
                    universityName: txt_university.Text,
                    semester: cmb_semester.Text,
                    savePath: lbl_caminho.Text
                );

            gif_loadAndSucess.Visible = false;
            gif_endLoadSucess.Visible = true;
        }

        private void VerifyEmptyFields()
        {
            if (String.IsNullOrEmpty(txt_course.Text))
                throw new ArgumentException("Type the course name before proceeding.");

            if (String.IsNullOrEmpty(txt_university.Text))
                throw new ArgumentException("Type the university name before proceeding.");

            if (String.IsNullOrEmpty(txt_table.Text))
                throw new ArgumentException("Type the table's name before proceeding.");

            if (String.IsNullOrEmpty(txt_teacher.Text))
                throw new ArgumentException("Type the teacher's name before proceeding.");

            if (String.IsNullOrEmpty(lbl_caminho.Text))
                throw new ArgumentException("Select the path to save the file.");
        }

        private void FulfillPeriodComboBox() =>
            cmb_semester.DataSource = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private void SetSystemVersion() =>
            lbl_versaoSistema.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();

        private void btn_selectedPath_Click(object sender, EventArgs e) =>
            OpenFileExporer();

        private void OpenFileExporer()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lbl_caminho.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
