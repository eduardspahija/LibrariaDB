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

namespace Libraria
{
    public partial class frmLibrat : BaseForm
    {
        OracleConnection conn;
        bool Iri;

        public frmLibrat()
        {
            InitializeComponent();
            Iri = false;
        }

        private void frmLibrat_Load(object sender, EventArgs e)
        {
            conn = CreateConnection();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select botuesiId, botuesi_emri from botuesi";

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                cbobotuesi.DataSource = ds.Tables[0].DefaultView;
                cbobotuesi.DisplayMember = "botuesi_emri";
                cbobotuesi.ValueMember = "botuesiId";
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToAddRows = false;

            foreach (DataGridViewColumn gridColumn in dataGridView1.Columns)
            {
                if (gridColumn.Name == "ColumnSasia" || gridColumn.Name == "ColumnQmimi")
                {
                    gridColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Format = gridColumn.Name == "ColumnSasia" ? "N0" : "N2";
                }
            }


            cboKerkimiSipas.DisplayMember = "Text";
            cboKerkimiSipas.ValueMember = "Value";
            var itemsKerkimi = new[] {
                new {Text = "Titullit", Value = 0},
                new {Text = "Barkodit", Value = 1},
                new {Text = "ISBN", Value = 2},
                new {Text = "Kategorise", Value = 3},
                new {Text = "Autorit", Value = 4},
                };
            cboKerkimiSipas.DataSource = itemsKerkimi;

            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);

            txtid.DataBindings.Add("Text", bindingSource1, "libriId");
            txttitulli.DataBindings.Add("Text", bindingSource1, "titulli");
            txtbarkodi.DataBindings.Add("Text", bindingSource1, "barkodi");
            txtisbn.DataBindings.Add("Text", bindingSource1, "isbn");
            txtqmimi.DataBindings.Add("Text", bindingSource1, "qmimi");
            txtsasia.DataBindings.Add("Text", bindingSource1, "sasia");
            cbobotuesi.DataBindings.Add("SelectedValue", bindingSource1, "botuesiId");
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
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                     "from libri l inner join botuesi b on l.botuesiId = b.botuesiId";

                }
                else

                    if (KerkimiSipas == 0)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                     "from libri l inner join botuesi b on l.botuesiId = b.botuesiId where LOWER(l.titulli) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 1)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                     "from libri l inner join botuesi b on l.botuesiId = b.botuesiId where LOWER(l.barkodi) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 2)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                    "from libri l inner join botuesi b on l.botuesiId = b.botuesiId where LOWER(l.isbn) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 3)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                    "from libri l inner join botuesi b on l.botuesiId = b.botuesiId, table(l.kategoria) k where LOWER(k.emri) like '%" + sKerkimi + "%'";

                }
                else if (KerkimiSipas == 4)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi,l.isbn, l.sasia, l.qmimi, b.botuesiId, b.botuesi_emri " +
                    "from libri l inner join botuesi b on l.botuesiId = b.botuesiId, table(l.autori) a where LOWER(a.emri) like '%" + sKerkimi + "%'";

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


        private void btnLexoShenimet_Click(object sender, EventArgs e)
        {
            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
            if (Iri)
            {
                Iri = false;
                return;
            }

            if (bindingSource1.Count != 0)
            { 
            DataRow row = ((DataRowView)bindingSource1.Current).Row;
            int libriId = Convert.ToInt32(row["libriId"]);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT k.emri as kategoria from libri l, table(l.kategoria) k WHERE l.libriid= '" + libriId.ToString() + "'";

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                string sKategoria = "";
                foreach (DataRow data in ds.Tables[0].Rows)

                {
                    sKategoria = sKategoria + data["kategoria"] + ", ";
                }

                sKategoria = sKategoria.Substring(0, (sKategoria.Length - 2));
                txtkategoria.Text = sKategoria;


                cmd.CommandText = "SELECT k.emri as autori from libri l, table(l.autori) k WHERE l.libriid= '" + libriId.ToString() + "'";

                OracleDataAdapter oda1 = new OracleDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                oda1.Fill(ds1);
                if (ds1.Tables.Count > 0)
                {
                    string sAutori = "";
                    foreach (DataRow data in ds1.Tables[0].Rows)

                    {
                        sAutori = sAutori + data["autori"] + ", ";
                    }
                    sAutori = sAutori.Substring(0, (sAutori.Length - 2));
                    txtautori.Text = sAutori;

                }
                }
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Iri = true;
            bindingSource1.AddNew();
            bindingSource1.MoveLast();
            txtautori.Text = "";
            txtkategoria.Text = "";
            txttitulli.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lBotuesiId = Convert.ToInt32(cbobotuesi.SelectedValue);
            string sTitulli = txttitulli.Text.Trim();
            string sbarkodi = txtbarkodi.Text.Trim();
            string sisbn = txtisbn.Text.Trim();

            decimal lqmimi;
            if (txtqmimi.Text == "")
                lqmimi = 0;
            else
                lqmimi = Convert.ToDecimal(txtqmimi.Text);

            int lsasia = Convert.ToInt32(txtsasia.Text);
            string sKategoria = txtkategoria.Text.Trim();
            string sAutori = txtautori.Text.Trim();
            

            if (sTitulli != "" && sbarkodi != "" && lBotuesiId != 0 && lqmimi != 0 && lsasia != 0 && sKategoria != "" && sAutori != "" )
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int lLibriiId;
                if (txtid.Text != "")
                    lLibriiId = Convert.ToInt32(txtid.Text);
                else
                    lLibriiId = 0;
                if (lLibriiId == 0)
                {
                    string sCommanda =
                     "INSERT INTO libri (titulli, barkodi, isbn, botuesiId, qmimi, sasia, kategoria, autori )" +
                                    " Values ('" + sTitulli + "', '" + sbarkodi + "', '" + sisbn + "', '" + lBotuesiId.ToString() + "', '" + lqmimi + "', '" + lsasia + "'";
                    string[] aKategoria = sKategoria.Split(',');

                    if (aKategoria.Length != 0)
                        sCommanda = sCommanda + ", kategoria_tab(";

                    foreach (string item in aKategoria)
                    {
                        sCommanda = sCommanda +
                            "kategoria_t('" + item.Trim() + "'),";
                    }
                    if (aKategoria.Length != 0)
                    {
                        sCommanda = sCommanda.Substring(0, (sCommanda.Length - 1));
                        sCommanda = sCommanda + "),";
                    }

                    string[] aAutori = sAutori.Split(',');
                    if (aAutori.Length != 0)
                        sCommanda = sCommanda + " autori_tab(";
                    foreach (string item in aAutori)
                    {
                        sCommanda = sCommanda +
                            "autori_t('" + item.Trim() + "'),";
                    }
                    if (aAutori.Length != 0)
                    {
                        sCommanda = sCommanda.Substring(0, (sCommanda.Length - 1));
                        sCommanda = sCommanda + ")";
                    }


                    sCommanda = sCommanda + ")";

                    cmd.CommandText = sCommanda;

                    
                }
                else
                {

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
                        cboKerkimiSipas.SelectedValue = 1;
                        txtKerkimi.Text = sbarkodi;
                        LoadData(conn, !chkKerkoSipas.Checked, 1);
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
                MessageBox.Show("Të dhënat jovalide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibrat_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
