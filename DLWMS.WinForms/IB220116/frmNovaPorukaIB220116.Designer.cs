namespace DLWMS.WinForms.IB220116
{
    partial class frmNovaPorukaIB220116
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
            cmbPredmeti = new ComboBox();
            label2 = new Label();
            dtpValidan = new DateTimePicker();
            label3 = new Label();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            label4 = new Label();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(8, 34);
            cmbPredmeti.Margin = new Padding(2);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(212, 23);
            cmbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Poruka je validna do:";
            // 
            // dtpValidan
            // 
            dtpValidan.Location = new Point(8, 78);
            dtpValidan.Margin = new Padding(2);
            dtpValidan.Name = "dtpValidan";
            dtpValidan.Size = new Size(211, 23);
            dtpValidan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 109);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Sadrzaj poruke:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(8, 125);
            txtSadrzaj.Margin = new Padding(2);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(212, 112);
            txtSadrzaj.TabIndex = 5;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(239, 34);
            pbSlika.Margin = new Padding(2);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(201, 205);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 6;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Slika:";
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(263, 242);
            btnOdustani.Margin = new Padding(2);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(78, 20);
            btnOdustani.TabIndex = 8;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += button1_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(362, 242);
            btnSacuvaj.Margin = new Padding(2);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(78, 20);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB220116
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 270);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(label4);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(label3);
            Controls.Add(dtpValidan);
            Controls.Add(label2);
            Controls.Add(cmbPredmeti);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "frmNovaPorukaIB220116";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Poruka";
            Load += frmNovaPorukaIB220116_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmeti;
        private Label label2;
        private DateTimePicker dtpValidan;
        private Label label3;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private Label label4;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}