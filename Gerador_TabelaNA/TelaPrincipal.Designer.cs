namespace Gerador_TabelaNA
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.txt_universidade = new System.Windows.Forms.TextBox();
            this.txt_professor = new System.Windows.Forms.TextBox();
            this.txt_tabela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_periodo = new System.Windows.Forms.ComboBox();
            this.lbl_caminho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_selecionaCaminho = new System.Windows.Forms.Button();
            this.btn_criarTabela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_versaoSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_universidade
            // 
            this.txt_universidade.Location = new System.Drawing.Point(114, 36);
            this.txt_universidade.MaxLength = 48;
            this.txt_universidade.Name = "txt_universidade";
            this.txt_universidade.Size = new System.Drawing.Size(259, 20);
            this.txt_universidade.TabIndex = 1;
            // 
            // txt_professor
            // 
            this.txt_professor.Location = new System.Drawing.Point(114, 155);
            this.txt_professor.MaxLength = 45;
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(259, 20);
            this.txt_professor.TabIndex = 6;
            // 
            // txt_tabela
            // 
            this.txt_tabela.Location = new System.Drawing.Point(114, 112);
            this.txt_tabela.MaxLength = 45;
            this.txt_tabela.Name = "txt_tabela";
            this.txt_tabela.Size = new System.Drawing.Size(259, 20);
            this.txt_tabela.TabIndex = 5;
            this.txt_tabela.Text = "Random Numbers Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "University: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table\'s name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teacher:";
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(114, 73);
            this.txt_curso.MaxLength = 45;
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(205, 20);
            this.txt_curso.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course: ";
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_periodo.FormatString = "0";
            this.cmb_periodo.FormattingEnabled = true;
            this.cmb_periodo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmb_periodo.Location = new System.Drawing.Point(325, 73);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Size = new System.Drawing.Size(48, 21);
            this.cmb_periodo.TabIndex = 3;
            // 
            // lbl_caminho
            // 
            this.lbl_caminho.AutoSize = true;
            this.lbl_caminho.Location = new System.Drawing.Point(68, 223);
            this.lbl_caminho.Name = "lbl_caminho";
            this.lbl_caminho.Size = new System.Drawing.Size(0, 13);
            this.lbl_caminho.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select a path to save the file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Semester:";
            // 
            // btn_selecionaCaminho
            // 
            this.btn_selecionaCaminho.BackgroundImage = global::Gerador_TabelaNA.Properties.Resources.document_icon;
            this.btn_selecionaCaminho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_selecionaCaminho.FlatAppearance.BorderSize = 0;
            this.btn_selecionaCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionaCaminho.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_selecionaCaminho.Location = new System.Drawing.Point(15, 211);
            this.btn_selecionaCaminho.Margin = new System.Windows.Forms.Padding(0);
            this.btn_selecionaCaminho.Name = "btn_selecionaCaminho";
            this.btn_selecionaCaminho.Size = new System.Drawing.Size(40, 37);
            this.btn_selecionaCaminho.TabIndex = 7;
            this.btn_selecionaCaminho.UseVisualStyleBackColor = true;
            this.btn_selecionaCaminho.Click += new System.EventHandler(this.btn_selecionaCaminho_Click);
            // 
            // btn_criarTabela
            // 
            this.btn_criarTabela.BackColor = System.Drawing.Color.Transparent;
            this.btn_criarTabela.BackgroundImage = global::Gerador_TabelaNA.Properties.Resources.adicionar_icon;
            this.btn_criarTabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_criarTabela.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_criarTabela.FlatAppearance.BorderSize = 0;
            this.btn_criarTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criarTabela.ForeColor = System.Drawing.Color.Transparent;
            this.btn_criarTabela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_criarTabela.Location = new System.Drawing.Point(328, 195);
            this.btn_criarTabela.Name = "btn_criarTabela";
            this.btn_criarTabela.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_criarTabela.Size = new System.Drawing.Size(42, 41);
            this.btn_criarTabela.TabIndex = 8;
            this.btn_criarTabela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_criarTabela.UseVisualStyleBackColor = false;
            this.btn_criarTabela.Click += new System.EventHandler(this.btn_criarTabela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Create Table";
            // 
            // lbl_versaoSistema
            // 
            this.lbl_versaoSistema.AutoSize = true;
            this.lbl_versaoSistema.Location = new System.Drawing.Point(335, 9);
            this.lbl_versaoSistema.Name = "lbl_versaoSistema";
            this.lbl_versaoSistema.Size = new System.Drawing.Size(41, 13);
            this.lbl_versaoSistema.TabIndex = 16;
            this.lbl_versaoSistema.Text = "version";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.lbl_versaoSistema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_caminho);
            this.Controls.Add(this.btn_selecionaCaminho);
            this.Controls.Add(this.cmb_periodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tabela);
            this.Controls.Add(this.txt_professor);
            this.Controls.Add(this.txt_universidade);
            this.Controls.Add(this.btn_criarTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunae - Random Number Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_criarTabela;
        private System.Windows.Forms.TextBox txt_universidade;
        private System.Windows.Forms.TextBox txt_professor;
        private System.Windows.Forms.TextBox txt_tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_periodo;
        private System.Windows.Forms.Button btn_selecionaCaminho;
        private System.Windows.Forms.Label lbl_caminho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_versaoSistema;
    }
}

