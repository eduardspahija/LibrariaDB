using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

using System.Globalization;
namespace Libraria
{
    public partial class frmShtepiteBotuese : BaseForm
    {
        OracleConnection conn;

        public frmShtepiteBotuese()
        {
            InitializeComponent();
        }

        private void ShtepiteBotuese_Load(object sender, EventArgs e)
        {
            conn = CreateConnection();


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToAddRows = false;

            cboKerkimiSipas.DisplayMember = "Text";
            cboKerkimiSipas.ValueMember = "Value";
            var itemsKerkimi = new[] {
                new {Text = "Emrit", Value = 0},
                new {Text = "Vendit", Value = 1}
                };
            cboKerkimiSipas.DataSource = itemsKerkimi;

            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);

            txtid.DataBindings.Add("Text", bindingSource1, "botuesiId");
            txtBotuesi.DataBindings.Add("Text", bindingSource1, "botuesi_emri");
            txtVendi.DataBindings.Add("Text", bindingSource1, "vendi");
        }

        private void LoadData(OracleConnection conn1, bool KrejtShenimet, int KerkimiSipas)
        {
            if (KrejtShenimet || txtKerkimi.Text.Trim() != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn1;
                cmd.CommandType = CommandType.Text;

                String sKerkimi;
                if (KrejtShenimet == true)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT * from botuesi";

                }
                else

                if (KerkimiSipas == 0)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT * from botuesi where lower(botuesi_emri) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 1)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT * from botuesi where lower(vendi) like '%" + sKerkimi + "%'";
                }

                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    bindingSource1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            txtBotuesi.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sBotuesi = txtBotuesi.Text.Trim();
            string sVendi = txtVendi.Text.Trim();

            if (sBotuesi != "")
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int lBotuesiId;
                if (txtid.Text != "")
                    lBotuesiId = Convert.ToInt32(txtid.Text);
                else
                    lBotuesiId = 0;
                if (lBotuesiId == 0)

                    cmd.CommandText = "INSERT INTO Botuesi (botuesi_emri, vendi) Values ('" + sBotuesi + "', '" + sVendi + "')";
                else
                {
                    cmd.CommandText = "UPDATE botuesi SET botuesi_emri = '" + sBotuesi + "', vendi = '" + sVendi + "'" +
                                                             " where botuesiId = '" + lBotuesiId.ToString() + "'";
                    
                }
                try
                {
                    conn.Open();
                    int recordsAffected = cmd.ExecuteNonQuery();
                    if (recordsAffected == 0)
                        MessageBox.Show("Të dhënat nuk u ruajtën!");
                    else
                    {
                        MessageBox.Show("Të dhënat u ruajtën me sukses!");
                        cboKerkimiSipas.SelectedValue = 0;
                        txtKerkimi.Text = sBotuesi;
                        LoadData(conn, !chkKerkoSipas.Checked, 0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
                MessageBox.Show("Të dhënat jovalide!", "Verejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLexoShenimet_Click(object sender, EventArgs e)
        {
            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
        }

        private void frmShtepiteBotuese_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
