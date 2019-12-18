namespace Libraria
{
    partial class frmLibrat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbobotuesi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTitulli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarkodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQmimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBotuesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblbotuesi = new System.Windows.Forms.Label();
            this.txtKerkimi = new System.Windows.Forms.TextBox();
            this.cboKerkimiSipas = new System.Windows.Forms.ComboBox();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.lblkategoria = new System.Windows.Forms.Label();
            this.lblqmimi = new System.Windows.Forms.Label();
            this.lbltitulli = new System.Windows.Forms.Label();
            this.lblbarkodi = new System.Windows.Forms.Label();
            this.lblautori = new System.Windows.Forms.Label();
            this.lblsasia = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.lbllibriid = new System.Windows.Forms.Label();
            this.txtqmimi = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttitulli = new System.Windows.Forms.TextBox();
            this.txtbarkodi = new System.Windows.Forms.TextBox();
            this.txtsasia = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtkategoria = new System.Windows.Forms.TextBox();
            this.txtautori = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLexoShenimet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbobotuesi
            // 
            this.cbobotuesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobotuesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobotuesi.FormattingEnabled = true;
            this.cbobotuesi.Location = new System.Drawing.Point(794, 223);
            this.cbobotuesi.Margin = new System.Windows.Forms.Padding(2);
            this.cbobotuesi.Name = "cbobotuesi";
            this.cbobotuesi.Size = new System.Drawing.Size(144, 24);
            this.cbobotuesi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitulli,
            this.ColumnIsbn,
            this.ColumnBarkodi,
            this.ColumnSasia,
            this.ColumnQmimi,
            this.ColumnBotuesi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 371);
            this.dataGridView1.TabIndex = 60;
            // 
            // ColumnTitulli
            // 
            this.ColumnTitulli.DataPropertyName = "titulli";
            this.ColumnTitulli.HeaderText = "Titulli";
            this.ColumnTitulli.Name = "ColumnTitulli";
            this.ColumnTitulli.ReadOnly = true;
            // 
            // ColumnIsbn
            // 
            this.ColumnIsbn.DataPropertyName = "isbn";
            this.ColumnIsbn.HeaderText = "ISBN";
            this.ColumnIsbn.Name = "ColumnIsbn";
            this.ColumnIsbn.ReadOnly = true;
            // 
            // ColumnBarkodi
            // 
            this.ColumnBarkodi.DataPropertyName = "barkodi";
            this.ColumnBarkodi.HeaderText = "Barkodi";
            this.ColumnBarkodi.Name = "ColumnBarkodi";
            this.ColumnBarkodi.ReadOnly = true;
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
            // ColumnBotuesi
            // 
            this.ColumnBotuesi.DataPropertyName = "botuesi_emri";
            this.ColumnBotuesi.HeaderText = "Shtëpia Botuese";
            this.ColumnBotuesi.Name = "ColumnBotuesi";
            this.ColumnBotuesi.ReadOnly = true;
            // 
            // lblbotuesi
            // 
            this.lblbotuesi.AutoSize = true;
            this.lblbotuesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbotuesi.Location = new System.Drawing.Point(680, 224);
            this.lblbotuesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbotuesi.Name = "lblbotuesi";
            this.lblbotuesi.Size = new System.Drawing.Size(116, 17);
            this.lblbotuesi.TabIndex = 59;
            this.lblbotuesi.Text = "Shtëpia Botuese:";
            // 
            // txtKerkimi
            // 
            this.txtKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkimi.Location = new System.Drawing.Point(218, 61);
            this.txtKerkimi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKerkimi.Name = "txtKerkimi";
            this.txtKerkimi.Size = new System.Drawing.Size(201, 23);
            this.txtKerkimi.TabIndex = 13;
            // 
            // cboKerkimiSipas
            // 
            this.cboKerkimiSipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKerkimiSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKerkimiSipas.FormattingEnabled = true;
            this.cboKerkimiSipas.Location = new System.Drawing.Point(23, 61);
            this.cboKerkimiSipas.Margin = new System.Windows.Forms.Padding(2);
            this.cboKerkimiSipas.Name = "cboKerkimiSipas";
            this.cboKerkimiSipas.Size = new System.Drawing.Size(185, 24);
            this.cboKerkimiSipas.TabIndex = 12;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(23, 21);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(101, 21);
            this.chkKerkoSipas.TabIndex = 61;
            this.chkKerkoSipas.Text = "Kërko sipas";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
            // 
            // lblkategoria
            // 
            this.lblkategoria.AutoSize = true;
            this.lblkategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkategoria.Location = new System.Drawing.Point(719, 254);
            this.lblkategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkategoria.Name = "lblkategoria";
            this.lblkategoria.Size = new System.Drawing.Size(73, 17);
            this.lblkategoria.TabIndex = 57;
            this.lblkategoria.Text = "Kategoria:";
            // 
            // lblqmimi
            // 
            this.lblqmimi.AutoSize = true;
            this.lblqmimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqmimi.Location = new System.Drawing.Point(736, 172);
            this.lblqmimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblqmimi.Name = "lblqmimi";
            this.lblqmimi.Size = new System.Drawing.Size(49, 17);
            this.lblqmimi.TabIndex = 56;
            this.lblqmimi.Text = "Çmimi:";
            // 
            // lbltitulli
            // 
            this.lbltitulli.AutoSize = true;
            this.lbltitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulli.Location = new System.Drawing.Point(742, 92);
            this.lbltitulli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulli.Name = "lbltitulli";
            this.lbltitulli.Size = new System.Drawing.Size(45, 17);
            this.lbltitulli.TabIndex = 55;
            this.lbltitulli.Text = "Titulli:";
            // 
            // lblbarkodi
            // 
            this.lblbarkodi.AutoSize = true;
            this.lblbarkodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarkodi.Location = new System.Drawing.Point(730, 119);
            this.lblbarkodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbarkodi.Name = "lblbarkodi";
            this.lblbarkodi.Size = new System.Drawing.Size(60, 17);
            this.lblbarkodi.TabIndex = 54;
            this.lblbarkodi.Text = "Barkodi:";
            // 
            // lblautori
            // 
            this.lblautori.AutoSize = true;
            this.lblautori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautori.Location = new System.Drawing.Point(740, 309);
            this.lblautori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblautori.Name = "lblautori";
            this.lblautori.Size = new System.Drawing.Size(49, 17);
            this.lblautori.TabIndex = 53;
            this.lblautori.Text = "Autori:";
            // 
            // lblsasia
            // 
            this.lblsasia.AutoSize = true;
            this.lblsasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsasia.Location = new System.Drawing.Point(741, 199);
            this.lblsasia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsasia.Name = "lblsasia";
            this.lblsasia.Size = new System.Drawing.Size(47, 17);
            this.lblsasia.TabIndex = 51;
            this.lblsasia.Text = "Sasia:";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisbn.Location = new System.Drawing.Point(743, 145);
            this.lblisbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(43, 17);
            this.lblisbn.TabIndex = 47;
            this.lblisbn.Text = "ISBN:";
            // 
            // lbllibriid
            // 
            this.lbllibriid.AutoSize = true;
            this.lbllibriid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllibriid.Location = new System.Drawing.Point(760, 66);
            this.lbllibriid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllibriid.Name = "lbllibriid";
            this.lbllibriid.Size = new System.Drawing.Size(25, 17);
            this.lbllibriid.TabIndex = 45;
            this.lbllibriid.Text = "ID:";
            // 
            // txtqmimi
            // 
            this.txtqmimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqmimi.Location = new System.Drawing.Point(794, 170);
            this.txtqmimi.Margin = new System.Windows.Forms.Padding(2);
            this.txtqmimi.Name = "txtqmimi";
            this.txtqmimi.Size = new System.Drawing.Size(144, 23);
            this.txtqmimi.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(794, 63);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 23);
            this.txtid.TabIndex = 0;
            // 
            // txttitulli
            // 
            this.txttitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulli.Location = new System.Drawing.Point(794, 89);
            this.txttitulli.Margin = new System.Windows.Forms.Padding(2);
            this.txttitulli.Name = "txttitulli";
            this.txttitulli.Size = new System.Drawing.Size(144, 23);
            this.txttitulli.TabIndex = 1;
            // 
            // txtbarkodi
            // 
            this.txtbarkodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarkodi.Location = new System.Drawing.Point(794, 116);
            this.txtbarkodi.Margin = new System.Windows.Forms.Padding(2);
            this.txtbarkodi.Name = "txtbarkodi";
            this.txtbarkodi.Size = new System.Drawing.Size(144, 23);
            this.txtbarkodi.TabIndex = 2;
            // 
            // txtsasia
            // 
            this.txtsasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsasia.Location = new System.Drawing.Point(794, 197);
            this.txtsasia.Margin = new System.Windows.Forms.Padding(2);
            this.txtsasia.Name = "txtsasia";
            this.txtsasia.Size = new System.Drawing.Size(144, 23);
            this.txtsasia.TabIndex = 5;
            // 
            // txtisbn
            // 
            this.txtisbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisbn.Location = new System.Drawing.Point(794, 143);
            this.txtisbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(144, 23);
            this.txtisbn.TabIndex = 3;
            // 
            // txtkategoria
            // 
            this.txtkategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkategoria.Location = new System.Drawing.Point(794, 249);
            this.txtkategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtkategoria.Multiline = true;
            this.txtkategoria.Name = "txtkategoria";
            this.txtkategoria.Size = new System.Drawing.Size(144, 50);
            this.txtkategoria.TabIndex = 7;
            // 
            // txtautori
            // 
            this.txtautori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautori.Location = new System.Drawing.Point(794, 304);
            this.txtautori.Margin = new System.Windows.Forms.Padding(2);
            this.txtautori.Multiline = true;
            this.txtautori.Name = "txtautori";
            this.txtautori.Size = new System.Drawing.Size(144, 49);
            this.txtautori.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(794, 437);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Libraria.Properties.Resources.btnAddNewItem_Image;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(794, 359);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(142, 28);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Shto Librin";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLexoShenimet
            // 
            this.btnLexoShenimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexoShenimet.Image = global::Libraria.Properties.Resources.Find_5650_32;
            this.btnLexoShenimet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLexoShenimet.Location = new System.Drawing.Point(425, 58);
            this.btnLexoShenimet.Margin = new System.Windows.Forms.Padding(2);
            this.btnLexoShenimet.Name = "btnLexoShenimet";
            this.btnLexoShenimet.Size = new System.Drawing.Size(234, 28);
            this.btnLexoShenimet.TabIndex = 14;
            this.btnLexoShenimet.Text = "Lexo Shënimet nga Serveri";
            this.btnLexoShenimet.UseVisualStyleBackColor = true;
            this.btnLexoShenimet.Click += new System.EventHandler(this.btnLexoShenimet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Libraria.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(794, 392);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Ruaje Librin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // frmLibrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(963, 487);
            this.Controls.Add(this.cbobotuesi);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblbotuesi);
            this.Controls.Add(this.txtKerkimi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboKerkimiSipas);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnLexoShenimet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblkategoria);
            this.Controls.Add(this.lblqmimi);
            this.Controls.Add(this.lbltitulli);
            this.Controls.Add(this.lblbarkodi);
            this.Controls.Add(this.lblautori);
            this.Controls.Add(this.lblsasia);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lbllibriid);
            this.Controls.Add(this.txtqmimi);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttitulli);
            this.Controls.Add(this.txtbarkodi);
            this.Controls.Add(this.txtsasia);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtkategoria);
            this.Controls.Add(this.txtautori);
            this.MaximizeBox = false;
            this.Name = "frmLibrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLibrat_FormClosing);
            this.Load += new System.EventHandler(this.frmLibrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblbotuesi;
        private System.Windows.Forms.TextBox txtKerkimi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboKerkimiSipas;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.Button btnLexoShenimet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblqmimi;
        private System.Windows.Forms.Label lbltitulli;
        private System.Windows.Forms.Label lblbarkodi;
        private System.Windows.Forms.Label lblautori;
        private System.Windows.Forms.Label lblsasia;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Label lbllibriid;
        private System.Windows.Forms.TextBox txtqmimi;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttitulli;
        private System.Windows.Forms.TextBox txtbarkodi;
        private System.Windows.Forms.TextBox txtsasia;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtkategoria;
        private System.Windows.Forms.TextBox txtautori;
        private System.Windows.Forms.Label lblkategoria;
        private System.Windows.Forms.ComboBox cbobotuesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarkodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQmimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBotuesi;
    }
}