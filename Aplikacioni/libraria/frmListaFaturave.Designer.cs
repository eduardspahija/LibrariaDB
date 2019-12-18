namespace Libraria
{
    partial class frmListaFaturave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFaturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVlera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFaturaLloji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKlientiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuntori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnBarkodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitulli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQmimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblPeriudha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFiltroFaturat = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFaturaId,
            this.ColumnDataFatures,
            this.ColumnVlera,
            this.ColumnFaturaLloji,
            this.ColumnKlientiId,
            this.ColumnPuntori});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(14, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnFaturaId
            // 
            this.ColumnFaturaId.DataPropertyName = "faturaId";
            this.ColumnFaturaId.HeaderText = "FaturaId";
            this.ColumnFaturaId.Name = "ColumnFaturaId";
            this.ColumnFaturaId.ReadOnly = true;
            // 
            // ColumnDataFatures
            // 
            this.ColumnDataFatures.DataPropertyName = "data_fatures";
            this.ColumnDataFatures.HeaderText = "Data Fatures";
            this.ColumnDataFatures.Name = "ColumnDataFatures";
            this.ColumnDataFatures.ReadOnly = true;
            // 
            // ColumnVlera
            // 
            this.ColumnVlera.DataPropertyName = "Vlera";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnVlera.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnVlera.HeaderText = "Vlera Faturës";
            this.ColumnVlera.Name = "ColumnVlera";
            this.ColumnVlera.ReadOnly = true;
            // 
            // ColumnFaturaLloji
            // 
            this.ColumnFaturaLloji.DataPropertyName = "fatura_lloji";
            this.ColumnFaturaLloji.HeaderText = "Fatura Lloji";
            this.ColumnFaturaLloji.Name = "ColumnFaturaLloji";
            this.ColumnFaturaLloji.ReadOnly = true;
            // 
            // ColumnKlientiId
            // 
            this.ColumnKlientiId.DataPropertyName = "KlientiEmri";
            this.ColumnKlientiId.HeaderText = "Klienti";
            this.ColumnKlientiId.Name = "ColumnKlientiId";
            this.ColumnKlientiId.ReadOnly = true;
            // 
            // ColumnPuntori
            // 
            this.ColumnPuntori.DataPropertyName = "PuntoriEmri";
            this.ColumnPuntori.HeaderText = "Punëtori";
            this.ColumnPuntori.Name = "ColumnPuntori";
            this.ColumnPuntori.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarkodi,
            this.ColumnTitulli,
            this.ColumnSasia,
            this.ColumnQmimi});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(14, 255);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(719, 195);
            this.dataGridView2.TabIndex = 1;
            // 
            // ColumnBarkodi
            // 
            this.ColumnBarkodi.DataPropertyName = "barkodi";
            this.ColumnBarkodi.HeaderText = "Barkodi";
            this.ColumnBarkodi.Name = "ColumnBarkodi";
            this.ColumnBarkodi.ReadOnly = true;
            // 
            // ColumnTitulli
            // 
            this.ColumnTitulli.DataPropertyName = "titulli";
            this.ColumnTitulli.HeaderText = "Titulli";
            this.ColumnTitulli.Name = "ColumnTitulli";
            this.ColumnTitulli.ReadOnly = true;
            // 
            // ColumnSasia
            // 
            this.ColumnSasia.DataPropertyName = "sasia";
            this.ColumnSasia.HeaderText = "Sasia";
            this.ColumnSasia.Name = "ColumnSasia";
            this.ColumnSasia.ReadOnly = true;
            // 
            // ColumnQmimi
            // 
            this.ColumnQmimi.DataPropertyName = "qmimi";
            this.ColumnQmimi.HeaderText = "Çmimi";
            this.ColumnQmimi.Name = "ColumnQmimi";
            this.ColumnQmimi.ReadOnly = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 75;
            // 
            // lblPeriudha
            // 
            this.lblPeriudha.AutoSize = true;
            this.lblPeriudha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriudha.Location = new System.Drawing.Point(11, 9);
            this.lblPeriudha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriudha.Name = "lblPeriudha";
            this.lblPeriudha.Size = new System.Drawing.Size(145, 17);
            this.lblPeriudha.TabIndex = 74;
            this.lblPeriudha.Text = "Periudha e Raportimit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(226, 5);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(109, 21);
            this.chkKerkoSipas.TabIndex = 78;
            this.chkKerkoSipas.Text = "Sipas datave";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(637, 457);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 86;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFiltroFaturat
            // 
            this.btnFiltroFaturat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroFaturat.Image = global::Libraria.Properties.Resources.FindResults1_6264_24;
            this.btnFiltroFaturat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroFaturat.Location = new System.Drawing.Point(226, 29);
            this.btnFiltroFaturat.Name = "btnFiltroFaturat";
            this.btnFiltroFaturat.Size = new System.Drawing.Size(129, 23);
            this.btnFiltroFaturat.TabIndex = 77;
            this.btnFiltroFaturat.Text = "Filtro Faturat";
            this.btnFiltroFaturat.UseVisualStyleBackColor = true;
            this.btnFiltroFaturat.Click += new System.EventHandler(this.btnFiltroFaturat_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // frmListaFaturave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(747, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnFiltroFaturat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblPeriudha);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "frmListaFaturave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista e Faturave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListaFaturave_FormClosing);
            this.Load += new System.EventHandler(this.frmListaFaturave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarkodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQmimi;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblPeriudha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFiltroFaturat;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataFatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVlera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaturaLloji;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKlientiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuntori;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.Button btnClose;
    }
}