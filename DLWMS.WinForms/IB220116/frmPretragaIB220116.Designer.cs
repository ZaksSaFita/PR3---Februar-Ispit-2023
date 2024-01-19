namespace DLWMS.WinForms.IB220116
{
    partial class frmPretragaIB220116
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbOcjenaOd = new ComboBox();
            label2 = new Label();
            cmdOcjenaDo = new ComboBox();
            label3 = new Label();
            dtpDatumOd = new DateTimePicker();
            label4 = new Label();
            dtpDatumDo = new DateTimePicker();
            dgvPretraga = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // cmbOcjenaOd
            // 
            cmbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaOd.FormattingEnabled = true;
            cmbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaOd.Location = new Point(88, 14);
            cmbOcjenaOd.Margin = new Padding(2);
            cmbOcjenaOd.Name = "cmbOcjenaOd";
            cmbOcjenaOd.Size = new Size(46, 23);
            cmbOcjenaOd.TabIndex = 1;
            cmbOcjenaOd.SelectedIndexChanged += cmbOcjenaOd_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "do";
            // 
            // cmdOcjenaDo
            // 
            cmdOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdOcjenaDo.FormattingEnabled = true;
            cmdOcjenaDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmdOcjenaDo.Location = new Point(164, 14);
            cmdOcjenaDo.Margin = new Padding(2);
            cmdOcjenaDo.Name = "cmdOcjenaDo";
            cmdOcjenaDo.Size = new Size(46, 23);
            cmdOcjenaDo.TabIndex = 3;
            cmdOcjenaDo.SelectedIndexChanged += cmdOcjenaDo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "polozeni u periodu od";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(350, 15);
            dtpDatumOd.Margin = new Padding(2);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(211, 23);
            dtpDatumOd.TabIndex = 5;
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 6;
            label4.Text = "do";
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(592, 16);
            dtpDatumDo.Margin = new Padding(2);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(211, 23);
            dtpDatumDo.TabIndex = 7;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Student, Predmet, Ocjena, Datum, Poruke });
            dgvPretraga.Location = new Point(21, 52);
            dgvPretraga.Margin = new Padding(2);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 62;
            dgvPretraga.RowTemplate.Height = 33;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(781, 223);
            dgvPretraga.TabIndex = 8;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Indeks";
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum polaganja";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPretragaIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 287);
            Controls.Add(dgvPretraga);
            Controls.Add(dtpDatumDo);
            Controls.Add(label4);
            Controls.Add(dtpDatumOd);
            Controls.Add(label3);
            Controls.Add(cmdOcjenaDo);
            Controls.Add(label2);
            Controls.Add(cmbOcjenaOd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "frmPretragaIB220116";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOcjenaOd;
        private Label label2;
        private ComboBox cmdOcjenaDo;
        private Label label3;
        private DateTimePicker dtpDatumOd;
        private Label label4;
        private DateTimePicker dtpDatumDo;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn Poruke;
        private ErrorProvider errorProvider1;
    }
}