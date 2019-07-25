namespace akreditasiAPP
{
    partial class viewData
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
            this.components = new System.ComponentModel.Container();
            this.iddataakreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akreditasiDataSet1 = new akreditasiAPP.akreditasiDataSet1();
            this.akreditasiDataSet = new akreditasiAPP.akreditasiDataSet();
            this.akreditasiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identitasprodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identitas_prodiTableAdapter = new akreditasiAPP.akreditasiDataSetTableAdapters.identitas_prodiTableAdapter();
            this.akreditasiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_data_akreTableAdapter = new akreditasiAPP.akreditasiDataSet1TableAdapters.id_data_akreTableAdapter();
            this.btBK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.programstudiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorskbanptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunpertamamenerimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peringkatterbaruakreditasipsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalskpendirianptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorskpendirianptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorteleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programstudiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpengelolaorganisasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perguruantinggiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iddataakreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identitasprodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iddataakreBindingSource
            // 
            this.iddataakreBindingSource.DataMember = "id_data_akre";
            this.iddataakreBindingSource.DataSource = this.akreditasiDataSet1;
            // 
            // akreditasiDataSet1
            // 
            this.akreditasiDataSet1.DataSetName = "akreditasiDataSet1";
            this.akreditasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akreditasiDataSet
            // 
            this.akreditasiDataSet.DataSetName = "akreditasiDataSet";
            this.akreditasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akreditasiDataSetBindingSource
            // 
            this.akreditasiDataSetBindingSource.DataSource = this.akreditasiDataSet;
            this.akreditasiDataSetBindingSource.Position = 0;
            // 
            // identitasprodiBindingSource
            // 
            this.identitasprodiBindingSource.DataMember = "identitas_prodi";
            this.identitasprodiBindingSource.DataSource = this.akreditasiDataSetBindingSource;
            // 
            // identitas_prodiTableAdapter
            // 
            this.identitas_prodiTableAdapter.ClearBeforeFill = true;
            // 
            // akreditasiDataSetBindingSource1
            // 
            this.akreditasiDataSetBindingSource1.DataSource = this.akreditasiDataSet;
            this.akreditasiDataSetBindingSource1.Position = 0;
            // 
            // id_data_akreTableAdapter
            // 
            this.id_data_akreTableAdapter.ClearBeforeFill = true;
            // 
            // btBK
            // 
            this.btBK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btBK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBK.ForeColor = System.Drawing.Color.White;
            this.btBK.Location = new System.Drawing.Point(668, 397);
            this.btBK.Name = "btBK";
            this.btBK.Size = new System.Drawing.Size(100, 41);
            this.btBK.TabIndex = 13;
            this.btBK.Text = "BACK";
            this.btBK.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 41);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEARCH";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(626, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // programstudiidDataGridViewTextBoxColumn
            // 
            this.programstudiidDataGridViewTextBoxColumn.DataPropertyName = "program_studi_id";
            this.programstudiidDataGridViewTextBoxColumn.HeaderText = "program_studi_id";
            this.programstudiidDataGridViewTextBoxColumn.Name = "programstudiidDataGridViewTextBoxColumn";
            // 
            // nomorskbanptDataGridViewTextBoxColumn
            // 
            this.nomorskbanptDataGridViewTextBoxColumn.DataPropertyName = "nomor_sk_ban_pt";
            this.nomorskbanptDataGridViewTextBoxColumn.HeaderText = "nomor_sk_ban_pt";
            this.nomorskbanptDataGridViewTextBoxColumn.Name = "nomorskbanptDataGridViewTextBoxColumn";
            // 
            // tahunpertamamenerimaDataGridViewTextBoxColumn
            // 
            this.tahunpertamamenerimaDataGridViewTextBoxColumn.DataPropertyName = "tahun_pertama_menerima";
            this.tahunpertamamenerimaDataGridViewTextBoxColumn.HeaderText = "tahun_pertama_menerima";
            this.tahunpertamamenerimaDataGridViewTextBoxColumn.Name = "tahunpertamamenerimaDataGridViewTextBoxColumn";
            // 
            // peringkatterbaruakreditasipsDataGridViewTextBoxColumn
            // 
            this.peringkatterbaruakreditasipsDataGridViewTextBoxColumn.DataPropertyName = "peringkat_terbaru_akreditasi_ps";
            this.peringkatterbaruakreditasipsDataGridViewTextBoxColumn.HeaderText = "peringkat_terbaru_akreditasi_ps";
            this.peringkatterbaruakreditasipsDataGridViewTextBoxColumn.Name = "peringkatterbaruakreditasipsDataGridViewTextBoxColumn";
            // 
            // pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn
            // 
            this.pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn.DataPropertyName = "pejabat_penandatangan_sk_pembukaan_ps";
            this.pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn.HeaderText = "pejabat_penandatangan_sk_pembukaan_ps";
            this.pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn.Name = "pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn";
            // 
            // tanggalskpendirianptDataGridViewTextBoxColumn
            // 
            this.tanggalskpendirianptDataGridViewTextBoxColumn.DataPropertyName = "tanggal_sk_pendirian_pt";
            this.tanggalskpendirianptDataGridViewTextBoxColumn.HeaderText = "tanggal_sk_pendirian_pt";
            this.tanggalskpendirianptDataGridViewTextBoxColumn.Name = "tanggalskpendirianptDataGridViewTextBoxColumn";
            // 
            // nomorskpendirianptDataGridViewTextBoxColumn
            // 
            this.nomorskpendirianptDataGridViewTextBoxColumn.DataPropertyName = "nomor_sk_pendirian_pt";
            this.nomorskpendirianptDataGridViewTextBoxColumn.HeaderText = "nomor_sk_pendirian_pt";
            this.nomorskpendirianptDataGridViewTextBoxColumn.Name = "nomorskpendirianptDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nomorteleponDataGridViewTextBoxColumn
            // 
            this.nomorteleponDataGridViewTextBoxColumn.DataPropertyName = "nomor_telepon";
            this.nomorteleponDataGridViewTextBoxColumn.HeaderText = "nomor_telepon";
            this.nomorteleponDataGridViewTextBoxColumn.Name = "nomorteleponDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // programstudiDataGridViewTextBoxColumn
            // 
            this.programstudiDataGridViewTextBoxColumn.DataPropertyName = "program_studi";
            this.programstudiDataGridViewTextBoxColumn.HeaderText = "program_studi";
            this.programstudiDataGridViewTextBoxColumn.Name = "programstudiDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "program";
            this.programDataGridViewTextBoxColumn.HeaderText = "program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // unitpengelolaorganisasiDataGridViewTextBoxColumn
            // 
            this.unitpengelolaorganisasiDataGridViewTextBoxColumn.DataPropertyName = "unit_pengelola_organisasi";
            this.unitpengelolaorganisasiDataGridViewTextBoxColumn.HeaderText = "Unit Pengelola Organisasi";
            this.unitpengelolaorganisasiDataGridViewTextBoxColumn.Name = "unitpengelolaorganisasiDataGridViewTextBoxColumn";
            // 
            // perguruantinggiDataGridViewTextBoxColumn
            // 
            this.perguruantinggiDataGridViewTextBoxColumn.DataPropertyName = "perguruan_tinggi";
            this.perguruantinggiDataGridViewTextBoxColumn.HeaderText = "Perguruan Tinggi";
            this.perguruantinggiDataGridViewTextBoxColumn.Name = "perguruantinggiDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perguruantinggiDataGridViewTextBoxColumn,
            this.unitpengelolaorganisasiDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.programstudiDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nomorteleponDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.nomorskpendirianptDataGridViewTextBoxColumn,
            this.tanggalskpendirianptDataGridViewTextBoxColumn,
            this.pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn,
            this.peringkatterbaruakreditasipsDataGridViewTextBoxColumn,
            this.tahunpertamamenerimaDataGridViewTextBoxColumn,
            this.nomorskbanptDataGridViewTextBoxColumn,
            this.programstudiidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iddataakreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btBK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewData";
            this.Text = "viewData";
            this.Load += new System.EventHandler(this.viewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iddataakreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identitasprodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akreditasiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource akreditasiDataSetBindingSource;
        private akreditasiDataSet akreditasiDataSet;
        private System.Windows.Forms.BindingSource identitasprodiBindingSource;
        private akreditasiDataSetTableAdapters.identitas_prodiTableAdapter identitas_prodiTableAdapter;
        private System.Windows.Forms.BindingSource akreditasiDataSetBindingSource1;
        private akreditasiDataSet1 akreditasiDataSet1;
        private System.Windows.Forms.BindingSource iddataakreBindingSource;
        private akreditasiDataSet1TableAdapters.id_data_akreTableAdapter id_data_akreTableAdapter;
        private System.Windows.Forms.Button btBK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programstudiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorskbanptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunpertamamenerimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peringkatterbaruakreditasipsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pejabatpenandatanganskpembukaanpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalskpendirianptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorskpendirianptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorteleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programstudiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpengelolaorganisasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perguruantinggiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}