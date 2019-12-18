namespace Libraria
{
    partial class frmPersonat
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
            this.txtKerkimi = new System.Windows.Forms.TextBox();
            this.cboKerkimiSipas = new System.Windows.Forms.ComboBox();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNrPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQyteti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmailAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboGjinia = new System.Windows.Forms.ComboBox();
            this.lblqyteti = new System.Windows.Forms.Label();
            this.lblshteti = new System.Windows.Forms.Label();
            this.lblkodipostal = new System.Windows.Forms.Label();
            this.txtkodipostal = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblemri = new System.Windows.Forms.Label();
            this.lblpersonmbiemri = new System.Windows.Forms.Label();
            this.lbladresa = new System.Windows.Forms.Label();
            this.lbltelefoni = new System.Windows.Forms.Label();
            this.lblgjinia = new System.Windows.Forms.Label();
            this.lblnrpersonal = new System.Windows.Forms.Label();
            this.lblpersonid = new System.Windows.Forms.Label();
            this.txtshteti = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtemri = new System.Windows.Forms.TextBox();
            this.txtmbiemri = new System.Windows.Forms.TextBox();
            this.txttelefoni = new System.Windows.Forms.TextBox();
            this.txtnrpersonal = new System.Windows.Forms.TextBox();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.txtqyteti = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLexoShenimet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKerkimi
            // 
            this.txtKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkimi.Location = new System.Drawing.Point(268, 69);
            this.txtKerkimi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKerkimi.Name = "txtKerkimi";
            this.txtKerkimi.Size = new System.Drawing.Size(241, 23);
            this.txtKerkimi.TabIndex = 14;
            // 
            // cboKerkimiSipas
            // 
            this.cboKerkimiSipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKerkimiSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKerkimiSipas.FormattingEnabled = true;
            this.cboKerkimiSipas.Location = new System.Drawing.Point(17, 67);
            this.cboKerkimiSipas.Margin = new System.Windows.Forms.Padding(2);
            this.cboKerkimiSipas.Name = "cboKerkimiSipas";
            this.cboKerkimiSipas.Size = new System.Drawing.Size(241, 24);
            this.cboKerkimiSipas.TabIndex = 13;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(17, 28);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(101, 21);
            this.chkKerkoSipas.TabIndex = 30;
            this.chkKerkoSipas.Text = "Kërko sipas";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
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
            this.ColumnPersonId,
            this.ColumnEmri,
            this.ColumnMbiemri,
            this.ColumnNrPersonal,
            this.ColumnAdresa,
            this.ColumnQyteti,
            this.ColumnTelefoni,
            this.ColumnEmailAdresa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 371);
            this.dataGridView1.TabIndex = 26;
            // 
            // ColumnPersonId
            // 
            this.ColumnPersonId.DataPropertyName = "PersonId";
            this.ColumnPersonId.HeaderText = "PersonId";
            this.ColumnPersonId.Name = "ColumnPersonId";
            this.ColumnPersonId.ReadOnly = true;
            this.ColumnPersonId.Visible = false;
            // 
            // ColumnEmri
            // 
            this.ColumnEmri.DataPropertyName = "emri";
            this.ColumnEmri.HeaderText = "Emri";
            this.ColumnEmri.Name = "ColumnEmri";
            this.ColumnEmri.ReadOnly = true;
            // 
            // ColumnMbiemri
            // 
            this.ColumnMbiemri.DataPropertyName = "mbiemri";
            this.ColumnMbiemri.HeaderText = "Mbiemri";
            this.ColumnMbiemri.Name = "ColumnMbiemri";
            this.ColumnMbiemri.ReadOnly = true;
            // 
            // ColumnNrPersonal
            // 
            this.ColumnNrPersonal.DataPropertyName = "nr_personal";
            this.ColumnNrPersonal.HeaderText = "NrPersonal";
            this.ColumnNrPersonal.Name = "ColumnNrPersonal";
            this.ColumnNrPersonal.ReadOnly = true;
            // 
            // ColumnAdresa
            // 
            this.ColumnAdresa.DataPropertyName = "adresa";
            this.ColumnAdresa.HeaderText = "Adresa";
            this.ColumnAdresa.Name = "ColumnAdresa";
            this.ColumnAdresa.ReadOnly = true;
            // 
            // ColumnQyteti
            // 
            this.ColumnQyteti.DataPropertyName = "qyteti";
            this.ColumnQyteti.HeaderText = "Qyteti";
            this.ColumnQyteti.Name = "ColumnQyteti";
            this.ColumnQyteti.ReadOnly = true;
            // 
            // ColumnTelefoni
            // 
            this.ColumnTelefoni.DataPropertyName = "telefoni";
            this.ColumnTelefoni.HeaderText = "Telefoni";
            this.ColumnTelefoni.Name = "ColumnTelefoni";
            this.ColumnTelefoni.ReadOnly = true;
            // 
            // ColumnEmailAdresa
            // 
            this.ColumnEmailAdresa.DataPropertyName = "email";
            this.ColumnEmailAdresa.HeaderText = "Email Adresa";
            this.ColumnEmailAdresa.Name = "ColumnEmailAdresa";
            this.ColumnEmailAdresa.ReadOnly = true;
            // 
            // cboGjinia
            // 
            this.cboGjinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGjinia.FormattingEnabled = true;
            this.cboGjinia.Location = new System.Drawing.Point(847, 170);
            this.cboGjinia.Margin = new System.Windows.Forms.Padding(2);
            this.cboGjinia.Name = "cboGjinia";
            this.cboGjinia.Size = new System.Drawing.Size(38, 24);
            this.cboGjinia.TabIndex = 4;
            // 
            // lblqyteti
            // 
            this.lblqyteti.AutoSize = true;
            this.lblqyteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqyteti.Location = new System.Drawing.Point(792, 275);
            this.lblqyteti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblqyteti.Name = "lblqyteti";
            this.lblqyteti.Size = new System.Drawing.Size(49, 17);
            this.lblqyteti.TabIndex = 24;
            this.lblqyteti.Text = "Qyteti:";
            // 
            // lblshteti
            // 
            this.lblshteti.AutoSize = true;
            this.lblshteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshteti.Location = new System.Drawing.Point(793, 325);
            this.lblshteti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblshteti.Name = "lblshteti";
            this.lblshteti.Size = new System.Drawing.Size(48, 17);
            this.lblshteti.TabIndex = 23;
            this.lblshteti.Text = "Shteti:";
            // 
            // lblkodipostal
            // 
            this.lblkodipostal.AutoSize = true;
            this.lblkodipostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkodipostal.Location = new System.Drawing.Point(763, 300);
            this.lblkodipostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkodipostal.Name = "lblkodipostal";
            this.lblkodipostal.Size = new System.Drawing.Size(82, 17);
            this.lblkodipostal.TabIndex = 22;
            this.lblkodipostal.Text = "Kodi postal:";
            // 
            // txtkodipostal
            // 
            this.txtkodipostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkodipostal.Location = new System.Drawing.Point(847, 297);
            this.txtkodipostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtkodipostal.Name = "txtkodipostal";
            this.txtkodipostal.Size = new System.Drawing.Size(144, 23);
            this.txtkodipostal.TabIndex = 9;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(752, 224);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(94, 17);
            this.lblemail.TabIndex = 20;
            this.lblemail.Text = "Email adresa:";
            // 
            // lblemri
            // 
            this.lblemri.AutoSize = true;
            this.lblemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemri.Location = new System.Drawing.Point(799, 98);
            this.lblemri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemri.Name = "lblemri";
            this.lblemri.Size = new System.Drawing.Size(40, 17);
            this.lblemri.TabIndex = 19;
            this.lblemri.Text = "Emri:";
            // 
            // lblpersonmbiemri
            // 
            this.lblpersonmbiemri.AutoSize = true;
            this.lblpersonmbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonmbiemri.Location = new System.Drawing.Point(780, 122);
            this.lblpersonmbiemri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpersonmbiemri.Name = "lblpersonmbiemri";
            this.lblpersonmbiemri.Size = new System.Drawing.Size(61, 17);
            this.lblpersonmbiemri.TabIndex = 18;
            this.lblpersonmbiemri.Text = "Mbiemri:";
            // 
            // lbladresa
            // 
            this.lbladresa.AutoSize = true;
            this.lbladresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladresa.Location = new System.Drawing.Point(785, 249);
            this.lbladresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladresa.Name = "lbladresa";
            this.lbladresa.Size = new System.Drawing.Size(57, 17);
            this.lbladresa.TabIndex = 16;
            this.lbladresa.Text = "Adresa:";
            // 
            // lbltelefoni
            // 
            this.lbltelefoni.AutoSize = true;
            this.lbltelefoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefoni.Location = new System.Drawing.Point(781, 199);
            this.lbltelefoni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefoni.Name = "lbltelefoni";
            this.lbltelefoni.Size = new System.Drawing.Size(63, 17);
            this.lbltelefoni.TabIndex = 15;
            this.lbltelefoni.Text = "Telefoni:";
            // 
            // lblgjinia
            // 
            this.lblgjinia.AutoSize = true;
            this.lblgjinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgjinia.Location = new System.Drawing.Point(793, 171);
            this.lblgjinia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgjinia.Name = "lblgjinia";
            this.lblgjinia.Size = new System.Drawing.Size(48, 17);
            this.lblgjinia.TabIndex = 14;
            this.lblgjinia.Text = "Gjinia:";
            // 
            // lblnrpersonal
            // 
            this.lblnrpersonal.AutoSize = true;
            this.lblnrpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnrpersonal.Location = new System.Drawing.Point(760, 146);
            this.lblnrpersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnrpersonal.Name = "lblnrpersonal";
            this.lblnrpersonal.Size = new System.Drawing.Size(86, 17);
            this.lblnrpersonal.TabIndex = 13;
            this.lblnrpersonal.Text = "Nr.personal:";
            // 
            // lblpersonid
            // 
            this.lblpersonid.AutoSize = true;
            this.lblpersonid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonid.Location = new System.Drawing.Point(812, 72);
            this.lblpersonid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpersonid.Name = "lblpersonid";
            this.lblpersonid.Size = new System.Drawing.Size(25, 17);
            this.lblpersonid.TabIndex = 12;
            this.lblpersonid.Text = "ID:";
            // 
            // txtshteti
            // 
            this.txtshteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshteti.Location = new System.Drawing.Point(847, 323);
            this.txtshteti.Margin = new System.Windows.Forms.Padding(2);
            this.txtshteti.Name = "txtshteti";
            this.txtshteti.Size = new System.Drawing.Size(144, 23);
            this.txtshteti.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(847, 222);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(144, 23);
            this.txtemail.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(847, 69);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 23);
            this.txtid.TabIndex = 0;
            // 
            // txtemri
            // 
            this.txtemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemri.Location = new System.Drawing.Point(847, 94);
            this.txtemri.Margin = new System.Windows.Forms.Padding(2);
            this.txtemri.Name = "txtemri";
            this.txtemri.Size = new System.Drawing.Size(144, 23);
            this.txtemri.TabIndex = 1;
            this.txtemri.Validated += new System.EventHandler(this.txtemri_Validated);
            // 
            // txtmbiemri
            // 
            this.txtmbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmbiemri.Location = new System.Drawing.Point(847, 119);
            this.txtmbiemri.Margin = new System.Windows.Forms.Padding(2);
            this.txtmbiemri.Name = "txtmbiemri";
            this.txtmbiemri.Size = new System.Drawing.Size(144, 23);
            this.txtmbiemri.TabIndex = 2;
            this.txtmbiemri.Validated += new System.EventHandler(this.txtmbiemri_Validated);
            // 
            // txttelefoni
            // 
            this.txttelefoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefoni.Location = new System.Drawing.Point(847, 197);
            this.txttelefoni.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefoni.Name = "txttelefoni";
            this.txttelefoni.Size = new System.Drawing.Size(144, 23);
            this.txttelefoni.TabIndex = 5;
            // 
            // txtnrpersonal
            // 
            this.txtnrpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrpersonal.Location = new System.Drawing.Point(847, 145);
            this.txtnrpersonal.Margin = new System.Windows.Forms.Padding(2);
            this.txtnrpersonal.Name = "txtnrpersonal";
            this.txtnrpersonal.Size = new System.Drawing.Size(144, 23);
            this.txtnrpersonal.TabIndex = 3;
            // 
            // txtadresa
            // 
            this.txtadresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadresa.Location = new System.Drawing.Point(847, 247);
            this.txtadresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(144, 23);
            this.txtadresa.TabIndex = 7;
            // 
            // txtqyteti
            // 
            this.txtqyteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqyteti.Location = new System.Drawing.Point(847, 272);
            this.txtqyteti.Margin = new System.Windows.Forms.Padding(2);
            this.txtqyteti.Name = "txtqyteti";
            this.txtqyteti.Size = new System.Drawing.Size(144, 23);
            this.txtqyteti.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(847, 444);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 28);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLexoShenimet
            // 
            this.btnLexoShenimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexoShenimet.Image = global::Libraria.Properties.Resources.Find_5650_32;
            this.btnLexoShenimet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLexoShenimet.Location = new System.Drawing.Point(513, 66);
            this.btnLexoShenimet.Margin = new System.Windows.Forms.Padding(2);
            this.btnLexoShenimet.Name = "btnLexoShenimet";
            this.btnLexoShenimet.Size = new System.Drawing.Size(234, 28);
            this.btnLexoShenimet.TabIndex = 15;
            this.btnLexoShenimet.Text = "Lexo Shënimet nga Serveri";
            this.btnLexoShenimet.UseVisualStyleBackColor = true;
            this.btnLexoShenimet.Click += new System.EventHandler(this.btnLexoShenimet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Libraria.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(847, 399);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Ruaje Personin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Libraria.Properties.Resources.btnAddNewItem_Image;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(847, 366);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(142, 28);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Shto Personin";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmPersonat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1000, 482);
            this.Controls.Add(this.txtKerkimi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboKerkimiSipas);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnLexoShenimet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboGjinia);
            this.Controls.Add(this.lblqyteti);
            this.Controls.Add(this.lblshteti);
            this.Controls.Add(this.lblkodipostal);
            this.Controls.Add(this.txtkodipostal);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblemri);
            this.Controls.Add(this.lblpersonmbiemri);
            this.Controls.Add(this.lbladresa);
            this.Controls.Add(this.lbltelefoni);
            this.Controls.Add(this.lblgjinia);
            this.Controls.Add(this.lblnrpersonal);
            this.Controls.Add(this.lblpersonid);
            this.Controls.Add(this.txtshteti);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtemri);
            this.Controls.Add(this.txtmbiemri);
            this.Controls.Add(this.txttelefoni);
            this.Controls.Add(this.txtnrpersonal);
            this.Controls.Add(this.txtadresa);
            this.Controls.Add(this.txtqyteti);
            this.MaximizeBox = false;
            this.Name = "frmPersonat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonat_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtqyteti;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.TextBox txtnrpersonal;
        private System.Windows.Forms.TextBox txttelefoni;
        private System.Windows.Forms.TextBox txtmbiemri;
        private System.Windows.Forms.TextBox txtemri;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtshteti;
        private System.Windows.Forms.Label lblpersonid;
        private System.Windows.Forms.Label lblnrpersonal;
        private System.Windows.Forms.Label lblgjinia;
        private System.Windows.Forms.Label lbltelefoni;
        private System.Windows.Forms.Label lbladresa;
        private System.Windows.Forms.Label lblpersonmbiemri;
        private System.Windows.Forms.Label lblemri;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtkodipostal;
        private System.Windows.Forms.Label lblkodipostal;
        private System.Windows.Forms.Label lblshteti;
        private System.Windows.Forms.Label lblqyteti;
        private System.Windows.Forms.ComboBox cboGjinia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLexoShenimet;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.ComboBox cboKerkimiSipas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQyteti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmailAdresa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtKerkimi;
    }
}