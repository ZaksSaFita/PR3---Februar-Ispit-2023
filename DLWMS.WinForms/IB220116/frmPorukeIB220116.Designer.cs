namespace DLWMS.WinForms.IB220116
{
    partial class frmPorukeIB220116
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
            btnNovaPoruka = new Button();
            lblStudent = new Label();
            dataGridView1 = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            dtpValidan = new DateTimePicker();
            label5 = new Label();
            cmbPredmeti = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtBroj = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(886, 19);
            btnNovaPoruka.Margin = new Padding(2);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(101, 20);
            btnNovaPoruka.TabIndex = 0;
            btnNovaPoruka.Text = "Nova Poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 25);
            lblStudent.Margin = new Padding(2, 0, 2, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(93, 15);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Poruke studenta";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(975, 162);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(886, 255);
            btnPrintaj.Margin = new Padding(2);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(90, 23);
            btnPrintaj.TabIndex = 0;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbPredmeti);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Location = new Point(40, 307);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(928, 227);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 10);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(318, 26);
            txtInfo.Margin = new Padding(2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(606, 154);
            txtInfo.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(10, 158);
            btnDodaj.Margin = new Padding(2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(220, 20);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidan
            // 
            dtpValidan.Location = new Point(10, 127);
            dtpValidan.Margin = new Padding(2);
            dtpValidan.Name = "dtpValidan";
            dtpValidan.Size = new Size(221, 23);
            dtpValidan.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 5;
            label5.Text = "Poruka je validna do:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(10, 78);
            cmbPredmeti.Margin = new Padding(2);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(221, 23);
            cmbPredmeti.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 61);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj dodavanja:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(10, 33);
            txtBroj.Margin = new Padding(2);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(221, 23);
            txtBroj.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPorukeIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 500);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblStudent);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "frmPorukeIB220116";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmPorukeIB220116";
            Load += frmPorukeIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaPoruka;
        private Label lblStudent;
        private DataGridView dataGridView1;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private DateTimePicker dtpValidan;
        private Label label5;
        private ComboBox cmbPredmeti;
        private Label label4;
        private Label label3;
        private TextBox txtBroj;
        private Label label6;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private ErrorProvider errorProvider1;
    }
}