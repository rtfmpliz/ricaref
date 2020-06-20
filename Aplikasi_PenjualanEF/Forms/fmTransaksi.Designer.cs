namespace Aplikasi_PenjualanEF.Forms
{
    partial class fmTransaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noKwitansiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglKwitansiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penjualanEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noKwitansiDataGridViewTextBoxColumn,
            this.tglKwitansiDataGridViewTextBoxColumn,
            this.iDPelangganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penjualanEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 76);
            this.dataGridView1.TabIndex = 0;
            // 
            // noKwitansiDataGridViewTextBoxColumn
            // 
            this.noKwitansiDataGridViewTextBoxColumn.DataPropertyName = "NoKwitansi";
            this.noKwitansiDataGridViewTextBoxColumn.HeaderText = "NoKwitansi";
            this.noKwitansiDataGridViewTextBoxColumn.Name = "noKwitansiDataGridViewTextBoxColumn";
            // 
            // tglKwitansiDataGridViewTextBoxColumn
            // 
            this.tglKwitansiDataGridViewTextBoxColumn.DataPropertyName = "TglKwitansi";
            this.tglKwitansiDataGridViewTextBoxColumn.HeaderText = "TglKwitansi";
            this.tglKwitansiDataGridViewTextBoxColumn.Name = "tglKwitansiDataGridViewTextBoxColumn";
            // 
            // iDPelangganDataGridViewTextBoxColumn
            // 
            this.iDPelangganDataGridViewTextBoxColumn.DataPropertyName = "IDPelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.HeaderText = "IDPelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.Name = "iDPelangganDataGridViewTextBoxColumn";
            // 
            // penjualanEntityBindingSource
            // 
            this.penjualanEntityBindingSource.DataSource = typeof(Aplikasi_PenjualanEF.Entities.PenjualanEntity);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(12, 53);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 2;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // fmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fmTransaksi";
            this.Text = "fmTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKwitansiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKwitansiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource penjualanEntityBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCetak;
    }
}