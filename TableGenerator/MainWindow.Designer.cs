namespace TableGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txt_university = new System.Windows.Forms.TextBox();
            this.txt_teacher = new System.Windows.Forms.TextBox();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_semester = new System.Windows.Forms.ComboBox();
            this.lbl_caminho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_selectedPath = new System.Windows.Forms.Button();
            this.btn_createTable = new System.Windows.Forms.Button();
            this.lbl_versaoSistema = new System.Windows.Forms.Label();
            this.gif_loadAndSucess = new System.Windows.Forms.PictureBox();
            this.gif_endLoadSucess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif_loadAndSucess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif_endLoadSucess)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_university
            // 
            this.txt_university.Location = new System.Drawing.Point(114, 36);
            this.txt_university.MaxLength = 48;
            this.txt_university.Name = "txt_university";
            this.txt_university.Size = new System.Drawing.Size(259, 20);
            this.txt_university.TabIndex = 1;
            // 
            // txt_teacher
            // 
            this.txt_teacher.Location = new System.Drawing.Point(114, 155);
            this.txt_teacher.MaxLength = 45;
            this.txt_teacher.Name = "txt_teacher";
            this.txt_teacher.Size = new System.Drawing.Size(259, 20);
            this.txt_teacher.TabIndex = 6;
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(114, 112);
            this.txt_table.MaxLength = 45;
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(259, 20);
            this.txt_table.TabIndex = 5;
            this.txt_table.Text = "Random Numbers Table";
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
            // txt_course
            // 
            this.txt_course.Location = new System.Drawing.Point(114, 73);
            this.txt_course.MaxLength = 45;
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(205, 20);
            this.txt_course.TabIndex = 2;
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
            // cmb_semester
            // 
            this.cmb_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semester.FormatString = "0";
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmb_semester.Location = new System.Drawing.Point(325, 73);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(48, 21);
            this.cmb_semester.TabIndex = 3;
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
            // btn_selectedPath
            // 
            this.btn_selectedPath.BackgroundImage = global::Gerador_TabelaNA.Properties.Resources.document_icon;
            this.btn_selectedPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_selectedPath.FlatAppearance.BorderSize = 0;
            this.btn_selectedPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectedPath.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_selectedPath.Location = new System.Drawing.Point(15, 218);
            this.btn_selectedPath.Margin = new System.Windows.Forms.Padding(0);
            this.btn_selectedPath.Name = "btn_selectedPath";
            this.btn_selectedPath.Size = new System.Drawing.Size(40, 37);
            this.btn_selectedPath.TabIndex = 7;
            this.btn_selectedPath.UseVisualStyleBackColor = true;
            this.btn_selectedPath.Click += new System.EventHandler(this.btn_selectedPath_Click);
            // 
            // btn_createTable
            // 
            this.btn_createTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_createTable.BackgroundImage = global::Gerador_TabelaNA.Properties.Resources.adicionar_icon;
            this.btn_createTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_createTable.FlatAppearance.BorderSize = 0;
            this.btn_createTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createTable.ForeColor = System.Drawing.Color.Transparent;
            this.btn_createTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createTable.Location = new System.Drawing.Point(329, 213);
            this.btn_createTable.Name = "btn_createTable";
            this.btn_createTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_createTable.Size = new System.Drawing.Size(44, 41);
            this.btn_createTable.TabIndex = 8;
            this.btn_createTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_createTable.UseVisualStyleBackColor = false;
            this.btn_createTable.Click += new System.EventHandler(this.btn_criarTabela_Click);
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
            // gif_loadAndSucess
            // 
            this.gif_loadAndSucess.ErrorImage = null;
            this.gif_loadAndSucess.Image = ((System.Drawing.Image)(resources.GetObject("gif_loadAndSucess.Image")));
            this.gif_loadAndSucess.InitialImage = ((System.Drawing.Image)(resources.GetObject("gif_loadAndSucess.InitialImage")));
            this.gif_loadAndSucess.Location = new System.Drawing.Point(332, 180);
            this.gif_loadAndSucess.Name = "gif_loadAndSucess";
            this.gif_loadAndSucess.Size = new System.Drawing.Size(37, 27);
            this.gif_loadAndSucess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif_loadAndSucess.TabIndex = 17;
            this.gif_loadAndSucess.TabStop = false;
            this.gif_loadAndSucess.Visible = false;
            // 
            // gif_endLoadSucess
            // 
            this.gif_endLoadSucess.ErrorImage = null;
            this.gif_endLoadSucess.Image = ((System.Drawing.Image)(resources.GetObject("gif_endLoadSucess.Image")));
            this.gif_endLoadSucess.InitialImage = ((System.Drawing.Image)(resources.GetObject("gif_endLoadSucess.InitialImage")));
            this.gif_endLoadSucess.Location = new System.Drawing.Point(338, 180);
            this.gif_endLoadSucess.Name = "gif_endLoadSucess";
            this.gif_endLoadSucess.Size = new System.Drawing.Size(26, 27);
            this.gif_endLoadSucess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif_endLoadSucess.TabIndex = 18;
            this.gif_endLoadSucess.TabStop = false;
            this.gif_endLoadSucess.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.gif_endLoadSucess);
            this.Controls.Add(this.gif_loadAndSucess);
            this.Controls.Add(this.lbl_versaoSistema);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_caminho);
            this.Controls.Add(this.btn_selectedPath);
            this.Controls.Add(this.cmb_semester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.txt_teacher);
            this.Controls.Add(this.txt_university);
            this.Controls.Add(this.btn_createTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Table Generator";
            ((System.ComponentModel.ISupportInitialize)(this.gif_loadAndSucess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif_endLoadSucess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createTable;
        private System.Windows.Forms.TextBox txt_university;
        private System.Windows.Forms.TextBox txt_teacher;
        private System.Windows.Forms.TextBox txt_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_semester;
        private System.Windows.Forms.Button btn_selectedPath;
        private System.Windows.Forms.Label lbl_caminho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_versaoSistema;
        private System.Windows.Forms.PictureBox gif_loadAndSucess;
        private System.Windows.Forms.PictureBox gif_endLoadSucess;
    }
}

