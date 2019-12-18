namespace Libraria
{
    partial class frmShtepiteBotuese
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnBotuesiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbotuesi_emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboKerkimiSipas = new System.Windows.Forms.ComboBox();
            this.chkKerkoSipas = new System.Windows.Forms.CheckBox();
            this.txtKerkimi = new System.Windows.Forms.TextBox();
            this.lblBotuesi = new System.Windows.Forms.Label();
            this.lblVendi = new System.Windows.Forms.Label();
            this.lblbotuesiId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtBotuesi = new System.Windows.Forms.TextBox();
            this.txtVendi = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLexoShenimet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.ColumnBotuesiId,
            this.Columnbotuesi_emri,
            this.ColumnVendi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 299);
            this.dataGridView1.TabIndex = 60;
            // 
            // ColumnBotuesiId
            // 
            this.ColumnBotuesiId.DataPropertyName = "BotuesiId";
            this.ColumnBotuesiId.HeaderText = "Botuesi ID";
            this.ColumnBotuesiId.Name = "ColumnBotuesiId";
            this.ColumnBotuesiId.ReadOnly = true;
            this.ColumnBotuesiId.Visible = false;
            // 
            // Columnbotuesi_emri
            // 
            this.Columnbotuesi_emri.DataPropertyName = "botuesi_emri";
            this.Columnbotuesi_emri.HeaderText = "Botuesi";
            this.Columnbotuesi_emri.Name = "Columnbotuesi_emri";
            this.Columnbotuesi_emri.ReadOnly = true;
            // 
            // ColumnVendi
            // 
            this.ColumnVendi.DataPropertyName = "vendi";
            this.ColumnVendi.HeaderText = "Vendi";
            this.ColumnVendi.Name = "ColumnVendi";
            this.ColumnVendi.ReadOnly = true;
            // 
            // cboKerkimiSipas
            // 
            this.cboKerkimiSipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKerkimiSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKerkimiSipas.FormattingEnabled = true;
            this.cboKerkimiSipas.Location = new System.Drawing.Point(11, 32);
            this.cboKerkimiSipas.Margin = new System.Windows.Forms.Padding(2);
            this.cboKerkimiSipas.Name = "cboKerkimiSipas";
            this.cboKerkimiSipas.Size = new System.Drawing.Size(241, 24);
            this.cboKerkimiSipas.TabIndex = 48;
            // 
            // chkKerkoSipas
            // 
            this.chkKerkoSipas.AutoSize = true;
            this.chkKerkoSipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKerkoSipas.Location = new System.Drawing.Point(11, 8);
            this.chkKerkoSipas.Margin = new System.Windows.Forms.Padding(2);
            this.chkKerkoSipas.Name = "chkKerkoSipas";
            this.chkKerkoSipas.Size = new System.Drawing.Size(101, 21);
            this.chkKerkoSipas.TabIndex = 61;
            this.chkKerkoSipas.Text = "Kërko sipas";
            this.chkKerkoSipas.UseVisualStyleBackColor = true;
            // 
            // txtKerkimi
            // 
            this.txtKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkimi.Location = new System.Drawing.Point(262, 34);
            this.txtKerkimi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKerkimi.Name = "txtKerkimi";
            this.txtKerkimi.Size = new System.Drawing.Size(241, 23);
            this.txtKerkimi.TabIndex = 50;
            // 
            // lblBotuesi
            // 
            this.lblBotuesi.AutoSize = true;
            this.lblBotuesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotuesi.Location = new System.Drawing.Point(509, 125);
            this.lblBotuesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBotuesi.Name = "lblBotuesi";
            this.lblBotuesi.Size = new System.Drawing.Size(115, 17);
            this.lblBotuesi.TabIndex = 55;
            this.lblBotuesi.Text = "Shtëpia botuese:";
            // 
            // lblVendi
            // 
            this.lblVendi.AutoSize = true;
            this.lblVendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendi.Location = new System.Drawing.Point(568, 150);
            this.lblVendi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendi.Name = "lblVendi";
            this.lblVendi.Size = new System.Drawing.Size(48, 17);
            this.lblVendi.TabIndex = 54;
            this.lblVendi.Text = "Vendi:";
            // 
            // lblbotuesiId
            // 
            this.lblbotuesiId.AutoSize = true;
            this.lblbotuesiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbotuesiId.Location = new System.Drawing.Point(586, 99);
            this.lblbotuesiId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbotuesiId.Name = "lblbotuesiId";
            this.lblbotuesiId.Size = new System.Drawing.Size(25, 17);
            this.lblbotuesiId.TabIndex = 45;
            this.lblbotuesiId.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(626, 97);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 23);
            this.txtid.TabIndex = 33;
            // 
            // txtBotuesi
            // 
            this.txtBotuesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBotuesi.Location = new System.Drawing.Point(626, 122);
            this.txtBotuesi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBotuesi.Name = "txtBotuesi";
            this.txtBotuesi.Size = new System.Drawing.Size(144, 23);
            this.txtBotuesi.TabIndex = 34;
            // 
            // txtVendi
            // 
            this.txtVendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendi.Location = new System.Drawing.Point(626, 147);
            this.txtVendi.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendi.Name = "txtVendi";
            this.txtVendi.Size = new System.Drawing.Size(144, 23);
            this.txtVendi.TabIndex = 35;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Libraria.Properties.Resources.btnClose_Image;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(571, 367);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(197, 28);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Dilni";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLexoShenimet
            // 
            this.btnLexoShenimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexoShenimet.Image = global::Libraria.Properties.Resources.Find_5650_32;
            this.btnLexoShenimet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLexoShenimet.Location = new System.Drawing.Point(11, 60);
            this.btnLexoShenimet.Margin = new System.Windows.Forms.Padding(2);
            this.btnLexoShenimet.Name = "btnLexoShenimet";
            this.btnLexoShenimet.Size = new System.Drawing.Size(491, 28);
            this.btnLexoShenimet.TabIndex = 51;
            this.btnLexoShenimet.Text = "Lexo Shënimet nga Serveri";
            this.btnLexoShenimet.UseVisualStyleBackColor = true;
            this.btnLexoShenimet.Click += new System.EventHandler(this.btnLexoShenimet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Libraria.Properties.Resources.btnSave_Image;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(571, 323);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 28);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Ruaje Shtëpinë Botuese";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Libraria.Properties.Resources.btnAddNewItem_Image;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(571, 289);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(197, 28);
            this.btnNew.TabIndex = 44;
            this.btnNew.Text = "Shto Shtëpinë Botuese";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmShtepiteBotuese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(783, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboKerkimiSipas);
            this.Controls.Add(this.chkKerkoSipas);
            this.Controls.Add(this.btnLexoShenimet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtKerkimi);
            this.Controls.Add(this.lblBotuesi);
            this.Controls.Add(this.lblVendi);
            this.Controls.Add(this.lblbotuesiId);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtBotuesi);
            this.Controls.Add(this.txtVendi);
            this.MaximizeBox = false;
            this.Name = "frmShtepiteBotuese";
            this.Text = "Shtëpitë Botuese";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShtepiteBotuese_FormClosing);
            this.Load += new System.EventHandler(this.ShtepiteBotuese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBotuesiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbotuesi_emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboKerkimiSipas;
        private System.Windows.Forms.CheckBox chkKerkoSipas;
        private System.Windows.Forms.Button btnLexoShenimet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtKerkimi;
        private System.Windows.Forms.Label lblBotuesi;
        private System.Windows.Forms.Label lblVendi;
        private System.Windows.Forms.Label lblbotuesiId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtBotuesi;
        private System.Windows.Forms.TextBox txtVendi;
    }
}