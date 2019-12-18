namespace Libraria
{
    partial class frmFatura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtVleraFatures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMenyraPageses = new System.Windows.Forms.ComboBox();
            this.lblgjinia = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnTitulli1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLibriId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarkodi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSasia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQmimi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQmimi = new System.Windows.Forms.TextBox();
            this.txtSasia = new System.Windows.Forms.TextBox();
            this.txtTitulli = new System.Windows.Forms.TextBox();
            this.txtBarkodi = new System.Windows.Forms.TextBox();
            this.lblSasia = new System.Windows.Forms.Label();
            this.lblQmimi = new System.Windows.Forms.Label();
            this.lblTitulli = new System.Windows.Forms.Label();
            this.lblBarkodi = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBleresi = new System.Windows.Forms.ComboBox();
            this.lblBleresi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTitulli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLibriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarkodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQmimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKerkimi = new System.Windows.Forms.TextBox();
            this.cboKerkimiSipas = new System.Windows.Forms.ComboBox();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLexoShenimet = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVleraFatures
            // 
            this.txtVleraFatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVleraFatures.Location = new System.Drawing.Point(1261, 12);
            this.txtVleraFatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVleraFatures.Name = "txtVleraFatures";
            this.txtVleraFatures.ReadOnly = true;
            this.txtVleraFatures.Size = new System.Drawing.Size(131, 27);
            this.txtVleraFatures.TabIndex = 89;
            this.txtVleraFatures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1096, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Vlera e faturës [€]:";
            // 
            // cboMenyraPageses
            // 
            this.cboMenyraPageses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenyraPageses.FormattingEnabled = true;
            this.cboMenyraPageses.Location = new System.Drawing.Point(932, 69);
            this.cboMenyraPageses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMenyraPageses.Name = "cboMenyraPageses";
            this.cboMenyraPageses.Size = new System.Drawing.Size(125, 28);
            this.cboMenyraPageses.TabIndex = 87;
            // 
            // lblgjinia
            // 
            this.lblgjinia.AutoSize = true;
            this.lblgjinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgjinia.Location = new System.Drawing.Point(928, 46);
            this.lblgjinia.Name = "lblgjinia";
            this.lblgjinia.Size = new System.Drawing.Size(139, 20);
            this.lblgjinia.TabIndex = 88;
            this.lblgjinia.Text = "Mënyra Pagesës:";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitulli1,
            this.ColumnLibriId1,
            this.ColumnBarkodi1,
            this.ColumnSasia1,
            this.ColumnQmimi1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(771, 103);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(621, 271);
            this.dataGridView2.TabIndex = 82;
            // 
            // ColumnTitulli1
            // 
            this.ColumnTitulli1.DataPropertyName = "titulli";
            this.ColumnTitulli1.HeaderText = "Titulli";
            this.ColumnTitulli1.Name = "ColumnTitulli1";
            this.ColumnTitulli1.ReadOnly = true;
            // 
            // ColumnLibriId1
            // 
            this.ColumnLibriId1.DataPropertyName = "libriId";
            this.ColumnLibriId1.HeaderText = "LibriId";
            this.ColumnLibriId1.Name = "ColumnLibriId1";
            this.ColumnLibriId1.ReadOnly = true;
            this.ColumnLibriId1.Visible = false;
            // 
            // ColumnBarkodi1
            // 
            this.ColumnBarkodi1.DataPropertyName = "barkodi";
            this.ColumnBarkodi1.HeaderText = "Barkodi";
            this.ColumnBarkodi1.Name = "ColumnBarkodi1";
            this.ColumnBarkodi1.ReadOnly = true;
            // 
            // ColumnSasia1
            // 
            this.ColumnSasia1.DataPropertyName = "sasia";
            this.ColumnSasia1.HeaderText = "Sasia";
            this.ColumnSasia1.Name = "ColumnSasia1";
            this.ColumnSasia1.ReadOnly = true;
            // 
            // ColumnQmimi1
            // 
            this.ColumnQmimi1.DataPropertyName = "qmimi";
            this.ColumnQmimi1.HeaderText = "Çmimi";
            this.ColumnQmimi1.Name = "ColumnQmimi1";
            this.ColumnQmimi1.ReadOnly = true;
            // 
            // txtQmimi
            // 
            this.txtQmimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQmimi.Location = new System.Drawing.Point(845, 494);
            this.txtQmimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQmimi.Name = "txtQmimi";
            this.txtQmimi.Size = new System.Drawing.Size(164, 27);
            this.txtQmimi.TabIndex = 3;
            this.txtQmimi.Validated += new System.EventHandler(this.txtQmimi_Validated);
            // 
            // txtSasia
            // 
            this.txtSasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSasia.Location = new System.Drawing.Point(845, 462);
            this.txtSasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Size = new System.Drawing.Size(164, 27);
            this.txtSasia.TabIndex = 2;
            this.txtSasia.Validated += new System.EventHandler(this.txtSasia_Validated);
            // 
            // txtTitulli
            // 
            this.txtTitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulli.Location = new System.Drawing.Point(845, 431);
            this.txtTitulli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.ReadOnly = true;
            this.txtTitulli.Size = new System.Drawing.Size(547, 27);
            this.txtTitulli.TabIndex = 1;
            // 
            // txtBarkodi
            // 
            this.txtBarkodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodi.Location = new System.Drawing.Point(845, 400);
            this.txtBarkodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkodi.Name = "txtBarkodi";
            this.txtBarkodi.ReadOnly = true;
            this.txtBarkodi.Size = new System.Drawing.Size(163, 27);
            this.txtBarkodi.TabIndex = 0;
            // 
            // lblSasia
            // 
            this.lblSasia.AutoSize = true;
            this.lblSasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSasia.Location = new System.Drawing.Point(784, 465);
            this.lblSasia.Name = "lblSasia";
            this.lblSasia.Size = new System.Drawing.Size(56, 20);
            this.lblSasia.TabIndex = 77;
            this.lblSasia.Text = "Sasia:";
            // 
            // lblQmimi
            // 
            this.lblQmimi.AutoSize = true;
            this.lblQmimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQmimi.Location = new System.Drawing.Point(777, 496);
            this.lblQmimi.Name = "lblQmimi";
            this.lblQmimi.Size = new System.Drawing.Size(62, 20);
            this.lblQmimi.TabIndex = 76;
            this.lblQmimi.Text = "Çmimi:";
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulli.Location = new System.Drawing.Point(785, 434);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(54, 20);
            this.lblTitulli.TabIndex = 75;
            this.lblTitulli.Text = "Titulli:";
            // 
            // lblBarkodi
            // 
            this.lblBarkodi.AutoSize = true;
            this.lblBarkodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarkodi.Location = new System.Drawing.Point(769, 402);
            this.lblBarkodi.Name = "lblBarkodi";
            this.lblBarkodi.Size = new System.Drawing.Size(71, 20);
            this.lblBarkodi.TabIndex = 74;
            this.lblBarkodi.Text = "Barkodi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(772, 75);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(769, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Data:";
            // 
            // cboBleresi
            // 
            this.cboBleresi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBleresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBleresi.FormattingEnabled = true;
            this.cboBleresi.Location = new System.Drawing.Point(1105, 69);
            this.cboBleresi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBleresi.Name = "cboBleresi";
            this.cboBleresi.Size = new System.Drawing.Size(285, 28);
            this.cboBleresi.TabIndex = 69;
            // 
            // lblBleresi
            // 
            this.lblBleresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBleresi.Location = new System.Drawing.Point(1107, 43);
            this.lblBleresi.Name = "lblBleresi";
            this.lblBleresi.Size = new System.Drawing.Size(285, 23);
            this.lblBleresi.TabIndex = 70;
            this.lblBleresi.Text = "Blerësi:";
            this.lblBleresi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitulli,
            this.ColumnLibriId,
            this.ColumnBarkodi,
            this.ColumnSasia,
            this.ColumnQmimi});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(17, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 417);
            this.dataGridView1.TabIndex = 65;
            // 
            // ColumnTitulli
            // 
            this.ColumnTitulli.DataPropertyName = "titulli";
            this.ColumnTitulli.HeaderText = "Titulli";
            this.ColumnTitulli.Name = "ColumnTitulli";
            this.ColumnTitulli.ReadOnly = true;
            // 
            // ColumnLibriId
            // 
            this.ColumnLibriId.DataPropertyName = "libriId";
            this.ColumnLibriId.HeaderText = "LibriId";
            this.ColumnLibriId.Name = "ColumnLibriId";
            this.ColumnLibriId.ReadOnly = true;
            this.ColumnLibriId.Visible = false;
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
            // txtKerkimi
            // 
            this.txtKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkimi.Location = new System.Drawing.Point(177, 69);
            this.txtKerkimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKerkimi.Name = "txtKerkimi";
            this.txtKerkimi.Size = new System.Drawing.Size(301, 26);
            this.txtKerkimi.TabIndex = 63;
            // 
            // cboKerkimiSipas
            // 
            this.cboKerkimiSipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKerkimiSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKerkimiSipas.FormattingEnabled = true;
            this.cboKerkimiSipas.Location = new System.Drawing.Point(17, 69);
            this.cboKerkimiSipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKerkimiSipas.Name = "cboKerkimiSipas";
            this.cboKerkimiSipas.Size = new System.Drawing.Size(153, 28);
            this.cboKerkimiSipas.TabIndex = 62;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(17, 36);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(119, 24);
            this.chkKerkoSipas.TabIndex = 66;
            this.chkKerkoSipas.Text = "Kërko sipas";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1213, 491);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 34);
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Libraria.Properties.Resources.Clear_Image;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(667, 340);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "Fshije";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Libraria.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1016, 490);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 34);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Ruaje Faturën";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Libraria.Properties.Resources.btnAddNewItem_Image;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(667, 299);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 34);
            this.btnNew.TabIndex = 83;
            this.btnNew.Text = "Shto";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLexoShenimet
            // 
            this.btnLexoShenimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexoShenimet.Image = global::Libraria.Properties.Resources.Find_5650_32;
            this.btnLexoShenimet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLexoShenimet.Location = new System.Drawing.Point(485, 66);
            this.btnLexoShenimet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLexoShenimet.Name = "btnLexoShenimet";
            this.btnLexoShenimet.Size = new System.Drawing.Size(176, 32);
            this.btnLexoShenimet.TabIndex = 64;
            this.btnLexoShenimet.Text = "Kërko Librin";
            this.btnLexoShenimet.UseVisualStyleBackColor = true;
            this.btnLexoShenimet.Click += new System.EventHandler(this.btnLexoShenimet_Click);
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1409, 542);
            this.Controls.Add(this.txtVleraFatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMenyraPageses);
            this.Controls.Add(this.lblgjinia);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtQmimi);
            this.Controls.Add(this.txtSasia);
            this.Controls.Add(this.txtTitulli);
            this.Controls.Add(this.txtBarkodi);
            this.Controls.Add(this.lblSasia);
            this.Controls.Add(this.lblQmimi);
            this.Controls.Add(this.lblTitulli);
            this.Controls.Add(this.lblBarkodi);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBleresi);
            this.Controls.Add(this.lblBleresi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKerkimi);
            this.Controls.Add(this.cboKerkimiSipas);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnLexoShenimet);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmFatura";
            this.Text = "Shitja - Faturat Dalëse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFatura_FormClosing);
            this.Load += new System.EventHandler(this.frmFaturaD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKerkimi;
        private System.Windows.Forms.ComboBox cboKerkimiSipas;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.Button btnLexoShenimet;
        private System.Windows.Forms.ComboBox cboBleresi;
        private System.Windows.Forms.Label lblBleresi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblBarkodi;
        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.Label lblQmimi;
        private System.Windows.Forms.Label lblSasia;
        private System.Windows.Forms.TextBox txtBarkodi;
        private System.Windows.Forms.TextBox txtTitulli;
        private System.Windows.Forms.TextBox txtSasia;
        private System.Windows.Forms.TextBox txtQmimi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLibriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarkodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQmimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulli1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLibriId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarkodi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSasia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQmimi1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.ComboBox cboMenyraPageses;
        private System.Windows.Forms.Label lblgjinia;
        private System.Windows.Forms.TextBox txtVleraFatures;
        private System.Windows.Forms.Label label2;
    }
}