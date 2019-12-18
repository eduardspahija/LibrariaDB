namespace Libraria
{
    partial class frmPunetoret
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNrPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQyteti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmailAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPozita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPersoni = new System.Windows.Forms.ComboBox();
            this.txtKerkimi = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboKerkimiSipas = new System.Windows.Forms.ComboBox();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.btnLexoShenimet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblpozita = new System.Windows.Forms.Label();
            this.lblpersoni = new System.Windows.Forms.Label();
            this.lblpuntorid = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpozita = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cboMenaxheri = new System.Windows.Forms.ComboBox();
            this.lblMenaxheri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.Location = new System.Drawing.Point(939, 306);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(173, 20);
            this.lblconfirmpassword.TabIndex = 64;
            this.lblconfirmpassword.Text = "Konfirmo Passwordin:";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(1145, 304);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(191, 26);
            this.txtconfirmpassword.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Libraria.Properties.Resources.btnAddNewItem_Image;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(1145, 418);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(189, 34);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Shto Punëtorin";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.ColumnEmailAdresa,
            this.ColumnPozita,
            this.ColumnUserName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 457);
            this.dataGridView1.TabIndex = 60;
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
            // ColumnPozita
            // 
            this.ColumnPozita.DataPropertyName = "pozita";
            this.ColumnPozita.HeaderText = "Pozita";
            this.ColumnPozita.Name = "ColumnPozita";
            this.ColumnPozita.ReadOnly = true;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.DataPropertyName = "userName";
            this.ColumnUserName.HeaderText = "User Name";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            // 
            // cboPersoni
            // 
            this.cboPersoni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPersoni.FormattingEnabled = true;
            this.cboPersoni.Location = new System.Drawing.Point(1145, 134);
            this.cboPersoni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPersoni.Name = "cboPersoni";
            this.cboPersoni.Size = new System.Drawing.Size(191, 28);
            this.cboPersoni.TabIndex = 1;
            // 
            // txtKerkimi
            // 
            this.txtKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkimi.Location = new System.Drawing.Point(325, 52);
            this.txtKerkimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKerkimi.Name = "txtKerkimi";
            this.txtKerkimi.Size = new System.Drawing.Size(279, 26);
            this.txtKerkimi.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1145, 514);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboKerkimiSipas
            // 
            this.cboKerkimiSipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKerkimiSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKerkimiSipas.FormattingEnabled = true;
            this.cboKerkimiSipas.Location = new System.Drawing.Point(23, 50);
            this.cboKerkimiSipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKerkimiSipas.Name = "cboKerkimiSipas";
            this.cboKerkimiSipas.Size = new System.Drawing.Size(293, 28);
            this.cboKerkimiSipas.TabIndex = 9;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(23, 2);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(119, 24);
            this.chkKerkoSipas.TabIndex = 61;
            this.chkKerkoSipas.Text = "Kërko sipas";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
            // 
            // btnLexoShenimet
            // 
            this.btnLexoShenimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexoShenimet.Image = global::Libraria.Properties.Resources.Find_5650_32;
            this.btnLexoShenimet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLexoShenimet.Location = new System.Drawing.Point(611, 44);
            this.btnLexoShenimet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLexoShenimet.Name = "btnLexoShenimet";
            this.btnLexoShenimet.Size = new System.Drawing.Size(313, 34);
            this.btnLexoShenimet.TabIndex = 11;
            this.btnLexoShenimet.Text = "Lexo Shënimet nga Serveri";
            this.btnLexoShenimet.UseVisualStyleBackColor = true;
            this.btnLexoShenimet.Click += new System.EventHandler(this.btnLexoShenimet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Libraria.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1145, 459);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Ruaje Punëtorin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(1013, 225);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(99, 20);
            this.lblusername.TabIndex = 56;
            this.lblusername.Text = "User Name:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(1020, 267);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(92, 20);
            this.lblpassword.TabIndex = 53;
            this.lblpassword.Text = "Passwordi:";
            // 
            // lblpozita
            // 
            this.lblpozita.AutoSize = true;
            this.lblpozita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpozita.Location = new System.Drawing.Point(987, 179);
            this.lblpozita.Name = "lblpozita";
            this.lblpozita.Size = new System.Drawing.Size(125, 20);
            this.lblpozita.TabIndex = 51;
            this.lblpozita.Text = "Pozita në punë:";
            // 
            // lblpersoni
            // 
            this.lblpersoni.AutoSize = true;
            this.lblpersoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersoni.Location = new System.Drawing.Point(980, 137);
            this.lblpersoni.Name = "lblpersoni";
            this.lblpersoni.Size = new System.Drawing.Size(132, 20);
            this.lblpersoni.TabIndex = 50;
            this.lblpersoni.Text = "Zgjedh personin:";
            // 
            // lblpuntorid
            // 
            this.lblpuntorid.AutoSize = true;
            this.lblpuntorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntorid.Location = new System.Drawing.Point(1081, 97);
            this.lblpuntorid.Name = "lblpuntorid";
            this.lblpuntorid.Size = new System.Drawing.Size(31, 20);
            this.lblpuntorid.TabIndex = 45;
            this.lblpuntorid.Text = "ID:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(1145, 220);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(191, 26);
            this.txtusername.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(1145, 92);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(191, 26);
            this.txtid.TabIndex = 0;
            // 
            // txtpozita
            // 
            this.txtpozita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpozita.Location = new System.Drawing.Point(1145, 178);
            this.txtpozita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpozita.Name = "txtpozita";
            this.txtpozita.Size = new System.Drawing.Size(191, 26);
            this.txtpozita.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(1145, 262);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(191, 26);
            this.txtpassword.TabIndex = 4;
            // 
            // cboMenaxheri
            // 
            this.cboMenaxheri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenaxheri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenaxheri.FormattingEnabled = true;
            this.cboMenaxheri.Location = new System.Drawing.Point(1145, 351);
            this.cboMenaxheri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMenaxheri.Name = "cboMenaxheri";
            this.cboMenaxheri.Size = new System.Drawing.Size(191, 28);
            this.cboMenaxheri.TabIndex = 65;
            // 
            // lblMenaxheri
            // 
            this.lblMenaxheri.AutoSize = true;
            this.lblMenaxheri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenaxheri.Location = new System.Drawing.Point(958, 354);
            this.lblMenaxheri.Name = "lblMenaxheri";
            this.lblMenaxheri.Size = new System.Drawing.Size(154, 20);
            this.lblMenaxheri.TabIndex = 66;
            this.lblMenaxheri.Text = "Zgjedh Menaxherin:";
            // 
            // frmPunetoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1355, 570);
            this.Controls.Add(this.cboMenaxheri);
            this.Controls.Add(this.lblMenaxheri);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboPersoni);
            this.Controls.Add(this.txtKerkimi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboKerkimiSipas);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnLexoShenimet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblpozita);
            this.Controls.Add(this.lblpersoni);
            this.Controls.Add(this.lblpuntorid);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtpozita);
            this.Controls.Add(this.txtpassword);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmPunetoret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPunetoret";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPunetoret_FormClosing);
            this.Load += new System.EventHandler(this.frmPunetoret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboPersoni;
        private System.Windows.Forms.TextBox txtKerkimi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboKerkimiSipas;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.Button btnLexoShenimet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblpozita;
        private System.Windows.Forms.Label lblpersoni;
        private System.Windows.Forms.Label lblpuntorid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpozita;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQyteti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmailAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPozita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.ComboBox cboMenaxheri;
        private System.Windows.Forms.Label lblMenaxheri;
    }
}